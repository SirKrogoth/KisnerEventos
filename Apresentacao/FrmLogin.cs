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
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            confirmarLogon();
        }

        public void confirmarLogon()
        {
            TelaLogonNegocio tln = new TelaLogonNegocio();
            FrmPrincipal principal = new FrmPrincipal();

            string retorno = tln.ConsultaUsuario(txtUsuario.Text, txtSenha.Text);

            try
            {
                int novoRetorno = Convert.ToInt32(retorno);

                if (novoRetorno == 1)
                {
                    principal.Show();
                    this.Visible = false;
                }
                else if(novoRetorno == 0)
                {
                    MessageBox.Show("Usuário não localizado ou não cadastrado.", "Usuário não localizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }                    
                else
                {
                    MessageBox.Show("Mais de um dado retornado pelo banco de dados.\nRevise os dados informados e caso persista, contate o administrador do sistema.","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Erro ao buscar usuário.\nContate o administrador.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                confirmarLogon();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void btnEntrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void btnLimpar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }
    }
}