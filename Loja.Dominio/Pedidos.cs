﻿using System;
using System.Collections.Generic;

namespace Loja.Dominio
{
    public class Pedidos
    {
        public int Id { get; set; }
        public DateTime MyProDataperty { get; set; }
        public virtual List <Produto> Produtos { get; set; }
    }
}