namespace Apresentacao
{
    partial class FrmCadastroServico
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpCriacao = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmSituaco = new System.Windows.Forms.ComboBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(15, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(92, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 73);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(372, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(15, 121);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(92, 20);
            this.txtValor.TabIndex = 5;
            this.txtValor.Text = "0,00";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de Criação";
            // 
            // dtpCriacao
            // 
            this.dtpCriacao.Enabled = false;
            this.dtpCriacao.Location = new System.Drawing.Point(175, 121);
            this.dtpCriacao.Name = "dtpCriacao";
            this.dtpCriacao.Size = new System.Drawing.Size(212, 20);
            this.dtpCriacao.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Situação";
            // 
            // cmSituaco
            // 
            this.cmSituaco.FormattingEnabled = true;
            this.cmSituaco.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cmSituaco.Location = new System.Drawing.Point(15, 172);
            this.cmSituaco.Name = "cmSituaco";
            this.cmSituaco.Size = new System.Drawing.Size(120, 21);
            this.cmSituaco.TabIndex = 9;
            this.cmSituaco.Text = "Selecione";
            // 
            // btnGravar
            // 
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.Location = new System.Drawing.Point(160, 170);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 32);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Location = new System.Drawing.Point(241, 170);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 32);
            this.btnNovo.TabIndex = 11;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(322, 170);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 32);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmCadastroServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 213);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.cmSituaco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpCriacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroServico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kisner Eventos - Cadastro de Serviço";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpCriacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmSituaco;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnLimpar;
    }
}