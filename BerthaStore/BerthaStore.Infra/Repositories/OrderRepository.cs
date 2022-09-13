using BerthaStore.Core.Entities;
using BerthaStore.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerthaStore.Infra.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Task<IEnumerable<Order>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task Inserir(Order order)
        {
            throw new System.NotImplementedException();
        }
    }
}
