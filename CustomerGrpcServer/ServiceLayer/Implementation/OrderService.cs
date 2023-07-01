using CustomerGrpcServer.DataLayer.Repositories;
using CustomerGrpcServer.Mappers;
using CustomerGrpcServer.ServiceLayer.Abstraction;
using CustomerGrpcServer.ServiceLayer.Dtos;

namespace CustomerGrpcServer.ServiceLayer.Implementation
{
    public class OrderService : IOrderService
    {
        OrderRepository _orderRepository;
        OrderItemRepository _orderItemRepository;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
            _orderItemRepository = new OrderItemRepository();
        }

        public void Add(OrderDto order)
        {
            _orderRepository.Add(order.ToModel());
        }

        public void Delete(int id)
        {
            _orderRepository.Delete(id);
        }

        public OrderDto Get(int id)
        {
            var order = _orderRepository.Get(id);
            order.OrderItems = _orderItemRepository.GetByOrderId(id);
            return order.ToDto();
        }

        public List<OrderDto> GetAll()
        {
            var orders = _orderRepository.GetAll();
            foreach (var order in orders)
            {
                order.OrderItems = _orderItemRepository.GetByOrderId(order.Id);
            }
            return orders.ConvertAll(x => x.ToDto());
        }

        public void Update(OrderDto product)
        {
            _orderRepository.Update(product.ToModel());
        }
    }
}
