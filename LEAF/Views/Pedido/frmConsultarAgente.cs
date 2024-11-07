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

namespace LEAF.Views.Pedido
{
    public partial class frmConsultarAgente : Form
    {
        public int IdPessoaSelecionada {  get; set; }
        public string NomePessoaSelecionada { get; set; }
        public string DadosPessoaSelecionada { get; set; }

        public frmConsultarAgente()
        {
            InitializeComponent();
            cbAgenteBuscarPor.SelectedIndex = 0;
        }

        private void btnBuscarAgente_Click(object sender, EventArgs e)
        {
            AtualizaGridPessoa();
        }
        private void AtualizaGridPessoa()
        {
            PessoaController pessoaController = new PessoaController();

            // Passando como parâmetros a opção selecionada no ComboBox e o texto digitado
            DataTable tabelaAgente = pessoaController.BuscarPessoa(VerificaComboBoxAgente(), txtBuscar.Text);

            // Atribuindo o DataTable da controller ao DataSource da grid
            grdDadosPessoa.DataSource = tabelaAgente;

            FormataGridPessoa();
        }
        private void FormataGridPessoa()
        {
            grdDadosPessoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (grdDadosPessoa.Columns.Count > 0)
            {
                grdDadosPessoa.RowHeadersVisible = false;

                grdDadosPessoa.Columns[0].HeaderText = "Cód. Agente";
                grdDadosPessoa.Columns[1].HeaderText = "Nome";
                grdDadosPessoa.Columns[2].HeaderText = "CPF";
                grdDadosPessoa.Columns[3].HeaderText = "CNPJ";

                grdDadosPessoa.Columns[0].Width = 51;
                grdDadosPessoa.Columns[1].Width = 159;
                grdDadosPessoa.Columns[2].Width = 85;
                grdDadosPessoa.Columns[3].Width = 117;

                // Aqui eu ocultei as colunas que não quero que apareça na grid mas que irei usar no formulário
                for (int i = 4; i < grdDadosPessoa.Columns.Count; i++)
                {
                    grdDadosPessoa.Columns[i].Visible = false;
                }
            }
        }
        private string VerificaComboBoxAgente()
        {
            string opcaoSelecionada = string.Empty;

            switch (cbAgenteBuscarPor.SelectedIndex)
            {
                case 0:
                    opcaoSelecionada = "idpessoa";
                    break;
                case 1:
                    opcaoSelecionada = "nome";
                    break;
                case 2:
                    opcaoSelecionada = "cpf";
                    break;
                case 3:
                    opcaoSelecionada = "cnpj";
                    break;
                default:
                    opcaoSelecionada = string.Empty;
                    break;
            }
            return opcaoSelecionada;
        }
        public void grdDadosPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grdDadosPessoa.Rows[e.RowIndex];

                var retorno = MessageBox.Show("Confirma cliente selecionado?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (retorno == DialogResult.OK)
                {
                    IdPessoaSelecionada = Convert.ToInt32(row.Cells["IdPessoa"].Value);
                    NomePessoaSelecionada = row.Cells["Nome"].Value.ToString();
                    DadosPessoaSelecionada = string.IsNullOrWhiteSpace(row.Cells["CPF"].Value?.ToString())
                    ? row.Cells["CNPJ"].Value.ToString()
                    : row.Cells["CPF"].Value.ToString();
                    // Validando para receber o CPF ou CNPJ do cliente selecionado

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
