using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Cliente
    {
        //dados do cliente
        public int codCliente { get; set; }
        public string nome { get; set; }
        public string sexo { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public DateTime nascimento { get; set; }
        public DateTime cadastro { get; set; }
        public Boolean ativo { get; set; }
        public string observacao { get; set; }
        public string telefone_residencial { get; set; }
        public string telefone_celular { get; set; }
        public string operadora_celular { get; set; }
        //dados referente a endereço
        public int codEndereco { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
    }
}