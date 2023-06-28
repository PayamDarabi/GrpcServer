using CustomerGrpcServer.DataLayer.Repositories;
using CustomerGrpcServer.Mappers;
using CustomerGrpcServer.ServiceLayer.Abstraction;
using CustomerGrpcServer.ServiceLayer.Dtos;

namespace CustomerGrpcServer.ServiceLayer.Implementation
{
    public class OrderItemService : IOrderItemService
    {
        OrderItemRepository _orderItemRepository;
        public OrderItemService()
        {
            _orderItemRepository = new OrderItemRepository();
        }

        public void Add(OrderItemDto orderItem)
        {
            _orderItemRepository.Add(orderItem.ToModel());
        }

        public void Delete(int id)
        {
            _orderItemRepository.Delete(id);
        }

        public OrderItemDto Get(int id)
        {
            return _orderItemRepository.Get(id).ToDto();
        }

        public List<OrderItemDto> GetAll()
        {
            return _orderItemRepository.GetAll().ConvertAll(x => x.ToDto());
        }

        public void Update(OrderItemDto orderItem)
        {
            _orderItemRepository.Update(orderItem.ToModel());
        }
    }
}
