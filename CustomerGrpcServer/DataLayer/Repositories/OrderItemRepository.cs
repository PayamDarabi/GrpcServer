using CustomerGrpcServer.DataLayer.Models;

namespace CustomerGrpcServer.DataLayer.Repositories
{
    public class OrderItemRepository
    {
        private static List<OrderItemModel> OrderItems;
        public OrderItemRepository()
        {
            OrderItems = new();
        }
        public void Add(OrderItemModel orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public void Update(OrderItemModel orderItemModel)
        {
            var orderItem = OrderItems.FirstOrDefault(x => x.Id == orderItemModel.Id);
            if (orderItem != null)
            {
                OrderItems.Remove(orderItem);
                OrderItems.Add(orderItem);
            }
        }

        public void Delete(int id)
        {
            var orderItem = OrderItems.FirstOrDefault(x => x.Id == id);
            if (orderItem != null)
            {
                OrderItems.Remove(orderItem);
            }
        }

        public OrderItemModel Get(int id)
        {
            var orderItem = OrderItems.FirstOrDefault(x => x.Id == id);
            return orderItem;
        }

        public List<OrderItemModel> GetAll()
        {
            return OrderItems;
        }
    }
}
