using CustomerGrpcServer.DataLayer.Repositories;
using CustomerGrpcServer.Mappers;
using CustomerGrpcServer.ServiceLayer.Abstraction;
using CustomerGrpcServer.ServiceLayer.Dtos;
using CustomerGrpcServer.Services;

namespace CustomerGrpcServer.ServiceLayer.Implementation
{
    public class CustomerService : ICustomerService
    {
        public CustomerService()
        {
        }

        public void Add(CustomerDto customer)
        {
            CustomerRepository.Add(customer.ToModel());
        }

        public void Update(CustomerDto customer)
        {
            CustomerRepository.Update(customer.ToModel());
        }

        public void Delete(int id)
        {
            CustomerRepository.Delete(id);
        }

        public CustomerDto Get(int id)
        {
            var result = CustomerRepository.Get(id);
            return result.ToDto();
        }

        public List<CustomerDto> GetAll()
        {
            var result = CustomerRepository.GetAll();
            return result.ConvertAll(x => x.ToDto());
        }
    }
}
