/**
 * Autogenerated by Thrift Compiler (0.12.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace com.chatopera.clause
{

  /// <summary>
  /// 意图槽位
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class IntentSlot : TBase
  {
    private string _intent_id;
    private string _name;
    private string _dict_id;
    private bool _requires;
    private string _id;
    private string _createdate;
    private string _updatedate;
    private string _question;
    private Dict _dict;

    public string Intent_id
    {
      get
      {
        return _intent_id;
      }
      set
      {
        __isset.intent_id = true;
        this._intent_id = value;
      }
    }

    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.name = true;
        this._name = value;
      }
    }

    public string Dict_id
    {
      get
      {
        return _dict_id;
      }
      set
      {
        __isset.dict_id = true;
        this._dict_id = value;
      }
    }

    public bool Requires
    {
      get
      {
        return _requires;
      }
      set
      {
        __isset.requires = true;
        this._requires = value;
      }
    }

    public string Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    public string Createdate
    {
      get
      {
        return _createdate;
      }
      set
      {
        __isset.createdate = true;
        this._createdate = value;
      }
    }

    public string Updatedate
    {
      get
      {
        return _updatedate;
      }
      set
      {
        __isset.updatedate = true;
        this._updatedate = value;
      }
    }

    public string Question
    {
      get
      {
        return _question;
      }
      set
      {
        __isset.question = true;
        this._question = value;
      }
    }

    public Dict Dict
    {
      get
      {
        return _dict;
      }
      set
      {
        __isset.dict = true;
        this._dict = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool intent_id;
      public bool name;
      public bool dict_id;
      public bool requires;
      public bool id;
      public bool createdate;
      public bool updatedate;
      public bool question;
      public bool dict;
    }

    public IntentSlot() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String) {
                Intent_id = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Name = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.String) {
                Dict_id = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Bool) {
                Requires = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.String) {
                Id = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.String) {
                Createdate = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.String) {
                Updatedate = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.String) {
                Question = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.Struct) {
                Dict = new Dict();
                Dict.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("IntentSlot");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Intent_id != null && __isset.intent_id) {
          field.Name = "intent_id";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Intent_id);
          oprot.WriteFieldEnd();
        }
        if (Name != null && __isset.name) {
          field.Name = "name";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Name);
          oprot.WriteFieldEnd();
        }
        if (Dict_id != null && __isset.dict_id) {
          field.Name = "dict_id";
          field.Type = TType.String;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Dict_id);
          oprot.WriteFieldEnd();
        }
        if (__isset.requires) {
          field.Name = "requires";
          field.Type = TType.Bool;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(Requires);
          oprot.WriteFieldEnd();
        }
        if (Id != null && __isset.id) {
          field.Name = "id";
          field.Type = TType.String;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Id);
          oprot.WriteFieldEnd();
        }
        if (Createdate != null && __isset.createdate) {
          field.Name = "createdate";
          field.Type = TType.String;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Createdate);
          oprot.WriteFieldEnd();
        }
        if (Updatedate != null && __isset.updatedate) {
          field.Name = "updatedate";
          field.Type = TType.String;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Updatedate);
          oprot.WriteFieldEnd();
        }
        if (Question != null && __isset.question) {
          field.Name = "question";
          field.Type = TType.String;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Question);
          oprot.WriteFieldEnd();
        }
        if (Dict != null && __isset.dict) {
          field.Name = "dict";
          field.Type = TType.Struct;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          Dict.Write(oprot);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("IntentSlot(");
      bool __first = true;
      if (Intent_id != null && __isset.intent_id) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Intent_id: ");
        __sb.Append(Intent_id);
      }
      if (Name != null && __isset.name) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Name: ");
        __sb.Append(Name);
      }
      if (Dict_id != null && __isset.dict_id) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Dict_id: ");
        __sb.Append(Dict_id);
      }
      if (__isset.requires) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Requires: ");
        __sb.Append(Requires);
      }
      if (Id != null && __isset.id) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Id: ");
        __sb.Append(Id);
      }
      if (Createdate != null && __isset.createdate) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Createdate: ");
        __sb.Append(Createdate);
      }
      if (Updatedate != null && __isset.updatedate) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Updatedate: ");
        __sb.Append(Updatedate);
      }
      if (Question != null && __isset.question) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Question: ");
        __sb.Append(Question);
      }
      if (Dict != null && __isset.dict) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Dict: ");
        __sb.Append(Dict== null ? "<null>" : Dict.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
