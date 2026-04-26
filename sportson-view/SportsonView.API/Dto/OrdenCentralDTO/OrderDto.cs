namespace SportsonView.API.Dto.OrdenCentralDTO
{
    public class OrderDto
    {
        public OrderHeadDto OrderHead { get; set; }
        public List<OrderItemDto> Items { get; set; }

    }
}