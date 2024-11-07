namespace LEAF.Views.Pedido
{
    partial class frmNovoPedido
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDadosCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.grdItensPedido = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDescartar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdItensPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "NOVO PEDIDO";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(95, 121);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(147, 27);
            this.txtNomeCliente.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cliente:";
            // 
            // txtDadosCliente
            // 
            this.txtDadosCliente.Location = new System.Drawing.Point(95, 156);
            this.txtDadosCliente.Name = "txtDadosCliente";
            this.txtDadosCliente.Size = new System.Drawing.Size(147, 27);
            this.txtDadosCliente.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "CPF/CNPJ:";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(95, 191);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(147, 27);
            this.txtCep.TabIndex = 11;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(95, 225);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(390, 27);
            this.txtEndereco.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "CEP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 40);
            this.label5.TabIndex = 12;
            this.label5.Text = "Endereço\r\nde entrega:";
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCliente.Location = new System.Drawing.Point(215, 96);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(27, 23);
            this.btnAddCliente.TabIndex = 15;
            this.btnAddCliente.Text = "+";
            this.btnAddCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduto.Location = new System.Drawing.Point(596, 92);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(27, 23);
            this.btnAddProduto.TabIndex = 15;
            this.btnAddProduto.Text = "+";
            this.btnAddProduto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // grdItensPedido
            // 
            this.grdItensPedido.AllowUserToAddRows = false;
            this.grdItensPedido.AllowUserToDeleteRows = false;
            this.grdItensPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItensPedido.Location = new System.Drawing.Point(254, 118);
            this.grdItensPedido.Name = "grdItensPedido";
            this.grdItensPedido.ReadOnly = true;
            this.grdItensPedido.Size = new System.Drawing.Size(369, 101);
            this.grdItensPedido.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Adicionar cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Adicionar produtos";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(549, 225);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(74, 27);
            this.txtValorTotal.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(497, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(242, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(242, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(242, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(485, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 15);
            this.label13.TabIndex = 18;
            this.label13.Text = "*";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(548, 258);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 30);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDescartar
            // 
            this.btnDescartar.BackColor = System.Drawing.Color.Red;
            this.btnDescartar.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescartar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDescartar.Location = new System.Drawing.Point(467, 258);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(76, 30);
            this.btnDescartar.TabIndex = 20;
            this.btnDescartar.Text = "Cancelar";
            this.btnDescartar.UseVisualStyleBackColor = false;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // frmNovoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 292);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grdItensPedido);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.btnAddCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtDadosCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmNovoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.grdItensPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDadosCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.DataGridView grdItensPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDescartar;
    }
}