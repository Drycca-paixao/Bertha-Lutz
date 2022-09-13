using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerthaStore.Application.Models.SearchOrder
{
    public class ItensOrderListResponse
    {
        public int ProductName { get; set; }
        public int Quantity { get; set; }
        public float UnitaryPrice { get; set; }
        public float TotalPrice { get; set; }
    }
}
