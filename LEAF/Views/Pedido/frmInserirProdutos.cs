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

namespace LEAF.Views.Pedido
{
    public partial class frmInserirProdutos : Form
    {
        public List<ItemPedidoModel> ItensSelecionados {  get; set; }
        public frmInserirProdutos()
        {
            InitializeComponent();

            ItensSelecionados = new List<ItemPedidoModel>();

            grdProdutosDisponiveis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdProdutosSelecionados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            AddProdutoSelecionado();
        }
        private void AddProdutoSelecionado()
        {
            if (string.IsNullOrWhiteSpace(txtQtdeSelecionada.Text) || !int.TryParse(txtQtdeSelecionada.Text, out _) || int.Parse(txtQtdeSelecionada.Text) <= 0)
            {
                MessageBox.Show("Por favor, insira uma quantidade válida.", "Quantidade Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (grdProdutosDisponiveis.SelectedRows.Count > 0)
            {
                DataTable produtoSelecionado = AtualizaGridProdutosSelecionados();

                foreach (DataGridViewRow linhaSelecionada in grdProdutosDisponiveis.SelectedRows)
                {
                    int idProduto = Convert.ToInt32(linhaSelecionada.Cells["ID"].Value);
                    string descricao = linhaSelecionada.Cells["Descrição"].Value.ToString();
                    int quantidadeSelecionada = Convert.ToInt32(txtQtdeSelecionada.Text);

                    decimal valorUnitario = Convert.ToDecimal(linhaSelecionada.Cells["Valor Unitário"].Value);

                    if (valorUnitario <= 0)
                    {
                        MessageBox.Show("O valor unitário do produto está incorreto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    decimal subtotal = valorUnitario * quantidadeSelecionada;

                    DataRow[] produtoExistente = produtoSelecionado.Select($"ID = {idProduto}");

                    if (produtoExistente.Length > 0)
                    {
                        DataRow linhaExistente = produtoExistente[0];

                        int quantidadeAdicionada = Convert.ToInt32(linhaExistente["Qtde Inserida"]);

                        linhaExistente["Qtde Inserida"] = quantidadeAdicionada + quantidadeSelecionada;
                        linhaExistente["Subtotal"] = (quantidadeAdicionada + quantidadeSelecionada) * valorUnitario;
                    }
                    else
                    {
                        AddProdutoNaTabela(produtoSelecionado, idProduto, descricao, quantidadeSelecionada, subtotal);
                    }
                }
                grdProdutosSelecionados.DataSource = produtoSelecionado;
            }
        }
        private void AddProdutoNaTabela(DataTable tabela, int idInsumo, string descricao, int quantidade, decimal subtotal)
        {
            DataRow novoInsumo = tabela.NewRow();

            novoInsumo["ID"] = idInsumo;
            novoInsumo["Descrição"] = descricao;
            novoInsumo["Qtde Inserida"] = quantidade;
            novoInsumo["Subtotal"] = subtotal;

            tabela.Rows.Add(novoInsumo);
        }
        private DataTable AtualizaGridProdutosSelecionados()
        {
            DataTable tabelaSelecionados;

            if (grdProdutosSelecionados.DataSource == null)
            {
                tabelaSelecionados = new DataTable();

                tabelaSelecionados.Columns.Add("ID", typeof(int));
                tabelaSelecionados.Columns.Add("Descrição", typeof(string));
                tabelaSelecionados.Columns.Add("Qtde Inserida", typeof(int));
                tabelaSelecionados.Columns.Add("Subtotal", typeof(decimal));

                grdProdutosSelecionados.DataSource = tabelaSelecionados;

                FormataGridProdutosSelecionados();
            }

            else
            {
                tabelaSelecionados = (DataTable)grdProdutosSelecionados.DataSource;
            }
            return tabelaSelecionados;
        }
        public void FormataGridProdutosSelecionados()
        {
            grdProdutosSelecionados.RowHeadersVisible = false;

            grdProdutosSelecionados.Columns["ID"].Width = 30;
            grdProdutosSelecionados.Columns["Descrição"].Width = 282;
            grdProdutosSelecionados.Columns["Qtde Inserida"].Width = 90;
            grdProdutosSelecionados.Columns["Subtotal"].Width = 70;
        }
        public void FormataGridProdutosDisponiveis()
        {
            grdProdutosDisponiveis.RowHeadersVisible = false;

            grdProdutosDisponiveis.Columns["ID"].Width = 30;
            grdProdutosDisponiveis.Columns["Descrição"].Width = 282;
            grdProdutosDisponiveis.Columns["Valor Unitário"].Width = 70;
            grdProdutosDisponiveis.Columns["Qtde em estoque"].Width = 90;
        }
        public void AtualizaGridProdutosDisponiveis()
        {
            ProdutoController produtoController = new ProdutoController();

            DataTable tabelaProdutosDisponiveis = produtoController.SelecionarProdutos(txtDesc.Text);

            grdProdutosDisponiveis.DataSource = tabelaProdutosDisponiveis;

            FormataGridProdutosDisponiveis();
        }
        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            AtualizaGridProdutosDisponiveis();
        }
        private void RemoveProdutoSelecionado()
        {
            if (grdProdutosSelecionados.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow linhaSelecionada in grdProdutosSelecionados.SelectedRows)
                {
                    grdProdutosSelecionados.Rows.Remove(linhaSelecionada);
                }
            }

            else
            {
                MessageBox.Show("Selecione ao menos um produto da lista para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnRemoveProduto_Click(object sender, EventArgs e)
        {
            RemoveProdutoSelecionado();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show("Confirma os itens do pedido?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                List<ItemPedidoModel> listaItensPedido = new List<ItemPedidoModel>();

                if (grdProdutosSelecionados.Rows.Count > 0)
                {
                    ItensSelecionados.Clear();

                    foreach (DataGridViewRow linha in grdProdutosSelecionados.Rows)
                    {
                        if (linha.Cells["ID"].Value != null)
                        {
                            int idProduto = Convert.ToInt32(linha.Cells["ID"].Value);
                            string descricao = linha.Cells["Descrição"].Value.ToString();
                            int quantidadeSelecionada = Convert.ToInt32(linha.Cells["Qtde Inserida"].Value);
                            decimal subtotal = Convert.ToDecimal(linha.Cells["Subtotal"].Value); 

                            ItemPedidoModel itemExistente = listaItensPedido.FirstOrDefault(item => item.Produto.IdProduto == idProduto);

                            if (itemExistente != null)
                            {
                                itemExistente.Quantidade += quantidadeSelecionada;
                                itemExistente.SubTotal += subtotal;
                            }
                            else
                            {
                                ItemPedidoModel itemPedido = new ItemPedidoModel
                                {
                                    Produto = new ProdutoModel
                                    {
                                        IdProduto = idProduto,
                                        Descricao = descricao,
                                    },
                                    Quantidade = quantidadeSelecionada,
                                    SubTotal = subtotal
                                };

                                listaItensPedido.Add(itemPedido);
                            }
                        }
                    }
                    ItensSelecionados.AddRange(listaItensPedido);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Nenhum produto foi selecionado no pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
