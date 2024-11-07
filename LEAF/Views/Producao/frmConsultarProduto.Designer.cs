namespace LEAF.Views
{
    partial class frmConsultarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.grdConsultaProdutos = new System.Windows.Forms.DataGridView();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do produto:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(158, 61);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(132, 25);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // grdConsultaProdutos
            // 
            this.grdConsultaProdutos.AllowUserToAddRows = false;
            this.grdConsultaProdutos.AllowUserToDeleteRows = false;
            this.grdConsultaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultaProdutos.Location = new System.Drawing.Point(26, 90);
            this.grdConsultaProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.grdConsultaProdutos.Name = "grdConsultaProdutos";
            this.grdConsultaProdutos.ReadOnly = true;
            this.grdConsultaProdutos.Size = new System.Drawing.Size(456, 173);
            this.grdConsultaProdutos.TabIndex = 2;
            this.grdConsultaProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsultaProdutos_CellClick);
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProduto.Image")));
            this.btnBuscarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProduto.Location = new System.Drawing.Point(297, 59);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(97, 28);
            this.btnBuscarProduto.TabIndex = 24;
            this.btnBuscarProduto.Text = "Buscar";
            this.btnBuscarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProduto.UseVisualStyleBackColor = false;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "PESQUISAR PRODUTO";
            // 
            // frmConsultarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 285);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarProduto);
            this.Controls.Add(this.grdConsultaProdutos);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmConsultarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.DataGridView grdConsultaProdutos;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.Label label2;
    }
}