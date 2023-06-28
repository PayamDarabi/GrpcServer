namespace CustomerGrpcServer.DataLayer.Models
{
    public class OrderModel
    {
        public OrderModel()
        {
            OrderItems = new List<OrderItemModel>();
        }
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreateDate { get; set; }
        public List<OrderItemModel> OrderItems { get; set; }
    }
}
