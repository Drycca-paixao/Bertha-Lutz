using BerthaStore.Core.Entities;
using BerthaStore.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BerthaStore.Infra.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public Task<IEnumerable<Client>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
