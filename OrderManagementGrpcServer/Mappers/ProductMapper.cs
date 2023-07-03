using OrderManagementGrpcServer.DataLayer.Models;
using OrderManagementGrpcServer.ServiceLayer.Dtos;

namespace OrderManagementGrpcServer.Mappers
{
    public static class ProductMapper
    {
        public static ProductModel ToModel(this ProductRequest productRequest)
        {
            return new ProductModel
            {
                Id = productRequest.Id,
                Name = productRequest.Name,
                Price = productRequest.Price,
            };
        }

        public static ProductModel ToModel(this ProductDto productDto)
        {
            return new ProductModel
            {
                Price = productDto.Price,
                Name = productDto.Name,
                Id = productDto.Id
            };
        }

        public static ProductDto ToDto(this ProductModel productModel)
        {
            return new ProductDto
            {
                Price = productModel.Price,
                Id = productModel.Id,
                Name = productModel.Name,
            };
        }

        public static ProductDto ToDto(this ProductRequest productRequest)
        {
            return new ProductDto
            {
                Price = productRequest.Price,
                Id = productRequest.Id,
                Name = productRequest.Name,
            };
        }
        public static ProductResponse ToResponse(this ProductDto productDto)
        {
            return new ProductResponse
            {
                Price = productDto.Price,
                Id = productDto.Id,
                Name = productDto.Name,
            };
        }

    }
}
