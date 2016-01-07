namespace Apresentacao
{
    partial class frmCadastroDecoracao
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
            this.txtNomeDecoracao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerCriacao = new System.Windows.Forms.DateTimePicker();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtControlaEstoque = new System.Windows.Forms.TextBox();
            this.cbControlaEstoque = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Decoração";
            // 
            // txtNomeDecoracao
            // 
            this.txtNomeDecoracao.Location = new System.Drawing.Point(15, 64);
            this.txtNomeDecoracao.Name = "txtNomeDecoracao";
            this.txtNomeDecoracao.Size = new System.Drawing.Size(375, 20);
            this.txtNomeDecoracao.TabIndex = 1;
            this.txtNomeDecoracao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeDecoracao_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Situação";
            // 
            // cbSituacao
            // 
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbSituacao.Location = new System.Drawing.Point(15, 142);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(114, 21);
            this.cbSituacao.TabIndex = 4;
            this.cbSituacao.Text = "Ativo";
            this.cbSituacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSituacao_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Criação";
            // 
            // dateTimePickerCriacao
            // 
            this.dateTimePickerCriacao.Enabled = false;
            this.dateTimePickerCriacao.Location = new System.Drawing.Point(163, 103);
            this.dateTimePickerCriacao.Name = "dateTimePickerCriacao";
            this.dateTimePickerCriacao.Size = new System.Drawing.Size(224, 20);
            this.dateTimePickerCriacao.TabIndex = 3;
            this.dateTimePickerCriacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerCriacao_KeyDown);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Location = new System.Drawing.Point(173, 185);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 31);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            this.btnNovo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnNovo_KeyDown);
            // 
            // btnGravar
            // 
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.Location = new System.Drawing.Point(92, 185);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 31);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            this.btnGravar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGravar_KeyDown);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(254, 185);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 31);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLimpar_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(15, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(15, 103);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 2;
            this.txtValor.Text = "0,00";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Estoque";
            // 
            // txtControlaEstoque
            // 
            this.txtControlaEstoque.Enabled = false;
            this.txtControlaEstoque.Location = new System.Drawing.Point(163, 142);
            this.txtControlaEstoque.Name = "txtControlaEstoque";
            this.txtControlaEstoque.Size = new System.Drawing.Size(77, 20);
            this.txtControlaEstoque.TabIndex = 10;
            this.txtControlaEstoque.Text = "0";
            this.txtControlaEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbControlaEstoque
            // 
            this.cbControlaEstoque.AutoSize = true;
            this.cbControlaEstoque.Location = new System.Drawing.Point(249, 144);
            this.cbControlaEstoque.Name = "cbControlaEstoque";
            this.cbControlaEstoque.Size = new System.Drawing.Size(107, 17);
            this.cbControlaEstoque.TabIndex = 11;
            this.cbControlaEstoque.Text = "Controla Estoque";
            this.cbControlaEstoque.UseVisualStyleBackColor = true;
            this.cbControlaEstoque.CheckedChanged += new System.EventHandler(this.cbControlaEstoque_CheckedChanged);
            // 
            // frmCadastroDecoracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 228);
            this.Controls.Add(this.cbControlaEstoque);
            this.Controls.Add(this.txtControlaEstoque);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dateTimePickerCriacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeDecoracao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroDecoracao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kisner Eventos - Cadastro de Decoração";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeDecoracao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerCriacao;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtControlaEstoque;
        private System.Windows.Forms.CheckBox cbControlaEstoque;
    }
}