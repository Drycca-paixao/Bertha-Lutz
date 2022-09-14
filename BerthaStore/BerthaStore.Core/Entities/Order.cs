using System;
using System.Collections.Generic;

namespace BerthaStore.Core.Entities
{
    public class Order
    {
        public int IdOrder { get; set; }
        public int IdClient { get; set; }
        public Client Client { get; set; }
        public List<ItemOrder> ItemOrders { get; set; }
        public string PaymentType { get; set; }
        public DateTime ShippingDate { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Created { get; set; }
        public string Status { get; set; }
    }
}
