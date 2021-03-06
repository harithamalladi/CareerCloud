// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/SecurityLogin.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CareerCloud.gRPC.Protos {
  public static partial class SecurityLoginService
  {
    static readonly string __ServiceName = "CareerCloud.gRPC.SecurityLoginService";

    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.SecLoginIdRequest> __Marshaller_CareerCloud_gRPC_SecLoginIdRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CareerCloud.gRPC.Protos.SecLoginIdRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.SecurityLogin> __Marshaller_CareerCloud_gRPC_SecurityLogin = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CareerCloud.gRPC.Protos.SecurityLogin.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.SecurityLogins> __Marshaller_CareerCloud_gRPC_SecurityLogins = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CareerCloud.gRPC.Protos.SecurityLogins.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SecLoginIdRequest, global::CareerCloud.gRPC.Protos.SecurityLogin> __Method_GetSecurityLogin = new grpc::Method<global::CareerCloud.gRPC.Protos.SecLoginIdRequest, global::CareerCloud.gRPC.Protos.SecurityLogin>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSecurityLogin",
        __Marshaller_CareerCloud_gRPC_SecLoginIdRequest,
        __Marshaller_CareerCloud_gRPC_SecurityLogin);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLogins, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CreateSecurityLogin = new grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLogins, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateSecurityLogin",
        __Marshaller_CareerCloud_gRPC_SecurityLogins,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLogins, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateApplcantEducation = new grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLogins, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateApplcantEducation",
        __Marshaller_CareerCloud_gRPC_SecurityLogins,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLogins, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteApplcantEducation = new grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLogins, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteApplcantEducation",
        __Marshaller_CareerCloud_gRPC_SecurityLogins,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CareerCloud.gRPC.Protos.SecurityLoginReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SecurityLoginService</summary>
    [grpc::BindServiceMethod(typeof(SecurityLoginService), "BindService")]
    public abstract partial class SecurityLoginServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::CareerCloud.gRPC.Protos.SecurityLogin> GetSecurityLogin(global::CareerCloud.gRPC.Protos.SecLoginIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> CreateSecurityLogin(global::CareerCloud.gRPC.Protos.SecurityLogins request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateApplcantEducation(global::CareerCloud.gRPC.Protos.SecurityLogins request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteApplcantEducation(global::CareerCloud.gRPC.Protos.SecurityLogins request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SecurityLoginServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetSecurityLogin, serviceImpl.GetSecurityLogin)
          .AddMethod(__Method_CreateSecurityLogin, serviceImpl.CreateSecurityLogin)
          .AddMethod(__Method_UpdateApplcantEducation, serviceImpl.UpdateApplcantEducation)
          .AddMethod(__Method_DeleteApplcantEducation, serviceImpl.DeleteApplcantEducation).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SecurityLoginServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetSecurityLogin, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SecLoginIdRequest, global::CareerCloud.gRPC.Protos.SecurityLogin>(serviceImpl.GetSecurityLogin));
      serviceBinder.AddMethod(__Method_CreateSecurityLogin, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SecurityLogins, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.CreateSecurityLogin));
      serviceBinder.AddMethod(__Method_UpdateApplcantEducation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SecurityLogins, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UpdateApplcantEducation));
      serviceBinder.AddMethod(__Method_DeleteApplcantEducation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SecurityLogins, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteApplcantEducation));
    }

  }
}
#endregion
