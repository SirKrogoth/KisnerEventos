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
    public class DecoracaoNegocio
    {
        AcessaDadosSqlServer acessaDados = new AcessaDadosSqlServer();

        public string InserirDecoracao(Decoracao decoracao)
        {
            try
            {
                acessaDados.limparParametro();
                acessaDados.adicionarParametro("@nome", decoracao.nome);
                acessaDados.adicionarParametro("@dataCadastro", decoracao.cadastro);
                acessaDados.adicionarParametro("@ativo", decoracao.ativo);
                acessaDados.adicionarParametro("@valor", decoracao.valor);

                string codDecoracao = acessaDados.executarManipulacao(CommandType.StoredProcedure, "SP_INSERIR_DECORACAO").ToString();

                return codDecoracao;
            }
            catch(Exception e)
            {
                return e.Message;
            }            
        }

        public string AlterarDecoracao(Decoracao decoracao)
        {
            try
            {
                acessaDados.limparParametro();
                acessaDados.adicionarParametro("@nome", decoracao.nome);
                acessaDados.adicionarParametro("@ativo", decoracao.ativo);
                acessaDados.adicionarParametro("@codDecoracao", decoracao.codDecoracao);
                acessaDados.adicionarParametro("@valor", decoracao.valor);

                string codDecoracao = acessaDados.executarManipulacao(CommandType.StoredProcedure, "SP_ALTERAR_DECORACAO").ToString();

                return codDecoracao;
            }
            catch(Exception e)
            {
                return e.Message;
            }            
        }

        public string ExcluirDecoracao(Decoracao decoracao)
        {
            try
            {
                acessaDados.limparParametro();
                acessaDados.adicionarParametro("@codDecoracao", decoracao.codDecoracao);

                string codDecoracao = acessaDados.executarManipulacao(CommandType.StoredProcedure, "SP_EXCLUIR_DECORACAO").ToString();

                return codDecoracao;
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }

        public DecoracaoColecao ConsultarNomeDecoracao(string nomeDecoracao)
        {
            try
            {
                DecoracaoColecao dc = new DecoracaoColecao();
                
                acessaDados.limparParametro();
                acessaDados.adicionarParametro("@nome", nomeDecoracao);

                DataTable consultaNome = acessaDados.executarConsulta(CommandType.StoredProcedure, "SP_CONSULTA_NOME_DECORACAO");

                foreach(DataRow linha in consultaNome.Rows)
                {
                    Decoracao decoracao = new Decoracao();

                    decoracao.codDecoracao = Convert.ToInt32(linha["codDecoracao"]);
                    decoracao.nome = Convert.ToString(linha["nome"]);
                    decoracao.cadastro = Convert.ToDateTime(linha["dataCadastro"]);
                    decoracao.ativo = Convert.ToBoolean(linha["ativo"]);
                    decoracao.valor = Convert.ToDouble(linha["valor"]);

                    dc.Add(decoracao);
                }

                return dc;
            }
            catch(Exception e)
            {
                throw new Exception("Não foi possível consultar os seus dados. Detalhes: " + e.Message);
            }
        }
    }
}