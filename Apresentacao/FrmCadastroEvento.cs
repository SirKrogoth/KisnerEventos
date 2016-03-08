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
        PagamentoNegocio pgtoNegocio = new PagamentoNegocio();
        EventoCarrinhoColecao eventoCarrinhoColecao = new EventoCarrinhoColecao();
        EstoqueNegocio estoqueNegocio = new EstoqueNegocio();

        public Cliente clienteSelecionado = null;
        public int codCliente = 0;
        public double valorTotal = 0;
        public double desconto = 0;
        public double acrescimo = 0;
        public double auxiliarDescontoAcrescimo = 0;
        public double auxiliarBrinquedo = 0;
        public double auxiliarDecoracao = 0;
        public double auxiliarServico = 0;
        public string codEvento = null;

        //Método construtor para o evento de alterar
        public FrmCadastroEvento(EnumeradorEvento acao, Evento eventoSelecionado)
        {
            InitializeComponent();

            if (acao == EnumeradorEvento.Alterar)
            {
                EventoNegocio eventoNegocio = new EventoNegocio();

                txtCodigo.Text = eventoSelecionado.codEvento.ToString();
                txtCliente.Text = eventoSelecionado.nomeCliente;
                codCliente = eventoSelecionado.codCliente;
                txtAniversariante.Text = eventoSelecionado.nome;
                txtLocal.Text = eventoSelecionado.localEvento;
                txtCidadeEvento.Text = eventoSelecionado.cidadeEvento;
                dateTimePickerDataEvento.Value = Convert.ToDateTime(eventoSelecionado.data_evento);
                maskedTextBoxInicio.Text = eventoSelecionado.inicio.ToString();
                maskedTextBoxTermino.Text = eventoSelecionado.termino.ToString();
                txtTema.Text = eventoSelecionado.tema;
                txtComplementar.Text = eventoSelecionado.observacao;
                btnGravar.Text = "Alterar";
                btnLimpar.Text = "Reimprimir";
                btnLimpar.Image = Properties.Resources.reimprimir;
                //Image.FromFile("Imagens/reimprimir.png");                
                btnNovo.Enabled = false;
                btnCancelarEvento.Enabled = true;
                
                //Pegar os dados de brinquedos e inserir no checkedListBoxBrinquedos
                BrinquedoColecao brinquedoColecaoGenerico = new BrinquedoColecao();
                brinquedoColecaoGenerico = eventoNegocio.BuscarEventoBrinquedo(eventoSelecionado.codEvento);
                
                brinquedoColecao = brinquedoNegocio.ConsultarNomeBrinquedo("");

                for (int i = 0; i < brinquedoColecao.Count; i++)
                {
                    checkedListBoxBrinquedos.Items.Add(brinquedoColecao[i].nome);
                }

                double auxiliarPrecoTotalBrinquedo = 0;

                for (int i = 0; i < brinquedoColecaoGenerico.Count; i++)
                {
                    for (int x = 0; x < brinquedoColecao.Count; x++)
                    {
                        if (brinquedoColecaoGenerico[i].nome == brinquedoColecao[x].nome)
                        {
                            checkedListBoxBrinquedos.SetItemChecked(x, true);
                            auxiliarPrecoTotalBrinquedo += brinquedoColecaoGenerico[i].valor;
                        }
                    }
                }
                //Pegar os dados de decoração e inserir no checkedListBoxDecoracoes
                DecoracaoColecao decoracaoColecaoGenerico = new DecoracaoColecao();
                decoracaoColecaoGenerico = eventoNegocio.BuscarEventoDecoracao(eventoSelecionado.codEvento);

                decoracaoColecao = decoracaoNegocio.ConsultarNomeDecoracao("");

                for (int i = 0; i < decoracaoColecao.Count; i++)
                {
                    checkedListBoxDecoracao.Items.Add(decoracaoColecao[i].nome);
                }

                double auxiliarPrecoTotalDecoracao = 0;

                for (int i = 0; i < decoracaoColecaoGenerico.Count; i++)
                {
                    for (int x = 0; x < decoracaoColecao.Count; x++)
                    {
                        if (decoracaoColecaoGenerico[i].nome == decoracaoColecao[x].nome)
                        {
                            checkedListBoxDecoracao.SetItemChecked(x, true);
                            auxiliarPrecoTotalDecoracao += decoracaoColecaoGenerico[i].valor;
                        }
                    }
                }
                //Pegar os dados de serviço e inserir no checkedListBoxServicos
                ServicoColecao servicoColecaoGenerico = new ServicoColecao();
                servicoColecaoGenerico = eventoNegocio.BuscarEventoServico(eventoSelecionado.codEvento);

                servicoColecao = servicoNegocio.ConsultarNome("");

                for (int i = 0; i < servicoColecao.Count; i++)
                {
                    checkedListBoxServicos.Items.Add(servicoColecao[i].nome);
                }

                double auxiliarPrecoTotalServico = 0;

                for (int i = 0; i < servicoColecaoGenerico.Count; i++)
                {
                    for (int x = 0; x < servicoColecao.Count; x++)
                    {
                        if (servicoColecaoGenerico[i].nome == servicoColecao[x].nome)
                        {
                            checkedListBoxServicos.SetItemChecked(x, true);
                            auxiliarPrecoTotalServico += servicoColecaoGenerico[i].valor;
                        }
                    }
                }
                //Código para buscar apenas o total do (evento + acrescimos) - descontos
                object retorno = eventoNegocio.BuscarValorTotalEvento(eventoSelecionado.codEvento);

                txtTotalEvento.Text = retorno.ToString();                    
                txtValorEvento.Text = (auxiliarPrecoTotalBrinquedo + auxiliarPrecoTotalDecoracao + auxiliarPrecoTotalServico).ToString();
            }
            else
                MessageBox.Show("Erro ao carregar dados.\nContate o Administrador do sistema.","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                checkedListBoxServicos.Items.Add(linha.nome);
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
                //evento.totalEvento = (auxiliarBrinquedo + auxiliarDecoracao + auxiliarServico + acrescimo) - desconto;
                evento.totalEvento = totalEvento();
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
                //Preenchendo quantidade segundo o dgvCarrinho de brinquedo
                for(int i = 0; i < dgvCarrinho.RowCount; i++)
                {                    
                    if(dgvCarrinho[0,i].Value.ToString() == "Brinquedo")
                    {
                        eventoBrinquedoColecao[i].quantidade = Convert.ToInt32(dgvCarrinho[colQuantidadeEvento.Index,i].Value);
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

                //Preenchendo quantidade segundo o dgvCarrinho de Decoração
                int x = 0;
                for (int i = 0; i < dgvCarrinho.RowCount; i++)
                {
                    if (dgvCarrinho[0,i].Value.ToString() == "Decoração")
                    {                        
                        eventoDecoracaoColecao[x].quantidade = Convert.ToInt32(dgvCarrinho[colQuantidadeEvento.Index, i].Value);
                        x++;
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

                //Preenchendo quantidade segundo o dgvCarrinho de Serviço
                int y = 0;
                for (int i = 0; i < dgvCarrinho.RowCount; i++)
                {
                    if (dgvCarrinho[0, i].Value.ToString() == "Serviço")
                    {
                        eventoServicoColecao[y].quantidade = Convert.ToInt32(dgvCarrinho[colQuantidadeEvento.Index, i].Value);
                        y++;
                    }
                }

                //Inserir forma de pagamento ao objeto
                PagamentoColecao pgtoColecao = new PagamentoColecao();
                for(int i = 0; i < dgvFormaPagamento.RowCount; i++)
                {
                    if(dgvFormaPagamento[2,i].Value.ToString() != "0".ToString())
                    {
                        PagamentoFormas pgtoFormas = new PagamentoFormas();

                        pgtoFormas.codPagamento = Convert.ToInt32(dgvFormaPagamento[0, i].Value);//codigo
                        pgtoFormas.nome = dgvFormaPagamento[1, i].Value.ToString();//Nome Forma
                        pgtoFormas.valor = Convert.ToInt32(dgvFormaPagamento[2, i].Value);//Valor pgto na forma selecionada

                        pgtoColecao.Add(pgtoFormas);
                    }
                }


                //gravando os registros de "brinquedos", "decoração" e "serviço".
                string codEventoBrinquedo = eventoNegocio.InserirEventoBrinquedo(eventoBrinquedoColecao);

                string codEventoDecoracao = eventoNegocio.InserirEventoDecoracao(eventoDecoracaoColecao);

                string codEventoServico = eventoNegocio.InserirEventoServico(eventoServicoColecao);

                pgtoNegocio.fCadastrarFormaPagamento(pgtoColecao, codEvento);

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
        //private void checkedListBoxBrinquedos_ItemCheck(object sender, ItemCheckEventArgs e)
        //{
        //    if(btnCancelarEvento.Enabled == true && btnGravar.Text == "Alterar")
        //    {
        //        int i = e.Index;
        //        //ele irá verificar o status do item(antes de ser clicado), se estiver marcado, retorna true
        //        if (checkedListBoxBrinquedos.GetItemChecked(i) == false)
        //            auxiliarBrinquedo = auxiliarBrinquedo + brinquedoColecao[i].valor;
        //        else
        //            auxiliarBrinquedo = auxiliarBrinquedo - brinquedoColecao[i].valor;
        //    }
        //    else
        //    {
        //        int i = checkedListBoxBrinquedos.SelectedIndex;
        //        //ele irá verificar o status do item(antes de ser clicado), se estiver marcado, retorna true
        //        if (checkedListBoxBrinquedos.GetItemChecked(i) == false)
        //            auxiliarBrinquedo = auxiliarBrinquedo + brinquedoColecao[i].valor;
        //        else
        //            auxiliarBrinquedo = auxiliarBrinquedo - brinquedoColecao[i].valor;
        //    }            
                
        //    totalEvento();
        //}
        ////Método para contar os listar as decorações "Checados" pelo usuário
        //private void checkedListBoxDecoracao_ItemCheck(object sender, ItemCheckEventArgs e)
        //{
        //    if(btnCancelarEvento.Enabled == true && btnGravar.Text == "Alterar")
        //    {
        //        int i = e.Index;
        //        if (checkedListBoxDecoracao.GetItemChecked(i) == false)
        //            auxiliarDecoracao = auxiliarDecoracao + decoracaoColecao[i].valor;
        //        else
        //            auxiliarDecoracao = auxiliarDecoracao - decoracaoColecao[i].valor;

        //    }
        //    else
        //    {
        //        int i = checkedListBoxDecoracao.SelectedIndex;
        //        if (checkedListBoxDecoracao.GetItemChecked(i) == false)
        //            auxiliarDecoracao = auxiliarDecoracao + decoracaoColecao[i].valor;
        //        else
        //            auxiliarDecoracao = auxiliarDecoracao - decoracaoColecao[i].valor;
        //    }
            
        //    totalEvento();
        //}
        ////Método para contar uma lista de serviços "checados" pelo usuário
        //private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        //{
        //    if (btnCancelarEvento.Enabled == true && btnGravar.Text == "Alterar")
        //    {

        //        int i = e.Index;
        //        if (checkedListBoxServicos.GetItemChecked(i) == false)
        //            auxiliarServico = auxiliarServico + servicoColecao[i].valor;
        //        else
        //            auxiliarServico = auxiliarServico - servicoColecao[i].valor;
        //    }
        //    else
        //    {
        //        int i = checkedListBoxServicos.SelectedIndex;
        //        if (checkedListBoxServicos.GetItemChecked(i) == false)
        //            auxiliarServico = auxiliarServico + servicoColecao[i].valor;
        //        else
        //            auxiliarServico = auxiliarServico - servicoColecao[i].valor;
        //    }

        //    totalEvento();
        //}

        //public void totalEvento()
        //{
        //    double total = 0;
        //    for (int i = 0; i < dgvCarrinho.RowCount; i++ )
        //    {
        //        double valor = Convert.ToDouble(dgvCarrinho["colValor", i].Value);
        //        double quantidade = Convert.ToDouble(dgvCarrinho["colQuantidadeEvento", i].Value);
                
        //        total = total + (valor * quantidade);

        //        txtValorEvento.Text = string.Format("{0:N}", total.ToString());
        //        txtTotalEvento.Text = string.Format("{0:N}", (total + acrescimo + auxiliarDescontoAcrescimo) - desconto).ToString();
        //    }                
        //}

        public double totalEvento()
        {
            double valorTotalEvento = 0;

            for(int i = 0; i < eventoCarrinhoColecao.Count; i++)
            {
                valorTotalEvento = valorTotalEvento + (eventoCarrinhoColecao[i].estoqueTemporario * eventoCarrinhoColecao[i].valor); 
            }

            txtTotalEvento.Text = (valorTotalEvento + acrescimo - desconto).ToString();
            txtValorEvento.Text = valorTotalEvento.ToString();

            return valorTotalEvento + acrescimo - desconto;
        }

        public void descontoTotal()
        {
            try
            {
                if (txtDesconto.Text != "0,00" || txtDesconto.Text != "0")
                    btnAplicarDesconto.Enabled = false;
                desconto = Convert.ToDouble(txtDesconto.Text);
                totalEvento();
            }
            catch
            {
                MessageBox.Show("Erro ao aplicar desconto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAplicarDesconto_Click(object sender, EventArgs e)
        {
            descontoTotal();
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

        public void acrescimoTotal()
        {
            try
            {
                if (txtAcrescimo.Text != "0,00" || txtAcrescimo.Text != "0")
                    btnAcrescimo.Enabled = false;
                acrescimo = Convert.ToDouble(txtAcrescimo.Text);
                totalEvento();
            }
            catch
            {
                MessageBox.Show("Erro ao aplicar acréscimo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAcrescimo_Click(object sender, EventArgs e)
        {
            acrescimoTotal();
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
            if(btnGravar.Text == "Alterar" && btnCancelarEvento.Enabled == true)
            {
                Evento evento = new Evento();
                EventoBrinquedoColecao eventoBrinquedoColecao = new EventoBrinquedoColecao();
                EventoDecoracaoColecao eventoDecoracaoColecao = new EventoDecoracaoColecao();
                EventoServicoColecao eventoServicoColecao = new EventoServicoColecao();
                EventoNegocio eventoNegocio = new EventoNegocio();

                //verificar se existe cliente selecionado
                if (txtCliente.Text == null)
                {
                    MessageBox.Show("Favor, selecione um cliente.", "Erro ao gravar evento.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                evento.codEvento = Convert.ToInt32(txtCodigo.Text);
                if (clienteSelecionado != null)
                    evento.codCliente = Convert.ToInt32(clienteSelecionado.codCliente);
                else
                    evento.codCliente = codCliente;
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
                //Atualizando os dados do evento
                eventoNegocio.AlterarEvento(evento);
                //Atualizando os dados dos brinquedos deste evento
                for (int i = 0; i < brinquedoColecao.Count; i++)
                {
                    if (checkedListBoxBrinquedos.GetItemChecked(i) == true)
                    {
                        EventoBrinquedo eventoBrinquedo = new EventoBrinquedo();
                        eventoBrinquedo.codBrinquedo = Convert.ToInt32(brinquedoColecao[i].codBrinquedo);
                        eventoBrinquedo.codEvento = Convert.ToInt32(codEvento);
                        eventoBrinquedo.quantidade = Convert.ToInt32(dgvCarrinho.Columns["ColQuantidade"]);
                        eventoBrinquedoColecao.Add(eventoBrinquedo);
                    }
                }

                eventoNegocio.AlterarEventoBrinquedo(eventoBrinquedoColecao, evento.codEvento);

                //Atualizando os dados das decorações deste evento
                for (int i = 0; i < decoracaoColecao.Count; i++ )
                {
                    if(checkedListBoxDecoracao.GetItemChecked(i) == true)
                    {
                        EventoDecoracao eventoDecoracao = new EventoDecoracao();
                        eventoDecoracao.codDecoracao = Convert.ToInt32(decoracaoColecao[i].codDecoracao);
                        eventoDecoracao.codEvento = Convert.ToInt32(codEvento);

                        eventoDecoracaoColecao.Add(eventoDecoracao);
                    }
                }

                eventoNegocio.AlterarEventoDecoracao(eventoDecoracaoColecao, evento.codEvento);

                //Atualizando os dados dos serviços deste evento
                for (int i = 0; i < servicoColecao.Count; i++ )
                {
                    if(checkedListBoxServicos.GetItemChecked(i) == true)
                    {
                        EventoServico eventoServico = new EventoServico();
                        eventoServico.codEvento = Convert.ToInt32(codEvento);
                        eventoServico.codServico = Convert.ToInt32(servicoColecao[i].codServico);

                        eventoServicoColecao.Add(eventoServico);
                    }
                }

                eventoNegocio.AlterarEventoServico(eventoServicoColecao, evento.codEvento);

                MessageBox.Show("Evento atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult retornoCliente = MessageBox.Show("Deseja reemprimir o contrato deste evento com os dados atualizados?", "Pergunta?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (retornoCliente == DialogResult.Yes)
                {
                    FrmVisualizadorContrato fvc = new FrmVisualizadorContrato(evento.codEvento.ToString());
                    fvc.Show();
                    limparEventos();
                }
                else
                    limparEventos();
                this.Close();
            }
            else
            {
                if(verificaCarrinho() == true)
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
                else
                {
                    MessageBox.Show("Existem informações não exibidas no Grid \"Carrinho\". Favor verificar se foram informados as quantidades do(s) produto(s) corretamente.", "Erro ao gravar dados.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }            
        }

        public bool verificaCarrinho()
        {
            try
            {
                //Verifica se o carrinho está vazio.
                if(dgvCarrinho.RowCount == 0)
                    return false;
                else
                {
                    //Verifica se as informações do carrinho estão com quantidade "zero"
                    for(int i = 0; i < dgvCarrinho.RowCount; i++)
                        if (dgvCarrinho[colQuantidadeEvento.Index, i].Value == null)
                            return false;
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Erro ao gravar dados.\nContate o administrador.", "Erro Fatal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
            if (btnLimpar.Text == "Limpar" && btnGravar.Text == "Gravar")
                limparEventos();
            else
            {
                FrmVisualizadorContrato fvc = new FrmVisualizadorContrato(txtCodigo.Text);

                fvc.Show();
            }
        }

        private void btnCancelarEvento_Click(object sender, EventArgs e)
        {
            EventoNegocio eventoNegocio = new EventoNegocio();
            Evento evento = new Evento();

            evento.codEvento = Convert.ToInt32(txtCodigo.Text);

            eventoNegocio.EventoCancelado(evento);
            DialogResult retorno = MessageBox.Show("Você tem certeja que deseja cancelar este evento?", "Pergunta?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
                MessageBox.Show("Evento cancelado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            EventoCarrinhoColecao eventoCarrinhoColecaoAuxiliar = new EventoCarrinhoColecao();

            if(tabControl.SelectedIndex.Equals(4))
            {
                dgvCarrinho.AutoGenerateColumns = false;

                if(eventoCarrinhoColecao.Count == (checkedListBoxBrinquedos.CheckedItems.Count + checkedListBoxDecoracao.CheckedItems.Count + checkedListBoxServicos.CheckedItems.Count))
                {
                    dgvCarrinho.DataSource = null;
                    dgvCarrinho.DataSource = eventoCarrinhoColecao;
                    dgvCarrinho.Update();
                    dgvCarrinho.Refresh();
                }
                else
                {
                    eventoCarrinhoColecao.Clear();
                    //Preenchendo o eventoCarrinhoColecao com as informações de Brinquedos
                    for (int i = 0; i < checkedListBoxBrinquedos.Items.Count; i++)
                    {
                        if (checkedListBoxBrinquedos.GetItemChecked(i) == true)
                        {                            
                            EventoCarrinho eventoCarrinho = new EventoCarrinho();

                            eventoCarrinho.tabela = "Brinquedo";
                            eventoCarrinho.nome = brinquedoColecao[i].nome;
                            eventoCarrinho.valor = brinquedoColecao[i].valor;
                            eventoCarrinho.estoque = brinquedoColecao[i].estoque;
                            object retorno = estoqueNegocio.estoqueDisponivelBrinquedo(brinquedoColecao[i].codBrinquedo, dateTimePickerDataEvento.Value);

                            try
                            {
                                //Transformando o valor objeto para string
                                string auxiliar = retorno.ToString();
                                //verificando se a string não está vazia
                                if (!auxiliar.Equals(""))
                                {
                                    
                                    int quantidadeLocada = Convert.ToInt32(retorno);
                                    eventoCarrinho.estoqueDisponivel = brinquedoColecao[i].estoque - quantidadeLocada;
                                    eventoCarrinhoColecao.Add(eventoCarrinho);
                                }
                                else
                                {                                    
                                    eventoCarrinho.estoqueDisponivel = brinquedoColecao[i].estoque;
                                    eventoCarrinhoColecao.Add(eventoCarrinho);                                                                                                            
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Erro ao buscar informações no banco de dados quanto ao brinquedo: " + brinquedoColecao[i].nome, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    //Preenchendo o eventoCarrinhoColecao com as informações de Decorações
                    for (int i = 0; i < checkedListBoxDecoracao.Items.Count; i++)
                    {
                        if (checkedListBoxDecoracao.GetItemChecked(i) == true)
                        {
                            EventoCarrinho eventoCarrinho = new EventoCarrinho();

                            eventoCarrinho.tabela = "Decoração";
                            eventoCarrinho.nome = decoracaoColecao[i].nome;
                            eventoCarrinho.valor = decoracaoColecao[i].valor;
                            eventoCarrinho.estoque = decoracaoColecao[i].estoque;
                            object retorno = estoqueNegocio.estoqueDisponivelDecoracao(decoracaoColecao[i].codDecoracao, dateTimePickerDataEvento.Value);

                            try
                            {
                                //Transformando o valor objeto para string
                                string auxiliar = retorno.ToString();
                                //verificando se a string não está vazia
                                if (!auxiliar.Equals(""))
                                {
                                    int quantidadeLocada = Convert.ToInt32(retorno);
                                    eventoCarrinho.estoqueDisponivel = decoracaoColecao[i].estoque - quantidadeLocada;
                                    eventoCarrinhoColecao.Add(eventoCarrinho);
                                }
                                else
                                {
                                    eventoCarrinho.estoqueDisponivel = decoracaoColecao[i].estoque;
                                    eventoCarrinhoColecao.Add(eventoCarrinho);
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Erro ao buscar informações no banco de dados quanto ao brinquedo: " + brinquedoColecao[i].nome, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    //Preenchendo o eventoCarrinhoColecao com as informações de Serviço
                    for (int i = 0; i < checkedListBoxServicos.Items.Count; i++)
                    {
                        if (checkedListBoxServicos.GetItemChecked(i) == true)
                        {
                            EventoCarrinho eventoCarrinho = new EventoCarrinho();

                            eventoCarrinho.tabela = "Serviço";
                            eventoCarrinho.nome = servicoColecao[i].nome;
                            eventoCarrinho.valor = servicoColecao[i].valor;
                            eventoCarrinho.estoque = servicoColecao[i].estoque;
                            object retorno = estoqueNegocio.estoqueDisponivelServico(servicoColecao[i].codServico, dateTimePickerDataEvento.Value);

                            try
                            {
                                //Transformando o valor objeto para string
                                string auxiliar = retorno.ToString();
                                //verificando se a string não está vazia
                                if (!auxiliar.Equals(""))
                                {
                                    int quantidadeLocada = Convert.ToInt32(retorno);
                                    eventoCarrinho.estoqueDisponivel = servicoColecao[i].estoque - quantidadeLocada;
                                    eventoCarrinhoColecao.Add(eventoCarrinho);
                                }
                                else
                                {
                                    eventoCarrinho.estoqueDisponivel = servicoColecao[i].estoque;
                                    eventoCarrinhoColecao.Add(eventoCarrinho);
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Erro ao buscar informações no banco de dados quanto ao brinquedo: " + brinquedoColecao[i].nome, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    dgvCarrinho.DataSource = null;
                    dgvCarrinho.DataSource = eventoCarrinhoColecao;
                    dgvCarrinho.Update();
                    dgvCarrinho.Refresh();
                }               
            }
            else if(tabControl.SelectedIndex.Equals(5))
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
                        msg.AppendLine(servico.nome + "....... R$ " + servico.valor);
                    }
                }
                txtExtrato.Text = msg.ToString();
            }
            else if(tabControl.SelectedIndex.Equals(6))
            {
                totalEvento();
                atualizarGridPagamento();
            }
        }
        private void tabControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void FrmCadastroEvento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void btnNovo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void btnLimpar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void btnCancelarEvento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void btnGravar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
        }

        private void txtDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                descontoTotal();
        }

        private void txtAcrescimo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                acrescimoTotal();
        }

        private void tabControl_Deselected(object sender, TabControlEventArgs e)
        {
            //Quando sair da tela de Carrinho, irá setar as informações do usuário.
            if(e.TabPageIndex == 4)
            {
                for(int i = 0; i < eventoCarrinhoColecao.Count; i++)
                {
                    eventoCarrinhoColecao[i].estoqueTemporario = Convert.ToInt32(dgvCarrinho[colQuantidadeEvento.Index,i].Value);
                }
            }
        }

        public void atualizarGridPagamento()
        {
            dgvFormaPagamento.AutoGenerateColumns = false;
            PagamentoNegocio pagamentoNegocio = new PagamentoNegocio();

            try
            {
                dgvFormaPagamento.DataSource = null;
                dgvFormaPagamento.DataSource = pagamentoNegocio.ExibirFormasPagamentos();
                dgvFormaPagamento.Update();
                dgvFormaPagamento.Refresh();
            }
            catch
            {
                MessageBox.Show("Erro ao carregar registros de pagamento.", "Erro pagamento.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}