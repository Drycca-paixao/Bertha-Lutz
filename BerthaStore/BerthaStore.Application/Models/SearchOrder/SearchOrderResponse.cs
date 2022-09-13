using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerthaStore.Application.Models.SearchOrder
{
    public class SearchOrderResponse
    {
        public int IdOrder { get; set; }
        public int IdClient { get; set; }
        public string PaymentType { get; set; }
        public List<ItensOrderListResponse> ItensOrderList { get; set; }
        public float TotalPrice { get; set; }
        public DateTime Created { get; set; }
        public DateTime ShippingDate { get; set; }
        public string Status { get; set; }
    }
}
