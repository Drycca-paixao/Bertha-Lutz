using System;

namespace BerthaStore.Core.Entities
{
    public class Order
    {
        public int idOrder { get ; set; }
        public int idClient { get; set; }
        public string paymentType { get; set; }
        public DateTime shippingDate { get; set; }
        public float totalPrice { get; set; }
        public DateTime created { get; set; }
        public string status { get; set; }

    }
}
