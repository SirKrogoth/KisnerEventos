using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace Negocio
{
    public class ServicoNegocio
    {
        AcessaDadosSqlServer acessaDadosSqlServer = new AcessaDadosSqlServer();

        public String InserirServico(Servico servico)
        {
            try
            {
                acessaDadosSqlServer.limparParametro();
                acessaDadosSqlServer.adicionarParametro("@descricao", servico.descricao);
                acessaDadosSqlServer.adicionarParametro("@valor", servico.valor);
                acessaDadosSqlServer.adicionarParametro("@ativo", servico.ativo);
                acessaDadosSqlServer.adicionarParametro("@data_cadastro", servico.cadastro);
                acessaDadosSqlServer.adicionarParametro("@estoque", servico.estoque);
                acessaDadosSqlServer.adicionarParametro("@controlaEstoque", servico.controlaEstoque);

                string codServico = acessaDadosSqlServer.executarManipulacao(CommandType.StoredProcedure, "SP_INSERIR_SERVICO").ToString();

                return codServico;
            }
            catch(Exception e)
            {
                return e.Message;
            }

        }

        public ServicoColecao ConsultarNome(string nome)
        {
            try
            {
                ServicoColecao servicoColecao = new ServicoColecao();

                acessaDadosSqlServer.limparParametro();
                acessaDadosSqlServer.adicionarParametro("@nome", nome);

                DataTable dataTable = acessaDadosSqlServer.executarConsulta(CommandType.StoredProcedure,"SP_CONSULTAR_NOME_SERVICO");

                foreach(DataRow linha in dataTable.Rows)
                {
                    Servico servico = new Servico();

                    servico.codServico = Convert.ToInt32(linha["codServico"]);
                    servico.descricao = Convert.ToString(linha["descricao"]);
                    servico.valor = Convert.ToDouble(linha["valor"]);
                    servico.ativo = Convert.ToBoolean(linha["ativo"]);
                    servico.cadastro = Convert.ToDateTime(linha["data_cadastro"]);
                    servico.estoque = Convert.ToInt32(linha["estoque"]);
                    servico.controlaEstoque = Convert.ToBoolean(linha["controlaEstoque"]);

                    servicoColecao.Add(servico);
                }

                return servicoColecao;

            }
            catch(Exception e)
            {
                throw new Exception("Não foi possível consultar dados no banco.\nContate o Administrador." + e.Message);
            }
        }

        public String DeletarServico(Servico servico)
        {
            try
            {
                acessaDadosSqlServer.limparParametro();
                acessaDadosSqlServer.adicionarParametro("@codServico", servico.codServico);

                string codServico = acessaDadosSqlServer.executarManipulacao(CommandType.StoredProcedure, "SP_EXCLUIR_SERVICO").ToString();

                return codServico;
            }
            catch(Exception e)
            {
                throw new Exception("Não foi possível deletar serviço.\nContate o Administrador." + e.Message);
            }
        }

        public String AlterarServico(Servico servico)
        {
            try
            {
                acessaDadosSqlServer.limparParametro();
                acessaDadosSqlServer.adicionarParametro("@codServico", servico.codServico);
                acessaDadosSqlServer.adicionarParametro("@descricao", servico.descricao);
                acessaDadosSqlServer.adicionarParametro("@valor", servico.valor);
                acessaDadosSqlServer.adicionarParametro("@ativo", servico.ativo);
                acessaDadosSqlServer.adicionarParametro("@estoque", servico.estoque);

                string codServico = acessaDadosSqlServer.executarManipulacao(CommandType.StoredProcedure, "SP_ALTERAR_SERVICO").ToString();

                return codServico;
            }
            catch(Exception e)
            {
                throw new Exception("Erro ao alterar dados.\nContate o Administrador." + e.Message);
            }
        }
    }
}