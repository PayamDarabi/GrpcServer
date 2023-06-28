using CustomerGrpcServer.DataLayer.Models;

namespace CustomerGrpcServer.DataLayer.Repositories
{
    public class ProductRepository
    {
        private static List<ProductModel> Products;

        public ProductRepository()
        {
            Products = new()
            {
                new ProductModel
                {
                    Id = 1,
                    Name = "Galaxy A10",
                    Price = 3000000
                },
                new ProductModel
                {
                    Id = 1,
                    Name = "Galaxy A14",
                    Price = 6520000
                }
            };
        }

        public void Add(ProductModel product)
        {
            Products.Add(product);
        }

        public void Update(ProductModel productModel)
        {
            var product = Products.FirstOrDefault(x => x.Id == productModel.Id);
            if (product != null)
            {
                Products.Remove(product);
                Products.Add(product);
            }
        }

        public void Delete(int id)
        {
            var product = Products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                Products.Remove(product);
            }
        }

        public ProductModel Get(int id)
        {
            var product = Products.FirstOrDefault(x => x.Id == id);
            return product;
        }

        public List<ProductModel> GetAll()
        {
            return Products;
        }
    }
}
