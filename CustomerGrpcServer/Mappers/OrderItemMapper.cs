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
                CustomerId = orderItemRequest.CustomerId,
                Id = orderItemRequest.Id,
                ProductId = orderItemRequest.ProductId,
            };
        }

        public static OrderItemModel ToModel(this OrderItemDto orderItemDto)
        {
            return new OrderItemModel
            {
                Id = orderItemDto.Id,
                ProductId = orderItemDto.ProductId,
                CustomerId = orderItemDto.CustomerId
            };
        }

        public static OrderItemDto ToDto(this OrderItemModel orderItemModel)
        {
            return new OrderItemDto
            {
                CustomerId = orderItemModel.CustomerId,
                ProductId = orderItemModel.ProductId,
                Id = orderItemModel.Id,
            };
        }

        public static OrderItemDto ToDto(this OrderItemRequest orderItemRequest)
        {
            return new OrderItemDto
            {
                CustomerId = orderItemRequest.CustomerId,
                ProductId = orderItemRequest.ProductId,
                Id = orderItemRequest.Id,
            };
        }
        
        public static OrderItemResponse ToResponse(this OrderItemDto orderItemDto)
        {
            return new OrderItemResponse
            {
                Id = orderItemDto.Id,
                ProductId = orderItemDto.ProductId,
                CustomerId = orderItemDto.CustomerId,
            };
        }
    }
}
