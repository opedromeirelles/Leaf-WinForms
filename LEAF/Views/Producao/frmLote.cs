using LEAF.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEAF.Views
{
    public partial class frmLote : Form
    {
        private frmProducao _frmProducao;
        public frmLote()
        {
            InitializeComponent();
        }
        public frmLote(frmProducao frmProducao, string idLote, string estagio, string produto, 
            int quantidade, DateTime? dataSemeadura, DateTime? dataCrescimento, DateTime? dataPlantio, DateTime? dataColheita, string usuario)
        {
            InitializeComponent();

            _frmProducao = frmProducao;
            btnAvancarEstagio.Visible = true;

            txtCodLote.Text = idLote;
            txtEstagioLote.Text = estagio;
            txtProdutoLote.Text = produto;
            txtUsuarioResponsavel.Text = usuario;
            txtQtdeProdutoLote.Text = quantidade.ToString();
            txtDtSemeadura.Text = dataSemeadura?.ToString("dd/MM/yyyy HH:mm:ss") ?? string.Empty; //Formatação para receber possíveis datas vazias
            txtDtCrescimento.Text = dataCrescimento?.ToString("dd/MM/yyyy HH:mm:ss") ?? string.Empty;
            txtDtPlantio.Text = dataPlantio?.ToString("dd/MM/yyyy HH:mm:ss") ?? string.Empty;
            txtDtColheita.Text = dataColheita?.ToString("dd/MM/yyyy HH:mm:ss") ?? string.Empty;
                                                                                      
            if (estagio == "Colheita")
            {
                btnAvancarEstagio.Visible = false;
            }

            AtualizaGrid(idLote);
            readOnly();
        }
        public void AtualizaGrid(string idLote)
        {
            grdItensInsumo.DataSource = null;

            ItemLoteController itensLote = new ItemLoteController();

            DataTable tabelaItens = itensLote.ListaItens(idLote);

            grdItensInsumo.DataSource = tabelaItens;

            FormataGridItens();
        }
        private void FormataGridItens()
        {
            grdItensInsumo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (grdItensInsumo.Columns.Count > 0)
            {
                grdItensInsumo.RowHeadersVisible = false;

                grdItensInsumo.Columns[0].HeaderText = "ID";
                grdItensInsumo.Columns[1].HeaderText = "Descrição";
                grdItensInsumo.Columns[2].HeaderText = "Un.Medida";
                grdItensInsumo.Columns[3].HeaderText = "Quantidade";

                grdItensInsumo.Columns[0].Width = 35;
                grdItensInsumo.Columns[1].Width = 283;
                grdItensInsumo.Columns[2].Width = 70;
                grdItensInsumo.Columns[3].Width = 70;
            }
        }
        private void readOnly()
        {
            txtCodLote.ReadOnly = true;
            txtEstagioLote.ReadOnly = true;
            txtProdutoLote.ReadOnly = true;
            txtQtdeProdutoLote.ReadOnly = true;
            txtDtSemeadura.ReadOnly = true;
            txtDtCrescimento.ReadOnly = true;
            txtDtPlantio.ReadOnly = true;
            txtDtColheita.ReadOnly = true;
            txtUsuarioResponsavel.ReadOnly = true;
        }
        private void btnAvancarEstagio_Click(object sender, EventArgs e)
        {
            LoteController loteController = new LoteController();

            string idLote = txtCodLote.Text;

            var pergunta1 = MessageBox.Show("Confirma avanço do lote?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (pergunta1 == DialogResult.OK)
            {
                var pergunta2 = MessageBox.Show("Houve alteração na quantidade?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (pergunta2 == DialogResult.Yes)
                {
                    int quantidadeAtual = Convert.ToInt32(txtQtdeProdutoLote.Text.Trim());

                    frmNovaQuantidadeLote frmNovaQtde = new frmNovaQuantidadeLote(quantidadeAtual);

                    var novoValor = frmNovaQtde.ShowDialog();

                    if (novoValor == DialogResult.Cancel)
                    {
                        MessageBox.Show("Alteração de quantidade cancelada. O lote não foi atualizado.", "Operação Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    int novaQuantidade = frmNovaQtde.NovaQuantidade;

                    loteController.AlterarQuantidadeLote(txtCodLote.Text, novaQuantidade);

                    MessageBox.Show("Quantidade atualizada com sucesso!");
                }

                else
                {
                    MessageBox.Show("Lote atualizado com sucesso!");
                }

                loteController.AvancarEstagio(idLote);

                Thread.Sleep(700);

                _frmProducao.AtualizaGridLote();
            
                this.Close();            
            }
        }
    }
}
