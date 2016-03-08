﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Servico
    {
        public int codServico{get;set;}
        public string nome { get; set; }
        public double valor { get; set; }
        public DateTime cadastro { get; set; }
        public Boolean ativo { get; set; }
        public int estoque { get; set; }
        public int estoqueDisponivel { get; set; }
        public Boolean controlaEstoque { get; set; }
    }
}
