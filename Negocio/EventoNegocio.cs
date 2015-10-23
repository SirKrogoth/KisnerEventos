using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data.SqlClient;

namespace Negocio
{
    public class EventoNegocio
    {
        AcessaDadosSqlServer acessaDados = new AcessaDadosSqlServer();

        public string InserirEvento(Evento evento)
        {
            try
            {
                acessaDados.limparParametro();
                acessaDados.adicionarParametro("@nome", evento.nome);
                acessaDados.adicionarParametro("@localEvento", evento.localEvento);
                acessaDados.adicionarParametro("@data_evento", evento.data_evento);
                acessaDados.adicionarParametro("@inicio", evento.inicio);
                acessaDados.adicionarParametro("@termino", evento.termino);
                acessaDados.adicionarParametro("@tema", evento.tema);
                acessaDados.adicionarParametro("@codCliente", evento.codCliente);
                acessaDados.adicionarParametro("@observacao", evento.observacao);
                acessaDados.adicionarParametro("@totalEvento", evento.totalEvento);
                acessaDados.adicionarParametro("@codParametro", evento.parametro);
                acessaDados.adicionarParametro("@concluido", 0);
                acessaDados.adicionarParametro("@cancelado", 0);
                acessaDados.adicionarParametro("@cidadeEvento", evento.cidadeEvento);

                string codEvento = acessaDados.executarManipulacao(CommandType.StoredProcedure, "SP_INSERIR_EVENTO").ToString();

                return codEvento;
            }
            catch(Exception e)
            {
                return e.Message;
            }          
        }

