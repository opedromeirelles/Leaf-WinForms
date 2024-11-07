using LEAF.Controllers;
using LEAF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Threading;

namespace LEAF.Views.Pedido
{
    public partial class frmNovoPedido : Form
    {
        private int idPessoaSelecionada;
        private frmPedidos _frmPedidos;
        private List<ItemPedidoModel> _itensPedido;
        public frmNovoPedido(frmPedidos frmPedidos, List<ItemPedidoModel> itensPedido)
        {
            InitializeComponent();

            _itensPedido = itensPedido;
            _frmPedidos = frmPedidos;

            txtNomeCliente.ReadOnly = true;
            txtDadosCliente.ReadOnly = true;
            txtValorTotal.ReadOnly = true;

            AtualizaGridItensPedido();
        }
        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            frmConsultarAgente frmCliente = new frmConsultarAgente();

            if (frmCliente.ShowDialog() == DialogResult.OK)
            {
                idPessoaSelecionada = frmCliente.IdPessoaSelecionada;
                txtNomeCliente.Text = frmCliente.NomePessoaSelecionada;
                txtDadosCliente.Text = frmCliente.DadosPessoaSelecionada;
            }
        }
        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            using (frmInserirProdutos frmAddProdutos = new frmInserirProdutos())
            {
                var resultado = frmAddProdutos.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    List<ItemPedidoModel> listaItensPedido = frmAddProdutos.ItensSelecionados;

                    foreach (var itemSelecionado in listaItensPedido)
                    {
                        var itemExistente = _itensPedido.FirstOrDefault(item => item.Produto.IdProduto == itemSelecionado.Produto.IdProduto);

                        if (itemExistente != null)
                        {
                            itemExistente.Quantidade += itemSelecionado.Quantidade;
                            itemExistente.SubTotal += itemSelecionado.SubTotal;                         
                        }
                        else
                        {
                            _itensPedido.Add(new ItemPedidoModel
                            {
                                Produto = new ProdutoModel
                                {
                                    IdProduto = itemSelecionado.Produto.IdProduto,
                                    Descricao = itemSelecionado.Produto.Descricao,
                                    ValorUnitario = itemSelecionado.Produto.ValorUnitario
                                },
                                Quantidade = itemSelecionado.Quantidade,
                                SubTotal = itemSelecionado.SubTotal
                            });
                        }
                    }
                    AtualizaGridItensPedido();
                }
            }
        }
        private void AtualizaGridItensPedido()
        {
            DataTable tabelaItensPedido = new DataTable();

            tabelaItensPedido.Columns.Add("ID", typeof(int));
            tabelaItensPedido.Columns.Add("Descrição", typeof(string));
            tabelaItensPedido.Columns.Add("Qtde", typeof(int));
            tabelaItensPedido.Columns.Add("Subtotal", typeof(decimal));

            foreach (var item in _itensPedido)
            {
                DataRow row = tabelaItensPedido.NewRow();

                row["ID"] = item.Produto.IdProduto;
                row["Descrição"] = item.Produto.Descricao;
                row["Qtde"] = item.Quantidade;
                row["Subtotal"] = item.SubTotal;

                tabelaItensPedido.Rows.Add(row);
            }
            grdItensPedido.DataSource = tabelaItensPedido;

            FormataGridItensPedido();
            AtualizaValorTotal();
        }
        private void FormataGridItensPedido()
        {
            grdItensPedido.RowHeadersVisible = false;

            grdItensPedido.Columns["ID"].Width = 36;
            grdItensPedido.Columns["Descrição"].Width = 180;
            grdItensPedido.Columns["Qtde"].Width = 70;
            grdItensPedido.Columns["Subtotal"].Width = 80;
        }
        public void AtualizaValorTotal()
        {
            decimal valorTotal = 0;

            foreach (DataGridViewRow row in grdItensPedido.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    valorTotal += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }

            txtValorTotal.Text = valorTotal.ToString();
            
            if (txtValorTotal.Text == "0")
            {
                txtValorTotal.Text = ""; // Para não iniciar o valor total com o número 0
            }
        }
        private void btnDescartar_Click(object sender, EventArgs e)
        {
            grdItensPedido.DataSource = null;
            this.Close();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool verificacao = VerificaCamposObrigatorios();

            if (verificacao == true)
            {
                var retorno = MessageBox.Show("Confirma os dados do novo pedido?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (retorno == DialogResult.OK)
                {
                    string cep = txtCep.Text;
                    string enderecoEntrega = txtEndereco.Text;
                    decimal valorTotal = Convert.ToDecimal(txtValorTotal.Text);
                    int cliente = idPessoaSelecionada;

                    PedidoController pedido = new PedidoController();

                    bool cadastro = pedido.CadastrarPedido(cep, enderecoEntrega, cliente, valorTotal, _itensPedido);

                    if (cadastro ==  true)
                    {
                        MessageBox.Show("Pedido cadastrado com sucesso!");
                        Thread.Sleep(800);
                        this.Close();
                        _frmPedidos.AtualizaGrid();
                    }

                    else
                    {
                        MessageBox.Show("Erro ao cadastrar");
                        return;
                    }
                }
            }
        }
        private bool VerificaCamposObrigatorios()
        {
            bool resultado = true;

            if (txtNomeCliente.Text == "" || txtDadosCliente.Text == "" || txtCep.Text == "" || txtEndereco.Text == "")
            {
                resultado = false;
                MessageBox.Show("Informe todos os campos obrigatórios.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (_itensPedido == null || _itensPedido.Count == 0)
            {
                resultado = false;
                MessageBox.Show("Deve haver ao menus um produto no pedido", "Pedido incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return resultado;
        }
    }
}
