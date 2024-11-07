namespace LEAF.Views.Pedido
{
    partial class frmConsultarAgente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarAgente));
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.cbAgenteBuscarPor = new System.Windows.Forms.ComboBox();
            this.grdDadosPessoa = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarAgente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(24, 81);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(62, 13);
            this.lblBuscarPor.TabIndex = 34;
            this.lblBuscarPor.Text = "Buscar por";
            // 
            // cbAgenteBuscarPor
            // 
            this.cbAgenteBuscarPor.BackColor = System.Drawing.SystemColors.Menu;
            this.cbAgenteBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAgenteBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAgenteBuscarPor.FormattingEnabled = true;
            this.cbAgenteBuscarPor.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "CPF",
            "CNPJ"});
            this.cbAgenteBuscarPor.Location = new System.Drawing.Point(25, 94);
            this.cbAgenteBuscarPor.Name = "cbAgenteBuscarPor";
            this.cbAgenteBuscarPor.Size = new System.Drawing.Size(90, 28);
            this.cbAgenteBuscarPor.TabIndex = 30;
            // 
            // grdDadosPessoa
            // 
            this.grdDadosPessoa.AllowUserToAddRows = false;
            this.grdDadosPessoa.AllowUserToDeleteRows = false;
            this.grdDadosPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDadosPessoa.Location = new System.Drawing.Point(25, 125);
            this.grdDadosPessoa.Name = "grdDadosPessoa";
            this.grdDadosPessoa.ReadOnly = true;
            this.grdDadosPessoa.Size = new System.Drawing.Size(415, 284);
            this.grdDadosPessoa.TabIndex = 33;
            this.grdDadosPessoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDadosPessoa_CellClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtBuscar.Location = new System.Drawing.Point(121, 94);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(216, 26);
            this.txtBuscar.TabIndex = 31;
            // 
            // btnBuscarAgente
            // 
            this.btnBuscarAgente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarAgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAgente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarAgente.Image")));
            this.btnBuscarAgente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarAgente.Location = new System.Drawing.Point(343, 93);
            this.btnBuscarAgente.Name = "btnBuscarAgente";
            this.btnBuscarAgente.Size = new System.Drawing.Size(97, 28);
            this.btnBuscarAgente.TabIndex = 32;
            this.btnBuscarAgente.Text = "Buscar";
            this.btnBuscarAgente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarAgente.UseVisualStyleBackColor = false;
            this.btnBuscarAgente.Click += new System.EventHandler(this.btnBuscarAgente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "PESQUISAR AGENTE";
            // 
            // frmConsultarAgente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBuscarPor);
            this.Controls.Add(this.cbAgenteBuscarPor);
            this.Controls.Add(this.grdDadosPessoa);
            this.Controls.Add(this.btnBuscarAgente);
            this.Controls.Add(this.txtBuscar);
            this.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmConsultarAgente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.ComboBox cbAgenteBuscarPor;
        private System.Windows.Forms.DataGridView grdDadosPessoa;
        private System.Windows.Forms.Button btnBuscarAgente;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
    }
}