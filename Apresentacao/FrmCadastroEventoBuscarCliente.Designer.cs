namespace Apresentacao
{
    partial class FrmCadastroEventoBuscarCliente
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
            this.dataGridViewBuscarCliente = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBuscarCliente
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewBuscarCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBuscarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuscarCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNome,
            this.colCidade});
            this.dataGridViewBuscarCliente.Location = new System.Drawing.Point(12, 3);
            this.dataGridViewBuscarCliente.MultiSelect = false;
            this.dataGridViewBuscarCliente.Name = "dataGridViewBuscarCliente";
            this.dataGridViewBuscarCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBuscarCliente.Size = new System.Drawing.Size(407, 152);
            this.dataGridViewBuscarCliente.TabIndex = 0;
            this.dataGridViewBuscarCliente.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBuscarCliente_CellContentDoubleClick);
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "codCliente";
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 80;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "nome";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 180;
            // 
            // colCidade
            // 
            this.colCidade.DataPropertyName = "cidade";
            this.colCidade.HeaderText = "Cidade";
            this.colCidade.Name = "colCidade";
            this.colCidade.ReadOnly = true;
            this.colCidade.Width = 120;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(344, 184);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(12, 186);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(326, 20);
            this.txtBusca.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dê um duplo clique no cliente desejado.";
            // 
            // FrmCadastroEventoBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 212);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridViewBuscarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroEventoBuscarCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kisner Eventos - Buscar cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBuscarCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCidade;
        private System.Windows.Forms.Label label1;
    }
}