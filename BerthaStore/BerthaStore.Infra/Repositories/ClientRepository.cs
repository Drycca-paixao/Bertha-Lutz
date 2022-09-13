using BerthaStore.Core.Entities;
using BerthaStore.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerthaStore.Infra.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public Task<IEnumerable<Client>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task Add(Client client)
        {
            throw new System.NotImplementedException();
        }
    }
}
