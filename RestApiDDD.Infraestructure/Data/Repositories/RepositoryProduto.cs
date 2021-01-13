using RestApiDDD.Domain.Core.Interfaces.Repositories;
using RestApiDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiDDD.Infraestructure.Data.Repositories
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly SqlContext sqlContext;

        public RepositoryProduto(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
