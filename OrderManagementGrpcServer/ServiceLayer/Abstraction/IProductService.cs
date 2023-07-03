using OrderManagementGrpcServer.ServiceLayer.Dtos;

namespace OrderManagementGrpcServer.ServiceLayer.Abstraction
{
    public interface IProductService
    {
        void Add(ProductDto product);
        void Update(ProductDto product);
        void Delete(int id);
        ProductDto Get(int id);
        List<ProductDto> GetAll();
    }
}
