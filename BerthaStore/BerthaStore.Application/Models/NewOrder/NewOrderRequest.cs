using BerthaStore.Application.Models.AddItemOrder;
using System;
using System.Collections.Generic;

namespace BerthaStore.Application.Models.NewOrder
{
    public class NewOrderRequest
    {
        public int IdClient { get; set; }
        public string PaymentType { get; set; }
        public List<AddItemOrderRequest> AddItemOrderRequest { get; set; }
    }
}
