namespace Apresentacao
{
    partial class FrmCadastroEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroEvento));
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataEvento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxInicio = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxTermino = new System.Windows.Forms.MaskedTextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePrincipal = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCidadeEvento = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAniversariante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageDadosEvento = new System.Windows.Forms.TabPage();
            this.checkedListBoxDecoracao = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkedListBoxBrinquedos = new System.Windows.Forms.CheckedListBox();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageServicos = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.checkedListBoxServicos = new System.Windows.Forms.CheckedListBox();
            this.tabPageDadosComplementares = new System.Windows.Forms.TabPage();
            this.txtComplementar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPageExtrato = new System.Windows.Forms.TabPage();
            this.txtExtrato = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPageValores = new System.Windows.Forms.TabPage();
            this.btnAcrescimo = new System.Windows.Forms.Button();
            this.txtAcrescimo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAplicarDesconto = new System.Windows.Forms.Button();
            this.txtValorEvento = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelarEvento = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtTotalEvento = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPagePrincipal.SuspendLayout();
            this.tabPageDadosEvento.SuspendLayout();
            this.tabPageServicos.SuspendLayout();
            this.tabPageDadosComplementares.SuspendLayout();
            this.tabPageExtrato.SuspendLayout();
            this.tabPageValores.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(48, 39);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(338, 20);
            this.txtCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(16, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(26, 29);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Local evento:";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(18, 141);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(196, 20);
            this.txtLocal.TabIndex = 2;
            // 
            // dateTimePickerDataEvento
            // 
            this.dateTimePickerDataEvento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataEvento.Location = new System.Drawing.Point(19, 194);
            this.dateTimePickerDataEvento.Name = "dateTimePickerDataEvento";
            this.dateTimePickerDataEvento.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDataEvento.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data evento:";
            // 
            // maskedTextBoxInicio
            // 
            this.maskedTextBoxInicio.Location = new System.Drawing.Point(177, 194);
            this.maskedTextBoxInicio.Mask = "00:00";
            this.maskedTextBoxInicio.Name = "maskedTextBoxInicio";
            this.maskedTextBoxInicio.Size = new System.Drawing.Size(37, 20);
            this.maskedTextBoxInicio.TabIndex = 5;
            this.maskedTextBoxInicio.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Termino:";
            // 
            // maskedTextBoxTermino
            // 
            this.maskedTextBoxTermino.Location = new System.Drawing.Point(286, 194);
            this.maskedTextBoxTermino.Mask = "00:00";
            this.maskedTextBoxTermino.Name = "maskedTextBoxTermino";
            this.maskedTextBoxTermino.Size = new System.Drawing.Size(42, 20);
            this.maskedTextBoxTermino.TabIndex = 6;
            this.maskedTextBoxTermino.ValidatingType = typeof(System.DateTime);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagePrincipal);
            this.tabControl.Controls.Add(this.tabPageDadosEvento);
            this.tabControl.Controls.Add(this.tabPageServicos);
            this.tabControl.Controls.Add(this.tabPageDadosComplementares);
            this.tabControl.Controls.Add(this.tabPageExtrato);
            this.tabControl.Controls.Add(this.tabPageValores);
            this.tabControl.Location = new System.Drawing.Point(12, 48);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(434, 268);
            this.tabControl.TabIndex = 11;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabPagePrincipal
            // 
            this.tabPagePrincipal.Controls.Add(this.label18);
            this.tabPagePrincipal.Controls.Add(this.txtCidadeEvento);
            this.tabPagePrincipal.Controls.Add(this.txtCodigo);
            this.tabPagePrincipal.Controls.Add(this.label15);
            this.tabPagePrincipal.Controls.Add(this.txtAniversariante);
            this.tabPagePrincipal.Controls.Add(this.label6);
            this.tabPagePrincipal.Controls.Add(this.btnBuscar);
            this.tabPagePrincipal.Controls.Add(this.maskedTextBoxTermino);
            this.tabPagePrincipal.Controls.Add(this.txtCliente);
            this.tabPagePrincipal.Controls.Add(this.label5);
            this.tabPagePrincipal.Controls.Add(this.label1);
            this.tabPagePrincipal.Controls.Add(this.label4);
            this.tabPagePrincipal.Controls.Add(this.label2);
            this.tabPagePrincipal.Controls.Add(this.maskedTextBoxInicio);
            this.tabPagePrincipal.Controls.Add(this.txtLocal);
            this.tabPagePrincipal.Controls.Add(this.label3);
            this.tabPagePrincipal.Controls.Add(this.dateTimePickerDataEvento);
            this.tabPagePrincipal.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrincipal.Name = "tabPagePrincipal";
            this.tabPagePrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrincipal.Size = new System.Drawing.Size(426, 242);
            this.tabPagePrincipal.TabIndex = 0;
            this.tabPagePrincipal.Text = "Principal";
            this.tabPagePrincipal.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(239, 125);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Cidade Evento:";
            // 
            // txtCidadeEvento
            // 
            this.txtCidadeEvento.Location = new System.Drawing.Point(240, 141);
            this.txtCidadeEvento.Name = "txtCidadeEvento";
            this.txtCidadeEvento.Size = new System.Drawing.Size(146, 20);
            this.txtCidadeEvento.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(286, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 14;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(237, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Código:";
            // 
            // txtAniversariante
            // 
            this.txtAniversariante.Location = new System.Drawing.Point(18, 93);
            this.txtAniversariante.Name = "txtAniversariante";
            this.txtAniversariante.Size = new System.Drawing.Size(368, 20);
            this.txtAniversariante.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nome do aniversariante: ";
            // 
            // tabPageDadosEvento
            // 
            this.tabPageDadosEvento.Controls.Add(this.checkedListBoxDecoracao);
            this.tabPageDadosEvento.Controls.Add(this.label9);
            this.tabPageDadosEvento.Controls.Add(this.label8);
            this.tabPageDadosEvento.Controls.Add(this.checkedListBoxBrinquedos);
            this.tabPageDadosEvento.Controls.Add(this.txtTema);
            this.tabPageDadosEvento.Controls.Add(this.label7);
            this.tabPageDadosEvento.Location = new System.Drawing.Point(4, 22);
            this.tabPageDadosEvento.Name = "tabPageDadosEvento";
            this.tabPageDadosEvento.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDadosEvento.Size = new System.Drawing.Size(426, 242);
            this.tabPageDadosEvento.TabIndex = 1;
            this.tabPageDadosEvento.Text = "Dados do evento";
            this.tabPageDadosEvento.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxDecoracao
            // 
            this.checkedListBoxDecoracao.FormattingEnabled = true;
            this.checkedListBoxDecoracao.Location = new System.Drawing.Point(223, 81);
            this.checkedListBoxDecoracao.Name = "checkedListBoxDecoracao";
            this.checkedListBoxDecoracao.Size = new System.Drawing.Size(165, 94);
            this.checkedListBoxDecoracao.TabIndex = 5;
            this.checkedListBoxDecoracao.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxDecoracao_ItemCheck);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Decoração:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Brinquedos:";
            // 
            // checkedListBoxBrinquedos
            // 
            this.checkedListBoxBrinquedos.FormattingEnabled = true;
            this.checkedListBoxBrinquedos.Location = new System.Drawing.Point(21, 81);
            this.checkedListBoxBrinquedos.Name = "checkedListBoxBrinquedos";
            this.checkedListBoxBrinquedos.Size = new System.Drawing.Size(182, 94);
            this.checkedListBoxBrinquedos.TabIndex = 2;
            this.checkedListBoxBrinquedos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxBrinquedos_ItemCheck);
            // 
            // txtTema
            // 
            this.txtTema.Location = new System.Drawing.Point(32, 28);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(356, 20);
            this.txtTema.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tema do evento:";
            // 
            // tabPageServicos
            // 
            this.tabPageServicos.Controls.Add(this.label17);
            this.tabPageServicos.Controls.Add(this.checkedListBoxServicos);
            this.tabPageServicos.Location = new System.Drawing.Point(4, 22);
            this.tabPageServicos.Name = "tabPageServicos";
            this.tabPageServicos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServicos.Size = new System.Drawing.Size(426, 242);
            this.tabPageServicos.TabIndex = 4;
            this.tabPageServicos.Text = "Serviços";
            this.tabPageServicos.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Serviços:";
            // 
            // checkedListBoxServicos
            // 
            this.checkedListBoxServicos.FormattingEnabled = true;
            this.checkedListBoxServicos.Location = new System.Drawing.Point(20, 39);
            this.checkedListBoxServicos.Name = "checkedListBoxServicos";
            this.checkedListBoxServicos.Size = new System.Drawing.Size(167, 94);
            this.checkedListBoxServicos.TabIndex = 0;
            this.checkedListBoxServicos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // tabPageDadosComplementares
            // 
            this.tabPageDadosComplementares.Controls.Add(this.txtComplementar);
            this.tabPageDadosComplementares.Controls.Add(this.label10);
            this.tabPageDadosComplementares.Location = new System.Drawing.Point(4, 22);
            this.tabPageDadosComplementares.Name = "tabPageDadosComplementares";
            this.tabPageDadosComplementares.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDadosComplementares.Size = new System.Drawing.Size(426, 242);
            this.tabPageDadosComplementares.TabIndex = 2;
            this.tabPageDadosComplementares.Text = "Dados complementares";
            this.tabPageDadosComplementares.UseVisualStyleBackColor = true;
            // 
            // txtComplementar
            // 
            this.txtComplementar.Location = new System.Drawing.Point(20, 36);
            this.txtComplementar.Multiline = true;
            this.txtComplementar.Name = "txtComplementar";
            this.txtComplementar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComplementar.Size = new System.Drawing.Size(385, 184);
            this.txtComplementar.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Informações complementar";
            // 
            // tabPageExtrato
            // 
            this.tabPageExtrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPageExtrato.Controls.Add(this.txtExtrato);
            this.tabPageExtrato.Controls.Add(this.label19);
            this.tabPageExtrato.Location = new System.Drawing.Point(4, 22);
            this.tabPageExtrato.Name = "tabPageExtrato";
            this.tabPageExtrato.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExtrato.Size = new System.Drawing.Size(426, 242);
            this.tabPageExtrato.TabIndex = 5;
            this.tabPageExtrato.Text = "Extrato";
            // 
            // txtExtrato
            // 
            this.txtExtrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtExtrato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExtrato.Location = new System.Drawing.Point(37, 42);
            this.txtExtrato.Multiline = true;
            this.txtExtrato.Name = "txtExtrato";
            this.txtExtrato.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExtrato.Size = new System.Drawing.Size(383, 188);
            this.txtExtrato.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(129, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(171, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "Não é documento fiscal";
            // 
            // tabPageValores
            // 
            this.tabPageValores.Controls.Add(this.btnAcrescimo);
            this.tabPageValores.Controls.Add(this.txtAcrescimo);
            this.tabPageValores.Controls.Add(this.label16);
            this.tabPageValores.Controls.Add(this.btnAplicarDesconto);
            this.tabPageValores.Controls.Add(this.txtValorEvento);
            this.tabPageValores.Controls.Add(this.txtDesconto);
            this.tabPageValores.Controls.Add(this.txtTotalEvento);
            this.tabPageValores.Controls.Add(this.label14);
            this.tabPageValores.Controls.Add(this.label13);
            this.tabPageValores.Controls.Add(this.label12);
            this.tabPageValores.Location = new System.Drawing.Point(4, 22);
            this.tabPageValores.Name = "tabPageValores";
            this.tabPageValores.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageValores.Size = new System.Drawing.Size(426, 242);
            this.tabPageValores.TabIndex = 3;
            this.tabPageValores.Text = "Valores";
            this.tabPageValores.UseVisualStyleBackColor = true;
            // 
            // btnAcrescimo
            // 
            this.btnAcrescimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcrescimo.Location = new System.Drawing.Point(166, 167);
            this.btnAcrescimo.Name = "btnAcrescimo";
            this.btnAcrescimo.Size = new System.Drawing.Size(75, 40);
            this.btnAcrescimo.TabIndex = 12;
            this.btnAcrescimo.Text = "Aplicar acréscimo";
            this.btnAcrescimo.UseVisualStyleBackColor = true;
            this.btnAcrescimo.Click += new System.EventHandler(this.btnAcrescimo_Click);
            // 
            // txtAcrescimo
            // 
            this.txtAcrescimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtAcrescimo.Location = new System.Drawing.Point(47, 176);
            this.txtAcrescimo.Name = "txtAcrescimo";
            this.txtAcrescimo.Size = new System.Drawing.Size(100, 22);
            this.txtAcrescimo.TabIndex = 11;
            this.txtAcrescimo.Text = "0,00";
            this.txtAcrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAcrescimo.Click += new System.EventHandler(this.txtAcrescimo_Click);
            this.txtAcrescimo.TextChanged += new System.EventHandler(this.txtAcrescimo_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "Acréscimo:";
            // 
            // btnAplicarDesconto
            // 
            this.btnAplicarDesconto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicarDesconto.Location = new System.Drawing.Point(166, 103);
            this.btnAplicarDesconto.Name = "btnAplicarDesconto";
            this.btnAplicarDesconto.Size = new System.Drawing.Size(75, 40);
            this.btnAplicarDesconto.TabIndex = 10;
            this.btnAplicarDesconto.Text = "Aplicar desconto";
            this.btnAplicarDesconto.UseVisualStyleBackColor = true;
            this.btnAplicarDesconto.Click += new System.EventHandler(this.btnAplicarDesconto_Click);
            // 
            // txtValorEvento
            // 
            this.txtValorEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEvento.Location = new System.Drawing.Point(47, 52);
            this.txtValorEvento.Name = "txtValorEvento";
            this.txtValorEvento.ReadOnly = true;
            this.txtValorEvento.Size = new System.Drawing.Size(100, 22);
            this.txtValorEvento.TabIndex = 8;
            this.txtValorEvento.Text = "0,00";
            this.txtValorEvento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(47, 112);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 22);
            this.txtDesconto.TabIndex = 9;
            this.txtDesconto.Text = "0,00";
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.Click += new System.EventHandler(this.txtDesconto_Click);
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(266, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Total do evento:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Desconto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Valor do evento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(68, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(473, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "Contrato de locação de brinquedos e decoração";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelarEvento);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.btnGravar);
            this.panel1.Location = new System.Drawing.Point(474, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 246);
            this.panel1.TabIndex = 9;
            // 
            // btnCancelarEvento
            // 
            this.btnCancelarEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarEvento.Enabled = false;
            this.btnCancelarEvento.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarEvento.Image")));
            this.btnCancelarEvento.Location = new System.Drawing.Point(21, 119);
            this.btnCancelarEvento.Name = "btnCancelarEvento";
            this.btnCancelarEvento.Size = new System.Drawing.Size(82, 51);
            this.btnCancelarEvento.TabIndex = 15;
            this.btnCancelarEvento.Text = "Cancelar";
            this.btnCancelarEvento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarEvento.UseVisualStyleBackColor = true;
            this.btnCancelarEvento.Click += new System.EventHandler(this.btnCancelarEvento_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(21, 62);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(82, 51);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(21, 8);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(82, 51);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGravar.Location = new System.Drawing.Point(21, 178);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(82, 52);
            this.btnGravar.TabIndex = 16;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtTotalEvento
            // 
            this.txtTotalEvento.AllowDrop = true;
            this.txtTotalEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalEvento.Location = new System.Drawing.Point(289, 173);
            this.txtTotalEvento.Name = "txtTotalEvento";
            this.txtTotalEvento.ReadOnly = true;
            this.txtTotalEvento.Size = new System.Drawing.Size(100, 26);
            this.txtTotalEvento.TabIndex = 6;
            this.txtTotalEvento.Text = "0,00";
            this.txtTotalEvento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmCadastroEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 343);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroEvento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kisner Eventos - Cadastro de Evento";
            this.tabControl.ResumeLayout(false);
            this.tabPagePrincipal.ResumeLayout(false);
            this.tabPagePrincipal.PerformLayout();
            this.tabPageDadosEvento.ResumeLayout(false);
            this.tabPageDadosEvento.PerformLayout();
            this.tabPageServicos.ResumeLayout(false);
            this.tabPageServicos.PerformLayout();
            this.tabPageDadosComplementares.ResumeLayout(false);
            this.tabPageDadosComplementares.PerformLayout();
            this.tabPageExtrato.ResumeLayout(false);
            this.tabPageExtrato.PerformLayout();
            this.tabPageValores.ResumeLayout(false);
            this.tabPageValores.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataEvento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTermino;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePrincipal;
        private System.Windows.Forms.TabPage tabPageDadosEvento;
        private System.Windows.Forms.TextBox txtAniversariante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox checkedListBoxDecoracao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPageDadosComplementares;
        private System.Windows.Forms.TextBox txtComplementar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPageValores;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtValorEvento;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelarEvento;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckedListBox checkedListBoxBrinquedos;
        private System.Windows.Forms.Button btnAplicarDesconto;
        private System.Windows.Forms.Button btnAcrescimo;
        private System.Windows.Forms.TextBox txtAcrescimo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPageServicos;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckedListBox checkedListBoxServicos;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCidadeEvento;
        private System.Windows.Forms.TabPage tabPageExtrato;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtExtrato;
        private System.Windows.Forms.TextBox txtTotalEvento;
    }
}