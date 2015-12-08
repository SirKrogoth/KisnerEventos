using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {            
            InitializeComponent();
        }

        private void brinquedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroBrinquedo fcb = new FrmCadastroBrinquedo(EnumeradorBrinquedo.Inserir, null);

            fcb.MdiParent = this;
            fcb.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void decoraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroDecoracao fcd = new frmCadastroDecoracao(EnumDecoracao.Inserir, null);

            fcd.MdiParent = this;
            fcd.Show();
        }

        private void brinquedoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAjusteBrinquedo fab = new frmAjusteBrinquedo();

            fab.MdiParent = this;
            fab.Show();
        }

        private void decoraçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAjusteDecoracao fad = new FrmAjusteDecoracao();

            fad.MdiParent = this;
            fad.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmCadastroBrinquedo fcb = new FrmCadastroBrinquedo(EnumeradorBrinquedo.Inserir, null);

            fcb.MdiParent = this;
            fcb.Show();
        }

        private void toolStripButtonCliente_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente fcc = new FrmCadastroCliente(EnumeradorCliente.Inserir, null);

            fcc.MdiParent = this;
            fcc.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente fcc = new FrmCadastroCliente(EnumeradorCliente.Inserir, null);

            fcc.MdiParent = this;
            fcc.Show();
        }
        //método para sair do sistema
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAjusteCliente fac = new FrmAjusteCliente();

            fac.MdiParent = this;
            fac.Show();
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroServico fcs = new FrmCadastroServico(EnumeradorServico.Inserir,null);

            fcs.MdiParent = this;
            fcs.Show();
        }

        private void serviçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAjusteServico fas = new FrmAjusteServico();

            fas.MdiParent = this;
            fas.Show();
        }

        private void eventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroEvento fce = new FrmCadastroEvento();

            fce.MdiParent = this;
            fce.Show();
        }

        private void toolStripButtonEventos_Click(object sender, EventArgs e)
        {
            FrmAgendaEventos fae = new FrmAgendaEventos();
            
            fae.Show();
        }

        private void agendaEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgendaEventos fae = new FrmAgendaEventos();

            fae.MdiParent = this;
            fae.Show();
        }

        private void adicionarNovoContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVisualizadorContrato fvc = new FrmVisualizadorContrato();

            fvc.Show();
        }

        private void toolStripButtonServicos_Click(object sender, EventArgs e)
        {
            FrmCadastroServico fcs = new FrmCadastroServico(EnumeradorServico.Inserir, null);

            fcs.MdiParent = this;
            fcs.Show();
        }

        private void eventoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void telaLoginTesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin fl = new FrmLogin();

            fl.Show();
            this.Visible = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonDecoracao_Click(object sender, EventArgs e)
        {
            frmCadastroDecoracao fcd = new frmCadastroDecoracao(EnumDecoracao.Inserir, null);

            fcd.MdiParent = this;
            fcd.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCriarBackup bck = new FrmCriarBackup();

            bck.MdiParent = this;
            bck.Show();
        }
    }
}