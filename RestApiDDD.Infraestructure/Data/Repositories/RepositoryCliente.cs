using RestApiDDD.Domain.Core.Interfaces.Repositories;
using RestApiDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiDDD.Infraestructure.Data.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext sqlContext;

        public RepositoryCliente(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
