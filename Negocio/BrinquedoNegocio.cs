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
    public class BrinquedoNegocio
    {
        //instanciar classe de conexao no banco e manipulação
        AcessaDadosSqlServer acessaDadosSqlServer = new AcessaDadosSqlServer();
        //Método para inserir Brinquedo
        public string InserirBrinquedo(Brinquedo brinquedo)
        {
            try
            {
                //limpando parametro
                acessaDadosSqlServer.limparParametro();
                //adicionando parametros
                acessaDadosSqlServer.adicionarParametro("@nome", brinquedo.nome);
                acessaDadosSqlServer.adicionarParametro("@dataCadastro", brinquedo.cadastro);
                acessaDadosSqlServer.adicionarParametro("@ativo", brinquedo.ativo);
                acessaDadosSqlServer.adicionarParametro("@valor", brinquedo.valor);
                acessaDadosSqlServer.adicionarParametro("@estoque", brinquedo.estoque);
                acessaDadosSqlServer.adicionarParametro("@controlaEstoque", brinquedo.controlaEstoque);
                //executar inserção
                string codCliente = acessaDadosSqlServer.executarManipulacao(CommandType.StoredProcedure, "SP_INSERIR_BRINQUEDO").ToString();

                return codCliente;
            }
            catch(Exception e)
            {
                return e.Message;
            }       
        }
        //Método para alterar Brinquedo
        public string AlterarBrinquedo(Brinquedo brinquedo)
        {
            try
            {
                acessaDadosSqlServer.limparParametro();
                acessaDadosSqlServer.adicionarParametro("@nome", brinquedo.nome);
                acessaDadosSqlServer.adicionarParametro("@ativo", brinquedo.ativo);
                acessaDadosSqlServer.adicionarParametro("@codBrinquedo", brinquedo.codBrinquedo);
                acessaDadosSqlServer.adicionarParametro("@valor", brinquedo.valor);
                acessaDadosSqlServer.adicionarParametro("@estoque", brinquedo.estoque);

                string codCliente = acessaDadosSqlServer.executarManipulacao(CommandType.StoredProcedure, "SP_ALTERAR_BRINQUEDO").ToString();

                return codCliente;
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
        //Método para excluir Brinquedo
        public string ExcluirBrinquerdo(Brinquedo brinquedo)
        {
            try
            {
                acessaDadosSqlServer.limparParametro();
                acessaDadosSqlServer.adicionarParametro("@codBrinquedo", brinquedo.codBrinquedo);
                string codCliente = acessaDadosSqlServer.executarManipulacao(CommandType.StoredProcedure, "SP_EXCLUIR_BRINQUEDO").ToString();

                return codCliente;
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        //Método para consultar Brinquedos por nome
        public BrinquedoColecao ConsultarNomeBrinquedo(string nomeBrinquedo)
        {
            try
            {
                BrinquedoColecao bc = new BrinquedoColecao();
                //abastecendo coleção
                acessaDadosSqlServer.limparParametro();
                acessaDadosSqlServer.adicionarParametro("@nome", nomeBrinquedo);
                DataTable dataTableBrinquedo = acessaDadosSqlServer.executarConsulta(CommandType.StoredProcedure,"SP_CONSULTAR_NOME_BRINQUEDO");
                
                foreach(DataRow linha in dataTableBrinquedo.Rows)
                {
                    Brinquedo b = new Brinquedo();
                    //alinhamento
                    b.codBrinquedo = Convert.ToInt32(linha["codBrinquedo"]);
                    b.nome = Convert.ToString(linha["nome"]);
                    b.cadastro = Convert.ToDateTime(linha["dataCadastro"]);
                    b.ativo = Convert.ToBoolean(linha["ativo"]);
                    b.valor = Convert.ToDouble(linha["valor"]);
                    b.estoque = Convert.ToInt32(linha["estoque"]);
                    b.controlaEstoque = Convert.ToBoolean(linha["controlaEstoque"]);
                    //adicionando cliente na coleção
                    bc.Add(b);
                }
                return bc;
            }
            catch(Exception exception)
            {
                throw new Exception("Não foi possivel consultar por nome. Detalhes: " + exception.Message);
            }
        }
    }
}