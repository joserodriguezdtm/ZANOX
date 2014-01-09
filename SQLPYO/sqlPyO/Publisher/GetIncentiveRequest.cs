// Type: ZanoxV2.Publisher.GetIncentiveRequest
// Assembly: ZanoxV2, Version=1.0.4955.28682, Culture=neutral, PublicKeyToken=d1e62d2627a2f3e0
// MVID: 35AD163E-3C46-45E7-B3AA-50397E6E2193
// Assembly location: C:\Users\daniel.lopez\Desktop\Zanox.API\ZanoxV2.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace sqlPyO.Publisher
{
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class GetIncentiveRequest
  {
    private string incentiveIdField;
    private int adspaceIdField;
    private bool adspaceIdFieldSpecified;
    private string connectIdField;

    public string incentiveId
    {
      get
      {
        return this.incentiveIdField;
      }
      set
      {
        this.incentiveIdField = value;
      }
    }

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
  }
}
