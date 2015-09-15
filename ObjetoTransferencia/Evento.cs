using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Evento
    {
        public int codEvento { get; set; }
        public string nome { get; set; }
        public string localEvento { get; set; }
        public DateTime data_evento { get; set; }
        public string cidadeEvento { get; set; }
        public TimeSpan inicio { get; set; }
        public TimeSpan termino { get; set; }
        public string tema { get; set; }
        public int codCliente { get; set; }
        public string observacao { get; set; }
        public double totalEvento { get; set; }
        public int parametro { get; set; }
        public bool concluido { get; set; }
        public bool cancelado { get; set; }
        public string nomeCliente { get; set; }
    }
}
