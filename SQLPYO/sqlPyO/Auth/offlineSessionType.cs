// Type: ZanoxV2.Auth.offlineSessionType
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
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://auth.zanox.com/2011-05-01/")]
  [DebuggerStepThrough]
  [Serializable]
  public class offlineSessionType
  {
    private string connectIdField;
    private string sessionKeyField;
    private string secretKeyField;
    private string connectSessionTokenField;

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
    public string connectSessionToken
    {
      get
      {
        return this.connectSessionTokenField;
      }
      set
      {
        this.connectSessionTokenField = value;
      }
    }
  }
}
