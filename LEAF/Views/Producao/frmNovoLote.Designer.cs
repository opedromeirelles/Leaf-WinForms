namespace LEAF.Views
{
    partial class frmNovoLote
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProdutoLote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddInsumo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodLote = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grdItensLote = new System.Windows.Forms.DataGridView();
            this.btnSalvarNovoLote = new System.Windows.Forms.Button();
            this.btnDescartarNovoLote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdItensLote)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cód. Lote:";
            // 
            // txtProdutoLote
            // 
            this.txtProdutoLote.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdutoLote.Location = new System.Drawing.Point(132, 136);
            this.txtProdutoLote.Name = "txtProdutoLote";
            this.txtProdutoLote.Size = new System.Drawing.Size(86, 25);
            this.txtProdutoLote.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adicionar";
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduto.Location = new System.Drawing.Point(39, 135);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(27, 23);
            this.btnAddProduto.TabIndex = 2;
            this.btnAddProduto.Text = "+";
            this.btnAddProduto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adicionar insumos";
            // 
            // btnAddInsumo
            // 
            this.btnAddInsumo.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInsumo.Location = new System.Drawing.Point(538, 75);
            this.btnAddInsumo.Name = "btnAddInsumo";
            this.btnAddInsumo.Size = new System.Drawing.Size(27, 23);
            this.btnAddInsumo.TabIndex = 4;
            this.btnAddInsumo.Text = "+";
            this.btnAddInsumo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddInsumo.UseVisualStyleBackColor = true;
            this.btnAddInsumo.Click += new System.EventHandler(this.btnAddInsumo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Leelawadee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "NOVO LOTE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(217, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(217, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "*";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(132, 168);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(86, 25);
            this.txtQuantidade.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Qtde:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(217, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "*";
            // 
            // txtCodLote
            // 
            this.txtCodLote.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodLote.Location = new System.Drawing.Point(132, 103);
            this.txtCodLote.Mask = "LLL000000";
            this.txtCodLote.Name = "txtCodLote";
            this.txtCodLote.Size = new System.Drawing.Size(86, 25);
            this.txtCodLote.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(72, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Produto";
            // 
            // grdItensLote
            // 
            this.grdItensLote.AllowUserToAddRows = false;
            this.grdItensLote.AllowUserToDeleteRows = false;
            this.grdItensLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItensLote.Location = new System.Drawing.Point(231, 101);
            this.grdItensLote.Name = "grdItensLote";
            this.grdItensLote.ReadOnly = true;
            this.grdItensLote.Size = new System.Drawing.Size(334, 93);
            this.grdItensLote.TabIndex = 21;
            // 
            // btnSalvarNovoLote
            // 
            this.btnSalvarNovoLote.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvarNovoLote.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarNovoLote.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvarNovoLote.Location = new System.Drawing.Point(490, 200);
            this.btnSalvarNovoLote.Name = "btnSalvarNovoLote";
            this.btnSalvarNovoLote.Size = new System.Drawing.Size(75, 30);
            this.btnSalvarNovoLote.TabIndex = 22;
            this.btnSalvarNovoLote.Text = "Salvar";
            this.btnSalvarNovoLote.UseVisualStyleBackColor = false;
            this.btnSalvarNovoLote.Click += new System.EventHandler(this.btnSalvarNovoLote_Click);
            // 
            // btnDescartarNovoLote
            // 
            this.btnDescartarNovoLote.BackColor = System.Drawing.Color.Red;
            this.btnDescartarNovoLote.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescartarNovoLote.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDescartarNovoLote.Location = new System.Drawing.Point(408, 200);
            this.btnDescartarNovoLote.Name = "btnDescartarNovoLote";
            this.btnDescartarNovoLote.Size = new System.Drawing.Size(76, 30);
            this.btnDescartarNovoLote.TabIndex = 23;
            this.btnDescartarNovoLote.Text = "Cancelar";
            this.btnDescartarNovoLote.UseVisualStyleBackColor = false;
            this.btnDescartarNovoLote.Click += new System.EventHandler(this.btnDescartarNovoLote_Click);
            // 
            // frmNovoLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 234);
            this.Controls.Add(this.btnSalvarNovoLote);
            this.Controls.Add(this.btnDescartarNovoLote);
            this.Controls.Add(this.grdItensLote);
            this.Controls.Add(this.txtCodLote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddInsumo);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtProdutoLote);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNovoLote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.grdItensLote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProdutoLote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddInsumo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtCodLote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grdItensLote;
        private System.Windows.Forms.Button btnSalvarNovoLote;
        private System.Windows.Forms.Button btnDescartarNovoLote;
    }
}