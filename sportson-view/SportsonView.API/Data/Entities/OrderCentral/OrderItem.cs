namespace SportsonView.API.Data.Entities.OrderCentral
{
    public class OrderItem
    {
        public string ProductName { get; set; }
        public string PartNo { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int QtyOrdered { get; set; }
        public decimal GrossAmount { get; set; }
        public string ImageLink { get; set; }
    }
}