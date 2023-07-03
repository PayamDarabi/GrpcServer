using OrderManagementGrpcServer.DataLayer.Repositories;
using OrderManagementGrpcServer.Mappers;
using OrderManagementGrpcServer.ServiceLayer.Abstraction;
using OrderManagementGrpcServer.ServiceLayer.Dtos;

namespace OrderManagementGrpcServer.ServiceLayer.Implementation
{
    public class ProductService : IProductService
    {
        ProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public void Add(ProductDto product)
        {
            _productRepository.Add(product.ToModel());
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public ProductDto Get(int id)
        {
            var result = _productRepository.Get(id);
            return result.ToDto();
        }

        public List<ProductDto> GetAll()
        {
            var result = _productRepository.GetAll();
            return result.ConvertAll(x => x.ToDto());
        }

        public void Update(ProductDto product)
        {
            _productRepository.Update(product.ToModel());
        }
    }
}
