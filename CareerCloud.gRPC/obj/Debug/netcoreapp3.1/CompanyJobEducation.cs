// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/CompanyJobEducation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.gRPC.Protos {

  /// <summary>Holder for reflection information generated from Protos/CompanyJobEducation.proto</summary>
  public static partial class CompanyJobEducationReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/CompanyJobEducation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompanyJobEducationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBQcm90b3MvQ29tcGFueUpvYkVkdWNhdGlvbi5wcm90bxIQQ2FyZWVyQ2xv",
            "dWQuZ1JQQxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90bxobZ29v",
            "Z2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvIiEKE0NvbXBKb2JFZHVJZFJlcXVl",
            "c3QSCgoCSWQYASABKAkiUQoTQ29tcGFueUpvYkVkdWNhdGlvbhIKCgJJZBgB",
            "IAEoCRILCgNKb2IYAiABKAkSDQoFTWFqb3IYAyABKAkSEgoKSW1wb3J0YW5j",
            "ZRgEIAEoBSJRChRDb21wYW55Sm9iRWR1Y2F0aW9ucxI5CgpDb21wSm9iRWR1",
            "GAEgAygLMiUuQ2FyZWVyQ2xvdWQuZ1JQQy5Db21wYW55Sm9iRWR1Y2F0aW9u",
            "MpcDChpDb21wYW55Sm9iRWR1Y2F0aW9uU2VydmljZRJmChZHZXRDb21wYW55",
            "Sm9iRWR1Y2F0aW9uEiUuQ2FyZWVyQ2xvdWQuZ1JQQy5Db21wSm9iRWR1SWRS",
            "ZXF1ZXN0GiUuQ2FyZWVyQ2xvdWQuZ1JQQy5Db21wYW55Sm9iRWR1Y2F0aW9u",
            "ElsKGUNyZWF0ZUNvbXBhbnlKb2JFZHVjYXRpb24SJi5DYXJlZXJDbG91ZC5n",
            "UlBDLkNvbXBhbnlKb2JFZHVjYXRpb25zGhYuZ29vZ2xlLnByb3RvYnVmLkVt",
            "cHR5ElkKF1VwZGF0ZUFwcGxjYW50RWR1Y2F0aW9uEiYuQ2FyZWVyQ2xvdWQu",
            "Z1JQQy5Db21wYW55Sm9iRWR1Y2F0aW9ucxoWLmdvb2dsZS5wcm90b2J1Zi5F",
            "bXB0eRJZChdEZWxldGVBcHBsY2FudEVkdWNhdGlvbhImLkNhcmVlckNsb3Vk",
            "LmdSUEMuQ29tcGFueUpvYkVkdWNhdGlvbnMaFi5nb29nbGUucHJvdG9idWYu",
            "RW1wdHlCGqoCF0NhcmVlckNsb3VkLmdSUEMuUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.CompJobEduIdRequest), global::CareerCloud.gRPC.Protos.CompJobEduIdRequest.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.CompanyJobEducation), global::CareerCloud.gRPC.Protos.CompanyJobEducation.Parser, new[]{ "Id", "Job", "Major", "Importance" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.CompanyJobEducations), global::CareerCloud.gRPC.Protos.CompanyJobEducations.Parser, new[]{ "CompJobEdu" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CompJobEduIdRequest : pb::IMessage<CompJobEduIdRequest> {
    private static readonly pb::MessageParser<CompJobEduIdRequest> _parser = new pb::MessageParser<CompJobEduIdRequest>(() => new CompJobEduIdRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompJobEduIdRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyJobEducationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompJobEduIdRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompJobEduIdRequest(CompJobEduIdRequest other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompJobEduIdRequest Clone() {
      return new CompJobEduIdRequest(this);
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
      return Equals(other as CompJobEduIdRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompJobEduIdRequest other) {
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
    public void MergeFrom(CompJobEduIdRequest other) {
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

  public sealed partial class CompanyJobEducation : pb::IMessage<CompanyJobEducation> {
    private static readonly pb::MessageParser<CompanyJobEducation> _parser = new pb::MessageParser<CompanyJobEducation>(() => new CompanyJobEducation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompanyJobEducation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyJobEducationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobEducation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobEducation(CompanyJobEducation other) : this() {
      id_ = other.id_;
      job_ = other.job_;
      major_ = other.major_;
      importance_ = other.importance_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobEducation Clone() {
      return new CompanyJobEducation(this);
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

    /// <summary>Field number for the "Job" field.</summary>
    public const int JobFieldNumber = 2;
    private string job_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Job {
      get { return job_; }
      set {
        job_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Major" field.</summary>
    public const int MajorFieldNumber = 3;
    private string major_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Major {
      get { return major_; }
      set {
        major_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Importance" field.</summary>
    public const int ImportanceFieldNumber = 4;
    private int importance_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Importance {
      get { return importance_; }
      set {
        importance_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompanyJobEducation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompanyJobEducation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Job != other.Job) return false;
      if (Major != other.Major) return false;
      if (Importance != other.Importance) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Job.Length != 0) hash ^= Job.GetHashCode();
      if (Major.Length != 0) hash ^= Major.GetHashCode();
      if (Importance != 0) hash ^= Importance.GetHashCode();
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
      if (Job.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Job);
      }
      if (Major.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Major);
      }
      if (Importance != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Importance);
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
      if (Job.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Job);
      }
      if (Major.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Major);
      }
      if (Importance != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Importance);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompanyJobEducation other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Job.Length != 0) {
        Job = other.Job;
      }
      if (other.Major.Length != 0) {
        Major = other.Major;
      }
      if (other.Importance != 0) {
        Importance = other.Importance;
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
            Job = input.ReadString();
            break;
          }
          case 26: {
            Major = input.ReadString();
            break;
          }
          case 32: {
            Importance = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CompanyJobEducations : pb::IMessage<CompanyJobEducations> {
    private static readonly pb::MessageParser<CompanyJobEducations> _parser = new pb::MessageParser<CompanyJobEducations>(() => new CompanyJobEducations());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompanyJobEducations> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyJobEducationReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobEducations() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobEducations(CompanyJobEducations other) : this() {
      compJobEdu_ = other.compJobEdu_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobEducations Clone() {
      return new CompanyJobEducations(this);
    }

    /// <summary>Field number for the "CompJobEdu" field.</summary>
    public const int CompJobEduFieldNumber = 1;
    private static readonly pb::FieldCodec<global::CareerCloud.gRPC.Protos.CompanyJobEducation> _repeated_compJobEdu_codec
        = pb::FieldCodec.ForMessage(10, global::CareerCloud.gRPC.Protos.CompanyJobEducation.Parser);
    private readonly pbc::RepeatedField<global::CareerCloud.gRPC.Protos.CompanyJobEducation> compJobEdu_ = new pbc::RepeatedField<global::CareerCloud.gRPC.Protos.CompanyJobEducation>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::CareerCloud.gRPC.Protos.CompanyJobEducation> CompJobEdu {
      get { return compJobEdu_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompanyJobEducations);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompanyJobEducations other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!compJobEdu_.Equals(other.compJobEdu_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= compJobEdu_.GetHashCode();
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
      compJobEdu_.WriteTo(output, _repeated_compJobEdu_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += compJobEdu_.CalculateSize(_repeated_compJobEdu_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompanyJobEducations other) {
      if (other == null) {
        return;
      }
      compJobEdu_.Add(other.compJobEdu_);
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
            compJobEdu_.AddEntriesFrom(input, _repeated_compJobEdu_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
