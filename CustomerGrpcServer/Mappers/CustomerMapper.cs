using CustomerGrpcServer.DataLayer.Models;
using CustomerGrpcServer.ServiceLayer.Dtos;

namespace CustomerGrpcServer.Mappers
{
    public static class CustomerMapper
    {
        public static CustomerModel ToModel(this CustomerRequest customerRequest)
        {
            return new CustomerModel
            {
                Age = customerRequest.Age,
                Id = customerRequest.Id,
                Name = customerRequest.Name,
            };
        }

        public static CustomerModel ToModel(this CustomerDto customerDto)
        {
            return new CustomerModel
            {
                Age = customerDto.Age,
                Id = customerDto.Id,
                Name = customerDto.Name,
            };
        }

        public static CustomerDto ToDto(this CustomerModel customerModel)
        {
            return new CustomerDto
            {
                Age = customerModel.Age,
                Id = customerModel.Id,
                Name = customerModel.Name,
            };
        }

        public static CustomerDto ToDto(this CustomerRequest customerRequest)
        {
            return new CustomerDto
            {
                Age = customerRequest.Age,
                Id = customerRequest.Id,
                Name = customerRequest.Name,
            };
        }
        public static CustomerResponse ToResponse(this CustomerDto customerDto)
        {
            return new CustomerResponse
            {
                Age = customerDto.Age,
                Id = customerDto.Id,
                Name = customerDto.Name,
            };
        }
    }
}