        public string AlterarEvento(Evento evento)
        {
            try
            {
                acessaDados.limparParametro();
                acessaDados.adicionarParametro("@codEvento", evento.codEvento);
                acessaDados.adicionarParametro("@codCliente", evento.codCliente);
                acessaDados.adicionarParametro("@nome", evento.nome);
                acessaDados.adicionarParametro("@local", evento.localEvento);
                acessaDados.adicionarParametro("@data_evento", evento.data_evento);
                acessaDados.adicionarParametro("@cidade", evento.cidadeEvento);
                acessaDados.adicionarParametro("@inicio", evento.inicio);
                acessaDados.adicionarParametro("@termino", evento.termino);
                acessaDados.adicionarParametro("@tema", evento.tema);
                acessaDados.adicionarParametro("@observacao", evento.observacao);
                acessaDados.adicionarParametro("@totalEvento", evento.totalEvento);
                acessaDados.adicionarParametro("@codParametro", evento.parametro);

                string codEvento = acessaDados.executarManipulacao(CommandType.StoredProcedure, "SP_ALTERAR_EVENTO").ToString();

                return codEvento;
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }

        public string ExcluirEvento(Evento evento)
        {
            try
            {
                acessaDados.limparParametro();
                acessaDados.adicionarParametro("@codEvento", evento.codEvento);

                string codEvento = acessaDados.executarManipulacao(CommandType.StoredProcedure, "SP_EXCLUIR_EVENTO").ToString();

                return codEvento;
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }

        public EventoColecao ConsultarNomeEvento(string nomeEvento)
        {
            try
            {
                EventoColecao ec = new EventoColecao();

                acessaDados.limparParametro();
                acessaDados.adicionarParametro("@nome", nomeEvento);

                DataTable retornoBanco = acessaDados.executarConsulta(CommandType.StoredProcedure, "SP_CONSULTAR_NOME_EVENTO");

                foreach(DataRow linha in retornoBanco.Rows)
                {
                    Evento evento = new Evento();

                    evento.codEvento = Convert.ToInt32(linha["codEvento"]);
                    evento.nome = Convert.ToString(linha["nome"]);
                    evento.localEvento = Convert.ToString(linha["localEvento"]);
                    evento.data_evento = Convert.ToDateTime(linha["data_evento"]);
                    evento.inicio = (TimeSpan)linha["inicio"];
                    evento.termino = (TimeSpan)linha["termino"];
                    evento.tema = Convert.ToString(linha["tema"]);
                    evento.codCliente = Convert.ToInt32(linha["codCliente"]);
                    evento.observacao = Convert.ToString(linha["observacao"]);

                    ec.Add(evento);
                }

                return ec;
            }
            catch(Exception e)
            {
                throw new Exception("Não foi possível consultar dados. Detalhes: " + e.Message);
            }
        }
        //Evento independente onde será retornado todos os eventos a serem realizados.
        public EventoColecao ConsultaProximosEventos()
        {
            SqlConnection conexao = acessaDados.criarConexaoBanco();
            try
            {
                //Abrindo conexao com o banco de dados 
                conexao.Open();

                EventoColecao eventoColecao = new EventoColecao();

                DateTime hoje = new DateTime();
                hoje = DateTime.Now;

                string script = "SELECT e.codEvento, e.nome, e.localEvento, e.data_evento, e.inicio, e.termino, e.tema, e.codCliente, e.observacao, e.concluido, e.cancelado, e.cidadeEvento, c.nome AS nomeCliente" +
                    " FROM tblEvento AS e" +
                    " INNER JOIN tblCliente AS c" +
                    " ON e.codCliente = c.codCliente" +
                    " WHERE data_evento >= '" + hoje +
                    "' AND concluido = 0" +
                    " AND cancelado = 0" +
                    " ORDER BY data_evento ASC";

                SqlCommand sql = new SqlCommand(script, conexao);
                //Irá retornar as informações do banco de dados
                SqlDataReader dataReader = sql.ExecuteReader();
                DataTable dataTable = new DataTable();
                //colocando os dados do dataReader dentro de um DataTable
                dataTable.Load(dataReader);
                
                foreach (DataRow linha in dataTable.Rows)
                {
                    Evento evento = new Evento();

                    evento.codEvento = Convert.ToInt32(linha["codEvento"]);
                    evento.nome = Convert.ToString(linha["nome"]);
                    evento.localEvento = Convert.ToString(linha["localEvento"]);
                    evento.data_evento = Convert.ToDateTime(linha["data_evento"]);
                    evento.inicio = (TimeSpan)linha["inicio"];
                    evento.termino = (TimeSpan)linha["termino"];
                    evento.tema = Convert.ToString(linha["tema"]);
                    evento.codCliente = Convert.ToInt32(linha["codCliente"]);
                    evento.observacao = Convert.ToString(linha["observacao"]);
                    evento.concluido = Convert.ToBoolean(linha["concluido"]);
                    evento.cancelado = Convert.ToBoolean(linha["cancelado"]);
                    evento.cidadeEvento = linha["cidadeEvento"].ToString();
                    evento.nomeCliente = linha["nomeCliente"].ToString();

                    eventoColecao.Add(evento);
                }

                return eventoColecao;
            }
            catch(Exception e)
            {
                throw new Exception("Não foi possível consultar dados. Detalhes: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        //Evento independente onde será retornado todos os eventos a serem realizados de forma avançada.
        public EventoColecao ConsultaAvancada(string cliente, string aniversariante, string cidade, DateTime dataDe, DateTime dataPara, bool concluido, bool cancelado)
        {
            SqlConnection conexao = acessaDados.criarConexaoBanco();
            try
            {
                conexao.Open();
                EventoColecao eventoColecao = new EventoColecao();
                string script = "SELECT e.codEvento, e.nome, e.localEvento, e.data_evento, e.inicio, e.termino, e.tema, e.codCliente, e.observacao, e.concluido, e.cancelado, e.cidadeEvento, c.nome AS nomeCliente" + 
                    " FROM tblEvento AS e" +
                    " INNER JOIN tblCliente AS c " +
                    " ON e.codCliente = c.codCliente " +
                    " WHERE c.nome LIKE '%" + cliente + "%' AND e.nome LIKE '%" + aniversariante + "%' AND e.cidadeEvento LIKE '%" + cidade + "%' AND e.data_evento >= '" + dataDe + "' AND e.data_evento <= '" + dataPara + "' AND (e.concluido = '" + concluido + "' OR e.concluido = 'false') AND (e.cancelado = '" + cancelado + "' OR e.cancelado = 'false' )ORDER BY data_evento ASC";
                SqlCommand sql = new SqlCommand(script, conexao);
                SqlDataReader dataReader = sql.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);

                foreach (DataRow linha in dataTable.Rows)
                {
                    Evento evento = new Evento();

                    evento.codEvento = Convert.ToInt32(linha["codEvento"]);
                    evento.nome = linha["nome"].ToString();
                    evento.localEvento = Convert.ToString(linha["localEvento"]);
                    evento.data_evento = Convert.ToDateTime(linha["data_evento"]);
                    evento.inicio = (TimeSpan)linha["inicio"];
                    evento.termino = (TimeSpan)linha["termino"];
                    evento.tema = Convert.ToString(linha["tema"]);
                    evento.codCliente = Convert.ToInt32(linha["codCliente"]);
                    evento.observacao = Convert.ToString(linha["observacao"]);
                    evento.concluido = Convert.ToBoolean(linha["concluido"]);
                    evento.cancelado = Convert.ToBoolean(linha["cancelado"]);
                    evento.cidadeEvento = linha["cidadeEvento"].ToString();
                    evento.nomeCliente = linha["nomeCliente"].ToString();

                    eventoColecao.Add(evento);
                }

                return eventoColecao;

            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public string InserirEventoBrinquedo(EventoBrinquedoColecao eventoBrinquedoColecao)
        {
            try
            {
                string codEventoBrinquedo = "0";

                for(int i = 0; i < eventoBrinquedoColecao.Count; i++)
                {
                    acessaDados.limparParametro();
                    acessaDados.adicionarParametro("@codEvento", eventoBrinquedoColecao[i].codEvento);
                    acessaDados.adicionarParametro("@codBrinquedo", eventoBrinquedoColecao[i].codBrinquedo);
                    //irá retornar o codigo do evento
                    codEventoBrinquedo = acessaDados.executarManipulacao(CommandType.StoredProcedure, "SP_INSERIR_EVENTOBRINQUEDO").ToString();
                }
                
                return codEventoBrinquedo;
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }

        public string InserirEventoDecoracao(EventoDecoracaoColecao eventoDecoracaoColecao)
        {
            try
            {
                string codEventoDecoracao = "0";

                for(int i = 0; i < eventoDecoracaoColecao.Count; i++)
                {
                    acessaDados.limparParametro();
                    acessaDados.adicionarParametro("@codEvento", eventoDecoracaoColecao[i].codEvento);
                    acessaDados.adicionarParametro("@codDecoracao", eventoDecoracaoColecao[i].codDecoracao);

                    codEventoDecoracao = acessaDados.executarManipulacao(CommandType.StoredProcedure, "SP_INSERIR_EVENTODECORACAO").ToString();

                }

                return codEventoDecoracao;
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }

        public string InserirEventoServico(EventoServicoColecao eventoServicoColecao)
        {
            try
            {
                string codEventoServico = "0";

                for(int i = 0; i < eventoServicoColecao.Count; i++)
                {
                    acessaDados.limparParametro();
                    acessaDados.adicionarParametro("@codServico", eventoServicoColecao[i].codServico);
                    acessaDados.adicionarParametro("@codEvento", eventoServicoColecao[i].codEvento);

                    codEventoServico = acessaDados.executarManipulacao(CommandType.StoredProcedure, "SP_INSERIR_EVENTOSERVICO").ToString();

                }

                return codEventoServico;
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
        //Método utilizado para atualizar as informações de Brinquedos
        public void AlterarEventoBrinquedo(EventoBrinquedoColecao eventoBrinquedoColecao, int codEvento)
        {
            SqlConnection conexao = acessaDados.criarConexaoBanco();

            try
            {
                conexao.Open();
                //Primeiramente precisamos excluir todos os dados do evento
                string sqlZerarBrinquedo = "DELETE FROM tblEventoBrinquedo WHERE codEvento = " + codEvento;
                SqlCommand cmdZerarBrinquedo = new SqlCommand(sqlZerarBrinquedo, conexao);
                cmdZerarBrinquedo.ExecuteReader();

                //Aqui, vamos inserir os novos dados desejados pelo cliente
                for(int i = 0; i < eventoBrinquedoColecao.Count; i++)
                {
                    string sqlBrinquedo = "INSERT INTO tblEventoBrinquedo(codEvento,codBrinquedo) " +
                        "VALUES(" + codEvento +",'"+eventoBrinquedoColecao[i].codBrinquedo+"')";
                    SqlCommand cmd = new SqlCommand(sqlBrinquedo, conexao);
                    cmd.ExecuteReader();
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        //Método utilizado para alterar os dados de decoração do evento
        public void AlterarEventoDecoracao(EventoDecoracaoColecao eventoDecoracaoColecao, int codEvento)
        {
            SqlConnection conexao = acessaDados.criarConexaoBanco();
            try
            {
                conexao.Open();
                //Excluindo os dados de evento decoração
                string sqlDelete = "DELETE FROM tblEventoDecoracao WHERE codEvento = " + codEvento;
                SqlCommand cmdDelete = new SqlCommand(sqlDelete, conexao);
                cmdDelete.ExecuteReader();
                //Inserindo os novos registros em evento decoração
                for(int i =0; i < eventoDecoracaoColecao.Count; i++)
                {
                    string sqlDecoracao = "INSERT INTO tblEventoDecoracao(codDecoracao,codEvento) " +
                        "VALUES(" + eventoDecoracaoColecao[i].codDecoracao + ", " + codEvento + " )";
                    SqlCommand cmdDecoracao = new SqlCommand(sqlDecoracao, conexao);
                    cmdDecoracao.ExecuteReader();
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        //Método usado para atualizar as informações de serviços do evento
        public void AlterarEventoServico(EventoServicoColecao eventoServicoColecao, int codEvento)
        {
            SqlConnection conexao = acessaDados.criarConexaoBanco();
            try
            {
                conexao.Open();
                //Excluir os dados existentes para depois substitui-los
                string sqlExcluir = "DELETE FROM tblEventoServico WHERE codEvento = " + codEvento;
                SqlCommand cmdDelete = new SqlCommand(sqlExcluir, conexao);
                cmdDelete.ExecuteReader();
                //Inserindo os novos dados adquiridos pelo sistema.
                for(int i = 0; i < eventoServicoColecao.Count; i++)
                {
                    string sqlServico = "INSERT INTO tblEventoServico(codEvento, codServico) " +
                        "VALUES(" + codEvento + ", " + eventoServicoColecao[i].codServico + ")";
                    SqlCommand cmd = new SqlCommand(sqlServico, conexao);
                    cmd.ExecuteReader();
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public void EventoConcluir(Evento evento)
        {
            SqlConnection conexao = acessaDados.criarConexaoBanco();
            try
            {
                conexao.Open();
                string sql = "UPDATE tblEvento SET concluido = 1 WHERE codEvento = " + evento.codEvento;
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.ExecuteNonQuery();                
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void EventoConcluirDesfazer(Evento evento)
        {
            SqlConnection conexao = acessaDados.criarConexaoBanco();
            try
            {
                conexao.Open();
                string sql = "UPDATE tblEvento SET concluido = 0 WHERE codEvento = " + evento.codEvento;
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        //métodos para cancelar evento
        public void EventoCancelado(Evento evento)
        {
            SqlConnection conexao = acessaDados.criarConexaoBanco();
            try
            {
                conexao.Open();
                string sql = "UPDATE tblEvento SET cancelado = 1 WHERE codEvento = " + evento.codEvento;
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void EventoCanceladoDesfazer(Evento evento)
        {
            SqlConnection conexao = acessaDados.criarConexaoBanco();
            try
            {
                conexao.Open();
                string sql = "UPDATE tblEvento SET cancelado = 0 WHERE codEvento = " + evento.codEvento;
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public BrinquedoColecao BuscarEventoBrinquedo(int codEvento)
        {
            SqlConnection conexao = acessaDados.criarConexaoBanco();
            try
            {
                BrinquedoColecao brinquedoColecao = new BrinquedoColecao();

                conexao.Open();
                string sql = "SELECT b.codBrinquedo, b.nome, b.dataCadastro, b.ativo, b.valor FROM tblBrinquedo AS b " +
                    "INNER JOIN tblEventoBrinquedo AS eb " +
                    "ON b.codBrinquedo = eb.codBrinquedo " +
                    "WHERE codEvento = " + codEvento;
                SqlCommand cmd = new SqlCommand(sql, conexao);
                SqlDataReader dataReader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);

                foreach(DataRow linha in dataTable.Rows)
                {
                    Brinquedo brinquedo = new Brinquedo();

                    brinquedo.codBrinquedo = Convert.ToInt32(linha["codBrinquedo"]);
                    brinquedo.nome = linha["nome"].ToString();
                    brinquedo.cadastro = Convert.ToDateTime(linha["dataCadastro"]);
                    brinquedo.ativo = Convert.ToBoolean(linha["ativo"]);
                    brinquedo.valor = Convert.ToDouble(linha["valor"]);

                    brinquedoColecao.Add(brinquedo);
                }

                return brinquedoColecao;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public DecoracaoColecao BuscarEventoDecoracao(int codEvento)
        {
            SqlConnection conexao = acessaDados.criarConexaoBanco();
            try
            {
                DecoracaoColecao decoracaoColecao = new DecoracaoColecao();
                conexao.Open();
                string sql = "SELECT d.codDecoracao, d.nome, d.ativo, d.valor FROM tblDecoracao AS d " +
                    "INNER JOIN tblEventoDecoracao AS ed " +
                    "ON d.codDecoracao = ed.codDecoracao " +
                    "WHERE ed.codEvento = " + codEvento;

                SqlCommand cmd = new SqlCommand(sql, conexao);
                SqlDataReader dataReader = cmd.ExecuteReader();
                DataTable dataTable = new System.Data.DataTable();

                dataTable.Load(dataReader);

                foreach(DataRow linha in dataTable.Rows)
                {
                    Decoracao decoracao = new Decoracao();
                    
                    decoracao.codDecoracao = Convert.ToInt32(linha["codDecoracao"]);
                    decoracao.nome = linha["nome"].ToString();
                    decoracao.ativo = Convert.ToBoolean(linha["ativo"]);
                    decoracao.valor = Convert.ToDouble(linha["valor"]);

                    decoracaoColecao.Add(decoracao);
                }

                return decoracaoColecao;
                
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public ServicoColecao BuscarEventoServico(int codEvento)
        {
            SqlConnection conexao = acessaDados.criarConexaoBanco();
            try
            {
                ServicoColecao servicoColecao = new ServicoColecao();
                conexao.Open();
                string sql = "SELECT s.codServico, s.descricao, s.valor, s.ativo FROM tblServico AS s " +
                    "INNER JOIN tblEventoServico AS es " +
                    "ON s.codServico = es.codServico " +
                    "WHERE es.codEvento = " + codEvento;

                SqlCommand cmd = new SqlCommand(sql, conexao);
                SqlDataReader dataReader = cmd.ExecuteReader();
                DataTable dataTable = new System.Data.DataTable();

                dataTable.Load(dataReader);

                foreach(DataRow linha in dataTable.Rows)
                {
                    Servico servico = new Servico();

                    servico.codServico = Convert.ToInt32(linha["codServico"]);
                    servico.descricao = linha["descricao"].ToString();
                    servico.valor = Convert.ToDouble(linha["valor"]);
                    servico.ativo = Convert.ToBoolean(linha["ativo"]);

                    servicoColecao.Add(servico);
                }

                return servicoColecao;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public object BuscarValorTotalEvento(int codEvento)
        {
            SqlConnection conexao = acessaDados.criarConexaoBanco();

            try
            {
                conexao.Open();
                string sql = "SELECT totalEvento FROM tblEvento WHERE codEvento = " + codEvento;
                SqlCommand cmd = new SqlCommand(sql, conexao);
                object retorno = cmd.ExecuteScalar();
                return retorno;
                
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}