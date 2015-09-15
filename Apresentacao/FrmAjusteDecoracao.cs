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
    public partial class FrmAjusteDecoracao : Form
    {
        public FrmAjusteDecoracao()
        {
            InitializeComponent();
            dataGridViewDecoracao.AutoGenerateColumns = false;
            atualizarGrid();
        }

        public void atualizarGrid()
        {
            DecoracaoNegocio decoracaoNegocio = new DecoracaoNegocio();
            DecoracaoColecao decoracaoColecao = new DecoracaoColecao();

            //consulta
            decoracaoColecao = decoracaoNegocio.ConsultarNomeDecoracao(txtPesquisa.Text);
            //limpar
            dataGridViewDecoracao.DataSource = null;
            //exibir
            dataGridViewDecoracao.DataSource = decoracaoColecao;
            dataGridViewDecoracao.Update();
            dataGridViewDecoracao.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void btnAjustar_Click(object sender, EventArgs e)
        {
            if(dataGridViewDecoracao.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não foi selecionado nenhuma decoração. \nFavor, selecione uma decoração antes de clicar em ajustar.", "Selecione uma decoração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Decoracao decoracaoSelecionada = (dataGridViewDecoracao.SelectedRows[0].DataBoundItem as Decoracao);
                frmCadastroDecoracao fcd = new frmCadastroDecoracao(EnumDecoracao.Alterar, decoracaoSelecionada);

                fcd.Show();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroDecoracao fcd = new frmCadastroDecoracao(EnumDecoracao.Inserir, null);

            fcd.Show();
        }
    }
}