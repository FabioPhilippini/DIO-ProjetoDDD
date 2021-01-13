using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiDDD.Application.DTOS
{
    public class ClienteDto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }
    }
}
