// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace MessagingService.Proto {
  public static partial class MessagingService
  {
    static readonly string __ServiceName = "messaging_service_proto.MessagingService";

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
    static readonly grpc::Marshaller<global::MessagingService.Proto.SendRequest> __Marshaller_messaging_service_proto_SendRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::MessagingService.Proto.SendRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::MessagingService.Proto.ListDialogRequest> __Marshaller_messaging_service_proto_ListDialogRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::MessagingService.Proto.ListDialogRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::MessagingService.Proto.ListDialogResponse> __Marshaller_messaging_service_proto_ListDialogResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::MessagingService.Proto.ListDialogResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::MessagingService.Proto.SendRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Send = new grpc::Method<global::MessagingService.Proto.SendRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Send",
        __Marshaller_messaging_service_proto_SendRequest,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::MessagingService.Proto.ListDialogRequest, global::MessagingService.Proto.ListDialogResponse> __Method_ListDialog = new grpc::Method<global::MessagingService.Proto.ListDialogRequest, global::MessagingService.Proto.ListDialogResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListDialog",
        __Marshaller_messaging_service_proto_ListDialogRequest,
        __Marshaller_messaging_service_proto_ListDialogResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::MessagingService.Proto.ServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MessagingService</summary>
    [grpc::BindServiceMethod(typeof(MessagingService), "BindService")]
    public abstract partial class MessagingServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> Send(global::MessagingService.Proto.SendRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::MessagingService.Proto.ListDialogResponse> ListDialog(global::MessagingService.Proto.ListDialogRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(MessagingServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Send, serviceImpl.Send)
          .AddMethod(__Method_ListDialog, serviceImpl.ListDialog).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MessagingServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Send, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::MessagingService.Proto.SendRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.Send));
      serviceBinder.AddMethod(__Method_ListDialog, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::MessagingService.Proto.ListDialogRequest, global::MessagingService.Proto.ListDialogResponse>(serviceImpl.ListDialog));
    }

  }
}
#endregion