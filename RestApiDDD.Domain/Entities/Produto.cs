﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiDDD.Domain.Entities
{
    public class Produto : Base
    {
        public string Nome { get; set; }

        public double Valor { get; set; }

        public bool IsDisponivel { get; set; }
    }
}
