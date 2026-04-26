namespace SportsonView.API.Dto.OrdenCentralDTO
{
    public class OrderItemDto
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