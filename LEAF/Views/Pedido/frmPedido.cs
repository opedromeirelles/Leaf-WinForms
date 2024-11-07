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

namespace LEAF.Views.Pedido
{
    public partial class frmPedido : Form
    {
        private frmPedidos _frmPedidos;
        public frmPedido()
        {
            InitializeComponent();
        }
        public frmPedido(frmPedidos frmPedidos, int idPedido, string status, decimal valorTotal, string enderecoEntrega, string cep,
            string cliente, string vendedor, string entregador, DateTime? dataEmissao, DateTime? dataSaida, DateTime? dataBaixa, DateTime? dataCancelamento)
        {
            InitializeComponent();

            _frmPedidos = frmPedidos;

            txtId.Text = idPedido.ToString();
            txtStatus.Text = status;
            txtVlrTotal.Text = valorTotal.ToString();
            txtEndereco.Text = enderecoEntrega.ToString();
            txtCep.Text = cep.ToString();
            txtCliente.Text = cliente.ToString();
            txtVendedor.Text = vendedor.ToString();
            txtEntregador.Text = entregador.ToString();
            txtDataEmissao.Text = dataEmissao?.ToString("dd/MM/yyyy HH:mm:ss") ?? string.Empty;
            txtDataSaida.Text = dataSaida?.ToString("dd/MM/yyyy HH:mm:ss") ?? string.Empty;
            txtDataBaixa.Text = dataBaixa?.ToString("dd/MM/yyyy HH:mm:ss") ?? string.Empty;
            txtDataCancelamento.Text = dataCancelamento?.ToString("dd/MM/yyyy HH:mm:ss") ?? string.Empty;
            //Formatação para receber possíveis dados vazios

            AtualizaGrid(idPedido);
            VerificaStatusPedido(txtStatus.Text);

            ReadOnly();
        }
        private void AtualizaGrid(int idPedido)
        {
            grdItensPedido.DataSource = null;

            ItemPedidoController itensPedido = new ItemPedidoController();

            DataTable tabelaItens = itensPedido.ListaItens(idPedido);

            grdItensPedido.DataSource = tabelaItens;

            FormataGrid();
        }
        private void FormataGrid()
        {
            grdItensPedido.RowHeadersVisible = false;

            grdItensPedido.Columns[0].HeaderText = "Descrição";
            grdItensPedido.Columns[1].HeaderText = "Valor Unitário";
            grdItensPedido.Columns[2].HeaderText = "Quantidade";
            grdItensPedido.Columns[3].HeaderText = "Subtotal";

            grdItensPedido.Columns[0].Width = 180;
            grdItensPedido.Columns[1].Width = 150;
            grdItensPedido.Columns[2].Width = 150;
            grdItensPedido.Columns[3].Width = 147;
        }
        private void ReadOnly()
        {
            txtId.ReadOnly = true;
            txtStatus.ReadOnly = true;
            txtVlrTotal.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtCliente.ReadOnly = true;
            txtVendedor.ReadOnly = true;
            txtEntregador.ReadOnly = true;
            txtCep.ReadOnly = true;
            txtDataEmissao.ReadOnly = true;
            txtDataSaida.ReadOnly = true;
            txtDataBaixa.ReadOnly = true;
            txtDataCancelamento.ReadOnly = true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var pergunta = MessageBox.Show("Deseja cancelar este pedido?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pergunta == DialogResult.Yes)
            {
                PedidoController pedidoController = new PedidoController();

                bool resultado = pedidoController.CancelarPedido(Convert.ToInt32(txtId.Text));

                if (resultado ==  true)
                {
                    MessageBox.Show("Pedido cancelado!", "", MessageBoxButtons.OK);

                    Thread.Sleep(800);
                    this.Close();
                    _frmPedidos.AtualizaGrid();
                }
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var pergunta = MessageBox.Show("Deseja excluir este pedido?\n\nEste processo é irreversível.", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (pergunta == DialogResult.Yes)
            {
                PedidoController pedidoController = new PedidoController();

                bool resultado = pedidoController.ExcluirPedido(Convert.ToInt32(txtId.Text));

                if (resultado == true)
                {
                    MessageBox.Show("Pedido excluído!", "", MessageBoxButtons.OK);

                    Thread.Sleep(800);
                    this.Close();
                    _frmPedidos.AtualizaGrid();
                }
            }
        }
        private void VerificaStatusPedido(string status)
        {
            if (status != "EM")
            {
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }
    }
 }
