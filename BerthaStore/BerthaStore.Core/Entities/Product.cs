using System;
using System.Collections.Generic;

namespace BerthaStore.Core.Entities
{
    public class Product
    {
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Storage { get; set; }
        public DateTime Created { get; set; }
        public List<ItemOrder> ItensOrder { get; set; }
    }
}
