// Type: ZanoxV2.Publisher.trackingLinkType
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [Serializable]
  public class trackingLinkType
  {
    private string ppvField;
    private string ppcField;
    private string tpvField;
    private int adspaceIdField;
    private bool adspaceIdFieldSpecified;

    public string ppv
    {
      get
      {
        return this.ppvField;
      }
      set
      {
        this.ppvField = value;
      }
    }

    public string ppc
    {
      get
      {
        return this.ppcField;
      }
      set
      {
        this.ppcField = value;
      }
    }

    public string tpv
    {
      get
      {
        return this.tpvField;
      }
      set
      {
        this.tpvField = value;
      }
    }

    [XmlAttribute]
    public int adspaceId
    {
      get
      {
        return this.adspaceIdField;
      }
      set
      {
        this.adspaceIdField = value;
      }
    }

    [XmlIgnore]
    public bool adspaceIdSpecified
    {
      get
      {
        return this.adspaceIdFieldSpecified;
      }
      set
      {
        this.adspaceIdFieldSpecified = value;
      }
    }
  }
}
