﻿using RestApiDDD.Application.DTOS;
using RestApiDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestApiDDD.Application.Mapper
{
    public class MapperProduto
    {
        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                Id = produtoDto.Id,
                Nome = produtoDto.Nome,
                Valor = produtoDto.Valor
            };

            return produto;
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            var produtoDto = new ProdutoDto()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            };
            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListClientesDto(IEnumerable<Produto> produtos)
        {
            var dto = produtos.Select(c => new ProdutoDto
            {
                Id = c.Id,
                Nome = c.Nome,
                Valor = c.Valor
            });
            return dto;
        }
    }
}
