namespace CustomerGrpcServer.ServiceLayer.Dtos
{
    public class OrderDto
    {
        public OrderDto()
        {
            OrderItems = new();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreateDate { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }
    }
}
