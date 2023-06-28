using CustomerGrpcServer.DataLayer.Models;
using CustomerGrpcServer.ServiceLayer.Dtos;
using Google.Protobuf.WellKnownTypes;

namespace CustomerGrpcServer.Mappers
{
    public static class OrderMapper
    {
        public static OrderModel ToModel(this OrderRequest orderRequest)
        {
            return new OrderModel
            {
                Id = orderRequest.Id,
                CreateDate = DateTime.UtcNow,
                OrderItems = orderRequest.OrderItems.Select(x => x.ToModel()).ToList()
            };
        }

        public static OrderModel ToModel(this OrderDto orderDto)
        {
            return new OrderModel
            {
                Id = orderDto.Id,
                CreateDate = DateTime.UtcNow,
                OrderItems = orderDto.OrderItems.ConvertAll(x => x.ToModel())
            };
        }

        public static OrderDto ToDto(this OrderModel orderModel)
        {
            return new OrderDto
            {
                Id = orderModel.Id,
                CreateDate = orderModel.CreateDate,
                OrderItems = orderModel.OrderItems.ConvertAll(x => x.ToDto())
            };
        }

        public static OrderDto ToDto(this OrderRequest orderRequest)
        {
            return new OrderDto
            {
                Id = orderRequest.Id,
                OrderItems = orderRequest.OrderItems.Select(x => x.ToDto()).ToList()
            };
        }
        public static OrderResponse ToResponse(this OrderDto orderDto)
        {
            var response = new OrderResponse
            {
                Id = orderDto.Id,
                CreateDate = Timestamp.FromDateTime(orderDto.CreateDate),
            };
            response.OrderItems.Add(orderDto.OrderItems.ConvertAll(x => x.ToResponse()));
            return response;
        }
    }
}
