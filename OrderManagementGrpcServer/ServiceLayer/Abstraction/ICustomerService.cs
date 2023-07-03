using OrderManagementGrpcServer.ServiceLayer.Dtos;

namespace OrderManagementGrpcServer.ServiceLayer.Abstraction
{
    public interface ICustomerService
    {
        void Add(CustomerDto customer);
        void Update(CustomerDto customer);
        void Delete(int id);
        CustomerDto Get(int id);
        List<CustomerDto> GetAll();
    }
}
