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
    public partial class frmInsumos : Form
    {
        public frmInsumos()
        {
            InitializeComponent();

            rbAtivo.Checked = true;
        }

        private void btnBuscarInsumos_Click(object sender, EventArgs e)
        {
            AtualizaGridInsumos();
        }
        private int VerificaStatus()
        {
            int status = 0;

            if (rbAtivo.Checked) { status = 0; }

            else if (rbInativo.Checked) { status = 1; }

            else { status = 2; }

            return status;
        }
        private void AtualizaGridInsumos()
        {
            InsumoController insumoController = new InsumoController();

            DataTable tabelaInsumos = insumoController.ListarInsumos(txtDescInsumo.Text, VerificaStatus());

            grdInsumos.DataSource = tabelaInsumos;

            FormataGrid();
        }
        public void FormataGrid()
        {
            grdInsumos.RowHeadersVisible = false;

            grdInsumos.Columns["ID"].Width = 35;
            grdInsumos.Columns["Cod. de barras"].Width = 115;
            grdInsumos.Columns["Descrição"].Width = 280;
            grdInsumos.Columns["Un. de Medida"].Width = 70;
            grdInsumos.Columns["Valor unitário"].Width = 70;
            grdInsumos.Columns["Qtde em Estoque"].Width = 70;
            grdInsumos.Columns["Status"].Width = 55;
            grdInsumos.Columns["Fornecedor"].Width = 135;
        }
    }
}
