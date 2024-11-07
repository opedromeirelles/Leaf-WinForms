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
    public partial class frmProducao : Form
    {
        public frmProducao()
        {
            InitializeComponent();
        }
        private void frmProducao_Load(object sender, EventArgs e)
        {
            cbProducaoBuscarPor.SelectedIndex = 0;
            
            AtualizaControles();

            // Para validar a troca da combo box
            cbProducaoBuscarPor.SelectedIndexChanged += cbProducaoBuscarPor_SelectedIndexChanged;
        }
        private void AtualizaControles()
        {
            txtCodLote.Text = "";
            cbStatusLote.SelectedIndex = 0;

            if (cbProducaoBuscarPor.SelectedIndex == 0)
            {
                cbStatusLote.Visible = false;
                txtCodLote.Visible = true;
            }
            else if (cbProducaoBuscarPor.SelectedIndex == 1)
            {
                cbStatusLote.Visible = true;
                txtCodLote.Visible = false;
            }
        }
        private void cbProducaoBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaControles();
        }
        private void btnBuscarLote_Click(object sender, EventArgs e)
        {
            AtualizaGridLote();

            if (grdLoteProducao.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum resultado encontrado.");
            }
        }
        public void AtualizaGridLote()
        {
            grdLoteProducao.DataSource = null;

            LoteController loteController = new LoteController();

            DataTable tabelaLote;

            if (cbProducaoBuscarPor.SelectedIndex == 0)
            {
                tabelaLote = loteController.BuscarLotePorID(txtCodLote.Text);
            }

            else
            {
                tabelaLote = loteController.BuscarLotePorStatus(verificaComboBoxLote());
            }

            grdLoteProducao.DataSource = tabelaLote;

            FormatagridLote();
        }
        private void FormatagridLote()
        {
            grdLoteProducao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (grdLoteProducao.Columns.Count > 0)
            {
                grdLoteProducao.RowHeadersVisible = false;

                grdLoteProducao.Columns[0].HeaderText = " Cód.Lote";
                grdLoteProducao.Columns[1].HeaderText = " Estágio";
                grdLoteProducao.Columns[2].HeaderText = " Produto";
                grdLoteProducao.Columns[3].HeaderText = " Quantidade";

                grdLoteProducao.Columns[0].Width = 121;
                grdLoteProducao.Columns[1].Width = 135;
                grdLoteProducao.Columns[2].Width = 150;
                grdLoteProducao.Columns[3].Width = 120;

                // Aqui eu ocultei as colunas que não quero que apareça na grid
                for (int i = 4; i < grdLoteProducao.Columns.Count; i++)
                {
                    grdLoteProducao.Columns[i].Visible = false;
                }
            }
        }
        private int verificaComboBoxLote()
        {
            int opcaoSelecionada = 0;

            if (cbStatusLote.SelectedIndex == 0)
            {
                opcaoSelecionada = 1;
            }
            else if (cbStatusLote.SelectedIndex == 1)
            {
                opcaoSelecionada = 2;
            }
            else if (cbStatusLote.SelectedIndex == 2)
            {
                opcaoSelecionada = 3;
            }
            else if (cbStatusLote.SelectedIndex == 3)
            {
                opcaoSelecionada = 4;
            }
            return opcaoSelecionada;
        }
        private void btnNovoLote_Click(object sender, EventArgs e)
        {
            frmNovoLote novoLote = new frmNovoLote(new List<ItemLoteModel>());
            novoLote.Show();
        }
        private void grdLoteProducao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Para tratativa caso clique no cabeçalho da grid
            {
                DataGridViewRow row = grdLoteProducao.Rows[e.RowIndex];

                string idLote = row.Cells["IdLote"].Value.ToString();
                string estagio = row.Cells["Estagio"].Value.ToString();
                string produto = row.Cells["Produto"].Value.ToString();
                string usuario = row.Cells["Usuario"].Value.ToString();
                int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
                DateTime? dataSemeadura = row.Cells["DataSemeadura"].Value as DateTime?;
                DateTime? dataCrescimento = row.Cells["DataCrescimento"].Value as DateTime?;
                DateTime? dataPlantio = row.Cells["DataPlantio"].Value as DateTime?;
                DateTime? dataColheita = row.Cells["DataColheita"].Value as DateTime?;

                frmLote menuLote = new frmLote(this, idLote, estagio, produto, quantidade, dataSemeadura, dataCrescimento, dataPlantio, dataColheita, usuario);
                menuLote.Show();
            }
        }
    }
}
