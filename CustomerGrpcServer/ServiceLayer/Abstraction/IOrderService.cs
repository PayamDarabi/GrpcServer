using CustomerGrpcServer.ServiceLayer.Dtos;

namespace CustomerGrpcServer.ServiceLayer.Abstraction
{
    public interface IOrderService
    {
        void Add(OrderDto orderItem);
        void Update(OrderDto orderItem);
        void Delete(int id);
        OrderDto Get(int id);
        List<OrderDto> GetAll();
    }
}
