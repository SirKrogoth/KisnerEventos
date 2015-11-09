namespace Apresentacao
{
    partial class frmAjusteBrinquedo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewBrinquedo = new System.Windows.Forms.DataGridView();
            this.colCodDecoracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeBrinquedo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjustar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrinquedo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBrinquedo
            // 
            this.dataGridViewBrinquedo.AllowUserToAddRows = false;
            this.dataGridViewBrinquedo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewBrinquedo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewBrinquedo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBrinquedo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodDecoracao,
            this.colNomeBrinquedo,
            this.colDataCadastro,
            this.valor,
            this.colAtivo});
            this.dataGridViewBrinquedo.Location = new System.Drawing.Point(12, 3);
            this.dataGridViewBrinquedo.MultiSelect = false;
            this.dataGridViewBrinquedo.Name = "dataGridViewBrinquedo";
            this.dataGridViewBrinquedo.ReadOnly = true;
            this.dataGridViewBrinquedo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBrinquedo.Size = new System.Drawing.Size(560, 219);
            this.dataGridViewBrinquedo.TabIndex = 0;
            this.dataGridViewBrinquedo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewBrinquedo_KeyDown);
            // 
            // colCodDecoracao
            // 
            this.colCodDecoracao.DataPropertyName = "codBrinquedo";
            dataGridViewCellStyle22.NullValue = null;
            this.colCodDecoracao.DefaultCellStyle = dataGridViewCellStyle22;
            this.colCodDecoracao.HeaderText = "Codigo";
            this.colCodDecoracao.Name = "colCodDecoracao";
            this.colCodDecoracao.ReadOnly = true;
            this.colCodDecoracao.Width = 80;
            // 
            // colNomeBrinquedo
            // 
            this.colNomeBrinquedo.DataPropertyName = "nome";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.NullValue = null;
            this.colNomeBrinquedo.DefaultCellStyle = dataGridViewCellStyle23;
            this.colNomeBrinquedo.HeaderText = "Nome Brinquedo";
            this.colNomeBrinquedo.Name = "colNomeBrinquedo";
            this.colNomeBrinquedo.ReadOnly = true;
            this.colNomeBrinquedo.Width = 170;
            // 
            // colDataCadastro
            // 
            this.colDataCadastro.DataPropertyName = "cadastro";
            dataGridViewCellStyle24.Format = "g";
            dataGridViewCellStyle24.NullValue = null;
            this.colDataCadastro.DefaultCellStyle = dataGridViewCellStyle24;
            this.colDataCadastro.HeaderText = "Data Cadastro";
            this.colDataCadastro.Name = "colDataCadastro";
            this.colDataCadastro.ReadOnly = true;
            this.colDataCadastro.Width = 110;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle25.Format = "C2";
            dataGridViewCellStyle25.NullValue = null;
            this.valor.DefaultCellStyle = dataGridViewCellStyle25;
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 70;
            // 
            // colAtivo
            // 
            this.colAtivo.DataPropertyName = "ativo";
            this.colAtivo.HeaderText = "Situação";
            this.colAtivo.Name = "colAtivo";
            this.colAtivo.ReadOnly = true;
            this.colAtivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAtivo.TrueValue = "";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 256);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(317, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione o item desejado e clique em \'Ajustar\'";
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
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(416, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // frmAjusteBrinquedo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 288);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAjustar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dataGridViewBrinquedo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAjusteBrinquedo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kisner Eventos - Ajuste de Brinquedo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrinquedo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBrinquedo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjustar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodDecoracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeBrinquedo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAtivo;
    }
}