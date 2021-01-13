using RestApiDDD.Application.DTOS;
using RestApiDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiDDD.Application.Interfaces.Mappers
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);
        IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);
        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}
