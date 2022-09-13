namespace BerthaStore.Application.Models.SearchOrder
{
    public class ItensOrderListResponse
    {
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public float UnitaryPrice { get; set; }
        public float TotalPrice { get; set; }
    }
}
