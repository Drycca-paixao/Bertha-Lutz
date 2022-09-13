using System.Collections.Generic;

namespace BerthaStore.Application.Models.UpdateOrder
{
    public class UpdateOrderRequest
    {
        public int IdOrder { get; set; }
        public int IdClient { get; set; }
        public string PaymentType { get; set; }
        public List<UpdateItemOrderRequest> UpdateItemOrderRequest { get; set; }
    }
}
