namespace LEAF.Views
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.label2 = new System.Windows.Forms.Label();
            this.grdProdutos = new System.Windows.Forms.DataGridView();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.gbStatusProduto = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
            this.gbStatusProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "PESQUISAR PRODUTO";
            // 
            // grdProdutos
            // 
            this.grdProdutos.AllowUserToAddRows = false;
            this.grdProdutos.AllowUserToDeleteRows = false;
            this.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProdutos.Location = new System.Drawing.Point(31, 86);
            this.grdProdutos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.ReadOnly = true;
            this.grdProdutos.Size = new System.Drawing.Size(457, 266);
            this.grdProdutos.TabIndex = 28;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(158, 56);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(133, 27);
            this.txtNomeProduto.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nome do produto:";
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProduto.Image")));
            this.btnBuscarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProduto.Location = new System.Drawing.Point(298, 54);
            this.btnBuscarProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(101, 29);
            this.btnBuscarProduto.TabIndex = 29;
            this.btnBuscarProduto.Text = "Buscar";
            this.btnBuscarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProduto.UseVisualStyleBackColor = false;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);
            // 
            // gbStatusProduto
            // 
            this.gbStatusProduto.Controls.Add(this.rbTodos);
            this.gbStatusProduto.Controls.Add(this.rbAtivo);
            this.gbStatusProduto.Controls.Add(this.rbInativo);
            this.gbStatusProduto.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatusProduto.Location = new System.Drawing.Point(414, 13);
            this.gbStatusProduto.Name = "gbStatusProduto";
            this.gbStatusProduto.Size = new System.Drawing.Size(72, 71);
            this.gbStatusProduto.TabIndex = 31;
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
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 377);
            this.Controls.Add(this.gbStatusProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarProduto);
            this.Controls.Add(this.grdProdutos);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            this.gbStatusProduto.ResumeLayout(false);
            this.gbStatusProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.DataGridView grdProdutos;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbStatusProduto;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.RadioButton rbInativo;
    }
}