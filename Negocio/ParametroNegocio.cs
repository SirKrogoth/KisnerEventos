using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class ParametroNegocio
    {
        AcessaDadosSqlServer acessaDados = new AcessaDadosSqlServer();
        public string fAtualiaParametro(Parametro parametro)
        {
            try
            {
                acessaDados.limparParametro();
                acessaDados.adicionarParametro("@razao_social", parametro.razao_social);
                acessaDados.adicionarParametro("@cnpj", parametro.cnpj);
                acessaDados.adicionarParametro("@ie", parametro.ie);
                acessaDados.adicionarParametro("@cpf", parametro.cpf);
                acessaDados.adicionarParametro("@rg", parametro.rg);
                acessaDados.adicionarParametro("@cidade", parametro.cidade);
                acessaDados.adicionarParametro("@estado", parametro.estado);
                acessaDados.adicionarParametro("@fone_principal", parametro.telefone_principal);
                acessaDados.adicionarParametro("@fone_celular", parametro.telefone_celular);
                acessaDados.adicionarParametro("@endereco", parametro.endereco);
                acessaDados.adicionarParametro("@bairro", parametro.bairro);

                string retorno = acessaDados.executarManipulacao(CommandType.StoredProcedure, "SP_ATUALIZAR_PARAMETRO").ToString();

                return retorno;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Parametro fMostrarParametros()
        {
            SqlConnection conexao = acessaDados.criarConexaoBanco();
            try
            {
                conexao.Open();
                Parametro parametro = new Parametro();
                string sql = "SELECT * FROM tblParametros WHERE codParametro = 1";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                SqlDataReader dataReader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();

                dataTable.Load(dataReader);

                foreach(DataRow linha in dataTable.Rows)
                {
                    parametro.razao_social = linha["razao_social"].ToString();
                    parametro.cnpj = linha["cnpj"].ToString();
                    parametro.ie = linha["ie"].ToString();
                    parametro.cpf = linha["cpf"].ToString();
                    parametro.rg = linha["rg"].ToString();
                    parametro.cidade = linha["cidade"].ToString();
                    parametro.estado = linha["estado"].ToString();
                    parametro.telefone_principal = linha["fone_principal"].ToString();
                    parametro.telefone_celular = linha["fone_celular"].ToString();
                    parametro.endereco = linha["endereco"].ToString();
                    parametro.bairro = linha["bairro"].ToString();
                }

                return parametro;
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