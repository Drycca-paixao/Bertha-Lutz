using BerthaStore.Core.Entities;
using BerthaStore.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerthaStore.Infra.Repositories
{
    public class ItemOrderRepository : IItemOrderRepository
    {
        public Task<IEnumerable<ItemOrder>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task New(ItemOrder itemOrder)
        {
            throw new System.NotImplementedException();
        }
    }
}
