using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerthaStore.Application.Models.NewProduct
{
    public class NewProductRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Storage { get; set; }
    }
}
