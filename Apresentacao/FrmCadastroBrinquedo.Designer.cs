namespace Apresentacao
{
    partial class FrmCadastroBrinquedo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeBrinquedo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerBrinquedo = new System.Windows.Forms.DateTimePicker();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQtdEstoque = new System.Windows.Forms.TextBox();
            this.cbControleEstoque = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Brinquedo";
            // 
            // txtNomeBrinquedo
            // 
            this.txtNomeBrinquedo.Location = new System.Drawing.Point(23, 64);
            this.txtNomeBrinquedo.Name = "txtNomeBrinquedo";
            this.txtNomeBrinquedo.Size = new System.Drawing.Size(362, 20);
            this.txtNomeBrinquedo.TabIndex = 1;
            this.txtNomeBrinquedo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeBrinquedo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Situação";
            // 
            // cbSituacao
            // 
            this.cbSituacao.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbSituacao.Location = new System.Drawing.Point(20, 142);
            this.cbSituacao.MaxDropDownItems = 3;
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(121, 21);
            this.cbSituacao.TabIndex = 4;
            this.cbSituacao.Text = "Ativo";
            this.cbSituacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSituacao_KeyDown);
            // 
            // btnGravar
            // 
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.Location = new System.Drawing.Point(87, 186);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 30);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            this.btnGravar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGravar_KeyDown);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(249, 186);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLimpar_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data de Criação";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePickerBrinquedo
            // 
            this.dateTimePickerBrinquedo.Enabled = false;
            this.dateTimePickerBrinquedo.Location = new System.Drawing.Point(172, 103);
            this.dateTimePickerBrinquedo.Name = "dateTimePickerBrinquedo";
            this.dateTimePickerBrinquedo.Size = new System.Drawing.Size(213, 20);
            this.dateTimePickerBrinquedo.TabIndex = 3;
            this.dateTimePickerBrinquedo.Value = new System.DateTime(2015, 2, 10, 0, 0, 0, 0);
            this.dateTimePickerBrinquedo.ValueChanged += new System.EventHandler(this.dateTimePickerBrinquedo_ValueChanged);
            this.dateTimePickerBrinquedo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerBrinquedo_KeyDown);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Location = new System.Drawing.Point(168, 186);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 30);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            this.btnNovo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnNovo_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(23, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtValor.Location = new System.Drawing.Point(20, 103);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 20);
            this.txtValor.TabIndex = 2;
            this.txtValor.Text = "0,00";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estoque";
            // 
            // txtQtdEstoque
            // 
            this.txtQtdEstoque.Enabled = false;
            this.txtQtdEstoque.Location = new System.Drawing.Point(174, 142);
            this.txtQtdEstoque.Name = "txtQtdEstoque";
            this.txtQtdEstoque.Size = new System.Drawing.Size(81, 20);
            this.txtQtdEstoque.TabIndex = 12;
            this.txtQtdEstoque.Text = "0";
            this.txtQtdEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbControleEstoque
            // 
            this.cbControleEstoque.AutoSize = true;
            this.cbControleEstoque.Location = new System.Drawing.Point(271, 144);
            this.cbControleEstoque.Name = "cbControleEstoque";
            this.cbControleEstoque.Size = new System.Drawing.Size(107, 17);
            this.cbControleEstoque.TabIndex = 13;
            this.cbControleEstoque.Text = "Controla Estoque";
            this.cbControleEstoque.UseVisualStyleBackColor = true;
            this.cbControleEstoque.CheckedChanged += new System.EventHandler(this.cbControleEstoque_CheckedChanged);
            // 
            // FrmCadastroBrinquedo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 228);
            this.Controls.Add(this.cbControleEstoque);
            this.Controls.Add(this.txtQtdEstoque);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dateTimePickerBrinquedo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeBrinquedo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroBrinquedo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kisner Eventos - Cadastro de Brinquedo";
            this.Load += new System.EventHandler(this.FrmCadastroBrinquedo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeBrinquedo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerBrinquedo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQtdEstoque;
        private System.Windows.Forms.CheckBox cbControleEstoque;
    }
}