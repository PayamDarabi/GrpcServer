using CustomerGrpcServer.DataLayer.Repositories;
using CustomerGrpcServer.Mappers;
using CustomerGrpcServer.ServiceLayer.Abstraction;
using CustomerGrpcServer.ServiceLayer.Dtos;
using CustomerGrpcServer.Services;

namespace CustomerGrpcServer.ServiceLayer.Implementation
{
    public class CustomerService : ICustomerService
    {
        CustomerRepository _customerRepository;
        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

        public void Add(CustomerDto customer)
        {
            _customerRepository.Add(customer.ToModel());
        }

        public void Update(CustomerDto customer)
        {
            _customerRepository.Update(customer.ToModel());
        }

        public void Delete(int id)
        {
            _customerRepository.Delete(id);
        }

        public CustomerDto Get(int id)
        {
            var result = _customerRepository.Get(id);
            return result.ToDto();
        }

        public List<CustomerDto> GetAll()
        {
            var result = _customerRepository.GetAll();
            return result.ConvertAll(x => x.ToDto());
        }
    }
}
