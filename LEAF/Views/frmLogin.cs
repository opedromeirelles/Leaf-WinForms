using LEAF.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LEAF.Controllers;
using LEAF.Models;

namespace LEAF
{
    public partial class frmLogin : Form
    {
        private LoginController _loginController;
        public frmLogin()
        {
            InitializeComponent();
            _loginController = new LoginController();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            bool autenticacao = _loginController.autenticarUsuario(usuario, senha);

            if (txtUsuario.Text != "")
            {

                if (autenticacao == true)
                {
                    frmHome telaHome = new frmHome();
                    telaHome.Show();
                    this.Hide();
                }           
                else
                {
                    MessageBox.Show("Dados inválidos ou usuário bloqueado.","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Informe um usuário.");
            }
            
        }
    }
}
