using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data.SqlClient;

namespace Negocio
{
    public class EstoqueNegocio
    {
        AcessaDadosSqlServer acessaDados = new AcessaDadosSqlServer();
        public void executarAjusteEstoqueBrinquedo(int movimento, int quantidade, int codigo, string registroMovimento)
        {
            SqlConnection conexao = acessaDados.criarConexaoBanco();
            try
            {
                conexao.Open();
                string scriptConsultaQuantidade = "SELECT estoque FROM tblBrinquedo WHERE codBrinquedo = " + codigo;
                SqlCommand sqlQuantidade = new SqlCommand(scriptConsultaQuantidade, conexao);
                object objQtdAtual = sqlQuantidade.ExecuteScalar();
                int qtdAtual = Convert.ToInt32(objQtdAtual);

                if(movimento == 1)
                {
                    string scriptAlterandoEstoque = "UPDATE tblBrinquedo SET estoque = " + (qtdAtual + quantidade) + 
                        " WHERE codBrinquedo = " + codigo;

                    registroMovimento = "Incremento de estoque no produto codigo " + codigo.ToString() + " de " + quantidade.ToString() +
                        " quantidades. Registro do usuario: " + registroMovimento;

                    string scriptInserindoHistorico = "INSERT INTO tblHistoricoSistema(tabela,conteudo,data_hora) " +
                        "VALUES('tblBrinquedo', '" + registroMovimento + "','" + DateTime.Now + "')";

                    SqlCommand sqlAlterandoEstoque = new SqlCommand(scriptAlterandoEstoque, conexao);
                    SqlCommand sqlInserindoHistorico = new SqlCommand(scriptInserindoHistorico, conexao);

                    sqlAlterandoEstoque.ExecuteNonQuery();
                    sqlInserindoHistorico.ExecuteNonQuery();
                }
                else
                {
                    string scriptAlterandoEstoque = "UPDATE tblBrinquedo SET estoque = " + (qtdAtual - quantidade) +
                        " WHERE codBrinquedo = " + codigo;

                    registroMovimento = "Saida de estoque no produto codigo " + codigo.ToString() + " de " + quantidade.ToString() +
                        " quantidades. Registro do usuario: " + registroMovimento;

                    string scriptInserindoHistorico = "INSERT INTO tblHistoricoSistema(tabela,conteudo,data_hora) " +
                        "VALUES('tblBrinquedo', '" + registroMovimento + "','" + DateTime.Now + "')";

                    SqlCommand sqlAlterandoEstoque = new SqlCommand(scriptAlterandoEstoque, conexao);
                    SqlCommand sqlInserindoHistorico = new SqlCommand(scriptInserindoHistorico, conexao);

                    sqlAlterandoEstoque.ExecuteNonQuery();
                    sqlInserindoHistorico.ExecuteNonQuery();
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
        public void executarAjusteEstoqueDecoracao(int movimento, int quantidade, int codigo, string registroMovimento)
        {
            SqlConnection conexao = acessaDados.criarConexaoBanco();
            try
            {
                conexao.Open();
                string scriptConsultaQuantidade = "SELECT estoque FROM tblDecoracao WHERE codDecoracao = " + codigo;
                SqlCommand sqlQuantidade = new SqlCommand(scriptConsultaQuantidade, conexao);
                object objQtdAtual = sqlQuantidade.ExecuteScalar();
                int qtdAtual = Convert.ToInt32(objQtdAtual);

                if (movimento == 1)
                {
                    string scriptAlterandoEstoque = "UPDATE tblDecoracao SET estoque = " + (qtdAtual + quantidade) +
                        " WHERE codDecoracao = " + codigo;

                    registroMovimento = "Incremento de estoque no produto codigo " + codigo.ToString() + " de " + quantidade.ToString() +
                        " quantidades. Registro do usuario: " + registroMovimento;

                    string scriptInserindoHistorico = "INSERT INTO tblHistoricoSistema(tabela,conteudo,data_hora) " +
                        "VALUES('tblDecoracao', '" + registroMovimento + "','" + DateTime.Now + "')";

                    SqlCommand sqlAlterandoEstoque = new SqlCommand(scriptAlterandoEstoque, conexao);
                    SqlCommand sqlInserindoHistorico = new SqlCommand(scriptInserindoHistorico, conexao);

                    sqlAlterandoEstoque.ExecuteNonQuery();
                    sqlInserindoHistorico.ExecuteNonQuery();
                }
                else
                {
                    string scriptAlterandoEstoque = "UPDATE tblDecoracao SET estoque = " + (qtdAtual - quantidade) +
                        " WHERE codDecoracao = " + codigo;

                    registroMovimento = "Saida de estoque no produto codigo " + codigo.ToString() + " de " + quantidade.ToString() +
                        " quantidades. Registro do usuario: " + registroMovimento;

                    string scriptInserindoHistorico = "INSERT INTO tblHistoricoSistema(tabela,conteudo,data_hora) " +
                        "VALUES('tblDecoracao', '" + registroMovimento + "','" + DateTime.Now + "')";

                    SqlCommand sqlAlterandoEstoque = new SqlCommand(scriptAlterandoEstoque, conexao);
                    SqlCommand sqlInserindoHistorico = new SqlCommand(scriptInserindoHistorico, conexao);

                    sqlAlterandoEstoque.ExecuteNonQuery();
                    sqlInserindoHistorico.ExecuteNonQuery();
                }
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

        public void executarAjusteEstoqueServico(int movimento, int quantidade, int codigo, string registroMovimento)
        {
            SqlConnection conexao = acessaDados.criarConexaoBanco();
            try
            {
                conexao.Open();
                string scriptConsultaQuantidade = "SELECT estoque FROM tblServico WHERE codServico = " + codigo;
                SqlCommand sqlQuantidade = new SqlCommand(scriptConsultaQuantidade, conexao);
                object objQtdAtual = sqlQuantidade.ExecuteScalar();
                int qtdAtual = Convert.ToInt32(objQtdAtual);

                if (movimento == 1)
                {
                    string scriptAlterandoEstoque = "UPDATE tblServico SET estoque = " + (qtdAtual + quantidade) +
                        " WHERE codServico = " + codigo;

                    registroMovimento = "Incremento de estoque no produto codigo " + codigo.ToString() + " de " + quantidade.ToString() +
                        " quantidades. Registro do usuario: " + registroMovimento;

                    string scriptInserindoHistorico = "INSERT INTO tblHistoricoSistema(tabela,conteudo,data_hora) " +
                        "VALUES('tblServico', '" + registroMovimento + "','" + DateTime.Now + "')";

                    SqlCommand sqlAlterandoEstoque = new SqlCommand(scriptAlterandoEstoque, conexao);
                    SqlCommand sqlInserindoHistorico = new SqlCommand(scriptInserindoHistorico, conexao);

                    sqlAlterandoEstoque.ExecuteNonQuery();
                    sqlInserindoHistorico.ExecuteNonQuery();
                }
                else
                {
                    string scriptAlterandoEstoque = "UPDATE tblServico SET estoque = " + (qtdAtual - quantidade) +
                        " WHERE codServico = " + codigo;

                    registroMovimento = "Saida de estoque no produto codigo " + codigo.ToString() + " de " + quantidade.ToString() +
                        " quantidades. Registro do usuario: " + registroMovimento;

                    string scriptInserindoHistorico = "INSERT INTO tblHistoricoSistema(tabela,conteudo,data_hora) " +
                        "VALUES('tblServico', '" + registroMovimento + "','" + DateTime.Now + "')";

                    SqlCommand sqlAlterandoEstoque = new SqlCommand(scriptAlterandoEstoque, conexao);
                    SqlCommand sqlInserindoHistorico = new SqlCommand(scriptInserindoHistorico, conexao);

                    sqlAlterandoEstoque.ExecuteNonQuery();
                    sqlInserindoHistorico.ExecuteNonQuery();
                }
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
    }
}
