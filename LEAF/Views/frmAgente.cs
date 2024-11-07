using LEAF.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEAF.Views
{
    public partial class frmAgente : Form
    {
        public frmAgente()
        {
            InitializeComponent();
        }
        private void frmAgente_Load(object sender, EventArgs e)
        {
            FormataGridPessoa();
            LimpaGridPessoa();
            ReadOnlyTrue();
            cbAgenteBuscarPor.SelectedIndex = 0;
        }
        private void LimpaCampos()
        {
            txtCodAgente.Text = "";
            txtNomeAgente.Text = "";
            txtCPFAgente.Text = "";
            txtCNPJAgente.Text = "";
            txtTelefone1Agente.Text = "";
            txtTelefone2Agente.Text = "";
            txtEmail1Agente.Text = "";
            txtEmail2Agente.Text = "";
            rbPessoaFisica.Checked = false;
            rbPessoaJuridica.Checked = false;
        }
        private void ReadOnlyTrue()
        {
            txtCPFAgente.Mask = "";
            txtCNPJAgente.Mask = "";
            btnNovoAgente.Enabled = true;
            txtCodAgente.ReadOnly = true;
            txtNomeAgente.ReadOnly = true;
            txtCPFAgente.ReadOnly = true;
            txtCNPJAgente.ReadOnly = true;
            txtTelefone1Agente.ReadOnly = true;
            txtTelefone2Agente.ReadOnly = true;
            txtEmail1Agente.ReadOnly = true;
            txtEmail2Agente.ReadOnly = true;
            rbPessoaFisica.Enabled = false;
            rbPessoaJuridica.Enabled = false;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
            btnEditar.Visible = false;
            lblCNPJObrigatorio.Visible = false;
            lblCPFObrigatorio.Visible = false;
            lblTelefoneObrigatorio.Visible = false;
            lblEmailObrigatorio.Visible = false;
            lblNomeObrigatorio.Visible = false;
            grdDadosPessoa.Enabled = true;
        }
        private void ReadOnlyFalse()
        {
            btnNovoAgente.Enabled = false;
            txtCodAgente.ReadOnly = false;
            txtNomeAgente.ReadOnly = false;
            txtCPFAgente.ReadOnly = false;
            txtCNPJAgente.ReadOnly = false;
            txtTelefone1Agente.ReadOnly = false;
            txtTelefone2Agente.ReadOnly = false;
            txtEmail1Agente.ReadOnly = false;
            txtEmail2Agente.ReadOnly = false;
            grbTipoPessoa.Enabled = true;
            rbPessoaFisica.Enabled = true;
            rbPessoaJuridica.Enabled = true;
            btnSalvar.Visible = true;
            btnCancelar.Visible = true;
            pnlDadosAgente.Enabled = true;
            lblCNPJObrigatorio.Visible = true;
            lblCPFObrigatorio.Visible = true;
            lblTelefoneObrigatorio.Visible = true;
            lblEmailObrigatorio.Visible = true;
            lblNomeObrigatorio.Visible = true;
        }
        private bool VerificaCamposObrigatorios()
        {
            bool resultado = true;

            if (txtNomeAgente.Text == "" || txtTelefone1Agente.Text == "" || txtEmail1Agente.Text == "" || (rbPessoaFisica.Checked && txtCPFAgente.Text == "   .   .   -") || (rbPessoaJuridica.Checked && txtCNPJAgente.Text == "  .   .   /    -"))
            {
                resultado = false;
                MessageBox.Show("Informe todos os campos obrigatórios.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
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
        private void rbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblCPF.Enabled = true;
            txtCPFAgente.ReadOnly = false;
            lblCPFObrigatorio.Visible = true;
            lblCNPJ.Enabled = false;
            txtCNPJAgente.ReadOnly = true;
            lblCNPJObrigatorio.Visible = false;
            txtCPFAgente.Mask = "000,000,000-00";
            txtCNPJAgente.Mask = "";
            txtCNPJAgente.Text = "";
        }
        private void rbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblCPF.Enabled = false;
            txtCPFAgente.ReadOnly = true;
            lblCPFObrigatorio.Visible = false;
            lblCNPJ.Enabled = true;
            txtCNPJAgente.ReadOnly = false;
            lblCNPJObrigatorio.Visible = true;
            txtCNPJAgente.Mask = "00,000,000/0000-00";
            txtCPFAgente.Mask = "";
            txtCPFAgente.Text = "";
        }
        private void btnNovoAgente_Click(object sender, EventArgs e)
        {
            ReadOnlyFalse();
            LimpaCampos();

            btnEditar.Visible = false;
            rbPessoaFisica.Checked = true;
            btnNovoAgente.Enabled = false;
            cbAgenteBuscarPor.Enabled = false;
            btnBuscarAgente.Enabled = false;
            txtBuscar.Enabled = false;
            txtCodAgente.Visible = false;
            lblCodAgente.Visible = false;
            lblBuscarPor.Enabled = false;
            grdDadosPessoa.Enabled = false;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var retorno = MessageBox.Show("Deseja cancelar a operação?", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (retorno == DialogResult.OK)
            {
                LimpaCampos();
                ReadOnlyTrue();

                cbAgenteBuscarPor.SelectedIndex = -0;
                btnEditar.Visible = false;
                txtBuscar.Enabled = true;
                btnBuscarAgente.Enabled = true;
                cbAgenteBuscarPor.Enabled = true;
                lblBuscarPor.Enabled = true;
                txtCodAgente.Visible = true;
                lblCodAgente.Visible = true;
                txtCPFAgente.Mask = "";
                txtCNPJAgente.Mask = "";
                lblCNPJ.Enabled = true;
                lblCPF.Enabled = true;
                grdDadosPessoa.Enabled = true;
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool verificacao = VerificaCamposObrigatorios();

            if (verificacao == true)
            {
                var retorno = MessageBox.Show("Confirma os dados inseridos?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (retorno == DialogResult.OK)
                {
                    string tipoPessoa = string.Empty;

                    if (rbPessoaFisica.Checked)
                    {
                        tipoPessoa = "PF";
                    }
                    else
                    {
                        tipoPessoa = "PJ";
                    }
                    
                    string nome = txtNomeAgente.Text;
                    string cpf = txtCPFAgente.Text;
                    string cnpj = txtCNPJAgente.Text;
                    string telefone1 = txtTelefone1Agente.Text;
                    string telefone2 = txtTelefone2Agente.Text;
                    string email1 = txtEmail1Agente.Text;
                    string email2 = txtEmail2Agente.Text;

                    PessoaController pessoaController = new PessoaController();
                        
                    if (txtCodAgente.Visible == false) // Quer dizer que estou cadastrando
                    {
                        bool cadastro = pessoaController.CadastrarPessoa(nome, tipoPessoa, cpf, cnpj, telefone1, telefone2, email1, email2);

                        if (cadastro == true)
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!");
                            ReadOnlyTrue();
                            AtualizaGridPessoa();
                        }
                    }

                    else // Quer dizer que estou editando
                    {
                        int id = Convert.ToInt32(txtCodAgente.Text);

                        bool edicao = pessoaController.EditarPessoa(id, nome, tipoPessoa, cpf, cnpj, telefone1, telefone2, email1, email2);

                        if (edicao == true)
                        {
                            MessageBox.Show("Cadastro atualizado com sucesso!");
                            ReadOnlyTrue();
                            AtualizaGridPessoa();
                        }
                    }
                }
            }        
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AtualizaGridPessoa();
        }
        private void grdDadosPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ReadOnlyTrue();

            if (e.RowIndex >= 0) // Para tratativa caso clique no cabeçalho da grid
            {
                // Acessa a linha clicada na grid
                DataGridViewRow row = grdDadosPessoa.Rows[e.RowIndex];

                // Preenchendo os textBox com os valores da linha selecionada
                txtCodAgente.Text = row.Cells["IdPessoa"].Value.ToString();
                txtNomeAgente.Text = row.Cells["Nome"].Value.ToString();
                txtCPFAgente.Text = row.Cells["CPF"].Value.ToString();
                txtCNPJAgente.Text = row.Cells["CNPJ"].Value.ToString();
                txtTelefone1Agente.Text = row.Cells["Telefone1"].Value.ToString();
                txtTelefone2Agente.Text = row.Cells["Telefone2"].Value.ToString();
                txtEmail1Agente.Text = row.Cells["Email1"].Value.ToString();
                txtEmail2Agente.Text = row.Cells["Email2"].Value.ToString();

                if (row.Cells["TipoPessoa"].Value.ToString() == "PF")
                {
                    rbPessoaFisica.Checked = true;
                }
                if (row.Cells["TipoPessoa"].Value.ToString() == "PJ")
                {
                    rbPessoaJuridica.Checked = true;
                }

                btnEditar.Visible = true;
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            ReadOnlyFalse();

            txtCodAgente.ReadOnly = true;
            btnSalvar.Visible = true;
            btnCancelar.Visible = true;
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
        private void LimpaGridPessoa()
        {
            grdDadosPessoa.DataSource = null;
        }
        private void AtualizaGridPessoa()
        {
            LimpaCampos();

            PessoaController pessoaController = new PessoaController();

            // Passando como parâmetros a opção selecionada no ComboBox e o texto digitado
            DataTable tabelaAgente = pessoaController.BuscarPessoa(VerificaComboBoxAgente(), txtBuscar.Text);

            // Atribuindo o DataTable da controller ao dataSource da grid
            grdDadosPessoa.DataSource = tabelaAgente;

            FormataGridPessoa();
        }
    }
}
