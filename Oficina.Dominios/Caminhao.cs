﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominios
{
    public class Caminhao : Veiculo
    {
        public QuantidadeEixo QuantidadeEixo { get; set; }

        public override List<string> Validar()
        {
            var erro = ValidarBase();
            return erro;
        }
    }
}
