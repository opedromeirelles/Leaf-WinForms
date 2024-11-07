namespace LEAF.Views
{
    partial class frmInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsumos));
            this.txtDescInsumo = new System.Windows.Forms.TextBox();
            this.grdInsumos = new System.Windows.Forms.DataGridView();
            this.btnBuscarInsumos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbStatusProduto = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdInsumos)).BeginInit();
            this.gbStatusProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescInsumo
            // 
            this.txtDescInsumo.Location = new System.Drawing.Point(48, 76);
            this.txtDescInsumo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescInsumo.Name = "txtDescInsumo";
            this.txtDescInsumo.Size = new System.Drawing.Size(328, 27);
            this.txtDescInsumo.TabIndex = 26;
            // 
            // grdInsumos
            // 
            this.grdInsumos.AllowUserToAddRows = false;
            this.grdInsumos.AllowUserToDeleteRows = false;
            this.grdInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInsumos.Location = new System.Drawing.Point(48, 112);
            this.grdInsumos.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.grdInsumos.Name = "grdInsumos";
            this.grdInsumos.ReadOnly = true;
            this.grdInsumos.Size = new System.Drawing.Size(821, 268);
            this.grdInsumos.TabIndex = 25;
            // 
            // btnBuscarInsumos
            // 
            this.btnBuscarInsumos.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarInsumos.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarInsumos.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarInsumos.Image")));
            this.btnBuscarInsumos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarInsumos.Location = new System.Drawing.Point(384, 76);
            this.btnBuscarInsumos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscarInsumos.Name = "btnBuscarInsumos";
            this.btnBuscarInsumos.Size = new System.Drawing.Size(87, 27);
            this.btnBuscarInsumos.TabIndex = 27;
            this.btnBuscarInsumos.Text = "Buscar";
            this.btnBuscarInsumos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarInsumos.UseVisualStyleBackColor = false;
            this.btnBuscarInsumos.Click += new System.EventHandler(this.btnBuscarInsumos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "PESQUISAR INSUMOS";
            // 
            // gbStatusProduto
            // 
            this.gbStatusProduto.Controls.Add(this.rbTodos);
            this.gbStatusProduto.Controls.Add(this.rbAtivo);
            this.gbStatusProduto.Controls.Add(this.rbInativo);
            this.gbStatusProduto.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatusProduto.Location = new System.Drawing.Point(797, 32);
            this.gbStatusProduto.Name = "gbStatusProduto";
            this.gbStatusProduto.Size = new System.Drawing.Size(72, 71);
            this.gbStatusProduto.TabIndex = 32;
            this.gbStatusProduto.TabStop = false;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(3, 47);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(63, 21);
            this.rbTodos.TabIndex = 0;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Location = new System.Drawing.Point(3, 13);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(55, 21);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(3, 30);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(64, 21);
            this.rbInativo.TabIndex = 0;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // frmInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 426);
            this.Controls.Add(this.gbStatusProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarInsumos);
            this.Controls.Add(this.txtDescInsumo);
            this.Controls.Add(this.grdInsumos);
            this.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.grdInsumos)).EndInit();
            this.gbStatusProduto.ResumeLayout(false);
            this.gbStatusProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarInsumos;
        private System.Windows.Forms.TextBox txtDescInsumo;
        private System.Windows.Forms.DataGridView grdInsumos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbStatusProduto;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.RadioButton rbInativo;
    }
}