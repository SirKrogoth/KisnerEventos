using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocio;
using System.Data.SqlClient;

namespace Apresentacao
{
    public partial class FrmAgendaEventos : Form
    {
        Evento eventoSelecionado = new Evento();
        EventoBrinquedoColecao eventoBrinquedoColecao = new EventoBrinquedoColecao();
        EventoDecoracaoColecao eventoDecoracaoColecao = new EventoDecoracaoColecao();
        EventoServicoColecao eventoServicoColecao = new EventoServicoColecao();
        public FrmAgendaEventos()
        {
            InitializeComponent();
            dgvAgendaEventos.AutoGenerateColumns = false;
            atualizaGrid();
        }

        public void atualizaGrid()
        {
            EventoColecao eventoColecao = new EventoColecao();
            EventoNegocio eventoNegocio = new EventoNegocio();
            
            //realizar consulta no banco de dados e nos trará todos os eventos cadastrados no sistema
            eventoColecao = eventoNegocio.ConsultaProximosEventos();
            //limpando grid
            dgvAgendaEventos.DataSource = null;
            //exibindo dados no grid
            dgvAgendaEventos.DataSource = eventoColecao;
            dgvAgendaEventos.Update();
            dgvAgendaEventos.Refresh();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisarEventos();
        }

        public void pesquisarEventos()
        {
            string cliente = txtCliente.Text;
            string aniversariante = txtAniverariante.Text;
            string cidade = txtCidade.Text;
            DateTime dataDe = dtpInicio.Value.Date;
            DateTime dataPara = dtpTermino.Value.Date;
            bool concluido = false;
            bool cancelado = false;

            if (cbConcluido.Checked == true)
                concluido = true;
            if (cbCancelado.Checked == true)
                cancelado = true;

            EventoNegocio eventoNegocio = new EventoNegocio();
            EventoColecao eventoColecao = new EventoColecao();

            eventoColecao = eventoNegocio.ConsultaAvancada(cliente, aniversariante, cidade, dataDe, dataPara, concluido, cancelado);

            dgvAgendaEventos.DataSource = null;
            dgvAgendaEventos.DataSource = eventoColecao;
            dgvAgendaEventos.Update();
            dgvAgendaEventos.Refresh();
        }
        //O KeyPressEventArgs é responsável por exibir qual é a tecla informada pelo usuário.
        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //o 13 é o valor do "enter" na tabela ASCII
            if (e.KeyChar == 13)
                pesquisarEventos();
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //o 13 é o valor do "enter" na tabela ASCII
            if (e.KeyChar == 13)
                pesquisarEventos();
        }
        
        private void txtAniverariante_KeyPress(object sender, KeyPressEventArgs e)
        {
            //o 13 é o valor do "enter" na tabela ASCII
            if (e.KeyChar == 13)
                pesquisarEventos();
        }
        //Evento responsável por informar com uma cor verde se o evento está concluido e vermelho para cancelado
        //CellFormatting serve para formatar as celulas do grid
        private void dgvAgendaEventos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 0 && e.Value.Equals(true))
            {
                DataGridViewRow row = dgvAgendaEventos.Rows[e.RowIndex];
                row.DefaultCellStyle.BackColor = Color.Green;
                row.DefaultCellStyle.ForeColor = Color.AliceBlue;
            }
            else if (e.Value != null && e.ColumnIndex == 1 && e.Value.Equals(true))
            {
                DataGridViewRow row = dgvAgendaEventos.Rows[e.RowIndex];
                row.DefaultCellStyle.BackColor = Color.Tomato;
                row.DefaultCellStyle.ForeColor = Color.AliceBlue;
            }
            else
                return;
        }

        private void dgvAgendaEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EventoNegocio eventoNegocio = new EventoNegocio();
            try
            {
                Evento evento = new Evento();
                if (e.ColumnIndex == dgvAgendaEventos.Columns["colConcluido"].Index)
                {
                    evento = (dgvAgendaEventos.Rows[e.RowIndex].DataBoundItem as Evento);
                    //se o evento estivar como false(ou seja, não finalizado), este método irá finaliza-lo
                    if (evento.concluido == false)
                    {
                        DialogResult pergunta = MessageBox.Show("Você confirma a finalização deste evento?", "Concluir evento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (pergunta == DialogResult.Yes)
                            eventoNegocio.EventoConcluir(evento);
                        else
                        {
                            //caso o usuário não confirme a conclusão, será setado novamente para false o checkbox
                            dgvAgendaEventos.Columns["colConcluido"].Selected = false;
                        }                            
                        atualizaGrid();
                    }
                    else
                    {
                        DialogResult pergunta = MessageBox.Show("Você confirma reabrir este evento?", "Reabrir evento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (pergunta == DialogResult.Yes)
                            eventoNegocio.EventoConcluirDesfazer(evento);
                        else
                            dgvAgendaEventos.Columns["colConcluido"].Selected = true;
                        atualizaGrid();
                    }
                }
                else if(e.ColumnIndex == dgvAgendaEventos.Columns["colCancelado"].Index)
                {
                    evento = (dgvAgendaEventos.Rows[e.RowIndex].DataBoundItem as Evento);
                    //se o evento estivar como false(ou seja, não finalizado), este método irá finaliza-lo
                    if (evento.cancelado == false)
                    {
                        DialogResult pergunta = MessageBox.Show("Você confirma o cancelamento deste evento?", "Cancelar evento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (pergunta == DialogResult.Yes)
                            eventoNegocio.EventoCancelado(evento);
                        else
                            dgvAgendaEventos.Columns["colCancelado"].Selected = false;
                        atualizaGrid();
                    }
                    else
                    {
                        DialogResult pergunta = MessageBox.Show("Você confirma reabrir este evento?", "Reabrir evento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (pergunta == DialogResult.Yes)
                            eventoNegocio.EventoCanceladoDesfazer(evento);
                        else
                            dgvAgendaEventos.Columns["colCancelado"].Selected = true;
                        atualizaGrid();
                    }
                }
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private void btnNovoEvento_Click(object sender, EventArgs e)
        {
            FrmCadastroEvento fce = new FrmCadastroEvento();

            this.Close();
            fce.MdiParent = FrmPrincipal.ActiveForm;
            fce.Show();
        }
        //Método responsável por pegar o registro que o usuário irá dar um duplo clique, e seguir os procedimentos
        private void dgvAgendaEventos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Evento eventoSelecionado = (dgvAgendaEventos.SelectedRows[0].DataBoundItem as Evento);
            FrmCadastroEvento fce = new FrmCadastroEvento(EnumeradorEvento.Alterar, eventoSelecionado);

            fce.Show();
            this.Close();
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void txtCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void cbConcluido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void cbCancelado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void txtAniverariante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void dtpInicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void dtpTermino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void btnPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void btnNovoEvento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void dgvAgendaEventos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }
    }
}