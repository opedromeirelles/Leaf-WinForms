namespace LEAF.Views.Pedido
{
    partial class frmInserirProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserirProdutos));
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.grdProdutosSelecionados = new System.Windows.Forms.DataGridView();
            this.grdProdutosDisponiveis = new System.Windows.Forms.DataGridView();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemoveProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQtdeSelecionada = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutosSelecionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutosDisponiveis)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "INSERIR PRODUTOS";
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProduto.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProduto.Image")));
            this.btnBuscarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProduto.Location = new System.Drawing.Point(252, 66);
            this.btnBuscarProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(97, 28);
            this.btnBuscarProduto.TabIndex = 44;
            this.btnBuscarProduto.Text = "Buscar";
            this.btnBuscarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProduto.UseVisualStyleBackColor = false;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(13, 66);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(233, 27);
            this.txtDesc.TabIndex = 43;
            // 
            // grdProdutosSelecionados
            // 
            this.grdProdutosSelecionados.AllowUserToAddRows = false;
            this.grdProdutosSelecionados.AllowUserToDeleteRows = false;
            this.grdProdutosSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProdutosSelecionados.Location = new System.Drawing.Point(13, 334);
            this.grdProdutosSelecionados.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grdProdutosSelecionados.Name = "grdProdutosSelecionados";
            this.grdProdutosSelecionados.ReadOnly = true;
            this.grdProdutosSelecionados.Size = new System.Drawing.Size(475, 163);
            this.grdProdutosSelecionados.TabIndex = 37;
            // 
            // grdProdutosDisponiveis
            // 
            this.grdProdutosDisponiveis.AllowUserToAddRows = false;
            this.grdProdutosDisponiveis.AllowUserToDeleteRows = false;
            this.grdProdutosDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProdutosDisponiveis.Location = new System.Drawing.Point(13, 97);
            this.grdProdutosDisponiveis.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grdProdutosDisponiveis.Name = "grdProdutosDisponiveis";
            this.grdProdutosDisponiveis.ReadOnly = true;
            this.grdProdutosDisponiveis.Size = new System.Drawing.Size(475, 174);
            this.grdProdutosDisponiveis.TabIndex = 38;
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduto.Location = new System.Drawing.Point(130, 294);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(25, 25);
            this.btnAddProduto.TabIndex = 49;
            this.btnAddProduto.Text = "\\/";
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Informe a quantidade:";
            // 
            // btnRemoveProduto
            // 
            this.btnRemoveProduto.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduto.Location = new System.Drawing.Point(299, 292);
            this.btnRemoveProduto.Name = "btnRemoveProduto";
            this.btnRemoveProduto.Size = new System.Drawing.Size(25, 25);
            this.btnRemoveProduto.TabIndex = 51;
            this.btnRemoveProduto.Text = "/\\";
            this.btnRemoveProduto.UseVisualStyleBackColor = true;
            this.btnRemoveProduto.Click += new System.EventHandler(this.btnRemoveProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Adicionar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Remover";
            // 
            // txtQtdeSelecionada
            // 
            this.txtQtdeSelecionada.Location = new System.Drawing.Point(59, 293);
            this.txtQtdeSelecionada.Name = "txtQtdeSelecionada";
            this.txtQtdeSelecionada.Size = new System.Drawing.Size(65, 27);
            this.txtQtdeSelecionada.TabIndex = 48;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(413, 502);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 30);
            this.btnSalvar.TabIndex = 53;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(332, 502);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 30);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmInserirProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 535);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.txtQtdeSelecionada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscarProduto);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.grdProdutosSelecionados);
            this.Controls.Add(this.grdProdutosDisponiveis);
            this.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmInserirProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutosSelecionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutosDisponiveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.DataGridView grdProdutosSelecionados;
        private System.Windows.Forms.DataGridView grdProdutosDisponiveis;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemoveProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQtdeSelecionada;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}