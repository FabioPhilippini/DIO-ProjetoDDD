﻿using RestApiDDD.Application.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiDDD.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDto clienteDto);
        void Update(ClienteDto clienteDto);
        void Remove(ClienteDto clienteDto);

        IEnumerable<ClienteDto> GetAll();
        ClienteDto GetById(int id);
    }
}
