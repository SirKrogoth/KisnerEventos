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
    public partial class FrmAjusteCliente : Form
    {
        public FrmAjusteCliente()
        {
            InitializeComponent();
            dataGridViewCliente.AutoGenerateColumns = false;
            atualizaGrid();
        }

        public void atualizaGrid()
        {
            ClienteColecao clienteColecao = new ClienteColecao();
            ClienteNegocio clienteNegocio = new ClienteNegocio();

            //realizando consulta
            clienteColecao = clienteNegocio.ConsultarNomeCliente(txtBusca.Text);
            //limpando grid
            dataGridViewCliente.DataSource = null;
            //Inserindo os dados na clienteColecao no Grid.
            dataGridViewCliente.DataSource = clienteColecao;
            dataGridViewCliente.Update();
            dataGridViewCliente.Refresh();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente fcc = new FrmCadastroCliente(EnumeradorCliente.Inserir, null);

            fcc.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void btnAjustar_Click(object sender, EventArgs e)
        {           
             if (dataGridViewCliente.SelectedRows.Count == 0)
             {
                 MessageBox.Show("Não foi selecionado nenhum cliente. \nFavor, selecione um cliente antes de clicar em ajustar.", "Selecione um Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 return;
             }
             else
             {
                 Cliente clienteSelecionado = (dataGridViewCliente.SelectedRows[0].DataBoundItem as Cliente);
                 FrmCadastroCliente fcc = new FrmCadastroCliente(EnumeradorCliente.Alterar, clienteSelecionado);
                 fcc.Show();
             }            
        }

        private void FrmAjusteCliente_Load(object sender, EventArgs e)
        {
            
        }
    }
}   