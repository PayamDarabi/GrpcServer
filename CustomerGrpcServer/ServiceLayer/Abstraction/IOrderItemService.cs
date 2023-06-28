﻿using CustomerGrpcServer.ServiceLayer.Dtos;

namespace CustomerGrpcServer.ServiceLayer.Abstraction
{
    public interface IOrderItemService
    {
        void Add(OrderItemDto orderItem);
        void Update(OrderItemDto orderItem);
        void Delete(int id);
        OrderItemDto Get(int id);
        List<OrderItemDto> GetAll();
    } 
}
