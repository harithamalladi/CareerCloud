// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/SystemLanguageCode.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.gRPC.Protos {

  /// <summary>Holder for reflection information generated from Protos/SystemLanguageCode.proto</summary>
  public static partial class SystemLanguageCodeReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/SystemLanguageCode.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SystemLanguageCodeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Qcm90b3MvU3lzdGVtTGFuZ3VhZ2VDb2RlLnByb3RvEhBDYXJlZXJDbG91",
            "ZC5nUlBDGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvGhtnb29n",
            "bGUvcHJvdG9idWYvZW1wdHkucHJvdG8iIgoUU3lzTGFuZ0NvZGVJZFJlcXVl",
            "c3QSCgoCSWQYASABKAkiSgoSU3lzdGVtTGFuZ3VhZ2VDb2RlEhIKCkxhbmd1",
            "YWdlSUQYASABKAkSDAoETmFtZRgCIAEoCRISCgpOYXRpdmVOYW1lGAMgASgJ",
            "IlAKE1N5c3RlbUxhbmd1YWdlQ29kZXMSOQoLU3lzTGFuZ0NvZGUYASADKAsy",
            "JC5DYXJlZXJDbG91ZC5nUlBDLlN5c3RlbUxhbmd1YWdlQ29kZTKRAwoZU3lz",
            "dGVtTGFuZ3VhZ2VDb2RlU2VydmljZRJlChVHZXRTeXN0ZW1MYW5ndWFnZUNv",
            "ZGUSJi5DYXJlZXJDbG91ZC5nUlBDLlN5c0xhbmdDb2RlSWRSZXF1ZXN0GiQu",
            "Q2FyZWVyQ2xvdWQuZ1JQQy5TeXN0ZW1MYW5ndWFnZUNvZGUSWQoYQ3JlYXRl",
            "U3lzdGVtTGFuZ3VhZ2VDb2RlEiUuQ2FyZWVyQ2xvdWQuZ1JQQy5TeXN0ZW1M",
            "YW5ndWFnZUNvZGVzGhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5ElgKF1VwZGF0",
            "ZUFwcGxjYW50RWR1Y2F0aW9uEiUuQ2FyZWVyQ2xvdWQuZ1JQQy5TeXN0ZW1M",
            "YW5ndWFnZUNvZGVzGhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5ElgKF0RlbGV0",
            "ZUFwcGxjYW50RWR1Y2F0aW9uEiUuQ2FyZWVyQ2xvdWQuZ1JQQy5TeXN0ZW1M",
            "YW5ndWFnZUNvZGVzGhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5QhqqAhdDYXJl",
            "ZXJDbG91ZC5nUlBDLlByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.SysLangCodeIdRequest), global::CareerCloud.gRPC.Protos.SysLangCodeIdRequest.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.SystemLanguageCode), global::CareerCloud.gRPC.Protos.SystemLanguageCode.Parser, new[]{ "LanguageID", "Name", "NativeName" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.SystemLanguageCodes), global::CareerCloud.gRPC.Protos.SystemLanguageCodes.Parser, new[]{ "SysLangCode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SysLangCodeIdRequest : pb::IMessage<SysLangCodeIdRequest> {
    private static readonly pb::MessageParser<SysLangCodeIdRequest> _parser = new pb::MessageParser<SysLangCodeIdRequest>(() => new SysLangCodeIdRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SysLangCodeIdRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.SystemLanguageCodeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SysLangCodeIdRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SysLangCodeIdRequest(SysLangCodeIdRequest other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SysLangCodeIdRequest Clone() {
      return new SysLangCodeIdRequest(this);
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
      return Equals(other as SysLangCodeIdRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SysLangCodeIdRequest other) {
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
    public void MergeFrom(SysLangCodeIdRequest other) {
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

  public sealed partial class SystemLanguageCode : pb::IMessage<SystemLanguageCode> {
    private static readonly pb::MessageParser<SystemLanguageCode> _parser = new pb::MessageParser<SystemLanguageCode>(() => new SystemLanguageCode());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SystemLanguageCode> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.SystemLanguageCodeReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemLanguageCode() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemLanguageCode(SystemLanguageCode other) : this() {
      languageID_ = other.languageID_;
      name_ = other.name_;
      nativeName_ = other.nativeName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemLanguageCode Clone() {
      return new SystemLanguageCode(this);
    }

    /// <summary>Field number for the "LanguageID" field.</summary>
    public const int LanguageIDFieldNumber = 1;
    private string languageID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LanguageID {
      get { return languageID_; }
      set {
        languageID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "NativeName" field.</summary>
    public const int NativeNameFieldNumber = 3;
    private string nativeName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NativeName {
      get { return nativeName_; }
      set {
        nativeName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SystemLanguageCode);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SystemLanguageCode other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LanguageID != other.LanguageID) return false;
      if (Name != other.Name) return false;
      if (NativeName != other.NativeName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (LanguageID.Length != 0) hash ^= LanguageID.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (NativeName.Length != 0) hash ^= NativeName.GetHashCode();
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
      if (LanguageID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LanguageID);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (NativeName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(NativeName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (LanguageID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LanguageID);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (NativeName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NativeName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SystemLanguageCode other) {
      if (other == null) {
        return;
      }
      if (other.LanguageID.Length != 0) {
        LanguageID = other.LanguageID;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.NativeName.Length != 0) {
        NativeName = other.NativeName;
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
            LanguageID = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            NativeName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SystemLanguageCodes : pb::IMessage<SystemLanguageCodes> {
    private static readonly pb::MessageParser<SystemLanguageCodes> _parser = new pb::MessageParser<SystemLanguageCodes>(() => new SystemLanguageCodes());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SystemLanguageCodes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.SystemLanguageCodeReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemLanguageCodes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemLanguageCodes(SystemLanguageCodes other) : this() {
      sysLangCode_ = other.sysLangCode_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemLanguageCodes Clone() {
      return new SystemLanguageCodes(this);
    }

    /// <summary>Field number for the "SysLangCode" field.</summary>
    public const int SysLangCodeFieldNumber = 1;
    private static readonly pb::FieldCodec<global::CareerCloud.gRPC.Protos.SystemLanguageCode> _repeated_sysLangCode_codec
        = pb::FieldCodec.ForMessage(10, global::CareerCloud.gRPC.Protos.SystemLanguageCode.Parser);
    private readonly pbc::RepeatedField<global::CareerCloud.gRPC.Protos.SystemLanguageCode> sysLangCode_ = new pbc::RepeatedField<global::CareerCloud.gRPC.Protos.SystemLanguageCode>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::CareerCloud.gRPC.Protos.SystemLanguageCode> SysLangCode {
      get { return sysLangCode_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SystemLanguageCodes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SystemLanguageCodes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!sysLangCode_.Equals(other.sysLangCode_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= sysLangCode_.GetHashCode();
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
      sysLangCode_.WriteTo(output, _repeated_sysLangCode_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += sysLangCode_.CalculateSize(_repeated_sysLangCode_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SystemLanguageCodes other) {
      if (other == null) {
        return;
      }
      sysLangCode_.Add(other.sysLangCode_);
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
            sysLangCode_.AddEntriesFrom(input, _repeated_sysLangCode_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
