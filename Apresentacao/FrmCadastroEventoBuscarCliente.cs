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
    public partial class FrmCadastroEventoBuscarCliente : Form
    {
        public Cliente clienteSelecionado = new Cliente();
        public FrmCadastroEventoBuscarCliente()
        {
            InitializeComponent();
            dataGridViewBuscarCliente.AutoGenerateColumns = false;
            atualizarGrid();
        }

        public void atualizarGrid()
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            ClienteColecao clienteColecao = new ClienteColecao();

            clienteColecao = clienteNegocio.ConsultarNomeCliente(txtBusca.Text);

            dataGridViewBuscarCliente.DataSource = null;
            dataGridViewBuscarCliente.DataSource = clienteColecao;
            dataGridViewBuscarCliente.Update();
            dataGridViewBuscarCliente.Refresh();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            FrmCadastroEvento fce = new FrmCadastroEvento();

            clienteSelecionado = (dataGridViewBuscarCliente.SelectedRows[0].DataBoundItem as Cliente);


            this.Close();
        }

        private void dataGridViewBuscarCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            FrmCadastroEvento fce = new FrmCadastroEvento();

            clienteSelecionado = (dataGridViewBuscarCliente.SelectedRows[0].DataBoundItem as Cliente);
            

            this.Close();
        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                atualizarGrid();
        }
    }
}
