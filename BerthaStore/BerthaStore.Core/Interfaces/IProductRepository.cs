using System.Collections.Generic;
using System.Threading.Tasks;
using BerthaStore.Core.Entities;

namespace BerthaStore.Core.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task New(Product product);
    }
}
