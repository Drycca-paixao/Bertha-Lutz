using System.Collections.Generic;
using System.Threading.Tasks;
using BerthaStore.Core.Entities;

namespace BerthaStore.Core.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task New(Order order);
        Task New();
    }
}
