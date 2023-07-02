using CustomerGrpcServer.DataLayer.Models;
using CustomerGrpcServer.ServiceLayer.Dtos;

namespace CustomerGrpcServer.Mappers
{
    public static class OrderItemMapper
    {
        public static OrderItemModel ToModel(this OrderItemRequest orderItemRequest)
        {
            return new OrderItemModel
            {
                Id = orderItemRequest.Id,
                OrderId = orderItemRequest.OrderId,
                ProductId = orderItemRequest.ProductId,
            };
        }

        public static OrderItemModel ToModel(this OrderItemDto orderItemDto)
        {
            return new OrderItemModel
            {
                Id = orderItemDto.Id,
                OrderId = orderItemDto.OrderId,
                ProductId = orderItemDto.ProductId
            };
        }

        public static OrderItemDto ToDto(this OrderItemModel orderItemModel)
        {
            return new OrderItemDto
            {
                ProductId = orderItemModel.ProductId,
                OrderId = orderItemModel.OrderId,
                Id = orderItemModel.Id,
            };
        }

        public static OrderItemDto ToDto(this OrderItemRequest orderItemRequest)
        {
            return new OrderItemDto
            {
                ProductId = orderItemRequest.ProductId,
                OrderId = orderItemRequest.OrderId,
                Id = orderItemRequest.Id,
            };
        }

        public static OrderItemResponse ToResponse(this OrderItemDto orderItemDto)
        {
            return new OrderItemResponse
            {
                Id = orderItemDto.Id,
                OrderId = orderItemDto.OrderId,
                ProductId = orderItemDto.ProductId,
            };
        }
    }
}
