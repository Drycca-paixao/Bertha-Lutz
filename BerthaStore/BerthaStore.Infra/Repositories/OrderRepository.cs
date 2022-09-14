using BerthaStore.Core.Entities;
using BerthaStore.Core.Interfaces;
using BerthaStore.Infra.Database;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerthaStore.Infra.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationContext _context;

        public OrderRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task New(Order obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public async Task Update(Order obj)
        {
            _context.Update(obj);
            _context.SaveChanges();
        }

        public Task<IEnumerable<Order>> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
