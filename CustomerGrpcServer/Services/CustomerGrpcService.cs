using CustomerGrpcServer.Mappers;
using CustomerGrpcServer.ServiceLayer.Abstraction;
using CustomerGrpcServer.ServiceLayer.Implementation;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace CustomerGrpcServer.Services
{
    public class CustomerGrpcService : Customer.CustomerBase
    {
        private readonly ICustomerService _customerService;
        private readonly ILogger<CustomerGrpcService> _logger;

        public CustomerGrpcService(ICustomerService customerService, ILogger<CustomerGrpcService> logger)
        {
            _logger = logger;
            _customerService = customerService;
        }
        public override Task<CustomerReply> Add(CustomerRequest request, ServerCallContext context)
        {
            _customerService.Add(request.ToDto());
            return Task.FromResult(new CustomerReply
            {
                Customer = new CustomerResponse
                {
                    Age = request.Age,
                    Id = request.Id,
                    Name = request.Name,
                },
                IsSuccess = true,
                Message = $"Customer with Id:{request.Id} added successfully..",
            });
        }

        public override Task<CustomerReply> Update(CustomerRequest request, ServerCallContext context)
        {
            _customerService.Update(request.ToDto());
            return Task.FromResult(new CustomerReply
            {
                Customer = new CustomerResponse
                {
                    Age = request.Age,
                    Id = request.Id,
                    Name = request.Name,
                },
                IsSuccess = true,
                Message = $"Customer with Id:{request.Id} updated successfully..",
            });
        }

        public override Task<DeleteCustomerReply> Delete(DeleteCustomerRequest request, ServerCallContext context)
        {
            _customerService.Delete(request.Id);
            return Task.FromResult(new DeleteCustomerReply
            {
                IsSuccess = true,
                Message = $"Customer with Id:{request.Id} deleted successfully..",
            });
        }

        public override Task<CustomerReply> Get(GetCustomerRequest request, ServerCallContext context)
        {
            var customer = _customerService.Get(request.Id);
            if (customer == null)
            {
                return Task.FromResult(new CustomerReply
                {
                    Customer = null,
                    IsSuccess = false,
                    Message = "customer not found"
                });
            }
            return Task.FromResult(new CustomerReply
            {
                Customer = customer.ToResponse(),
                IsSuccess = true,
                Message = "Get customer successful"
            });
        }

        public override Task<CustomersReply> GetAll(Empty empty, ServerCallContext context)
        {
            CustomersReply customersReply = new CustomersReply
            {
                IsSuccess = true,
                Message = "Get All Customers successful"
            };
            customersReply.Customers.AddRange(_customerService.GetAll().ConvertAll(x => x.ToResponse()));
            return Task.FromResult(customersReply);
        }
    }
}