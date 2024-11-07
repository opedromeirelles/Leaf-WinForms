using System;
using LEAF.Controllers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LEAF.Models;

namespace LEAF.Views
{
    public partial class frmConsultarProduto : Form
    {
        public int IdProdutoSelecionado { get; set; }
        public string DescricaoProdutoSelecionado { get; set; }
        public frmConsultarProduto()
        {
            InitializeComponent();
        }
        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            AtualizaGridProdutos();
        }
        private void AtualizaGridProdutos()
        {
            grdConsultaProdutos.DataSource = null;

            ProdutoController produtoController = new ProdutoController();

            DataTable tabelaProdutos = produtoController.SelecionarProdutos(txtNomeProduto.Text);

            grdConsultaProdutos.DataSource = tabelaProdutos;

            FormataGridProdutos();
        }
        private void FormataGridProdutos()
        {
            grdConsultaProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if(grdConsultaProdutos.Columns.Count > 0)
            {
                grdConsultaProdutos.RowHeadersVisible = false;

                grdConsultaProdutos.Columns[0].HeaderText = "ID";
                grdConsultaProdutos.Columns[1].HeaderText = "Descrição";
                grdConsultaProdutos.Columns[2].HeaderText = "Valor unitário";
                grdConsultaProdutos.Columns[3].HeaderText = "Qtde em estoque";

                grdConsultaProdutos.Columns[0].Width = 50;
                grdConsultaProdutos.Columns[1].Width = 208;
                grdConsultaProdutos.Columns[2].Width = 80;
                grdConsultaProdutos.Columns[3].Width = 115;

                for (int i = 4; i < grdConsultaProdutos.Columns.Count; i++)
                {
                    grdConsultaProdutos.Columns[i].Visible = false;
                }
            }
        }
        public void grdConsultaProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grdConsultaProdutos.Rows[e.RowIndex];

                var retorno = MessageBox.Show("Confirma produto selecionado?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (retorno == DialogResult.OK)
                {
                    IdProdutoSelecionado = Convert.ToInt32(row.Cells["ID"].Value);
                    DescricaoProdutoSelecionado = row.Cells["Descrição"].Value.ToString();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
