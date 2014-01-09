// Type: ZanoxV2.Publisher.GetReportBasicRequest
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
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [Serializable]
  public class GetReportBasicRequest
  {
    private string currencyField;
    private int programIdField;
    private bool programIdFieldSpecified;
    private int admediumIdField;
    private bool admediumIdFieldSpecified;
    private int adspaceIdField;
    private bool adspaceIdFieldSpecified;
    private reviewStateEnum reviewStateField;
    private bool reviewStateFieldSpecified;
    private groupByEnum[] groupByField;
    private DateTime fromDateField;
    private DateTime toDateField;
    private string connectIdField;
    private string timestampField;
    private string nonceField;
    private string signatureField;

    public string currency
    {
      get
      {
        return this.currencyField;
      }
      set
      {
        this.currencyField = value;
      }
    }

    public int programId
    {
      get
      {
        return this.programIdField;
      }
      set
      {
        this.programIdField = value;
      }
    }

    [XmlIgnore]
    public bool programIdSpecified
    {
      get
      {
        return this.programIdFieldSpecified;
      }
      set
      {
        this.programIdFieldSpecified = value;
      }
    }

    public int admediumId
    {
      get
      {
        return this.admediumIdField;
      }
      set
      {
        this.admediumIdField = value;
      }
    }

    [XmlIgnore]
    public bool admediumIdSpecified
    {
      get
      {
        return this.admediumIdFieldSpecified;
      }
      set
      {
        this.admediumIdFieldSpecified = value;
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

    public reviewStateEnum reviewState
    {
      get
      {
        return this.reviewStateField;
      }
      set
      {
        this.reviewStateField = value;
      }
    }

    [XmlIgnore]
    public bool reviewStateSpecified
    {
      get
      {
        return this.reviewStateFieldSpecified;
      }
      set
      {
        this.reviewStateFieldSpecified = value;
      }
    }

    [XmlElement("groupBy")]
    public groupByEnum[] groupBy
    {
      get
      {
        return this.groupByField;
      }
      set
      {
        this.groupByField = value;
      }
    }

    public DateTime fromDate
    {
      get
      {
        return this.fromDateField;
      }
      set
      {
        this.fromDateField = value;
      }
    }

    public DateTime toDate
    {
      get
      {
        return this.toDateField;
      }
      set
      {
        this.toDateField = value;
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
