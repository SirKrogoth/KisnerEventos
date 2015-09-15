using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoBancoDados.Properties;
using ObjetoTransferencia;
using Negocio;
using System.Data.SqlClient;

namespace Apresentacao
{
    public partial class FrmCadastroEvento : Form
    {
        BrinquedoColecao brinquedoColecao = new BrinquedoColecao();
        BrinquedoNegocio brinquedoNegocio = new BrinquedoNegocio();
        DecoracaoColecao decoracaoColecao = new DecoracaoColecao();
        DecoracaoNegocio decoracaoNegocio = new DecoracaoNegocio();
        ServicoColecao servicoColecao = new ServicoColecao();
        ServicoNegocio servicoNegocio = new ServicoNegocio();

        public Cliente clienteSelecionado = null;
        public double valorTotal = 0;
        public double desconto = 0;
        public double acrescimo = 0;
        public double auxiliarBrinquedo = 0;
        public double auxiliarDecoracao = 0;
        public double auxiliarServico = 0;
        public string codEvento = null;

        //Método construtor
        public FrmCadastroEvento(EnumeradorEvento acao, Evento objEvento, EventoBrinquedoColecao eventoBrinquedoColecao, EventoDecoracaoColecao eventoDecoracaoColecao, EventoServicoColecao eventoServicoColecao)
        {
            InitializeComponent();

            //Preenchendo checkList de todos os brinquedos
            brinquedoColecao = brinquedoNegocio.ConsultarNomeBrinquedo("");            

            int i;

            for (i = 0; i < brinquedoColecao.Count; i++)
            {                
                checkedListBoxBrinquedos.Items.Add(brinquedoColecao[i].nome);                
            }

            decoracaoColecao = decoracaoNegocio.ConsultarNomeDecoracao("");

            for (i = 0; i < decoracaoColecao.Count; i++)
            {
                checkedListBoxDecoracao.Items.Add(decoracaoColecao[i].nome);
            }

            servicoColecao = servicoNegocio.ConsultarNome("");
            //Mesmo processo usado acima, apenas com a diferença de estar usando o foreach 
            //para fins didaticos
            foreach (Servico linha in servicoColecao)
            {
                checkedListBoxServicos.Items.Add(linha.descricao);
            }

            if(acao == EnumeradorEvento.Alterar)
            {
                txtCliente.Text = clienteSelecionado.nome;
                txtAniversariante.Text = objEvento.nome;
                txtLocal.Text = objEvento.localEvento;
                txtCidadeEvento.Text = objEvento.cidadeEvento;
                dateTimePickerDataEvento.Text = objEvento.data_evento.ToString();
                maskedTextBoxInicio.Text = objEvento.inicio.ToString();
                maskedTextBoxTermino.Text = objEvento.termino.ToString();
                txtTema.Text = objEvento.tema;

                for (i = 0; i < brinquedoColecao.Count; i++)
                {                    
                    for(int x = 0; x < eventoBrinquedoColecao.Count; x++)
                    {
                        if(brinquedoColecao[i].codBrinquedo == eventoBrinquedoColecao[x].codBrinquedo)
                        {
                            checkedListBoxBrinquedos.Items.Add(eventoBrinquedoColecao[i]);
                        }
                    }
                }                
            }
        }

        public FrmCadastroEvento()
        {
            InitializeComponent();

            //Preenchendo checkList de brinquedo

            brinquedoColecao = brinquedoNegocio.ConsultarNomeBrinquedo("");

            int i;

            for (i = 0; i < brinquedoColecao.Count; i++)
            {               
                checkedListBoxBrinquedos.Items.Add(brinquedoColecao[i].nome);                
            }

            decoracaoColecao = decoracaoNegocio.ConsultarNomeDecoracao("");

            for (i = 0; i < decoracaoColecao.Count; i++)
            {
                checkedListBoxDecoracao.Items.Add(decoracaoColecao[i].nome);
            }

            servicoColecao = servicoNegocio.ConsultarNome("");
            //Mesmo processo usado acima, apenas com a diferença de estar usando o foreach 
            //para fins didaticos
            foreach (Servico linha in servicoColecao)
            {
                checkedListBoxServicos.Items.Add(linha.descricao);
            }
        }
        //Método usado para buscar o cliente cadastrado
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmCadastroEventoBuscarCliente fcebc = new FrmCadastroEventoBuscarCliente();

