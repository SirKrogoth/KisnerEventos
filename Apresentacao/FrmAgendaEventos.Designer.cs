namespace Apresentacao
{
    partial class FrmAgendaEventos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAgendaEventos = new System.Windows.Forms.DataGridView();
            this.colConcluido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCancelado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAniversariante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalEnveto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTermino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAniverariante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTermino = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCancelado = new System.Windows.Forms.CheckBox();
            this.cbConcluido = new System.Windows.Forms.CheckBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNovoEvento = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaEventos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAgendaEventos
            // 
            this.dgvAgendaEventos.AllowUserToAddRows = false;
            this.dgvAgendaEventos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAgendaEventos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAgendaEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendaEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colConcluido,
            this.colCancelado,
            this.colCliente,
            this.colAniversariante,
            this.colLocalEnveto,
            this.colCidade,
            this.colData,
            this.colInicio,
            this.colTermino});
            this.dgvAgendaEventos.Location = new System.Drawing.Point(12, 130);
            this.dgvAgendaEventos.MultiSelect = false;
            this.dgvAgendaEventos.Name = "dgvAgendaEventos";
            this.dgvAgendaEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgendaEventos.Size = new System.Drawing.Size(984, 321);
            this.dgvAgendaEventos.TabIndex = 8;
            this.dgvAgendaEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgendaEventos_CellContentClick);
            this.dgvAgendaEventos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgendaEventos_CellDoubleClick);
            this.dgvAgendaEventos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAgendaEventos_CellFormatting);
            // 
            // colConcluido
            // 
            this.colConcluido.DataPropertyName = "concluido";
            this.colConcluido.HeaderText = "Concluido";
            this.colConcluido.Name = "colConcluido";
            this.colConcluido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colConcluido.Width = 60;
            // 
            // colCancelado
            // 
            this.colCancelado.DataPropertyName = "cancelado";
            this.colCancelado.HeaderText = "Cancelado";
            this.colCancelado.Name = "colCancelado";
            this.colCancelado.Width = 60;
            // 
            // colCliente
            // 
            this.colCliente.DataPropertyName = "nomeCliente";
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            this.colCliente.Width = 120;
            // 
            // colAniversariante
            // 
            this.colAniversariante.DataPropertyName = "nome";
            this.colAniversariante.HeaderText = "Aniversariante";
            this.colAniversariante.Name = "colAniversariante";
            this.colAniversariante.ReadOnly = true;
            this.colAniversariante.Width = 120;
            // 
            // colLocalEnveto
            // 
            this.colLocalEnveto.DataPropertyName = "localEvento";
            this.colLocalEnveto.HeaderText = "Local";
            this.colLocalEnveto.Name = "colLocalEnveto";
            this.colLocalEnveto.ReadOnly = true;
            this.colLocalEnveto.Width = 170;
            // 
            // colCidade
            // 
            this.colCidade.DataPropertyName = "cidadeEvento";
            this.colCidade.HeaderText = "Cidade";
            this.colCidade.Name = "colCidade";
            this.colCidade.ReadOnly = true;
            // 
            // colData
            // 
            this.colData.DataPropertyName = "data_evento";
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            this.colData.Width = 80;
            // 
            // colInicio
            // 
            this.colInicio.DataPropertyName = "inicio";
            this.colInicio.HeaderText = "Inicio";
            this.colInicio.Name = "colInicio";
            this.colInicio.ReadOnly = true;
            this.colInicio.Width = 90;
            // 
            // colTermino
            // 
            this.colTermino.DataPropertyName = "termino";
            this.colTermino.HeaderText = "Termino";
            this.colTermino.Name = "colTermino";
            this.colTermino.ReadOnly = true;
            this.colTermino.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(16, 41);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(343, 20);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aniversariante:";
            // 
            // txtAniverariante
            // 
            this.txtAniverariante.Location = new System.Drawing.Point(19, 85);
            this.txtAniverariante.Name = "txtAniverariante";
            this.txtAniverariante.Size = new System.Drawing.Size(340, 20);
            this.txtAniverariante.TabIndex = 2;
            this.txtAniverariante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAniverariante_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(405, 41);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(221, 20);
            this.txtCidade.TabIndex = 1;
            this.txtCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCidade_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "De:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(408, 85);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(98, 20);
            this.dtpInicio.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Para:";
            // 
            // dtpTermino
            // 
            this.dtpTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTermino.Location = new System.Drawing.Point(522, 85);
            this.dtpTermino.Name = "dtpTermino";
            this.dtpTermino.Size = new System.Drawing.Size(104, 20);
            this.dtpTermino.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCancelado);
            this.groupBox1.Controls.Add(this.cbConcluido);
            this.groupBox1.Location = new System.Drawing.Point(668, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status de exibição";
            // 
            // cbCancelado
            // 
            this.cbCancelado.AutoSize = true;
            this.cbCancelado.Location = new System.Drawing.Point(7, 44);
            this.cbCancelado.Name = "cbCancelado";
            this.cbCancelado.Size = new System.Drawing.Size(77, 17);
            this.cbCancelado.TabIndex = 6;
            this.cbCancelado.Text = "Cancelado";
            this.cbCancelado.UseVisualStyleBackColor = true;
            // 
            // cbConcluido
            // 
            this.cbConcluido.AutoSize = true;
            this.cbConcluido.Location = new System.Drawing.Point(7, 20);
            this.cbConcluido.Name = "cbConcluido";
            this.cbConcluido.Size = new System.Drawing.Size(73, 17);
            this.cbConcluido.TabIndex = 5;
            this.cbConcluido.Text = "Concluido";
            this.cbConcluido.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Location = new System.Drawing.Point(840, 86);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnNovoEvento
            // 
            this.btnNovoEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoEvento.Location = new System.Drawing.Point(921, 86);
            this.btnNovoEvento.Name = "btnNovoEvento";
            this.btnNovoEvento.Size = new System.Drawing.Size(75, 23);
            this.btnNovoEvento.TabIndex = 12;
            this.btnNovoEvento.Text = "Novo";
            this.btnNovoEvento.UseVisualStyleBackColor = true;
            this.btnNovoEvento.Click += new System.EventHandler(this.btnNovoEvento_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(757, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dê um duplo clique no evento que deseja alterar.";
            // 
            // FrmAgendaEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 479);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnNovoEvento);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpTermino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAniverariante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAgendaEventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgendaEventos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kisner Eventos - Agenda de Eventos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaEventos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgendaEventos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAniverariante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTermino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbCancelado;
        private System.Windows.Forms.CheckBox cbConcluido;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnNovoEvento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colConcluido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCancelado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAniversariante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalEnveto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTermino;
        private System.Windows.Forms.Label label6;

    }
}