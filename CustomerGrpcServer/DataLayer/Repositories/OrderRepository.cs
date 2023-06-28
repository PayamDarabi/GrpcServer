using CustomerGrpcServer.DataLayer.Models;

namespace CustomerGrpcServer.DataLayer.Repositories
{
    public class OrderRepository
    {
        private static List<OrderModel> Orders;
        public OrderRepository()
        {
            Orders = new();
        }

        public void Add(OrderModel order)
        {
            Orders.Add(order);
        }

        public void Update(OrderModel orderModel)
        {
            var order = Orders.FirstOrDefault(x => x.Id == orderModel.Id);
            if (order != null)
            {
                Orders.Remove(order);
                Orders.Add(order);
            }
        }

        public void Delete(int id)
        {
            var product = Orders.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                Orders.Remove(product);
            }
        }

        public OrderModel Get(int id)
        {
            var order = Orders.FirstOrDefault(x => x.Id == id);
            return order;
        }

        public List<OrderModel> GetAll()
        {
            return Orders;
        }
    }
}
