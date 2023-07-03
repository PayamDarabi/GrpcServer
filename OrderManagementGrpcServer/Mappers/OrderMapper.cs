using Google.Protobuf.WellKnownTypes;
using OrderManagementGrpcServer.DataLayer.Models;
using OrderManagementGrpcServer.ServiceLayer.Dtos;

namespace OrderManagementGrpcServer.Mappers
{
    public static class OrderMapper
    {
        public static OrderModel ToModel(this OrderRequest orderRequest)
        {
            return new OrderModel
            {
                Id = orderRequest.Id,
                CreateDate = DateTime.UtcNow,
                CustomerId = orderRequest.CustomerId,
                OrderItems = orderRequest.OrderItems.Select(x => x.ToModel()).ToList()
            };
        }

        public static OrderModel ToModel(this OrderDto orderDto)
        {
            return new OrderModel
            {
                Id = orderDto.Id,
                CustomerId = orderDto.CustomerId,
                CreateDate = DateTime.UtcNow,
                OrderItems = orderDto.OrderItems.ConvertAll(x => x.ToModel())
            };
        }

        public static OrderDto ToDto(this OrderModel orderModel)
        {
            return new OrderDto
            {
                Id = orderModel.Id,
                CustomerId = orderModel.CustomerId,
                CreateDate = orderModel.CreateDate,
                OrderItems = orderModel.OrderItems.ConvertAll(x => x.ToDto())
            };
        }

        public static OrderDto ToDto(this OrderRequest orderRequest)
        {
            return new OrderDto
            {
                Id = orderRequest.Id,
                CustomerId = orderRequest.CustomerId,
                OrderItems = orderRequest.OrderItems.Select(x => x.ToDto()).ToList()
            };
        }
        public static OrderResponse ToResponse(this OrderDto orderDto)
        {
            var response = new OrderResponse
            {
                Id = orderDto.Id,
                CustomerId = orderDto.CustomerId,
                CreateDate = Timestamp.FromDateTime(orderDto.CreateDate),
            };
            response.OrderItems.Add(orderDto.OrderItems.ConvertAll(x => x.ToResponse()));
            return response;
        }
    }
}
