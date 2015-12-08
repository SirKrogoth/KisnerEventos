using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados;
using System.Data;

namespace Negocio
{
    public class BackupNegocio
    {
        AcessaDadosSqlServer acessaDadosSqlServer = new AcessaDadosSqlServer();
        public int gerarBackupSistema(string nomeBanco, string localSalvo, string nomeArquivo)
        {
            try
            {
                acessaDadosSqlServer.limparParametro();
                acessaDadosSqlServer.adicionarParametro("@banco", nomeBanco);
                acessaDadosSqlServer.adicionarParametro("@localSalvo", localSalvo);
                acessaDadosSqlServer.adicionarParametro("@nomeArquivo", nomeArquivo);
                int retorno = Convert.ToInt32(acessaDadosSqlServer.executarManipulacao(CommandType.StoredProcedure, "SP_CRIAR_BACKUP"));

                return retorno;
            }
            catch(Exception e)
            {
                throw new Exception("Não foi possível gerar um backup de dados válido. Contate o administrador do sistema.\nDetalhes: " + e.Message);
            }

        }
    }
}
