namespace SportsonView.API.Data.Entities.OrderCentral
{
    public class Order
    {
        public OrderHead OrderHead { get; set; }
        public List<OrderItem> Item { get; set; }
    }
}
