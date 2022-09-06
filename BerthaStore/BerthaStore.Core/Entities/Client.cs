using System;
using System.Collections.Generic;

namespace BerthaStore.Core.Entities
{
    public class Client
    {
        public int IdClient { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Password { get; set; }
        public DateTime created { get; set; }
        public List<Order> Orders { get; set; }
    }
}
