﻿namespace Apresentacao
{
    partial class FrmAjusteDecoracao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDecoracao = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnAjustar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.colCodDecoracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeDecoracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDecoracao)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDecoracao
            // 
            this.dataGridViewDecoracao.AllowUserToAddRows = false;
            this.dataGridViewDecoracao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewDecoracao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDecoracao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDecoracao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodDecoracao,
            this.colNomeDecoracao,
            this.colDataCadastro,
            this.colValor,
            this.colEstoque,
            this.colAtivo});
            this.dataGridViewDecoracao.Location = new System.Drawing.Point(12, 5);
            this.dataGridViewDecoracao.MultiSelect = false;
            this.dataGridViewDecoracao.Name = "dataGridViewDecoracao";
            this.dataGridViewDecoracao.ReadOnly = true;
            this.dataGridViewDecoracao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDecoracao.Size = new System.Drawing.Size(560, 219);
            this.dataGridViewDecoracao.TabIndex = 0;
            this.dataGridViewDecoracao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewDecoracao_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o item desejado e clique em \'Ajustar\'";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(12, 256);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(317, 20);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // btnAjustar
            // 
            this.btnAjustar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjustar.Location = new System.Drawing.Point(497, 254);
            this.btnAjustar.Name = "btnAjustar";
            this.btnAjustar.Size = new System.Drawing.Size(75, 23);
            this.btnAjustar.TabIndex = 4;
            this.btnAjustar.Text = "Ajustar";
            this.btnAjustar.UseVisualStyleBackColor = true;
            this.btnAjustar.Click += new System.EventHandler(this.btnAjustar_Click);
            this.btnAjustar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAjustar_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(335, 254);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnBuscar_KeyDown);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Location = new System.Drawing.Point(416, 254);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            this.btnNovo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnNovo_KeyDown);
            // 
            // colCodDecoracao
            // 
            this.colCodDecoracao.DataPropertyName = "codDecoracao";
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.colCodDecoracao.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCodDecoracao.HeaderText = "Código";
            this.colCodDecoracao.Name = "colCodDecoracao";
            this.colCodDecoracao.ReadOnly = true;
            this.colCodDecoracao.Width = 80;
            // 
            // colNomeDecoracao
            // 
            this.colNomeDecoracao.DataPropertyName = "nome";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colNomeDecoracao.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNomeDecoracao.HeaderText = "Nome Decoração";
            this.colNomeDecoracao.Name = "colNomeDecoracao";
            this.colNomeDecoracao.ReadOnly = true;
            this.colNomeDecoracao.Width = 180;
            // 
            // colDataCadastro
            // 
            this.colDataCadastro.DataPropertyName = "cadastro";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Format = "g";
            this.colDataCadastro.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDataCadastro.HeaderText = "Data Cadastro";
            this.colDataCadastro.Name = "colDataCadastro";
            this.colDataCadastro.ReadOnly = true;
            this.colDataCadastro.Width = 120;
            // 
            // colValor
            // 
            this.colValor.DataPropertyName = "valor";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = "0,00";
            this.colValor.DefaultCellStyle = dataGridViewCellStyle5;
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            this.colValor.Width = 70;
            // 
            // colEstoque
            // 
            this.colEstoque.DataPropertyName = "estoque";
            this.colEstoque.HeaderText = "Estoque";
            this.colEstoque.Name = "colEstoque";
            this.colEstoque.ReadOnly = true;
            this.colEstoque.Width = 60;
            // 
            // colAtivo
            // 
            this.colAtivo.DataPropertyName = "ativo";
            this.colAtivo.HeaderText = "Situação";
            this.colAtivo.Name = "colAtivo";
            this.colAtivo.ReadOnly = true;
            // 
            // FrmAjusteDecoracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 288);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAjustar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDecoracao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAjusteDecoracao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kisner Eventos - Ajuste de Decorações";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDecoracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDecoracao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnAjustar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodDecoracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeDecoracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstoque;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAtivo;
    }
}