using OrderManagementGrpcServer.ServiceLayer.Dtos;

namespace OrderManagementGrpcServer.ServiceLayer.Abstraction
{
    public interface IOrderItemService
    {
        void Add(OrderItemDto orderItem);
        void Update(OrderItemDto orderItem);
        void Delete(int id);
        OrderItemDto Get(int id);
        List<OrderItemDto> GetAll();
        void AddRange(List<OrderItemDto> orderItems);
        void DeleteByOrderId(int orderId);
        List<OrderItemDto> GetByOrderId(int orderId);
    }
}
