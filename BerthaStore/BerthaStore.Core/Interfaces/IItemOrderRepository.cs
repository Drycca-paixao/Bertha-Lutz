using System.Threading.Tasks;
using BerthaStore.Core.Entities;

namespace BerthaStore.Core.Interfaces
{
    public interface IItemOrderRepository : IRepository<ItemOrder>
    {
        Task Add(ItemOrder ItemOrder);
    }
}
