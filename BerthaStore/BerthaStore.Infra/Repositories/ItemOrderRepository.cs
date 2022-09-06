using BerthaStore.Core.Entities;
using BerthaStore.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerthaStore.Infra.Repositories
{
    public class ItemOrderRepository : IItemOrderRepository
    {
        public Task<IEnumerable<ItemOrder>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
