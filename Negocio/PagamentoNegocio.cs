using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ObjetoTransferencia;
using AcessoBancoDados;

namespace Negocio
{
    public class PagamentoNegocio
    {
        AcessaDadosSqlServer acessaDadosSqlServer = new AcessaDadosSqlServer();

        public PagamentoColecao ExibirFormasPagamentos()
        {
            SqlConnection conexao = acessaDadosSqlServer.criarConexaoBanco();
            
            try
            {
                conexao.Open();
                string sql = "SELECT * FROM tblpagamentoFormas";
                SqlCommand cmd = new SqlCommand(sql, conexao);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();

                dataTable.Load(reader);

                PagamentoColecao pagamentoColecao = new PagamentoColecao();
                
                foreach(DataRow linha in dataTable.Rows)
                {
                    PagamentoFormas pagamentoFormas = new PagamentoFormas();

                    pagamentoFormas.codPagamento = Convert.ToInt32(linha["codPagamento"]);
                    pagamentoFormas.nome = linha["nome"].ToString();
                    pagamentoFormas.valor = 0;

                    pagamentoColecao.Add(pagamentoFormas);
                }

                return pagamentoColecao;

            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void fCadastrarFormaPagamento(PagamentoColecao pgtoColecao, string codEvento)
        {
            SqlConnection conexao = acessaDadosSqlServer.criarConexaoBanco();
            try
            {
                conexao.Open();
                
                for(int i = 0; i < pgtoColecao.Count; i++)
                {
                    string sql = "INSERT INTO tblEventoPagamento(codEvento,codPagamento,valor) " +
                        "VALUES(" + Convert.ToInt32(codEvento) + "," + pgtoColecao[i].codPagamento + "," + pgtoColecao[i].valor + ")";
                    SqlCommand cmd = new SqlCommand(sql, conexao);

                    cmd.ExecuteScalar();
                }
            }
            catch(Exception e)
            {
                throw new Exception("Erro ao gravar a forma de pagamento.\nDetalhe: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
