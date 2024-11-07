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

namespace LEAF.Views
{
    public partial class frmNovoLote : Form
    {
        private int idProdutoSelecionado;
        private List<ItemLoteModel> _itensLote;
        public frmNovoLote(List<ItemLoteModel> itensLote)
        {
            InitializeComponent();
            _itensLote = itensLote;

            txtProdutoLote.ReadOnly = true;
        }
        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            frmConsultarProduto frm = new frmConsultarProduto();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                idProdutoSelecionado = frm.IdProdutoSelecionado;
                txtProdutoLote.Text = frm.DescricaoProdutoSelecionado;
            }
        }
        private void btnSalvarNovoLote_Click(object sender, EventArgs e)
        {
            bool verificacao = VerificaCamposObrigatorios();

            if (verificacao == true)
            {
                var retorno = MessageBox.Show("Confirma os dados do novo lote?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (retorno == DialogResult.OK)
                {
                    if (!int.TryParse(txtQuantidade.Text, out int qtde) || int.Parse(txtQuantidade.Text) <= 0)
                    {
                        MessageBox.Show("Por favor, insira uma quantidade válida.", "Quantidade Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    LoteController loteController = new LoteController();

                    bool cadastro = loteController.CadastrarLote(txtCodLote.Text, idProdutoSelecionado, Convert.ToInt32(txtQuantidade.Text), _itensLote);

                    if (cadastro == true)
                    {
                        MessageBox.Show("Lote cadastrado com sucesso!");
                        LimparCampos();
                        this.Close();
                    }
                }
            }
        }
        private void LimparCampos()
        {
            txtCodLote.Text = "";
            txtProdutoLote.Text = "";
            txtQuantidade.Text = "";
        }        
        private bool VerificaCamposObrigatorios()
        {
            bool resultado = true;

            if (txtCodLote.Text == "" || txtProdutoLote.Text == "" || txtQuantidade.Text == "")
            {
                resultado = false;
                MessageBox.Show("Informe todos os campos obrigatórios.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (_itensLote == null || _itensLote.Count == 0)
            {
                resultado = false;
                MessageBox.Show("Adicione pelo menos um insumo ao lote.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return resultado;
        }
        private void btnDescartarNovoLote_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddInsumo_Click(object sender, EventArgs e)
        {
            using (frmInserirInsumos frmAddInsumos = new frmInserirInsumos())
            {
                var resultado = frmAddInsumos.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    List<ItemLoteModel> listaItensLote = frmAddInsumos.ItensSelecionados;

                    foreach (var itemSelecionado in listaItensLote)
                    {
                        var itemExistente = _itensLote.FirstOrDefault(item => item.IdInsumo == itemSelecionado.IdInsumo);

                        if (itemExistente != null)
                        {
                            itemExistente.Quantidade += itemSelecionado.Quantidade;
                        }

                        else
                        {
                            _itensLote.Add(itemSelecionado);
                        }
                    }
                    AtualizaGridItensLote();
                }
            }
        }
        private void AtualizaGridItensLote()
        {
            DataTable tabelaItensLote = new DataTable();

            tabelaItensLote.Columns.Add("ID", typeof(int));
            tabelaItensLote.Columns.Add("Descrição", typeof(string));
            tabelaItensLote.Columns.Add("Qtde", typeof(int));

            foreach (var item in _itensLote)
            {
                DataRow row = tabelaItensLote.NewRow();

                row["ID"] = item.Insumo.IdInsumo;
                row["Descrição"] = item.Insumo.Descricao;
                row["Qtde"] = item.Quantidade;

                tabelaItensLote.Rows.Add(row);
            }
            grdItensLote.DataSource = tabelaItensLote;
            FormataGridItensLote();
        }
        private void FormataGridItensLote()
        {
            grdItensLote.RowHeadersVisible = false;

            grdItensLote.Columns["ID"].Width = 40;
            grdItensLote.Columns["Descrição"].Width = 220;
            grdItensLote.Columns["Qtde"].Width = 70;
        }
    }
}
