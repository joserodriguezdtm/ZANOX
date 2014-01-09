// Type: ZanoxV2.Auth.createConnectRequest
// Assembly: ZanoxV2, Version=1.0.4955.28682, Culture=neutral, PublicKeyToken=d1e62d2627a2f3e0
// MVID: 35AD163E-3C46-45E7-B3AA-50397E6E2193
// Assembly location: C:\Users\daniel.lopez\Desktop\Zanox.API\ZanoxV2.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace sqlPyO.Auth
{
  [XmlType(AnonymousType = true, Namespace = "http://auth.zanox.com/2011-05-01/")]
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class createConnectRequest
  {
    private string applicationIdField;
    private string connectIdField;
    private int loginIdField;
    private bool loginIdFieldSpecified;
    private roleType roleField;
    private bool roleFieldSpecified;
    private string publicKeyField;
    private string timestampField;
    private string nonceField;
    private string signatureField;

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public string applicationId
    {
      get
      {
        return this.applicationIdField;
      }
      set
      {
        this.applicationIdField = value;
      }
    }

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public string connectId
    {
      get
      {
        return this.connectIdField;
      }
      set
      {
        this.connectIdField = value;
      }
    }

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public int loginId
    {
      get
      {
        return this.loginIdField;
      }
      set
      {
        this.loginIdField = value;
      }
    }

    [XmlIgnore]
    public bool loginIdSpecified
    {
      get
      {
        return this.loginIdFieldSpecified;
      }
      set
      {
        this.loginIdFieldSpecified = value;
      }
    }

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public roleType role
    {
      get
      {
        return this.roleField;
      }
      set
      {
        this.roleField = value;
      }
    }

    [XmlIgnore]
    public bool roleSpecified
    {
      get
      {
        return this.roleFieldSpecified;
      }
      set
      {
        this.roleFieldSpecified = value;
      }
    }

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public string publicKey
    {
      get
      {
        return this.publicKeyField;
      }
      set
      {
        this.publicKeyField = value;
      }
    }

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public string timestamp
    {
      get
      {
        return this.timestampField;
      }
      set
      {
        this.timestampField = value;
      }
    }

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public string nonce
    {
      get
      {
        return this.nonceField;
      }
      set
      {
        this.nonceField = value;
      }
    }

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public string signature
    {
      get
      {
        return this.signatureField;
      }
      set
      {
        this.signatureField = value;
      }
    }
  }
}
