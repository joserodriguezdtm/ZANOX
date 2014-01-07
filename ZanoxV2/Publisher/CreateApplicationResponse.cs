// Type: ZanoxV2.Publisher.CreateApplicationResponse
// Assembly: ZanoxV2, Version=1.0.4955.28682, Culture=neutral, PublicKeyToken=d1e62d2627a2f3e0
// MVID: 35AD163E-3C46-45E7-B3AA-50397E6E2193
// Assembly location: C:\Users\daniel.lopez\Desktop\Zanox.API\ZanoxV2.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ZanoxV2.Publisher
{
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [Serializable]
  public class CreateApplicationResponse
  {
    private applicationItem applicationItemField;
    private string secretKeyField;
    private string connectIdField;
    private string publicKeyField;

    public applicationItem applicationItem
    {
      get
      {
        return this.applicationItemField;
      }
      set
      {
        this.applicationItemField = value;
      }
    }

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
  }
}
