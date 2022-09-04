using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerthaStore.Application.Models.NewOrder
{
    public class NewOrderRequest
    {
        public int IdOrder { get; set; }
        public int IdClient { get; set; }
        public string PaymentType { get; set; }
        public DateTime ShippingDate { get; set; }
        public float TotalPrice { get; set; }
        public DateTime Created { get; set; }
        public string Status { get; set; }
    }
}
