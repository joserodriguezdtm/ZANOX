// Type: ZanoxV2.Publisher.statsType
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
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [DebuggerStepThrough]
  [Serializable]
  public class statsType
  {
    private long viewCountField;
    private bool viewCountFieldSpecified;
    private long tpvCountField;
    private bool tpvCountFieldSpecified;
    private long clickCountField;
    private bool clickCountFieldSpecified;
    private double clickCommissionField;
    private bool clickCommissionFieldSpecified;
    private long leadCountField;
    private bool leadCountFieldSpecified;
    private double leadCommissionField;
    private bool leadCommissionFieldSpecified;
    private long saleCountField;
    private bool saleCountFieldSpecified;
    private double saleCommissionField;
    private bool saleCommissionFieldSpecified;
    private double saleAmountField;
    private bool saleAmountFieldSpecified;

    public long viewCount
    {
      get
      {
        return this.viewCountField;
      }
      set
      {
        this.viewCountField = value;
      }
    }

    [XmlIgnore]
    public bool viewCountSpecified
    {
      get
      {
        return this.viewCountFieldSpecified;
      }
      set
      {
        this.viewCountFieldSpecified = value;
      }
    }

    public long tpvCount
    {
      get
      {
        return this.tpvCountField;
      }
      set
      {
        this.tpvCountField = value;
      }
    }

    [XmlIgnore]
    public bool tpvCountSpecified
    {
      get
      {
        return this.tpvCountFieldSpecified;
      }
      set
      {
        this.tpvCountFieldSpecified = value;
      }
    }

    public long clickCount
    {
      get
      {
        return this.clickCountField;
      }
      set
      {
        this.clickCountField = value;
      }
    }

    [XmlIgnore]
    public bool clickCountSpecified
    {
      get
      {
        return this.clickCountFieldSpecified;
      }
      set
      {
        this.clickCountFieldSpecified = value;
      }
    }

    public double clickCommission
    {
      get
      {
        return this.clickCommissionField;
      }
      set
      {
        this.clickCommissionField = value;
      }
    }

    [XmlIgnore]
    public bool clickCommissionSpecified
    {
      get
      {
        return this.clickCommissionFieldSpecified;
      }
      set
      {
        this.clickCommissionFieldSpecified = value;
      }
    }

    public long leadCount
    {
      get
      {
        return this.leadCountField;
      }
      set
      {
        this.leadCountField = value;
      }
    }

    [XmlIgnore]
    public bool leadCountSpecified
    {
      get
      {
        return this.leadCountFieldSpecified;
      }
      set
      {
        this.leadCountFieldSpecified = value;
      }
    }

    public double leadCommission
    {
      get
      {
        return this.leadCommissionField;
      }
      set
      {
        this.leadCommissionField = value;
      }
    }

    [XmlIgnore]
    public bool leadCommissionSpecified
    {
      get
      {
        return this.leadCommissionFieldSpecified;
      }
      set
      {
        this.leadCommissionFieldSpecified = value;
      }
    }

    public long saleCount
    {
      get
      {
        return this.saleCountField;
      }
      set
      {
        this.saleCountField = value;
      }
    }

    [XmlIgnore]
    public bool saleCountSpecified
    {
      get
      {
        return this.saleCountFieldSpecified;
      }
      set
      {
        this.saleCountFieldSpecified = value;
      }
    }

    public double saleCommission
    {
      get
      {
        return this.saleCommissionField;
      }
      set
      {
        this.saleCommissionField = value;
      }
    }

    [XmlIgnore]
    public bool saleCommissionSpecified
    {
      get
      {
        return this.saleCommissionFieldSpecified;
      }
      set
      {
        this.saleCommissionFieldSpecified = value;
      }
    }

    public double saleAmount
    {
      get
      {
        return this.saleAmountField;
      }
      set
      {
        this.saleAmountField = value;
      }
    }

    [XmlIgnore]
    public bool saleAmountSpecified
    {
      get
      {
        return this.saleAmountFieldSpecified;
      }
      set
      {
        this.saleAmountFieldSpecified = value;
      }
    }
  }
}
