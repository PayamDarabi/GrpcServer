// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/customer.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace OrderManagementGrpcServer {
  public static partial class Customer
  {
    static readonly string __ServiceName = "OrderManagementGrpcServer.Customer";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::OrderManagementGrpcServer.CustomerRequest> __Marshaller_OrderManagementGrpcServer_CustomerRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrderManagementGrpcServer.CustomerRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::OrderManagementGrpcServer.CustomerReply> __Marshaller_OrderManagementGrpcServer_CustomerReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrderManagementGrpcServer.CustomerReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::OrderManagementGrpcServer.DeleteCustomerRequest> __Marshaller_OrderManagementGrpcServer_DeleteCustomerRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrderManagementGrpcServer.DeleteCustomerRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::OrderManagementGrpcServer.DeleteCustomerReply> __Marshaller_OrderManagementGrpcServer_DeleteCustomerReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrderManagementGrpcServer.DeleteCustomerReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::OrderManagementGrpcServer.GetCustomerRequest> __Marshaller_OrderManagementGrpcServer_GetCustomerRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrderManagementGrpcServer.GetCustomerRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::OrderManagementGrpcServer.CustomersReply> __Marshaller_OrderManagementGrpcServer_CustomersReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrderManagementGrpcServer.CustomersReply.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::OrderManagementGrpcServer.CustomerRequest, global::OrderManagementGrpcServer.CustomerReply> __Method_Add = new grpc::Method<global::OrderManagementGrpcServer.CustomerRequest, global::OrderManagementGrpcServer.CustomerReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Add",
        __Marshaller_OrderManagementGrpcServer_CustomerRequest,
        __Marshaller_OrderManagementGrpcServer_CustomerReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::OrderManagementGrpcServer.CustomerRequest, global::OrderManagementGrpcServer.CustomerReply> __Method_Update = new grpc::Method<global::OrderManagementGrpcServer.CustomerRequest, global::OrderManagementGrpcServer.CustomerReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_OrderManagementGrpcServer_CustomerRequest,
        __Marshaller_OrderManagementGrpcServer_CustomerReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::OrderManagementGrpcServer.DeleteCustomerRequest, global::OrderManagementGrpcServer.DeleteCustomerReply> __Method_Delete = new grpc::Method<global::OrderManagementGrpcServer.DeleteCustomerRequest, global::OrderManagementGrpcServer.DeleteCustomerReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_OrderManagementGrpcServer_DeleteCustomerRequest,
        __Marshaller_OrderManagementGrpcServer_DeleteCustomerReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::OrderManagementGrpcServer.GetCustomerRequest, global::OrderManagementGrpcServer.CustomerReply> __Method_Get = new grpc::Method<global::OrderManagementGrpcServer.GetCustomerRequest, global::OrderManagementGrpcServer.CustomerReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_OrderManagementGrpcServer_GetCustomerRequest,
        __Marshaller_OrderManagementGrpcServer_CustomerReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::OrderManagementGrpcServer.CustomersReply> __Method_GetAll = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::OrderManagementGrpcServer.CustomersReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAll",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_OrderManagementGrpcServer_CustomersReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::OrderManagementGrpcServer.CustomerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Customer</summary>
    [grpc::BindServiceMethod(typeof(Customer), "BindService")]
    public abstract partial class CustomerBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::OrderManagementGrpcServer.CustomerReply> Add(global::OrderManagementGrpcServer.CustomerRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::OrderManagementGrpcServer.CustomerReply> Update(global::OrderManagementGrpcServer.CustomerRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::OrderManagementGrpcServer.DeleteCustomerReply> Delete(global::OrderManagementGrpcServer.DeleteCustomerRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::OrderManagementGrpcServer.CustomerReply> Get(global::OrderManagementGrpcServer.GetCustomerRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::OrderManagementGrpcServer.CustomersReply> GetAll(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CustomerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Add, serviceImpl.Add)
          .AddMethod(__Method_Update, serviceImpl.Update)
          .AddMethod(__Method_Delete, serviceImpl.Delete)
          .AddMethod(__Method_Get, serviceImpl.Get)
          .AddMethod(__Method_GetAll, serviceImpl.GetAll).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CustomerBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Add, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::OrderManagementGrpcServer.CustomerRequest, global::OrderManagementGrpcServer.CustomerReply>(serviceImpl.Add));
      serviceBinder.AddMethod(__Method_Update, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::OrderManagementGrpcServer.CustomerRequest, global::OrderManagementGrpcServer.CustomerReply>(serviceImpl.Update));
      serviceBinder.AddMethod(__Method_Delete, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::OrderManagementGrpcServer.DeleteCustomerRequest, global::OrderManagementGrpcServer.DeleteCustomerReply>(serviceImpl.Delete));
      serviceBinder.AddMethod(__Method_Get, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::OrderManagementGrpcServer.GetCustomerRequest, global::OrderManagementGrpcServer.CustomerReply>(serviceImpl.Get));
      serviceBinder.AddMethod(__Method_GetAll, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::OrderManagementGrpcServer.CustomersReply>(serviceImpl.GetAll));
    }

  }
}
#endregion
