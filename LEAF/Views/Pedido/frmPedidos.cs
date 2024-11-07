using LEAF.Controllers;
using LEAF.Models;
using LEAF.Views.Pedido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LEAF.Views
{
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }
        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            AtualizaGrid();

            if (grdPedido.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum pedido encontrado.");
            }
        }
        private void frmPedido_Load(object sender, EventArgs e)
        {
            cbPedidoBuscarPor.SelectedIndex = 0;

            AtualizaControles();

            cbPedidoBuscarPor.SelectedIndexChanged += cbPedidoBuscarPor_SelectedIndexChanged;
        }
        private void cbPedidoBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaControles();
        }
        private void AtualizaControles()
        {
            txtIdPedido.Text = "";
            cbStatusPedido.SelectedIndex = 0;

            if (cbPedidoBuscarPor.SelectedIndex == 0)
            {
                cbStatusPedido.Visible = true;
                txtIdPedido.Visible = false;
            }
            else if (cbPedidoBuscarPor.SelectedIndex == 1)
            {
                cbStatusPedido.Visible = false;
                txtIdPedido.Visible = true;
            }
        }
        private void FormataGrid()
        {
            grdPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (grdPedido.Columns.Count > 0)
            {
                grdPedido.RowHeadersVisible = false;

                grdPedido.Columns[0].HeaderText = "N°";
                grdPedido.Columns[1].HeaderText = "Status";
                grdPedido.Columns[2].HeaderText = "Total";
                grdPedido.Columns[3].HeaderText = "Cliente";
                grdPedido.Columns[4].HeaderText = "Vendedor";
                grdPedido.Columns[5].HeaderText = "Data Emissão";

                grdPedido.Columns[0].Width = 65;
                grdPedido.Columns[1].Width = 80;
                grdPedido.Columns[2].Width = 100;
                grdPedido.Columns[3].Width = 175;
                grdPedido.Columns[4].Width = 170;
                grdPedido.Columns[5].Width = 170;

                // Aqui eu ocultei as colunas que não quero que apareça na grid
                for (int i = 6; i < grdPedido.Columns.Count; i++)
                {
                    grdPedido.Columns[i].Visible = false;
                }
            }
        }
        public void AtualizaGrid()
        {
            grdPedido.DataSource = null;

            PedidoController pedidoController = new PedidoController();

            DataTable tabelaPedido;

            if (cbPedidoBuscarPor.SelectedIndex == 1)
            {
                tabelaPedido = string.IsNullOrWhiteSpace(txtIdPedido.Text) ? null : pedidoController.BuscarPedidoPorId(Convert.ToInt32(txtIdPedido.Text));
            }

            else
            {
                tabelaPedido = pedidoController.BuscarPedidoPorStatus(VerificaComboBoxPedido());
            }

            grdPedido.DataSource = tabelaPedido;

            FormataGrid();
        }
        private string VerificaComboBoxPedido()
        {
            string opcaoSelecionada = string.Empty;

            switch (cbStatusPedido.SelectedIndex)
            {
                case 0:
                    opcaoSelecionada = "EM";
                    break;

                case 1:
                    opcaoSelecionada = "RT";
                    break;

                case 2:            
                    opcaoSelecionada = "BX";
                    break;

                case 3:            
                    opcaoSelecionada = "CA";
                    break;

                default:
                    opcaoSelecionada = string.Empty;
                    break;
            }
            return opcaoSelecionada;
        }
        private void grdPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Para tratativa caso clique no cabeçalho da grid
            {
                DataGridViewRow row = grdPedido.Rows[e.RowIndex];

                int idPedido = Convert.ToInt32(row.Cells["N°"].Value);
                string status = row.Cells["Status"].Value.ToString();
                decimal valorTotal = Convert.ToDecimal(row.Cells["Total"].Value);
                string enderecoEntrega = row.Cells["Endereço"].Value.ToString();
                string cep = row.Cells["CEP"].Value.ToString();
                string cliente = row.Cells["Cliente"].Value.ToString();
                string vendedor = row.Cells["Vendedor"].Value.ToString();
                string entregador = row.Cells["Entregador"].Value.ToString();
                DateTime? dataEmissao = row.Cells["Data Emissão"].Value as DateTime?;
                DateTime? dataSaida = row.Cells["Data Saída"].Value as DateTime?;
                DateTime? dataBaixa = row.Cells["Data Entrega"].Value as DateTime?;
                DateTime? dataCancelamento = row.Cells["Data Cancelamento"].Value as DateTime?;

                frmPedido menuPedido = new frmPedido(this, idPedido, status, valorTotal, enderecoEntrega, cep, cliente, vendedor, entregador, dataEmissao, dataSaida, dataBaixa, dataCancelamento);
                menuPedido.Show();
            }
        }
        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            frmNovoPedido novoPedido = new frmNovoPedido(this, new List<ItemPedidoModel>());
            novoPedido.Show();
        }
    }
}
