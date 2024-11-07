using LEAF.Controllers;
using LEAF.Models;
using LEAF.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEAF.Views
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            exibirMenus();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public void exibirMenus()
        {
            int idDepartamento = SessaoUsuario.Departamento;

            if (idDepartamento == 4)
            {
                mnuPedidos.Visible = false;
                mnuProdutos.Visible = false;
                mnuAgentes.Visible = false;
            }
            else if (idDepartamento == 5)
            {
                mnuProducao.Visible = false;
                mnuInsumos.Visible = false;
            }
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            var retorno = MessageBox.Show("Deseja desconectar a sessão?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (retorno == DialogResult.Yes)
            {
                frmLogin telaLogin = new frmLogin();
                telaLogin.Show();
                this.Hide();
            }
        }
        private void mnuAgentes_Click(object sender, EventArgs e)
        {
            frmAgente menuAgente = new frmAgente();
            menuAgente.MdiParent = this;
            menuAgente.Show();
        }
        private void mnuProducao_Click(object sender, EventArgs e)
        {
            frmProducao menuProducao = new frmProducao();
            menuProducao.MdiParent = this;
            menuProducao.Show();
        }
        private void mnuInsumos_Click(object sender, EventArgs e)
        {
            frmInsumos menuInsumos = new frmInsumos();
            menuInsumos.MdiParent = this;
            menuInsumos.Show();
        }
        private void mnuProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos menuProdutos = new frmProdutos();
            menuProdutos.MdiParent = this;
            menuProdutos.Show();
        }

        private void mnuPedidos_Click(object sender, EventArgs e)
        {
            frmPedidos menuPedidos = new frmPedidos();
            menuPedidos.MdiParent = this;
            menuPedidos.Show();
        }
    }
}
