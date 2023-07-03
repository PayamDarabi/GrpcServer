using OrderManagementGrpcServer.DataLayer.Models;

namespace OrderManagementGrpcServer.DataLayer.Repositories
{
    public class OrderRepository
    {
        private static List<OrderModel> Orders;
        public OrderRepository()
        {
            if (Orders == null)
            {
                Orders = new();
            }
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
            var order = Orders.FirstOrDefault(x => x.Id == id);
            if (order != null)
            {
                Orders.Remove(order);
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
