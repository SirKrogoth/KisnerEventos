using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Decoracao
    {
        public int codDecoracao { get; set; }
        public string nome { get; set; }
        public DateTime cadastro { get; set; }
        public Boolean ativo { get; set; }
        public Double valor { get; set; }
    }
}