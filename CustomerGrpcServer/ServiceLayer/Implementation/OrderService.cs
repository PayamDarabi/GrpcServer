using CustomerGrpcServer.DataLayer.Repositories;
using CustomerGrpcServer.Mappers;
using CustomerGrpcServer.ServiceLayer.Abstraction;
using CustomerGrpcServer.ServiceLayer.Dtos;

namespace CustomerGrpcServer.ServiceLayer.Implementation
{
    public class OrderService : IOrderService
    {
        OrderRepository _orderRepository;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
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
            var result = _orderRepository.Get(id);
            return result.ToDto();
        }

        public List<OrderDto> GetAll()
        {
            var result = _orderRepository.GetAll();
            return result.ConvertAll(x => x.ToDto());
        }

        public void Update(OrderDto product)
        {
            _orderRepository.Update(product.ToModel());
        }
    }
}
