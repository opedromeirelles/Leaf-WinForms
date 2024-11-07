namespace LEAF.Views
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAgentes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProducao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInsumos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 556);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(986, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPedidos,
            this.mnuProdutos,
            this.mnuAgentes,
            this.mnuProducao,
            this.mnuInsumos,
            this.mnuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuPedidos
            // 
            this.mnuPedidos.Name = "mnuPedidos";
            this.mnuPedidos.Size = new System.Drawing.Size(61, 20);
            this.mnuPedidos.Text = "Pedidos";
            this.mnuPedidos.Click += new System.EventHandler(this.mnuPedidos_Click);
            // 
            // mnuProdutos
            // 
            this.mnuProdutos.Name = "mnuProdutos";
            this.mnuProdutos.Size = new System.Drawing.Size(67, 20);
            this.mnuProdutos.Text = "Produtos";
            this.mnuProdutos.Click += new System.EventHandler(this.mnuProdutos_Click);
            // 
            // mnuAgentes
            // 
            this.mnuAgentes.Name = "mnuAgentes";
            this.mnuAgentes.Size = new System.Drawing.Size(62, 20);
            this.mnuAgentes.Text = "Agentes";
            this.mnuAgentes.Click += new System.EventHandler(this.mnuAgentes_Click);
            // 
            // mnuProducao
            // 
            this.mnuProducao.Name = "mnuProducao";
            this.mnuProducao.Size = new System.Drawing.Size(70, 20);
            this.mnuProducao.Text = "Produção";
            this.mnuProducao.Click += new System.EventHandler(this.mnuProducao_Click);
            // 
            // mnuInsumos
            // 
            this.mnuInsumos.Name = "mnuInsumos";
            this.mnuInsumos.Size = new System.Drawing.Size(64, 20);
            this.mnuInsumos.Text = "Insumos";
            this.mnuInsumos.Click += new System.EventHandler(this.mnuInsumos_Click);
            // 
            // mnuSair
            // 
            this.mnuSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(38, 20);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(986, 578);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuPedidos;
        private System.Windows.Forms.ToolStripMenuItem mnuAgentes;
        private System.Windows.Forms.ToolStripMenuItem mnuProducao;
        private System.Windows.Forms.ToolStripMenuItem mnuInsumos;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuProdutos;
    }
}