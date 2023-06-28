using CustomerGrpcServer.DataLayer.Repositories;
using CustomerGrpcServer.ServiceLayer.Dtos;

namespace CustomerGrpcServer.ServiceLayer.Abstraction
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
