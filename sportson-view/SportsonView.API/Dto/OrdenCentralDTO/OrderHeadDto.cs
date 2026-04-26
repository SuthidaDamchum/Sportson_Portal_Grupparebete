namespace SportsonView.API.Dto.OrdenCentralDTO
{
    public class OrderHeadDto
    {
        public string OrderNo { get; set; }
        public string OrderDate { get; set; }
        public string OrderStatusText { get; set; }
        public string OrderType { get; set; }
        public bool FailedRulesCheck { get; set; }
        public List<string> FailedRulesMessages { get; set; }
        public decimal TotalGrossAmount { get; set; }
        public CustomerDto Customer { get; set; }
        public ShopDto NewShop { get; set; }
    }
}