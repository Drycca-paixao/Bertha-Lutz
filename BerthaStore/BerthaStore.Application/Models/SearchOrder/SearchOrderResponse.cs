using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerthaStore.Application.Models.SearchOrder
{
    public class SearchOrderResponse
    {
        public int IdItemOrder { get; set; }
        public int IdOrder { get; set; }
        public int IdProduct { get; set; }
        public int Quantity { get; set; }
        public int UnitaryPrice { get; set; }
    }
}
