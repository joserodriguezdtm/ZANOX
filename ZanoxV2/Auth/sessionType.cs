// Type: ZanoxV2.Auth.sessionType
// Assembly: ZanoxV2, Version=1.0.4955.28682, Culture=neutral, PublicKeyToken=d1e62d2627a2f3e0
// MVID: 35AD163E-3C46-45E7-B3AA-50397E6E2193
// Assembly location: C:\Users\daniel.lopez\Desktop\Zanox.API\ZanoxV2.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ZanoxV2.Auth
{
  [XmlType(Namespace = "http://auth.zanox.com/2011-05-01/")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [DebuggerStepThrough]
  [Serializable]
  public class sessionType
  {
    private string connectIdField;
    private string sessionKeyField;
    private string secretKeyField;
    private int sessionExpiresField;
    private string offlineTokenField;

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
    public string sessionKey
    {
      get
      {
        return this.sessionKeyField;
      }
      set
      {
        this.sessionKeyField = value;
      }
    }

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public string secretKey
    {
      get
      {
        return this.secretKeyField;
      }
      set
      {
        this.secretKeyField = value;
      }
    }

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public int sessionExpires
    {
      get
      {
        return this.sessionExpiresField;
      }
      set
      {
        this.sessionExpiresField = value;
      }
    }

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
  }
}
