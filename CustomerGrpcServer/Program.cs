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
            builder.Services.AddSingleton<ICustomerService, CustomerService>();
            var app = builder.Build();

            app.MapGrpcService<CustomerGrpcService>();
            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

            app.Run();
        }
    }
}