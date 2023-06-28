namespace CustomerGrpcServer.ServiceLayer.Dtos
{
    public class OrderItemDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
    }
}
