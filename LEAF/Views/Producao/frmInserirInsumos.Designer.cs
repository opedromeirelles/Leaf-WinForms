namespace LEAF.Views
{
    partial class frmInserirInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserirInsumos));
            this.grdInsumosDisponiveis = new System.Windows.Forms.DataGridView();
            this.grdInsumosSelecionados = new System.Windows.Forms.DataGridView();
            this.btnAddInsumo = new System.Windows.Forms.Button();
            this.btnRemoveInsumo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescInsumo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarInsumos = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdInsumosDisponiveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdInsumosSelecionados)).BeginInit();
            this.SuspendLayout();
            // 
            // grdInsumosDisponiveis
            // 
            this.grdInsumosDisponiveis.AllowUserToAddRows = false;
            this.grdInsumosDisponiveis.AllowUserToDeleteRows = false;
            this.grdInsumosDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInsumosDisponiveis.Location = new System.Drawing.Point(14, 95);
            this.grdInsumosDisponiveis.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grdInsumosDisponiveis.Name = "grdInsumosDisponiveis";
            this.grdInsumosDisponiveis.ReadOnly = true;
            this.grdInsumosDisponiveis.Size = new System.Drawing.Size(475, 174);
            this.grdInsumosDisponiveis.TabIndex = 0;
            // 
            // grdInsumosSelecionados
            // 
            this.grdInsumosSelecionados.AllowUserToAddRows = false;
            this.grdInsumosSelecionados.AllowUserToDeleteRows = false;
            this.grdInsumosSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInsumosSelecionados.Location = new System.Drawing.Point(14, 311);
            this.grdInsumosSelecionados.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grdInsumosSelecionados.Name = "grdInsumosSelecionados";
            this.grdInsumosSelecionados.ReadOnly = true;
            this.grdInsumosSelecionados.Size = new System.Drawing.Size(475, 163);
            this.grdInsumosSelecionados.TabIndex = 0;
            // 
            // btnAddInsumo
            // 
            this.btnAddInsumo.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInsumo.Location = new System.Drawing.Point(92, 278);
            this.btnAddInsumo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddInsumo.Name = "btnAddInsumo";
            this.btnAddInsumo.Size = new System.Drawing.Size(25, 25);
            this.btnAddInsumo.TabIndex = 1;
            this.btnAddInsumo.Text = "\\/";
            this.btnAddInsumo.UseVisualStyleBackColor = true;
            this.btnAddInsumo.Click += new System.EventHandler(this.btnAddInsumo_Click);
            // 
            // btnRemoveInsumo
            // 
            this.btnRemoveInsumo.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveInsumo.Location = new System.Drawing.Point(300, 279);
            this.btnRemoveInsumo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRemoveInsumo.Name = "btnRemoveInsumo";
            this.btnRemoveInsumo.Size = new System.Drawing.Size(25, 25);
            this.btnRemoveInsumo.TabIndex = 1;
            this.btnRemoveInsumo.Text = "/\\";
            this.btnRemoveInsumo.UseVisualStyleBackColor = true;
            this.btnRemoveInsumo.Click += new System.EventHandler(this.btnRemoveInsumo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adicionar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remover";
            // 
            // txtDescInsumo
            // 
            this.txtDescInsumo.Location = new System.Drawing.Point(14, 65);
            this.txtDescInsumo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescInsumo.Name = "txtDescInsumo";
            this.txtDescInsumo.Size = new System.Drawing.Size(351, 25);
            this.txtDescInsumo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "INSERIR INSUMOS";
            // 
            // btnBuscarInsumos
            // 
            this.btnBuscarInsumos.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarInsumos.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarInsumos.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarInsumos.Image")));
            this.btnBuscarInsumos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarInsumos.Location = new System.Drawing.Point(371, 63);
            this.btnBuscarInsumos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarInsumos.Name = "btnBuscarInsumos";
            this.btnBuscarInsumos.Size = new System.Drawing.Size(97, 28);
            this.btnBuscarInsumos.TabIndex = 24;
            this.btnBuscarInsumos.Text = "Buscar";
            this.btnBuscarInsumos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarInsumos.UseVisualStyleBackColor = false;
            this.btnBuscarInsumos.Click += new System.EventHandler(this.btnBuscarInsumos_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(414, 481);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 30);
            this.btnSalvar.TabIndex = 37;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(333, 481);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 30);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmInserirInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 517);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscarInsumos);
            this.Controls.Add(this.txtDescInsumo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveInsumo);
            this.Controls.Add(this.btnAddInsumo);
            this.Controls.Add(this.grdInsumosSelecionados);
            this.Controls.Add(this.grdInsumosDisponiveis);
            this.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInserirInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.grdInsumosDisponiveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdInsumosSelecionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdInsumosDisponiveis;
        private System.Windows.Forms.DataGridView grdInsumosSelecionados;
        private System.Windows.Forms.Button btnAddInsumo;
        private System.Windows.Forms.Button btnRemoveInsumo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescInsumo;
        private System.Windows.Forms.Button btnBuscarInsumos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}