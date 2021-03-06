﻿// Type: ZanoxV2.Auth.getOfflineSession
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
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [XmlType(AnonymousType = true, Namespace = "http://auth.zanox.com/2011-05-01/")]
  [DesignerCategory("code")]
  [Serializable]
  public class getOfflineSession
  {
    private string offlineTokenField;
    private string publicKeyField;
    private string signatureField;
    private string nonceField;
    private string timestampField;

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public string offlineToken
    {
      get
      {
        return this.offlineTokenField;
      }
      set
      {
        this.offlineTokenField = value;
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
  }
}
