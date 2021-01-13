using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiDDD.Application.DTOS
{
    public class ClienteDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }
    }
}
