using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//três classes necessárias
using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace Negocio
{
    public class ClienteNegocio
    {
        //instanciar conexao banco
        AcessaDadosSqlServer acessaDadosSqlServer = new AcessaDadosSqlServer();

        public string InserirCliente(Cliente cliente)
        {
            try
            {
                //limpar parametro
                acessaDadosSqlServer.limparParametro();
                //adicionando parametros para inserção de cliente
                acessaDadosSqlServer.adicionarParametro("@nome", cliente.nome);
                if(cliente.sexo == "Masculino")
                    acessaDadosSqlServer.adicionarParametro("@sexo", true);
                else
                    acessaDadosSqlServer.adicionarParametro("@sexo", false);
                acessaDadosSqlServer.adicionarParametro("@rg", cliente.rg);
                acessaDadosSqlServer.adicionarParametro("@cpf", cliente.cpf);
                acessaDadosSqlServer.adicionarParametro("@telefone_residencial", cliente.telefone_residencial);
                if (cliente.telefone_celular == null && cliente.operadora_celular == null)
                {
                    acessaDadosSqlServer.adicionarParametro("@telefone_celular", 0);
                    acessaDadosSqlServer.adicionarParametro("@operadora_celular", "Nao informado");
                }
                else
                {
                    acessaDadosSqlServer.adicionarParametro("@telefone_celular", cliente.telefone_celular);
                    acessaDadosSqlServer.adicionarParametro("@operadora_celular", cliente.operadora_celular);
                }
                acessaDadosSqlServer.adicionarParametro("@email", cliente.email);
                acessaDadosSqlServer.adicionarParametro("@nascimento", cliente.nascimento);
                acessaDadosSqlServer.adicionarParametro("@ativo", cliente.ativo);
                acessaDadosSqlServer.adicionarParametro("@observacao", cliente.observacao);

                string codCliente = acessaDadosSqlServer.executarManipulacao(CommandType.StoredProcedure, "SP_INSERIR_CLIENTE").ToString();

                int novoCodCliente = Convert.ToInt32(codCliente);
                //limpando parametros
                acessaDadosSqlServer.limparParametro();
                //adicionando parametros para inserção de endereco
                acessaDadosSqlServer.adicionarParametro("@codCliente", novoCodCliente);
                acessaDadosSqlServer.adicionarParametro("@rua", cliente.rua);
                acessaDadosSqlServer.adicionarParametro("@numero", cliente.numero);
                acessaDadosSqlServer.adicionarParametro("@bairro", cliente.bairro);
                acessaDadosSqlServer.adicionarParametro("@cidade", cliente.cidade);
                acessaDadosSqlServer.adicionarParametro("@estado", cliente.estado);
                acessaDadosSqlServer.adicionarParametro("@cep", cliente.cep);

                string codEndereco = acessaDadosSqlServer.executarManipulacao(CommandType.StoredProcedure, "SP_INSERIR_CLIENTE_ENDERECO").ToString();

                return codCliente;
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
        public ClienteColecao ConsultarNomeCliente(string clienteNome)
        {
            try
            {
                ClienteColecao clienteColecao = new ClienteColecao();

                acessaDadosSqlServer.limparParametro();
                acessaDadosSqlServer.adicionarParametro("@nome", clienteNome);
                //criando estrutura para receber dados do banco
                DataTable dataTableCliente = acessaDadosSqlServer.executarConsulta(CommandType.StoredProcedure, "SP_CONSULTAR_NOME_CLIENTE");

                foreach(DataRow linha in dataTableCliente.Rows)
                {
                    Cliente cliente = new Cliente();

                    cliente.codCliente = Convert.ToInt32(linha["codCliente"]);
                    cliente.nome = Convert.ToString(linha["nome"]);
                    if (linha["sexo"].Equals(true))
                        cliente.sexo = "Masculino";
                    else
                        cliente.sexo = "Feminino";
                    cliente.rg = Convert.ToString(linha["rg"]);
                    cliente.cpf = Convert.ToString(linha["cpf"]);
                    cliente.email = Convert.ToString(linha["email"]);
                    cliente.ativo = Convert.ToBoolean(linha["ativo"]);
                    cliente.observacao = Convert.ToString(linha["observacao"]);
                    cliente.telefone_residencial = Convert.ToString(linha["telefone_residencial"]);
                    cliente.telefone_celular = Convert.ToString(linha["telefone_celular"]);
                    cliente.operadora_celular = Convert.ToString(linha["operadora_celular"]);
                    cliente.nascimento = Convert.ToDateTime(linha["nascimento"]);
                    cliente.cadastro = Convert.ToDateTime(linha["data_cadastro"]);
                    cliente.rua = Convert.ToString(linha["rua"]);
                    cliente.numero = Convert.ToInt32(linha["numero"]);
                    cliente.bairro = Convert.ToString(linha["bairro"]);
                    cliente.cidade = Convert.ToString(linha["cidade"]);
                    cliente.estado = Convert.ToString(linha["estado"]);
                    cliente.cep = Convert.ToString(linha["cep"]);

                    clienteColecao.Add(cliente);
                }

                return clienteColecao;
            }
            catch(Exception e)
            {
                throw new Exception("Não foi possível consultar dados.\nVerifique se está com o serviço do SQL ativo.\nDetalhe: " + e.Message);
            }        
         }

        public String AlterarCliente(Cliente cliente)
        {
            try
            {
                //limpar parametro
                acessaDadosSqlServer.limparParametro();
                //adicionando parametros para inserção de cliente
                acessaDadosSqlServer.adicionarParametro("@codCliente", cliente.codCliente);
                acessaDadosSqlServer.adicionarParametro("@nome", cliente.nome);
                if(cliente.sexo == "Masculino")
                    acessaDadosSqlServer.adicionarParametro("@sexo", true);
                else
                    acessaDadosSqlServer.adicionarParametro("@sexo", false);
                acessaDadosSqlServer.adicionarParametro("@rg", cliente.rg);
                acessaDadosSqlServer.adicionarParametro("@cpf", cliente.cpf);
                acessaDadosSqlServer.adicionarParametro("@telefone_residencial", cliente.telefone_residencial);
                if (cliente.telefone_celular == null && cliente.operadora_celular == null)
                {
                    acessaDadosSqlServer.adicionarParametro("@telefone_celular", 0);
                    acessaDadosSqlServer.adicionarParametro("@operadora_celular", "Nao informado");
                }
                else
                {
                    acessaDadosSqlServer.adicionarParametro("@telefone_celular", cliente.telefone_celular);
                    acessaDadosSqlServer.adicionarParametro("@operadora_celular", cliente.operadora_celular);
                }
                acessaDadosSqlServer.adicionarParametro("@email", cliente.email);
                acessaDadosSqlServer.adicionarParametro("@nascimento", cliente.nascimento);
                acessaDadosSqlServer.adicionarParametro("@ativo", cliente.ativo);
                acessaDadosSqlServer.adicionarParametro("@observacao", cliente.observacao);
                acessaDadosSqlServer.adicionarParametro("@data_cadastro", cliente.cadastro);

                string codCliente = acessaDadosSqlServer.executarManipulacao(CommandType.StoredProcedure, "SP_ALTERAR_CLIENTE").ToString();

                int novoCodCliente = Convert.ToInt32(codCliente);
                //limpando parametros
                acessaDadosSqlServer.limparParametro();
                //adicionando parametros para inserção de endereco
                acessaDadosSqlServer.adicionarParametro("@codCliente", novoCodCliente);
                acessaDadosSqlServer.adicionarParametro("@rua", cliente.rua);
                acessaDadosSqlServer.adicionarParametro("@numero", cliente.numero);
                acessaDadosSqlServer.adicionarParametro("@bairro", cliente.bairro);
                acessaDadosSqlServer.adicionarParametro("@cidade", cliente.cidade);
                acessaDadosSqlServer.adicionarParametro("@estado", cliente.estado);
                acessaDadosSqlServer.adicionarParametro("@cep", cliente.cep);

                string codEndereco = acessaDadosSqlServer.executarManipulacao(CommandType.StoredProcedure, "SP_ALTERAR_CLIENTE_ENDERECO").ToString();

                return codCliente;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public String ExcluirCliente(Cliente cliente)
        {
            try
            {
                acessaDadosSqlServer.limparParametro();
                acessaDadosSqlServer.adicionarParametro("@codCliente", cliente.codCliente);

                string retorno = acessaDadosSqlServer.executarManipulacao(CommandType.StoredProcedure, "SP_EXCLUIR_CLIENTE_ENDERECO").ToString();

                retorno = null;
                retorno = acessaDadosSqlServer.executarManipulacao(CommandType.StoredProcedure, "SP_EXCLUIR_CLIENTE").ToString();
                return retorno;
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
    }
}