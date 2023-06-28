using CustomerGrpcServer.Mappers;
using CustomerGrpcServer.ServiceLayer.Abstraction;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace CustomerGrpcServer.Services
{
    public class ProductGrpcService : Product.ProductBase
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductGrpcService> _logger;

        public ProductGrpcService(IProductService productService, ILogger<ProductGrpcService> logger)
        {
            _logger = logger;
            _productService = productService;
        }

        public override Task<ProductReply> Add(ProductRequest request, ServerCallContext context)
        {
            _productService.Add(request.ToDto());
            return Task.FromResult(new ProductReply
            {
                Product = new ProductResponse
                {
                    Id = request.Id,
                    Name = request.Name,
                    Price = request.Price,
                },
                IsSuccess = true,
                Message = $"Product with Id:{request.Id} added successfully..",
            });
        }

        public override Task<ProductReply> Update(ProductRequest request, ServerCallContext context)
        {
            _productService.Update(request.ToDto());
            return Task.FromResult(new ProductReply
            {
                Product = new ProductResponse
                {
                    Id = request.Id,
                    Name = request.Name,
                    Price = request.Price,
                },
                IsSuccess = true,
                Message = $"Product with Id:{request.Id} updated successfully..",
            });
        }

        public override Task<DeleteProductReply> Delete(DeleteProductRequest request, ServerCallContext context)
        {
            _productService.Delete(request.Id);
            return Task.FromResult(new DeleteProductReply
            {
                IsSuccess = true,
                Message = $"Product with Id:{request.Id} deleted successfully..",
            });
        }

        public override Task<ProductReply> Get(GetProductRequest request, ServerCallContext context)
        {
            var product = _productService.Get(request.Id);
            if (product == null)
            {
                return Task.FromResult(new ProductReply
                {
                    Product = null,
                    IsSuccess = false,
                    Message = "product not found"
                });
            }
            return Task.FromResult(new ProductReply
            {
                Product = product.ToResponse(),
                IsSuccess = true,
                Message = "Get product successful"
            });
        }

        public override Task<ProductsReply> GetAll(Empty empty, ServerCallContext context)
        {
            ProductsReply productsReply = new ProductsReply
            {
                IsSuccess = true,
                Message = "GetAll products successful"
            };
            productsReply.Products.AddRange(_productService.GetAll().ConvertAll(x => x.ToResponse()));
            return Task.FromResult(productsReply);
        }
    }
}