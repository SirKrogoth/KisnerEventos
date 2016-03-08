using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class EventoCarrinho
    {
        public string nome { get; set; }
        public string tabela { get; set; }
        public double valor { get; set; }
        public int estoque { get; set; }
        public int estoqueDisponivel { get; set; }
        public int estoqueTemporario { get; set; }
    }
}
