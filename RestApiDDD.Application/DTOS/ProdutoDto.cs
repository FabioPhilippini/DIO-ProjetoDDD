using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiDDD.Application.DTOS
{
    public class ProdutoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public double Valor { get; set; }
    }
}
