using OrderManagementGrpcServer.DataLayer.Repositories;
using OrderManagementGrpcServer.Mappers;
using OrderManagementGrpcServer.ServiceLayer.Abstraction;
using OrderManagementGrpcServer.ServiceLayer.Dtos;

namespace OrderManagementGrpcServer.ServiceLayer.Implementation
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

        public void AddRange(List<OrderItemDto> orderItems)
        {
            _orderItemRepository.AddRange(orderItems.ConvertAll(x => x.ToModel()));
        }

        public void Delete(int id)
        {
            _orderItemRepository.Delete(id);
        }

        public void DeleteByOrderId(int orderId)
        {
            _orderItemRepository.DeleteByOrderId(orderId);
        }

        public OrderItemDto Get(int id)
        {
            return _orderItemRepository.Get(id).ToDto();
        }

        public List<OrderItemDto> GetByOrderId(int orderId)
        {
            return _orderItemRepository.GetByOrderId(orderId).ConvertAll(x => x.ToDto());
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
