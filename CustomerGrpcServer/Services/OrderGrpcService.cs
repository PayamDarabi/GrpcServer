using CustomerGrpcServer.Mappers;
using CustomerGrpcServer.ServiceLayer.Abstraction;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace CustomerGrpcServer.Services
{
    public class OrderGrpcService : Order.OrderBase
    {
        private readonly IOrderService _orderService;
        private readonly ILogger<OrderGrpcService> _logger;

        public OrderGrpcService(IOrderService orderService, ILogger<OrderGrpcService> logger)
        {
            _logger = logger;
            _orderService = orderService;
        }

        public override Task<OrderReply> Add(OrderRequest request, ServerCallContext context)
        {
            _orderService.Add(request.ToDto());
            return Task.FromResult(new OrderReply
            {
                Order = new OrderResponse
                {
                    Id = request.Id,
                },
                IsSuccess = true,
                Message = $"Order with Id:{request.Id} added successfully..",
            });
        }

        public override Task<OrderReply> Update(OrderRequest request, ServerCallContext context)
        {
            _orderService.Update(request.ToDto());
            return Task.FromResult(new OrderReply
            {
                Order = new OrderResponse
                {
                    Id = request.Id,
                },
                IsSuccess = true,
                Message = $"Order with Id:{request.Id} updated successfully..",
            });
        }

        public override Task<DeleteOrderReply> Delete(DeleteOrderRequest request, ServerCallContext context)
        {
            _orderService.Delete(request.Id);
            return Task.FromResult(new DeleteOrderReply
            {
                IsSuccess = true,
                Message = $"Order with Id:{request.Id} deleted successfully..",
            });
        }

        public override Task<OrderReply> Get(GetOrderRequest request, ServerCallContext context)
        {
            var order = _orderService.Get(request.Id);
            if (order == null)
            {
                return Task.FromResult(new OrderReply
                {
                    Order = null,
                    IsSuccess = false,
                    Message = "order not found"
                });
            }
            return Task.FromResult(new OrderReply
            {
                Order = order.ToResponse(),
                IsSuccess = true,
                Message = "Get order successful"
            });
        }

        public override Task<OrdersReply> GetAll(Empty empty, ServerCallContext context)
        {
            OrdersReply ordersReply = new OrdersReply
            {
                IsSuccess = true,
                Message = "GetAll orders successful"
            };
            ordersReply.Orders.AddRange(_orderService.GetAll().ConvertAll(x => x.ToResponse()));
            return Task.FromResult(ordersReply);
        }
    }
    
}
