namespace LEAF.Views
{
    partial class frmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidos));
            this.grdPedido = new System.Windows.Forms.DataGridView();
            this.cbPedidoBuscarPor = new System.Windows.Forms.ComboBox();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.cbStatusPedido = new System.Windows.Forms.ComboBox();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.btnBuscarPedido = new System.Windows.Forms.Button();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPedido
            // 
            this.grdPedido.AllowUserToAddRows = false;
            this.grdPedido.AllowUserToDeleteRows = false;
            this.grdPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPedido.Location = new System.Drawing.Point(17, 97);
            this.grdPedido.Name = "grdPedido";
            this.grdPedido.ReadOnly = true;
            this.grdPedido.Size = new System.Drawing.Size(763, 268);
            this.grdPedido.TabIndex = 0;
            this.grdPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPedido_CellClick);
            // 
            // cbPedidoBuscarPor
            // 
            this.cbPedidoBuscarPor.BackColor = System.Drawing.SystemColors.Menu;
            this.cbPedidoBuscarPor.FormattingEnabled = true;
            this.cbPedidoBuscarPor.Items.AddRange(new object[] {
            "Status",
            "N° Pedido"});
            this.cbPedidoBuscarPor.Location = new System.Drawing.Point(17, 63);
            this.cbPedidoBuscarPor.Name = "cbPedidoBuscarPor";
            this.cbPedidoBuscarPor.Size = new System.Drawing.Size(97, 28);
            this.cbPedidoBuscarPor.TabIndex = 1;
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(14, 48);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(62, 13);
            this.lblBuscarPor.TabIndex = 32;
            this.lblBuscarPor.Text = "Buscar por";
            // 
            // cbStatusPedido
            // 
            this.cbStatusPedido.BackColor = System.Drawing.SystemColors.Menu;
            this.cbStatusPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusPedido.FormattingEnabled = true;
            this.cbStatusPedido.Items.AddRange(new object[] {
            "Em aberto",
            "Rota de entrega",
            "Baixado",
            "Cancelado"});
            this.cbStatusPedido.Location = new System.Drawing.Point(117, 63);
            this.cbStatusPedido.Name = "cbStatusPedido";
            this.cbStatusPedido.Size = new System.Drawing.Size(141, 28);
            this.cbStatusPedido.TabIndex = 35;
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPedido.Location = new System.Drawing.Point(120, 64);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(135, 26);
            this.txtIdPedido.TabIndex = 36;
            // 
            // btnBuscarPedido
            // 
            this.btnBuscarPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPedido.Image")));
            this.btnBuscarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPedido.Location = new System.Drawing.Point(264, 63);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Size = new System.Drawing.Size(97, 28);
            this.btnBuscarPedido.TabIndex = 37;
            this.btnBuscarPedido.Text = "Buscar";
            this.btnBuscarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPedido.UseVisualStyleBackColor = false;
            this.btnBuscarPedido.Click += new System.EventHandler(this.btnBuscarPedido_Click);
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNovoPedido.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNovoPedido.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovoPedido.Location = new System.Drawing.Point(652, 58);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(128, 36);
            this.btnNovoPedido.TabIndex = 38;
            this.btnNovoPedido.Text = "Novo Pedido +";
            this.btnNovoPedido.UseVisualStyleBackColor = false;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 32);
            this.label2.TabIndex = 39;
            this.label2.Text = "PEDIDOS";
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNovoPedido);
            this.Controls.Add(this.btnBuscarPedido);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.cbStatusPedido);
            this.Controls.Add(this.lblBuscarPor);
            this.Controls.Add(this.cbPedidoBuscarPor);
            this.Controls.Add(this.grdPedido);
            this.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPedido;
        private System.Windows.Forms.ComboBox cbPedidoBuscarPor;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.ComboBox cbStatusPedido;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Button btnBuscarPedido;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.Label label2;
    }
}