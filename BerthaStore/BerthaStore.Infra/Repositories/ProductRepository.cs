﻿using BerthaStore.Core.Entities;
using BerthaStore.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerthaStore.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task<IEnumerable<Product>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task New(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
