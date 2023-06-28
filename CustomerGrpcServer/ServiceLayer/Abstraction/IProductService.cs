using CustomerGrpcServer.ServiceLayer.Dtos;

namespace CustomerGrpcServer.ServiceLayer.Abstraction
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
