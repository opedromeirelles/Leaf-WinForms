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
    public partial class frmNovaQuantidadeLote : Form
    {
        private int quantidadeAtual;
        public int NovaQuantidade { get; set; }
        public LoteController _loteController;
        public frmNovaQuantidadeLote(int quantidadeAtual)
        {
            InitializeComponent();
            this.quantidadeAtual = quantidadeAtual;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int quantidade;

            if (!int.TryParse(txtNovaQtdeLote.Text.Trim(), out quantidade))
            {
                MessageBox.Show("Por favor, informe um valor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (quantidade >= quantidadeAtual)
            {
                MessageBox.Show("A nova quantidade não pode ser igual ou maior do que a atual.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (quantidade < 0)
            {
                MessageBox.Show("A quantidade não pode ser um valor negativo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                NovaQuantidade = quantidade;

                MessageBox.Show("Quantidade atualizada!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
