// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/CompanyDescription.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.gRPC.Protos {

  /// <summary>Holder for reflection information generated from Protos/CompanyDescription.proto</summary>
  public static partial class CompanyDescriptionReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/CompanyDescription.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompanyDescriptionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Qcm90b3MvQ29tcGFueURlc2NyaXB0aW9uLnByb3RvEhBDYXJlZXJDbG91",
            "ZC5nUlBDGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvGhtnb29n",
            "bGUvcHJvdG9idWYvZW1wdHkucHJvdG8iHgoQQ29tRGVzY0lkUmVxdWVzdBIK",
            "CgJJZBgBIAEoCSJzChJDb21wYW55RGVzY3JpcHRpb24SCgoCSWQYASABKAkS",
            "DwoHQ29tcGFueRgCIAEoCRISCgpMYW5ndWFnZUlkGAMgASgJEhMKC0NvbXBh",
            "bnlOYW1lGAQgASgJEhcKD0NvbXBEZXNjcmlwdGlvbhgFIAEoCSJNChNDb21w",
            "YW55RGVzY3JpcHRpb25zEjYKCENvbXBEZXNjGAEgAygLMiQuQ2FyZWVyQ2xv",
            "dWQuZ1JQQy5Db21wYW55RGVzY3JpcHRpb24yjQMKGUNvbXBhbnlEZXNjcmlw",
            "dGlvblNlcnZpY2USYQoVR2V0Q29tcGFueURlc2NyaXB0aW9uEiIuQ2FyZWVy",
            "Q2xvdWQuZ1JQQy5Db21EZXNjSWRSZXF1ZXN0GiQuQ2FyZWVyQ2xvdWQuZ1JQ",
            "Qy5Db21wYW55RGVzY3JpcHRpb24SWQoYQ3JlYXRlQ29tcGFueURlc2NyaXB0",
            "aW9uEiUuQ2FyZWVyQ2xvdWQuZ1JQQy5Db21wYW55RGVzY3JpcHRpb25zGhYu",
            "Z29vZ2xlLnByb3RvYnVmLkVtcHR5ElgKF1VwZGF0ZUFwcGxjYW50RWR1Y2F0",
            "aW9uEiUuQ2FyZWVyQ2xvdWQuZ1JQQy5Db21wYW55RGVzY3JpcHRpb25zGhYu",
            "Z29vZ2xlLnByb3RvYnVmLkVtcHR5ElgKF0RlbGV0ZUFwcGxjYW50RWR1Y2F0",
            "aW9uEiUuQ2FyZWVyQ2xvdWQuZ1JQQy5Db21wYW55RGVzY3JpcHRpb25zGhYu",
            "Z29vZ2xlLnByb3RvYnVmLkVtcHR5QhqqAhdDYXJlZXJDbG91ZC5nUlBDLlBy",
            "b3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.ComDescIdRequest), global::CareerCloud.gRPC.Protos.ComDescIdRequest.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.CompanyDescription), global::CareerCloud.gRPC.Protos.CompanyDescription.Parser, new[]{ "Id", "Company", "LanguageId", "CompanyName", "CompDescription" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.CompanyDescriptions), global::CareerCloud.gRPC.Protos.CompanyDescriptions.Parser, new[]{ "CompDesc" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ComDescIdRequest : pb::IMessage<ComDescIdRequest> {
    private static readonly pb::MessageParser<ComDescIdRequest> _parser = new pb::MessageParser<ComDescIdRequest>(() => new ComDescIdRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ComDescIdRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyDescriptionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ComDescIdRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ComDescIdRequest(ComDescIdRequest other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ComDescIdRequest Clone() {
      return new ComDescIdRequest(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ComDescIdRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ComDescIdRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ComDescIdRequest other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CompanyDescription : pb::IMessage<CompanyDescription> {
    private static readonly pb::MessageParser<CompanyDescription> _parser = new pb::MessageParser<CompanyDescription>(() => new CompanyDescription());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompanyDescription> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyDescriptionReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDescription() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDescription(CompanyDescription other) : this() {
      id_ = other.id_;
      company_ = other.company_;
      languageId_ = other.languageId_;
      companyName_ = other.companyName_;
      compDescription_ = other.compDescription_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDescription Clone() {
      return new CompanyDescription(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Company" field.</summary>
    public const int CompanyFieldNumber = 2;
    private string company_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Company {
      get { return company_; }
      set {
        company_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "LanguageId" field.</summary>
    public const int LanguageIdFieldNumber = 3;
    private string languageId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LanguageId {
      get { return languageId_; }
      set {
        languageId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "CompanyName" field.</summary>
    public const int CompanyNameFieldNumber = 4;
    private string companyName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CompanyName {
      get { return companyName_; }
      set {
        companyName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "CompDescription" field.</summary>
    public const int CompDescriptionFieldNumber = 5;
    private string compDescription_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CompDescription {
      get { return compDescription_; }
      set {
        compDescription_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompanyDescription);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompanyDescription other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Company != other.Company) return false;
      if (LanguageId != other.LanguageId) return false;
      if (CompanyName != other.CompanyName) return false;
      if (CompDescription != other.CompDescription) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Company.Length != 0) hash ^= Company.GetHashCode();
      if (LanguageId.Length != 0) hash ^= LanguageId.GetHashCode();
      if (CompanyName.Length != 0) hash ^= CompanyName.GetHashCode();
      if (CompDescription.Length != 0) hash ^= CompDescription.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Company.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Company);
      }
      if (LanguageId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LanguageId);
      }
      if (CompanyName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(CompanyName);
      }
      if (CompDescription.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(CompDescription);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Company.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Company);
      }
      if (LanguageId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LanguageId);
      }
      if (CompanyName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CompanyName);
      }
      if (CompDescription.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CompDescription);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompanyDescription other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Company.Length != 0) {
        Company = other.Company;
      }
      if (other.LanguageId.Length != 0) {
        LanguageId = other.LanguageId;
      }
      if (other.CompanyName.Length != 0) {
        CompanyName = other.CompanyName;
      }
      if (other.CompDescription.Length != 0) {
        CompDescription = other.CompDescription;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Company = input.ReadString();
            break;
          }
          case 26: {
            LanguageId = input.ReadString();
            break;
          }
          case 34: {
            CompanyName = input.ReadString();
            break;
          }
          case 42: {
            CompDescription = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CompanyDescriptions : pb::IMessage<CompanyDescriptions> {
    private static readonly pb::MessageParser<CompanyDescriptions> _parser = new pb::MessageParser<CompanyDescriptions>(() => new CompanyDescriptions());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompanyDescriptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyDescriptionReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDescriptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDescriptions(CompanyDescriptions other) : this() {
      compDesc_ = other.compDesc_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyDescriptions Clone() {
      return new CompanyDescriptions(this);
    }

    /// <summary>Field number for the "CompDesc" field.</summary>
    public const int CompDescFieldNumber = 1;
    private static readonly pb::FieldCodec<global::CareerCloud.gRPC.Protos.CompanyDescription> _repeated_compDesc_codec
        = pb::FieldCodec.ForMessage(10, global::CareerCloud.gRPC.Protos.CompanyDescription.Parser);
    private readonly pbc::RepeatedField<global::CareerCloud.gRPC.Protos.CompanyDescription> compDesc_ = new pbc::RepeatedField<global::CareerCloud.gRPC.Protos.CompanyDescription>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::CareerCloud.gRPC.Protos.CompanyDescription> CompDesc {
      get { return compDesc_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompanyDescriptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompanyDescriptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!compDesc_.Equals(other.compDesc_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= compDesc_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      compDesc_.WriteTo(output, _repeated_compDesc_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += compDesc_.CalculateSize(_repeated_compDesc_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompanyDescriptions other) {
      if (other == null) {
        return;
      }
      compDesc_.Add(other.compDesc_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            compDesc_.AddEntriesFrom(input, _repeated_compDesc_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code