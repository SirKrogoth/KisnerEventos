namespace Apresentacao
{
    partial class FrmCriarBackup
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
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocalSalvo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.btnGerarBackup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do banco de dados";
            // 
            // txtBanco
            // 
            this.txtBanco.Enabled = false;
            this.txtBanco.Location = new System.Drawing.Point(61, 65);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(229, 20);
            this.txtBanco.TabIndex = 1;
            this.txtBanco.Text = "KISNER_EVENTOS";
            this.txtBanco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBanco_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local onde o banco de dados será salvo";
            // 
            // txtLocalSalvo
            // 
            this.txtLocalSalvo.Enabled = false;
            this.txtLocalSalvo.Location = new System.Drawing.Point(61, 104);
            this.txtLocalSalvo.Name = "txtLocalSalvo";
            this.txtLocalSalvo.Size = new System.Drawing.Size(198, 20);
            this.txtLocalSalvo.TabIndex = 3;
            this.txtLocalSalvo.Text = "C:\\BACKUP\\";
            this.txtLocalSalvo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocalSalvo_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome do arquivo";
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Location = new System.Drawing.Point(61, 143);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(229, 20);
            this.txtNomeArquivo.TabIndex = 5;
            this.txtNomeArquivo.Text = "KISNER_EVENTOS";
            this.txtNomeArquivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeArquivo_KeyDown);
            // 
            // btnGerarBackup
            // 
            this.btnGerarBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarBackup.Location = new System.Drawing.Point(215, 169);
            this.btnGerarBackup.Name = "btnGerarBackup";
            this.btnGerarBackup.Size = new System.Drawing.Size(75, 39);
            this.btnGerarBackup.TabIndex = 6;
            this.btnGerarBackup.Text = "Gerar Backup";
            this.btnGerarBackup.UseVisualStyleBackColor = true;
            this.btnGerarBackup.Click += new System.EventHandler(this.btnGerarBackup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gerador de backup manual";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCriarBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 217);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGerarBackup);
            this.Controls.Add(this.txtNomeArquivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocalSalvo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCriarBackup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kisner Eventos - Criar Backup";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCriarBackup_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocalSalvo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.Button btnGerarBackup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}