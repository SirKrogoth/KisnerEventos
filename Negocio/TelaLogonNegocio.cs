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
    public class TelaLogonNegocio
    {
        AcessaDadosSqlServer acessaDados = new AcessaDadosSqlServer();
        public string ConsultaUsuario(string login, string senha)
        {            
            try
            {
                acessaDados.limparParametro();
                acessaDados.adicionarParametro("@logon", login);
                acessaDados.adicionarParametro("@senha", senha);

                string retorno = acessaDados.executarManipulacao(CommandType.StoredProcedure, "SP_VERIFICA_USUARIO").ToString();

                return retorno;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}