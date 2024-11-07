using LEAF.Controllers;
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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();

            rbAtivo.Checked = true;
        }
        private void FormataGridProduto()
        {
            if (grdProdutos.Columns.Count > 0)
            {
                grdProdutos.RowHeadersVisible = false;

                grdProdutos.Columns[0].HeaderText = "ID";
                grdProdutos.Columns[1].HeaderText = "Descrição";
                grdProdutos.Columns[2].HeaderText = "Valor unitário";
                grdProdutos.Columns[3].HeaderText = "Qtde em estoque";
                grdProdutos.Columns[4].HeaderText = "Status";

                grdProdutos.Columns[0].Width = 51;
                grdProdutos.Columns[1].Width = 186;
                grdProdutos.Columns[2].Width = 80;
                grdProdutos.Columns[3].Width = 80;
                grdProdutos.Columns[4].Width = 57;
            }
        }
        private void AtualizaGridProduto()
        {
            ProdutoController produtoController = new ProdutoController();

            DataTable tabelaProduto = produtoController.ListarProdutos(txtNomeProduto.Text, VerificaStatus());

            grdProdutos.DataSource = tabelaProduto;

            FormataGridProduto();
        }
        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            AtualizaGridProduto();
        }
        private int VerificaStatus()
        {
            int status = 0;

            if (rbAtivo.Checked) { status = 0; }

            else if (rbInativo.Checked) { status = 1; } 
            
            else { status = 2; }

            return status;
        }
    }
}
