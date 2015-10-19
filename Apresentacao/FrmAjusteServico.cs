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
    public partial class FrmAjusteServico : Form
    {
        public FrmAjusteServico()
        {
            InitializeComponent();
            dataGridViewAjusteServico.AutoGenerateColumns = false;
            atualizaGrid();
        }

        public void atualizaGrid()
        {
            ServicoNegocio servicoNegocio = new ServicoNegocio();
            ServicoColecao servicoColecao = new ServicoColecao();

            servicoColecao = servicoNegocio.ConsultarNome(txtPesquisa.Text);

            dataGridViewAjusteServico.DataSource = null;
            dataGridViewAjusteServico.DataSource = servicoColecao;
            dataGridViewAjusteServico.Update();
            dataGridViewAjusteServico.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastroServico fas = new FrmCadastroServico(EnumeradorServico.Inserir,null);

            fas.Show();
        }

        private void dataGridViewAjusteServico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Servico servicoSelecionado = new Servico();

            servicoSelecionado = (dataGridViewAjusteServico.SelectedRows[0].DataBoundItem as Servico);
            FrmCadastroServico fcs = new FrmCadastroServico(EnumeradorServico.Alterar, servicoSelecionado);

            fcs.Show();
        }

        private void btnAjustar_Click(object sender, EventArgs e)
        {
            Servico servicoSelecionado = new Servico();

            servicoSelecionado = (dataGridViewAjusteServico.SelectedRows[0].DataBoundItem as Servico);
            FrmCadastroServico fcs = new FrmCadastroServico(EnumeradorServico.Alterar, servicoSelecionado);

            fcs.Show();
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                atualizaGrid();
        }
    }
}