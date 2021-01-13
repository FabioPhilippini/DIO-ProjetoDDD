using RestApiDDD.Application.DTOS;
using RestApiDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiDDD.Application.Interfaces.Mappers
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> MapperListClientesDto(IEnumerable<Produto> produtos);
        ProdutoDto MapperEntityToDto(Produto produto);
    }
}
