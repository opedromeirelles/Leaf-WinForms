namespace LEAF.Views
{
    partial class frmProducao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducao));
            this.label2 = new System.Windows.Forms.Label();
            this.grdLoteProducao = new System.Windows.Forms.DataGridView();
            this.btnNovoLote = new System.Windows.Forms.Button();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.cbProducaoBuscarPor = new System.Windows.Forms.ComboBox();
            this.txtCodLote = new System.Windows.Forms.TextBox();
            this.cbStatusLote = new System.Windows.Forms.ComboBox();
            this.btnBuscarLote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdLoteProducao)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "LOTE DE PRODUÇÃO";
            // 
            // grdLoteProducao
            // 
            this.grdLoteProducao.AllowUserToAddRows = false;
            this.grdLoteProducao.AllowUserToDeleteRows = false;
            this.grdLoteProducao.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdLoteProducao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdLoteProducao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdLoteProducao.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdLoteProducao.Location = new System.Drawing.Point(23, 120);
            this.grdLoteProducao.Name = "grdLoteProducao";
            this.grdLoteProducao.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdLoteProducao.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdLoteProducao.Size = new System.Drawing.Size(529, 233);
            this.grdLoteProducao.TabIndex = 22;
            this.grdLoteProducao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLoteProducao_CellClick);
            // 
            // btnNovoLote
            // 
            this.btnNovoLote.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNovoLote.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNovoLote.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoLote.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovoLote.Location = new System.Drawing.Point(424, 77);
            this.btnNovoLote.Name = "btnNovoLote";
            this.btnNovoLote.Size = new System.Drawing.Size(128, 36);
            this.btnNovoLote.TabIndex = 27;
            this.btnNovoLote.Text = "Novo Lote +";
            this.btnNovoLote.UseVisualStyleBackColor = false;
            this.btnNovoLote.Click += new System.EventHandler(this.btnNovoLote_Click);
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(21, 68);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(62, 13);
            this.lblBuscarPor.TabIndex = 31;
            this.lblBuscarPor.Text = "Buscar por";
            // 
            // cbProducaoBuscarPor
            // 
            this.cbProducaoBuscarPor.BackColor = System.Drawing.SystemColors.Menu;
            this.cbProducaoBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducaoBuscarPor.FormattingEnabled = true;
            this.cbProducaoBuscarPor.Items.AddRange(new object[] {
            "Código",
            "Status"});
            this.cbProducaoBuscarPor.Location = new System.Drawing.Point(22, 81);
            this.cbProducaoBuscarPor.Name = "cbProducaoBuscarPor";
            this.cbProducaoBuscarPor.Size = new System.Drawing.Size(90, 28);
            this.cbProducaoBuscarPor.TabIndex = 30;
            // 
            // txtCodLote
            // 
            this.txtCodLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodLote.Location = new System.Drawing.Point(117, 83);
            this.txtCodLote.Name = "txtCodLote";
            this.txtCodLote.Size = new System.Drawing.Size(149, 26);
            this.txtCodLote.TabIndex = 32;
            // 
            // cbStatusLote
            // 
            this.cbStatusLote.BackColor = System.Drawing.SystemColors.Menu;
            this.cbStatusLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusLote.FormattingEnabled = true;
            this.cbStatusLote.Items.AddRange(new object[] {
            "Semeadura",
            "Crescimento",
            "Desenvolvimento",
            "Colheita"});
            this.cbStatusLote.Location = new System.Drawing.Point(117, 81);
            this.cbStatusLote.Name = "cbStatusLote";
            this.cbStatusLote.Size = new System.Drawing.Size(149, 28);
            this.cbStatusLote.TabIndex = 34;
            // 
            // btnBuscarLote
            // 
            this.btnBuscarLote.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLote.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarLote.Image")));
            this.btnBuscarLote.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarLote.Location = new System.Drawing.Point(271, 81);
            this.btnBuscarLote.Name = "btnBuscarLote";
            this.btnBuscarLote.Size = new System.Drawing.Size(97, 29);
            this.btnBuscarLote.TabIndex = 33;
            this.btnBuscarLote.Text = "Buscar";
            this.btnBuscarLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarLote.UseVisualStyleBackColor = false;
            this.btnBuscarLote.Click += new System.EventHandler(this.btnBuscarLote_Click);
            // 
            // frmProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 369);
            this.Controls.Add(this.cbStatusLote);
            this.Controls.Add(this.btnBuscarLote);
            this.Controls.Add(this.txtCodLote);
            this.Controls.Add(this.lblBuscarPor);
            this.Controls.Add(this.cbProducaoBuscarPor);
            this.Controls.Add(this.btnNovoLote);
            this.Controls.Add(this.grdLoteProducao);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProducao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmProducao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLoteProducao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdLoteProducao;
        private System.Windows.Forms.Button btnNovoLote;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.ComboBox cbProducaoBuscarPor;
        private System.Windows.Forms.TextBox txtCodLote;
        private System.Windows.Forms.Button btnBuscarLote;
        private System.Windows.Forms.ComboBox cbStatusLote;
    }
}