            fcebc.ShowDialog();

            clienteSelecionado = fcebc.clienteSelecionado;

            txtCliente.Text = clienteSelecionado.nome;
            txtCidadeEvento.Text = clienteSelecionado.cidade;
        }

        public void gravarEvento()
        {
            try
            {
                Evento evento = new Evento();
                EventoBrinquedoColecao eventoBrinquedoColecao = new EventoBrinquedoColecao();
                EventoDecoracaoColecao eventoDecoracaoColecao = new EventoDecoracaoColecao();
                EventoServicoColecao eventoServicoColecao = new EventoServicoColecao();
                EventoNegocio eventoNegocio = new EventoNegocio();

                //verificar se existe cliente selecionado
                if (clienteSelecionado == null)
                {
                    MessageBox.Show("Favor, selecione um cliente.", "Erro ao gravar evento.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                evento.codCliente = Convert.ToInt32(clienteSelecionado.codCliente);
                evento.nome = txtAniversariante.Text;
                evento.localEvento = txtLocal.Text;
                evento.data_evento = dateTimePickerDataEvento.Value;
                evento.cidadeEvento = txtCidadeEvento.Text;
                evento.inicio = TimeSpan.Parse(maskedTextBoxInicio.Text);
                evento.termino = TimeSpan.Parse(maskedTextBoxTermino.Text);
                evento.tema = txtTema.Text;
                evento.observacao = txtComplementar.Text;
                evento.totalEvento = (auxiliarBrinquedo + auxiliarDecoracao + auxiliarServico + acrescimo) - desconto;
                evento.parametro = 1;
                //inserido o codigo do evento gravado
                codEvento = eventoNegocio.InserirEvento(evento);

                /*componente responsável por buscar os registros "checados"
                 * e adicionar em uma lista de objeto
                 */
                for (int i = 0; i < brinquedoColecao.Count; i++)
                {                    
                    if(checkedListBoxBrinquedos.GetItemChecked(i) == true)
                    {
                        EventoBrinquedo eventoBrinquedo = new EventoBrinquedo();
                        eventoBrinquedo.codBrinquedo = Convert.ToInt32(brinquedoColecao[i].codBrinquedo);
                        eventoBrinquedo.codEvento = Convert.ToInt32(codEvento);

                        eventoBrinquedoColecao.Add(eventoBrinquedo);
                    }
                }

                for (int i = 0; i < decoracaoColecao.Count; i++)
                {
                    if (checkedListBoxDecoracao.GetItemChecked(i) == true)
                    {
                        EventoDecoracao eventoDecoracao = new EventoDecoracao();

                        eventoDecoracao.codDecoracao = Convert.ToInt32(decoracaoColecao[i].codDecoracao);
                        eventoDecoracao.codEvento = Convert.ToInt32(codEvento);

                        eventoDecoracaoColecao.Add(eventoDecoracao);
                    }
                }

                for (int i = 0; i < servicoColecao.Count; i++)
                {
                    if (checkedListBoxServicos.GetItemChecked(i) == true)
                    {
                        EventoServico eventoServico = new EventoServico();

                        eventoServico.codServico = Convert.ToInt32(servicoColecao[i].codServico);
                        eventoServico.codEvento = Convert.ToInt32(codEvento);

                        eventoServicoColecao.Add(eventoServico);
                    }
                }

                //gravando os registros de "brinquedos", "decoração" e "serviço".
                string codEventoBrinquedo = eventoNegocio.InserirEventoBrinquedo(eventoBrinquedoColecao);

                string codEventoDecoracao = eventoNegocio.InserirEventoDecoracao(eventoDecoracaoColecao);

                string codEventoServico = eventoNegocio.InserirEventoServico(eventoServicoColecao);

                try
                {
                    int codEventoInteiro = Convert.ToInt32(codEvento);
                    int codEventoBrinquedoInteiro = Convert.ToInt32(codEventoBrinquedo);
                    int codEventoDecoracaoInteiro = Convert.ToInt32(codEventoDecoracao);
                    int codEventoServicoInteiro = Convert.ToInt32(codEventoServico);

                    MessageBox.Show("Evento gravado com sucesso.", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Erro ao gravar evento.\nContate o Administrador.", "Erro ao gravar evento.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                       
            }
            catch
            {
                MessageBox.Show("Erro ao gravar evento.\nContate o Administrador.", "Erro ao gravar evento.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        //Método para contar os listar os brinquedos "Checados" pelo usuário
        private void checkedListBoxBrinquedos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int i = checkedListBoxBrinquedos.SelectedIndex;
            //ele irá verificar o status do item(antes de ser clicado), se estiver marcado, retorna true
            if(checkedListBoxBrinquedos.GetItemChecked(i) == false)
                auxiliarBrinquedo = auxiliarBrinquedo + brinquedoColecao[i].valor;
            else
                auxiliarBrinquedo = auxiliarBrinquedo - brinquedoColecao[i].valor;
                
            totalEvento();
        }
        //Método para contar os listar as decorações "Checados" pelo usuário
        private void checkedListBoxDecoracao_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int i = checkedListBoxDecoracao.SelectedIndex;
            if (checkedListBoxDecoracao.GetItemChecked(i) == false)
                auxiliarDecoracao = auxiliarDecoracao + decoracaoColecao[i].valor;
            else
                auxiliarDecoracao = auxiliarDecoracao - decoracaoColecao[i].valor;

            totalEvento();
        }
        //Método para contar uma lista de serviços "checados" pelo usuário
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int i = checkedListBoxServicos.SelectedIndex;
            if(checkedListBoxServicos.GetItemChecked(i) == false)
                auxiliarServico = auxiliarServico + servicoColecao[i].valor;
            else
                auxiliarServico = auxiliarServico - servicoColecao[i].valor;

            totalEvento();
        }

        public void totalEvento()
        {
            txtTotalEvento.Text = string.Format("{0:N}", (auxiliarBrinquedo + auxiliarDecoracao + auxiliarServico + acrescimo) - desconto).ToString();
        }
        private void btnAplicarDesconto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDesconto.Text != "0,00" || txtDesconto.Text != "0")
                    btnAplicarDesconto.Enabled = false;                 
                desconto = Convert.ToDouble(txtDesconto.Text);
                valorTotal = -valorTotal - (desconto - auxiliarBrinquedo - auxiliarDecoracao - auxiliarServico); 
                txtTotalEvento.Text = string.Format("{0:N}", valorTotal);
                valorTotal = 0;                
            }
            catch
            {
                MessageBox.Show("Erro ao aplicar desconto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDesconto_Click(object sender, EventArgs e)
        {
            
            string replica = string.Empty;

            replica = txtDesconto.Text.Replace(",", "").Replace(",", "");
            if (replica.Equals(""))
                replica = "";
            replica = replica.PadLeft(3, '0');
            if (replica.Length > 3 && replica.Substring(0, 1) == "0")
                replica = replica.Substring(1, replica.Length - 1);
            txtDesconto.Text = string.Format("{0:N}", "");
            txtDesconto.SelectionStart = txtTotalEvento.Text.Length;
        }
        //Método para desabilitar/habilitar botao de acrescimo
        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            if (btnAplicarDesconto.Enabled == false)
                btnAplicarDesconto.Enabled = true;
            if(txtDesconto.Text == "0,00" || txtDesconto.Text == "0")
            {
                txtAcrescimo.Enabled = true;
                btnAcrescimo.Enabled = true;
            }
            else
            {
                txtAcrescimo.Enabled = false;
                btnAcrescimo.Enabled = false;
            }
        }        

        private void btnAcrescimo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAcrescimo.Text != "0,00" || txtAcrescimo.Text != "0")
                    btnAcrescimo.Enabled = false;
                acrescimo = Convert.ToDouble(txtAcrescimo.Text);
                valorTotal = valorTotal + (acrescimo + auxiliarBrinquedo + auxiliarDecoracao + auxiliarServico);
                txtTotalEvento.Text = string.Format("{0:N}", valorTotal);
                valorTotal = 0;
            }
            catch
            {
                MessageBox.Show("Erro ao aplicar acréscimo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Método para desabilitar
        private void txtAcrescimo_TextChanged(object sender, EventArgs e)
        {
            if (btnAcrescimo.Enabled == false)
                btnAcrescimo.Enabled = true;
            if (txtAcrescimo.Text == "0,00" || txtAcrescimo.Text == "0")
            {
                txtDesconto.Enabled = true;
                btnAplicarDesconto.Enabled = true;
            }
            else
            {
                txtDesconto.Enabled = false;
                btnAplicarDesconto.Enabled = false;
            }
        }

        private void txtAcrescimo_Click(object sender, EventArgs e)
        {
            string replica = string.Empty;

            replica = txtDesconto.Text.Replace(",", "").Replace(",", "");
            if (replica.Equals(""))
                replica = "";
            replica = replica.PadLeft(3, '0');
            if (replica.Length > 3 && replica.Substring(0, 1) == "0")
                replica = replica.Substring(1, replica.Length - 1);
            txtAcrescimo.Text = string.Format("{0:N}", "");
            txtAcrescimo.SelectionStart = txtTotalEvento.Text.Length;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {            
            gravarEvento();

            if (MessageBox.Show("Deseja gerar o contrato deste evento?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmVisualizadorContrato fvc = new FrmVisualizadorContrato(codEvento);
                fvc.Show();
                limparEventos();
            }
            else
                return;
        }

        public void limparEventos()
        {
            txtCliente.Text = "";
            txtAniversariante.Text = "";
            txtLocal.Text = "";
            dateTimePickerDataEvento.Value = DateTime.Now;
            maskedTextBoxInicio.Text = "";
            maskedTextBoxTermino.Text = "";
            txtTema.Text = "";
            txtComplementar.Text = "";
            txtTotalEvento.Text = "0.00";
            txtDesconto.Text = "0.00";
            txtAcrescimo.Text = "0.00";
            txtValorEvento.Text = "0.00";
            checkedListBoxBrinquedos.ClearSelected();
            checkedListBoxDecoracao.ClearSelected();
            checkedListBoxServicos.ClearSelected();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparEventos();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparEventos();
        }

        private void btnCancelarEvento_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if(tabControl.SelectedIndex.Equals(4))
            {
                StringBuilder msg = new StringBuilder();
                //Exibindo extrato dos brinquedos
                msg.AppendLine("BRINQUEDOS:");
                msg.AppendLine();
                Brinquedo brinquedo = new Brinquedo();
                for(int i = 0; i < checkedListBoxBrinquedos.Items.Count; i++)
                {
                    if(checkedListBoxBrinquedos.GetItemChecked(i) == true)
                    {
                        brinquedo = brinquedoColecao[i];
                        msg.AppendLine(brinquedo.nome + "....... R$ " + brinquedo.valor);
                    }                                
                }
                //Exibindo extrato das decorações
                msg.AppendLine();
                msg.AppendLine("DECORAÇÕES:");
                msg.AppendLine();
                Decoracao decoracao = new Decoracao();
                for (int i = 0; i < checkedListBoxDecoracao.Items.Count; i++)
                {
                    if (checkedListBoxDecoracao.GetItemChecked(i) == true)
                    {
                        decoracao = decoracaoColecao[i];
                        msg.AppendLine(decoracao.nome + "....... R$ " + decoracao.valor);
                    }
                }
                //Exibindo extrato dos serviços
                msg.AppendLine();
                msg.AppendLine("SERVIÇOS:");
                msg.AppendLine();
                Servico servico = new Servico();
                for (int i = 0; i < checkedListBoxServicos.Items.Count; i++)
                {
                    if (checkedListBoxServicos.GetItemChecked(i) == true)
                    {
                        servico = servicoColecao[i];
                        msg.AppendLine(servico.descricao + "....... R$ " + servico.valor);
                    }
                }
                txtExtrato.Text = msg.ToString();
            }
        }
    }
}