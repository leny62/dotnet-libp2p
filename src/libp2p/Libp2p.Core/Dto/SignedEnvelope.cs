// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SignedEnvelope.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Nethermind.Libp2p.Core.Dto {

  /// <summary>Holder for reflection information generated from SignedEnvelope.proto</summary>
  public static partial class SignedEnvelopeReflection {

    #region Descriptor
    /// <summary>File descriptor for SignedEnvelope.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SignedEnvelopeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRTaWduZWRFbnZlbG9wZS5wcm90byJeCg5TaWduZWRFbnZlbG9wZRISCgpw",
            "dWJsaWNfa2V5GAEgAigMEhQKDHBheWxvYWRfdHlwZRgCIAIoDBIPCgdwYXls",
            "b2FkGAMgAigMEhEKCXNpZ25hdHVyZRgFIAIoDEIdqgIaTmV0aGVybWluZC5M",
            "aWJwMnAuQ29yZS5EdG8="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Nethermind.Libp2p.Core.Dto.SignedEnvelope), global::Nethermind.Libp2p.Core.Dto.SignedEnvelope.Parser, new[]{ "PublicKey", "PayloadType", "Payload", "Signature" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SignedEnvelope : pb::IMessage<SignedEnvelope>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SignedEnvelope> _parser = new pb::MessageParser<SignedEnvelope>(() => new SignedEnvelope());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SignedEnvelope> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Nethermind.Libp2p.Core.Dto.SignedEnvelopeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SignedEnvelope() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SignedEnvelope(SignedEnvelope other) : this() {
      publicKey_ = other.publicKey_;
      payloadType_ = other.payloadType_;
      payload_ = other.payload_;
      signature_ = other.signature_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SignedEnvelope Clone() {
      return new SignedEnvelope(this);
    }

    /// <summary>Field number for the "public_key" field.</summary>
    public const int PublicKeyFieldNumber = 1;
    private readonly static pb::ByteString PublicKeyDefaultValue = pb::ByteString.Empty;

    private pb::ByteString publicKey_;
    /// <summary>
    /// public_key is the public key of the keypair the enclosed payload was
    /// signed with.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString PublicKey {
      get { return publicKey_ ?? PublicKeyDefaultValue; }
      set {
        publicKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "public_key" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasPublicKey {
      get { return publicKey_ != null; }
    }
    /// <summary>Clears the value of the "public_key" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearPublicKey() {
      publicKey_ = null;
    }

    /// <summary>Field number for the "payload_type" field.</summary>
    public const int PayloadTypeFieldNumber = 2;
    private readonly static pb::ByteString PayloadTypeDefaultValue = pb::ByteString.Empty;

    private pb::ByteString payloadType_;
    /// <summary>
    /// payload_type encodes the type of payload, so that it can be deserialized
    /// deterministically.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString PayloadType {
      get { return payloadType_ ?? PayloadTypeDefaultValue; }
      set {
        payloadType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "payload_type" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasPayloadType {
      get { return payloadType_ != null; }
    }
    /// <summary>Clears the value of the "payload_type" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearPayloadType() {
      payloadType_ = null;
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 3;
    private readonly static pb::ByteString PayloadDefaultValue = pb::ByteString.Empty;

    private pb::ByteString payload_;
    /// <summary>
    /// payload is the actual payload carried inside this envelope.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Payload {
      get { return payload_ ?? PayloadDefaultValue; }
      set {
        payload_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "payload" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasPayload {
      get { return payload_ != null; }
    }
    /// <summary>Clears the value of the "payload" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearPayload() {
      payload_ = null;
    }

    /// <summary>Field number for the "signature" field.</summary>
    public const int SignatureFieldNumber = 5;
    private readonly static pb::ByteString SignatureDefaultValue = pb::ByteString.Empty;

    private pb::ByteString signature_;
    /// <summary>
    /// signature is the signature produced by the private key corresponding to
    /// the enclosed public key, over the payload, prefixing a domain string for
    /// additional security.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Signature {
      get { return signature_ ?? SignatureDefaultValue; }
      set {
        signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "signature" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasSignature {
      get { return signature_ != null; }
    }
    /// <summary>Clears the value of the "signature" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearSignature() {
      signature_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SignedEnvelope);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SignedEnvelope other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PublicKey != other.PublicKey) return false;
      if (PayloadType != other.PayloadType) return false;
      if (Payload != other.Payload) return false;
      if (Signature != other.Signature) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasPublicKey) hash ^= PublicKey.GetHashCode();
      if (HasPayloadType) hash ^= PayloadType.GetHashCode();
      if (HasPayload) hash ^= Payload.GetHashCode();
      if (HasSignature) hash ^= Signature.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasPublicKey) {
        output.WriteRawTag(10);
        output.WriteBytes(PublicKey);
      }
      if (HasPayloadType) {
        output.WriteRawTag(18);
        output.WriteBytes(PayloadType);
      }
      if (HasPayload) {
        output.WriteRawTag(26);
        output.WriteBytes(Payload);
      }
      if (HasSignature) {
        output.WriteRawTag(42);
        output.WriteBytes(Signature);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasPublicKey) {
        output.WriteRawTag(10);
        output.WriteBytes(PublicKey);
      }
      if (HasPayloadType) {
        output.WriteRawTag(18);
        output.WriteBytes(PayloadType);
      }
      if (HasPayload) {
        output.WriteRawTag(26);
        output.WriteBytes(Payload);
      }
      if (HasSignature) {
        output.WriteRawTag(42);
        output.WriteBytes(Signature);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasPublicKey) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(PublicKey);
      }
      if (HasPayloadType) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(PayloadType);
      }
      if (HasPayload) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Payload);
      }
      if (HasSignature) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Signature);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SignedEnvelope other) {
      if (other == null) {
        return;
      }
      if (other.HasPublicKey) {
        PublicKey = other.PublicKey;
      }
      if (other.HasPayloadType) {
        PayloadType = other.PayloadType;
      }
      if (other.HasPayload) {
        Payload = other.Payload;
      }
      if (other.HasSignature) {
        Signature = other.Signature;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            PublicKey = input.ReadBytes();
            break;
          }
          case 18: {
            PayloadType = input.ReadBytes();
            break;
          }
          case 26: {
            Payload = input.ReadBytes();
            break;
          }
          case 42: {
            Signature = input.ReadBytes();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            PublicKey = input.ReadBytes();
            break;
          }
          case 18: {
            PayloadType = input.ReadBytes();
            break;
          }
          case 26: {
            Payload = input.ReadBytes();
            break;
          }
          case 42: {
            Signature = input.ReadBytes();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
