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
            this.timerLogon.Start();

            confirmarLogon();
        }

        public void confirmarLogon()
        {
            TelaLogonNegocio tln = new TelaLogonNegocio();
            FrmPrincipal principal = new FrmPrincipal();

            string retorno = tln.ConsultaUsuario(txtUsuario.Text, txtSenha.Text);

            int novoRetorno = Convert.ToInt32(retorno);

            if (novoRetorno != 0)
            {
                principal.Show();
                this.Visible = false;
            }
            else
                MessageBox.Show("Usuário não localizado ou não cadastrado, verifique com o administrador.", "Usuário não localizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                confirmarLogon();
        }

        private void timerLogon_Tick(object sender, EventArgs e)
        {
            this.progressBarLogon.Increment(1);
            if (progressBarLogon.Value == 100)
                timerLogon.Stop();
        }
    }
}