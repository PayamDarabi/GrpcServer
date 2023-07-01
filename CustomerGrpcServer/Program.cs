using CustomerGrpcServer.DataLayer.Repositories;
using CustomerGrpcServer.ServiceLayer.Abstraction;
using CustomerGrpcServer.ServiceLayer.Implementation;
using CustomerGrpcServer.Services;

namespace CustomerGrpcServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddGrpc();
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IOrderItemService, OrderItemService>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            var app = builder.Build();

            app.MapGrpcService<CustomerGrpcService>();
            app.MapGrpcService<OrderGrpcService>();
            app.MapGrpcService<ProductGrpcService>();
            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client");

            app.Run();
        }
    }
}