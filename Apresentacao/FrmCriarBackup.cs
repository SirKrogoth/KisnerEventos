using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Apresentacao
{
    public partial class FrmCriarBackup : Form
    {
        public FrmCriarBackup()
        {
            InitializeComponent();
        }

        private void btnGerarBackup_Click(object sender, EventArgs e)
        {
            try
            {
                BackupNegocio bn = new BackupNegocio();

                int retorno = bn.gerarBackupSistema(txtBanco.Text, txtLocalSalvo.Text, txtNomeArquivo.Text);

                MessageBox.Show("Banco de dados gerado com sucesso.\nSalvo em " + txtLocalSalvo.Text, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

            }catch
            {
                MessageBox.Show("Erro ao gerar backup do banco de dados.", "Erro ao gerar backup.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void FrmCriarBackup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void txtBanco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void txtLocalSalvo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void txtNomeArquivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtLocalSalvo.Text = fbd.SelectedPath;
            }
        }
    }
}
