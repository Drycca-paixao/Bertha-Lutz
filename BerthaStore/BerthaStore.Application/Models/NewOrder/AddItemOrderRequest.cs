namespace BerthaStore.Application.Models.NewOrder
{
    public class AddItemOrderRequest
    {
        public int IdOrder { get; set; }
        public int IdProduct { get; set; }
        public int Quantity { get; set; }
        public int UnitaryPrice { get; set; }
    }
}
