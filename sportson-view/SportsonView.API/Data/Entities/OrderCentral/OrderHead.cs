namespace SportsonView.API.Data.Entities.OrderCentral
{
    public class OrderHead
    {
        public string OrderNo { get; set; }
        public string OrderDate { get; set; }
        public string OrderStatusText { get; set; }
        public string OrderType { get; set; }
        public bool FailedRulesCheck { get; set; }
        public List<string> FailRulesCheckMessages { get; set; }
        public decimal TotalGrossAmount { get; set; }
        public Customer Customer { get; set; }
        public Shop NewShop { get; set; }
    }
}
