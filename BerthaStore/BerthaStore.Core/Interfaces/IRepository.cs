using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerthaStore.Core.Interfaces
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();  
    }
}
