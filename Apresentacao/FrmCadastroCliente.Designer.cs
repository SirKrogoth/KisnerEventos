namespace Apresentacao
{
    partial class FrmCadastroCliente
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
            this.groupBoxDadosCliente = new System.Windows.Forms.GroupBox();
            this.mTxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.mTxtResidencial = new System.Windows.Forms.MaskedTextBox();
            this.mTxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxOperadora = new System.Windows.Forms.ComboBox();
            this.labelOperadora = new System.Windows.Forms.Label();
            this.labelCelular = new System.Windows.Forms.Label();
            this.checkBoxInformaCelular = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEndereco = new System.Windows.Forms.GroupBox();
            this.mTxtCep = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxEstados = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxInformacoesComplementares = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxSituacao = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePickerDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBoxDadosCliente.SuspendLayout();
            this.groupBoxEndereco.SuspendLayout();
            this.groupBoxInformacoesComplementares.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDadosCliente
            // 
            this.groupBoxDadosCliente.Controls.Add(this.mTxtCelular);
            this.groupBoxDadosCliente.Controls.Add(this.mTxtResidencial);
            this.groupBoxDadosCliente.Controls.Add(this.mTxtCpf);
            this.groupBoxDadosCliente.Controls.Add(this.comboBoxOperadora);
            this.groupBoxDadosCliente.Controls.Add(this.labelOperadora);
            this.groupBoxDadosCliente.Controls.Add(this.labelCelular);
            this.groupBoxDadosCliente.Controls.Add(this.checkBoxInformaCelular);
            this.groupBoxDadosCliente.Controls.Add(this.label15);
            this.groupBoxDadosCliente.Controls.Add(this.dateTimePickerNascimento);
            this.groupBoxDadosCliente.Controls.Add(this.label12);
            this.groupBoxDadosCliente.Controls.Add(this.label5);
            this.groupBoxDadosCliente.Controls.Add(this.txtRg);
            this.groupBoxDadosCliente.Controls.Add(this.label4);
            this.groupBoxDadosCliente.Controls.Add(this.radioButtonFeminino);
            this.groupBoxDadosCliente.Controls.Add(this.radioButtonMasculino);
            this.groupBoxDadosCliente.Controls.Add(this.label3);
            this.groupBoxDadosCliente.Controls.Add(this.txtNome);
            this.groupBoxDadosCliente.Controls.Add(this.label2);
            this.groupBoxDadosCliente.Controls.Add(this.txtCodigo);
            this.groupBoxDadosCliente.Controls.Add(this.label1);
            this.groupBoxDadosCliente.Location = new System.Drawing.Point(12, 3);
            this.groupBoxDadosCliente.Name = "groupBoxDadosCliente";
            this.groupBoxDadosCliente.Size = new System.Drawing.Size(443, 204);
            this.groupBoxDadosCliente.TabIndex = 0;
            this.groupBoxDadosCliente.TabStop = false;
            this.groupBoxDadosCliente.Text = "Informações do cliente";
            // 
            // mTxtCelular
            // 
            this.mTxtCelular.Location = new System.Drawing.Point(114, 170);
            this.mTxtCelular.Mask = "(99) 0000-0000";
            this.mTxtCelular.Name = "mTxtCelular";
            this.mTxtCelular.Size = new System.Drawing.Size(100, 20);
            this.mTxtCelular.TabIndex = 9;
            this.mTxtCelular.Visible = false;
            this.mTxtCelular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mTxtCelular_KeyDown);
            // 
            // mTxtResidencial
            // 
            this.mTxtResidencial.Location = new System.Drawing.Point(114, 140);
            this.mTxtResidencial.Mask = "(99) 0000-0000";
            this.mTxtResidencial.Name = "mTxtResidencial";
            this.mTxtResidencial.Size = new System.Drawing.Size(100, 20);
            this.mTxtResidencial.TabIndex = 7;
            this.mTxtResidencial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mTxtResidencial_KeyDown);
            // 
            // mTxtCpf
            // 
            this.mTxtCpf.Location = new System.Drawing.Point(201, 106);
            this.mTxtCpf.Mask = "999.999.999-99";
            this.mTxtCpf.Name = "mTxtCpf";
            this.mTxtCpf.Size = new System.Drawing.Size(100, 20);
            this.mTxtCpf.TabIndex = 6;
            this.mTxtCpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mTxtCpf_KeyDown);
            // 
            // comboBoxOperadora
            // 
            this.comboBoxOperadora.FormattingEnabled = true;
            this.comboBoxOperadora.Items.AddRange(new object[] {
            "Claro",
            "Vivo",
            "Tim",
            "Oi",
            "Algar",
            "Nextel",
            "Sercomtel",
            "Outra"});
            this.comboBoxOperadora.Location = new System.Drawing.Point(303, 169);
            this.comboBoxOperadora.Name = "comboBoxOperadora";
            this.comboBoxOperadora.Size = new System.Drawing.Size(117, 21);
            this.comboBoxOperadora.TabIndex = 10;
            this.comboBoxOperadora.Text = "Selecione";
            this.comboBoxOperadora.Visible = false;
            this.comboBoxOperadora.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxOperadora_KeyDown);
            // 
            // labelOperadora
            // 
            this.labelOperadora.AutoSize = true;
            this.labelOperadora.Location = new System.Drawing.Point(240, 173);
            this.labelOperadora.Name = "labelOperadora";
            this.labelOperadora.Size = new System.Drawing.Size(60, 13);
            this.labelOperadora.TabIndex = 17;
            this.labelOperadora.Text = "Operadora:";
            this.labelOperadora.Visible = false;
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.Location = new System.Drawing.Point(16, 173);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(68, 13);
            this.labelCelular.TabIndex = 15;
            this.labelCelular.Text = "Fone celular:";
            this.labelCelular.Visible = false;
            // 
            // checkBoxInformaCelular
            // 
            this.checkBoxInformaCelular.AutoSize = true;
            this.checkBoxInformaCelular.Location = new System.Drawing.Point(245, 142);
            this.checkBoxInformaCelular.Name = "checkBoxInformaCelular";
            this.checkBoxInformaCelular.Size = new System.Drawing.Size(139, 17);
            this.checkBoxInformaCelular.TabIndex = 8;
            this.checkBoxInformaCelular.Text = "Informar telefone celular";
            this.checkBoxInformaCelular.UseVisualStyleBackColor = true;
            this.checkBoxInformaCelular.CheckedChanged += new System.EventHandler(this.checkBoxInformaCelular_CheckedChanged);
            this.checkBoxInformaCelular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBoxInformaCelular_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Fone Residencial:";
            // 
            // dateTimePickerNascimento
            // 
            this.dateTimePickerNascimento.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNascimento.Location = new System.Drawing.Point(85, 75);
            this.dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            this.dateTimePickerNascimento.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerNascimento.TabIndex = 2;
            this.dateTimePickerNascimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerNascimento_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CPF:";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(49, 106);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(96, 20);
            this.txtRg.TabIndex = 5;
            this.txtRg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRg_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "RG:";
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Location = new System.Drawing.Point(342, 77);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFeminino.TabIndex = 4;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            this.radioButtonFeminino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.radioButtonFeminino_KeyDown);
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Checked = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(263, 77);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 3;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            this.radioButtonMasculino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.radioButtonMasculino_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sexo:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(358, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(62, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(83, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // groupBoxEndereco
            // 
            this.groupBoxEndereco.Controls.Add(this.mTxtCep);
            this.groupBoxEndereco.Controls.Add(this.label11);
            this.groupBoxEndereco.Controls.Add(this.comboBoxEstados);
            this.groupBoxEndereco.Controls.Add(this.label10);
            this.groupBoxEndereco.Controls.Add(this.txtCidade);
            this.groupBoxEndereco.Controls.Add(this.label9);
            this.groupBoxEndereco.Controls.Add(this.txtBairro);
            this.groupBoxEndereco.Controls.Add(this.label8);
            this.groupBoxEndereco.Controls.Add(this.txtNumero);
            this.groupBoxEndereco.Controls.Add(this.label7);
            this.groupBoxEndereco.Controls.Add(this.txtRua);
            this.groupBoxEndereco.Controls.Add(this.label6);
            this.groupBoxEndereco.Location = new System.Drawing.Point(461, 3);
            this.groupBoxEndereco.Name = "groupBoxEndereco";
            this.groupBoxEndereco.Size = new System.Drawing.Size(443, 131);
            this.groupBoxEndereco.TabIndex = 1;
            this.groupBoxEndereco.TabStop = false;
            this.groupBoxEndereco.Text = "Endereço";
            // 
            // mTxtCep
            // 
            this.mTxtCep.Location = new System.Drawing.Point(62, 100);
            this.mTxtCep.Mask = "99999-999";
            this.mTxtCep.Name = "mTxtCep";
            this.mTxtCep.Size = new System.Drawing.Size(100, 20);
            this.mTxtCep.TabIndex = 5;
            this.mTxtCep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mTxtCep_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "CEP:";
            // 
            // comboBoxEstados
            // 
            this.comboBoxEstados.FormattingEnabled = true;
            this.comboBoxEstados.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBoxEstados.Location = new System.Drawing.Point(62, 72);
            this.comboBoxEstados.Name = "comboBoxEstados";
            this.comboBoxEstados.Size = new System.Drawing.Size(83, 21);
            this.comboBoxEstados.TabIndex = 4;
            this.comboBoxEstados.Text = "RS";
            this.comboBoxEstados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxEstados_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Estado:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(272, 48);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(148, 20);
            this.txtCidade.TabIndex = 3;
            this.txtCidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCidade_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(62, 48);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(146, 20);
            this.txtBairro.TabIndex = 2;
            this.txtBairro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBairro_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Bairro:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(357, 24);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(63, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Número:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(62, 24);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(230, 20);
            this.txtRua.TabIndex = 0;
            this.txtRua.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRua_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Rua:";
            // 
            // groupBoxInformacoesComplementares
            // 
            this.groupBoxInformacoesComplementares.Controls.Add(this.txtEmail);
            this.groupBoxInformacoesComplementares.Controls.Add(this.label17);
            this.groupBoxInformacoesComplementares.Controls.Add(this.comboBoxSituacao);
            this.groupBoxInformacoesComplementares.Controls.Add(this.label16);
            this.groupBoxInformacoesComplementares.Controls.Add(this.dateTimePickerDataCadastro);
            this.groupBoxInformacoesComplementares.Controls.Add(this.label14);
            this.groupBoxInformacoesComplementares.Controls.Add(this.txtObservacoes);
            this.groupBoxInformacoesComplementares.Controls.Add(this.label13);
            this.groupBoxInformacoesComplementares.Location = new System.Drawing.Point(12, 213);
            this.groupBoxInformacoesComplementares.Name = "groupBoxInformacoesComplementares";
            this.groupBoxInformacoesComplementares.Size = new System.Drawing.Size(443, 150);
            this.groupBoxInformacoesComplementares.TabIndex = 2;
            this.groupBoxInformacoesComplementares.TabStop = false;
            this.groupBoxInformacoesComplementares.Text = "Informações complementares";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(53, 25);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(367, 20);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Email:";
            // 
            // comboBoxSituacao
            // 
            this.comboBoxSituacao.FormattingEnabled = true;
            this.comboBoxSituacao.Items.AddRange(new object[] {
            "Inativo"});
            this.comboBoxSituacao.Location = new System.Drawing.Point(209, 123);
            this.comboBoxSituacao.Name = "comboBoxSituacao";
            this.comboBoxSituacao.Size = new System.Drawing.Size(104, 21);
            this.comboBoxSituacao.TabIndex = 3;
            this.comboBoxSituacao.Text = "Ativo";
            this.comboBoxSituacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxSituacao_KeyDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(207, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Ativo:";
            // 
            // dateTimePickerDataCadastro
            // 
            this.dateTimePickerDataCadastro.Enabled = false;
            this.dateTimePickerDataCadastro.Location = new System.Drawing.Point(210, 73);
            this.dateTimePickerDataCadastro.Name = "dateTimePickerDataCadastro";
            this.dateTimePickerDataCadastro.Size = new System.Drawing.Size(226, 20);
            this.dateTimePickerDataCadastro.TabIndex = 2;
            this.dateTimePickerDataCadastro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerDataCadastro_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(207, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Data criação:";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(13, 76);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacoes.Size = new System.Drawing.Size(164, 62);
            this.txtObservacoes.TabIndex = 1;
            this.txtObservacoes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtObservacoes_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Observações:";
            // 
            // btnGravar
            // 
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.Location = new System.Drawing.Point(480, 329);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 32);
            this.btnGravar.TabIndex = 3;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            this.btnGravar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGravar_KeyDown);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Location = new System.Drawing.Point(561, 329);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 32);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            this.btnNovo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnNovo_KeyDown);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(642, 329);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 32);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLimpar_KeyDown);
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 380);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.groupBoxInformacoesComplementares);
            this.Controls.Add(this.groupBoxEndereco);
            this.Controls.Add(this.groupBoxDadosCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kisner Eventos - Cadastro de Clientes";
            this.groupBoxDadosCliente.ResumeLayout(false);
            this.groupBoxDadosCliente.PerformLayout();
            this.groupBoxEndereco.ResumeLayout(false);
            this.groupBoxEndereco.PerformLayout();
            this.groupBoxInformacoesComplementares.ResumeLayout(false);
            this.groupBoxInformacoesComplementares.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDadosCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxEndereco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxEstados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerNascimento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBoxInformacoesComplementares;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataCadastro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxOperadora;
        private System.Windows.Forms.Label labelOperadora;
        private System.Windows.Forms.Label labelCelular;
        private System.Windows.Forms.CheckBox checkBoxInformaCelular;
        private System.Windows.Forms.MaskedTextBox mTxtCelular;
        private System.Windows.Forms.MaskedTextBox mTxtResidencial;
        private System.Windows.Forms.MaskedTextBox mTxtCpf;
        private System.Windows.Forms.ComboBox comboBoxSituacao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox mTxtCep;
    }
}