namespace LEAF.Views
{
    partial class frmAgente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgente));
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.cbAgenteBuscarPor = new System.Windows.Forms.ComboBox();
            this.pnlDadosAgente = new System.Windows.Forms.Panel();
            this.txtCNPJAgente = new System.Windows.Forms.MaskedTextBox();
            this.txtCPFAgente = new System.Windows.Forms.MaskedTextBox();
            this.lblNomeObrigatorio = new System.Windows.Forms.Label();
            this.lblEmailObrigatorio = new System.Windows.Forms.Label();
            this.lblCNPJObrigatorio = new System.Windows.Forms.Label();
            this.lblCPFObrigatorio = new System.Windows.Forms.Label();
            this.lblTelefoneObrigatorio = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail2Agente = new System.Windows.Forms.TextBox();
            this.txtEmail1Agente = new System.Windows.Forms.TextBox();
            this.lblCodAgente = new System.Windows.Forms.Label();
            this.txtTelefone2Agente = new System.Windows.Forms.TextBox();
            this.txtNomeAgente = new System.Windows.Forms.TextBox();
            this.txtTelefone1Agente = new System.Windows.Forms.TextBox();
            this.grbTipoPessoa = new System.Windows.Forms.GroupBox();
            this.rbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.txtCodAgente = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grdDadosPessoa = new System.Windows.Forms.DataGridView();
            this.btnNovoAgente = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarAgente = new System.Windows.Forms.Button();
            this.pnlDadosAgente.SuspendLayout();
            this.grbTipoPessoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Location = new System.Drawing.Point(12, 101);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(58, 13);
            this.lblBuscarPor.TabIndex = 29;
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
            this.cbAgenteBuscarPor.Location = new System.Drawing.Point(13, 114);
            this.cbAgenteBuscarPor.Name = "cbAgenteBuscarPor";
            this.cbAgenteBuscarPor.Size = new System.Drawing.Size(90, 28);
            this.cbAgenteBuscarPor.TabIndex = 21;
            // 
            // pnlDadosAgente
            // 
            this.pnlDadosAgente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDadosAgente.Controls.Add(this.txtCNPJAgente);
            this.pnlDadosAgente.Controls.Add(this.txtCPFAgente);
            this.pnlDadosAgente.Controls.Add(this.lblNomeObrigatorio);
            this.pnlDadosAgente.Controls.Add(this.lblEmailObrigatorio);
            this.pnlDadosAgente.Controls.Add(this.lblCNPJObrigatorio);
            this.pnlDadosAgente.Controls.Add(this.lblCPFObrigatorio);
            this.pnlDadosAgente.Controls.Add(this.lblTelefoneObrigatorio);
            this.pnlDadosAgente.Controls.Add(this.lblCNPJ);
            this.pnlDadosAgente.Controls.Add(this.lblCPF);
            this.pnlDadosAgente.Controls.Add(this.btnEditar);
            this.pnlDadosAgente.Controls.Add(this.label3);
            this.pnlDadosAgente.Controls.Add(this.label7);
            this.pnlDadosAgente.Controls.Add(this.label6);
            this.pnlDadosAgente.Controls.Add(this.label5);
            this.pnlDadosAgente.Controls.Add(this.label4);
            this.pnlDadosAgente.Controls.Add(this.txtEmail2Agente);
            this.pnlDadosAgente.Controls.Add(this.txtEmail1Agente);
            this.pnlDadosAgente.Controls.Add(this.lblCodAgente);
            this.pnlDadosAgente.Controls.Add(this.txtTelefone2Agente);
            this.pnlDadosAgente.Controls.Add(this.txtNomeAgente);
            this.pnlDadosAgente.Controls.Add(this.txtTelefone1Agente);
            this.pnlDadosAgente.Controls.Add(this.grbTipoPessoa);
            this.pnlDadosAgente.Controls.Add(this.txtCodAgente);
            this.pnlDadosAgente.Location = new System.Drawing.Point(431, 145);
            this.pnlDadosAgente.Name = "pnlDadosAgente";
            this.pnlDadosAgente.Size = new System.Drawing.Size(362, 284);
            this.pnlDadosAgente.TabIndex = 25;
            // 
            // txtCNPJAgente
            // 
            this.txtCNPJAgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJAgente.Location = new System.Drawing.Point(224, 102);
            this.txtCNPJAgente.Mask = "00,000,000/0000-00";
            this.txtCNPJAgente.Name = "txtCNPJAgente";
            this.txtCNPJAgente.Size = new System.Drawing.Size(121, 22);
            this.txtCNPJAgente.TabIndex = 98;
            // 
            // txtCPFAgente
            // 
            this.txtCPFAgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPFAgente.Location = new System.Drawing.Point(224, 72);
            this.txtCPFAgente.Mask = "000,000,000-00";
            this.txtCPFAgente.Name = "txtCPFAgente";
            this.txtCPFAgente.Size = new System.Drawing.Size(121, 22);
            this.txtCPFAgente.TabIndex = 4;
            // 
            // lblNomeObrigatorio
            // 
            this.lblNomeObrigatorio.AutoSize = true;
            this.lblNomeObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeObrigatorio.Location = new System.Drawing.Point(322, 34);
            this.lblNomeObrigatorio.Name = "lblNomeObrigatorio";
            this.lblNomeObrigatorio.Size = new System.Drawing.Size(15, 20);
            this.lblNomeObrigatorio.TabIndex = 9;
            this.lblNomeObrigatorio.Text = "*";
            // 
            // lblEmailObrigatorio
            // 
            this.lblEmailObrigatorio.AutoSize = true;
            this.lblEmailObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailObrigatorio.Location = new System.Drawing.Point(311, 222);
            this.lblEmailObrigatorio.Name = "lblEmailObrigatorio";
            this.lblEmailObrigatorio.Size = new System.Drawing.Size(15, 20);
            this.lblEmailObrigatorio.TabIndex = 9;
            this.lblEmailObrigatorio.Text = "*";
            // 
            // lblCNPJObrigatorio
            // 
            this.lblCNPJObrigatorio.AutoSize = true;
            this.lblCNPJObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJObrigatorio.Location = new System.Drawing.Point(344, 103);
            this.lblCNPJObrigatorio.Name = "lblCNPJObrigatorio";
            this.lblCNPJObrigatorio.Size = new System.Drawing.Size(15, 20);
            this.lblCNPJObrigatorio.TabIndex = 9;
            this.lblCNPJObrigatorio.Text = "*";
            // 
            // lblCPFObrigatorio
            // 
            this.lblCPFObrigatorio.AutoSize = true;
            this.lblCPFObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFObrigatorio.Location = new System.Drawing.Point(344, 73);
            this.lblCPFObrigatorio.Name = "lblCPFObrigatorio";
            this.lblCPFObrigatorio.Size = new System.Drawing.Size(15, 20);
            this.lblCPFObrigatorio.TabIndex = 9;
            this.lblCPFObrigatorio.Text = "*";
            // 
            // lblTelefoneObrigatorio
            // 
            this.lblTelefoneObrigatorio.AutoSize = true;
            this.lblTelefoneObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneObrigatorio.Location = new System.Drawing.Point(209, 144);
            this.lblTelefoneObrigatorio.Name = "lblTelefoneObrigatorio";
            this.lblTelefoneObrigatorio.Size = new System.Drawing.Size(15, 20);
            this.lblTelefoneObrigatorio.TabIndex = 9;
            this.lblTelefoneObrigatorio.Text = "*";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(174, 106);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(52, 18);
            this.lblCNPJ.TabIndex = 8;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(177, 77);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(42, 18);
            this.lblCPF.TabIndex = 8;
            this.lblCPF.Text = "CPF:";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(289, 1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(70, 28);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "E-mail 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "E-mail 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone 1:";
            // 
            // txtEmail2Agente
            // 
            this.txtEmail2Agente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail2Agente.Location = new System.Drawing.Point(103, 254);
            this.txtEmail2Agente.Name = "txtEmail2Agente";
            this.txtEmail2Agente.Size = new System.Drawing.Size(208, 26);
            this.txtEmail2Agente.TabIndex = 8;
            // 
            // txtEmail1Agente
            // 
            this.txtEmail1Agente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail1Agente.Location = new System.Drawing.Point(103, 222);
            this.txtEmail1Agente.Name = "txtEmail1Agente";
            this.txtEmail1Agente.Size = new System.Drawing.Size(208, 26);
            this.txtEmail1Agente.TabIndex = 7;
            // 
            // lblCodAgente
            // 
            this.lblCodAgente.AutoSize = true;
            this.lblCodAgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodAgente.Location = new System.Drawing.Point(1, 4);
            this.lblCodAgente.Name = "lblCodAgente";
            this.lblCodAgente.Size = new System.Drawing.Size(102, 20);
            this.lblCodAgente.TabIndex = 4;
            this.lblCodAgente.Text = "Cód. Agente:";
            // 
            // txtTelefone2Agente
            // 
            this.txtTelefone2Agente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone2Agente.Location = new System.Drawing.Point(103, 185);
            this.txtTelefone2Agente.Name = "txtTelefone2Agente";
            this.txtTelefone2Agente.Size = new System.Drawing.Size(106, 26);
            this.txtTelefone2Agente.TabIndex = 6;
            // 
            // txtNomeAgente
            // 
            this.txtNomeAgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAgente.Location = new System.Drawing.Point(104, 37);
            this.txtNomeAgente.Name = "txtNomeAgente";
            this.txtNomeAgente.Size = new System.Drawing.Size(218, 26);
            this.txtNomeAgente.TabIndex = 1;
            // 
            // txtTelefone1Agente
            // 
            this.txtTelefone1Agente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone1Agente.Location = new System.Drawing.Point(103, 143);
            this.txtTelefone1Agente.Name = "txtTelefone1Agente";
            this.txtTelefone1Agente.Size = new System.Drawing.Size(106, 26);
            this.txtTelefone1Agente.TabIndex = 5;
            // 
            // grbTipoPessoa
            // 
            this.grbTipoPessoa.Controls.Add(this.rbPessoaJuridica);
            this.grbTipoPessoa.Controls.Add(this.rbPessoaFisica);
            this.grbTipoPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTipoPessoa.Location = new System.Drawing.Point(7, 75);
            this.grbTipoPessoa.Name = "grbTipoPessoa";
            this.grbTipoPessoa.Size = new System.Drawing.Size(164, 55);
            this.grbTipoPessoa.TabIndex = 97;
            this.grbTipoPessoa.TabStop = false;
            this.grbTipoPessoa.Text = "Tipo de pessoa:";
            // 
            // rbPessoaJuridica
            // 
            this.rbPessoaJuridica.AutoSize = true;
            this.rbPessoaJuridica.Location = new System.Drawing.Point(80, 25);
            this.rbPessoaJuridica.Name = "rbPessoaJuridica";
            this.rbPessoaJuridica.Size = new System.Drawing.Size(81, 24);
            this.rbPessoaJuridica.TabIndex = 3;
            this.rbPessoaJuridica.TabStop = true;
            this.rbPessoaJuridica.Text = "Jurídica";
            this.rbPessoaJuridica.UseVisualStyleBackColor = true;
            this.rbPessoaJuridica.CheckedChanged += new System.EventHandler(this.rbPessoaJuridica_CheckedChanged);
            // 
            // rbPessoaFisica
            // 
            this.rbPessoaFisica.AutoSize = true;
            this.rbPessoaFisica.Location = new System.Drawing.Point(13, 25);
            this.rbPessoaFisica.Name = "rbPessoaFisica";
            this.rbPessoaFisica.Size = new System.Drawing.Size(68, 24);
            this.rbPessoaFisica.TabIndex = 2;
            this.rbPessoaFisica.TabStop = true;
            this.rbPessoaFisica.Text = "Física";
            this.rbPessoaFisica.UseVisualStyleBackColor = true;
            this.rbPessoaFisica.CheckedChanged += new System.EventHandler(this.rbPessoaFisica_CheckedChanged);
            // 
            // txtCodAgente
            // 
            this.txtCodAgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodAgente.Location = new System.Drawing.Point(103, 3);
            this.txtCodAgente.Name = "txtCodAgente";
            this.txtCodAgente.Size = new System.Drawing.Size(100, 26);
            this.txtCodAgente.TabIndex = 99;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(718, 437);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 30);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(637, 437);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 30);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grdDadosPessoa
            // 
            this.grdDadosPessoa.AllowUserToAddRows = false;
            this.grdDadosPessoa.AllowUserToDeleteRows = false;
            this.grdDadosPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDadosPessoa.Location = new System.Drawing.Point(13, 145);
            this.grdDadosPessoa.Name = "grdDadosPessoa";
            this.grdDadosPessoa.ReadOnly = true;
            this.grdDadosPessoa.Size = new System.Drawing.Size(415, 284);
            this.grdDadosPessoa.TabIndex = 28;
            this.grdDadosPessoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDadosPessoa_CellClick);
            // 
            // btnNovoAgente
            // 
            this.btnNovoAgente.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNovoAgente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNovoAgente.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoAgente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovoAgente.Location = new System.Drawing.Point(667, 105);
            this.btnNovoAgente.Name = "btnNovoAgente";
            this.btnNovoAgente.Size = new System.Drawing.Size(128, 36);
            this.btnNovoAgente.TabIndex = 24;
            this.btnNovoAgente.Text = "Novo Agente +";
            this.btnNovoAgente.UseVisualStyleBackColor = false;
            this.btnNovoAgente.Click += new System.EventHandler(this.btnNovoAgente_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtBuscar.Location = new System.Drawing.Point(109, 114);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(216, 26);
            this.txtBuscar.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "MANUTENÇÃO DE AGENTES";
            // 
            // btnBuscarAgente
            // 
            this.btnBuscarAgente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarAgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAgente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarAgente.Image")));
            this.btnBuscarAgente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarAgente.Location = new System.Drawing.Point(331, 113);
            this.btnBuscarAgente.Name = "btnBuscarAgente";
            this.btnBuscarAgente.Size = new System.Drawing.Size(97, 28);
            this.btnBuscarAgente.TabIndex = 23;
            this.btnBuscarAgente.Text = "Buscar";
            this.btnBuscarAgente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarAgente.UseVisualStyleBackColor = false;
            this.btnBuscarAgente.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmAgente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 476);
            this.Controls.Add(this.lblBuscarPor);
            this.Controls.Add(this.cbAgenteBuscarPor);
            this.Controls.Add(this.pnlDadosAgente);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grdDadosPessoa);
            this.Controls.Add(this.btnNovoAgente);
            this.Controls.Add(this.btnBuscarAgente);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAgente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAgente_Load);
            this.pnlDadosAgente.ResumeLayout(false);
            this.pnlDadosAgente.PerformLayout();
            this.grbTipoPessoa.ResumeLayout(false);
            this.grbTipoPessoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.ComboBox cbAgenteBuscarPor;
        private System.Windows.Forms.Panel pnlDadosAgente;
        private System.Windows.Forms.Label lblNomeObrigatorio;
        private System.Windows.Forms.Label lblEmailObrigatorio;
        private System.Windows.Forms.Label lblCNPJObrigatorio;
        private System.Windows.Forms.Label lblCPFObrigatorio;
        private System.Windows.Forms.Label lblTelefoneObrigatorio;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail2Agente;
        private System.Windows.Forms.TextBox txtEmail1Agente;
        private System.Windows.Forms.Label lblCodAgente;
        private System.Windows.Forms.TextBox txtTelefone2Agente;
        private System.Windows.Forms.TextBox txtNomeAgente;
        private System.Windows.Forms.TextBox txtTelefone1Agente;
        private System.Windows.Forms.GroupBox grbTipoPessoa;
        private System.Windows.Forms.RadioButton rbPessoaJuridica;
        private System.Windows.Forms.RadioButton rbPessoaFisica;
        private System.Windows.Forms.TextBox txtCodAgente;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView grdDadosPessoa;
        private System.Windows.Forms.Button btnNovoAgente;
        private System.Windows.Forms.Button btnBuscarAgente;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCPFAgente;
        private System.Windows.Forms.MaskedTextBox txtCNPJAgente;
    }
}