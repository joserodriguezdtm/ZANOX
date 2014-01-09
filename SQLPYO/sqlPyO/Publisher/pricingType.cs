// Type: ZanoxV2.Publisher.pricingType
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
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [DesignerCategory("code")]
  [Serializable]
  public class pricingType
  {
    private double shareField;
    private double setupField;
    private bool setupFieldSpecified;
    private double monthlyField;
    private string currencyField;
    private string descriptionField;
    private string idField;

    public double share
    {
      get
      {
        return this.shareField;
      }
      set
      {
        this.shareField = value;
      }
    }

    public double setup
    {
      get
      {
        return this.setupField;
      }
      set
      {
        this.setupField = value;
      }
    }

    [XmlIgnore]
    public bool setupSpecified
    {
      get
      {
        return this.setupFieldSpecified;
      }
      set
      {
        this.setupFieldSpecified = value;
      }
    }

    public double monthly
    {
      get
      {
        return this.monthlyField;
      }
      set
      {
        this.monthlyField = value;
      }
    }

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

    public string description
    {
      get
      {
        return this.descriptionField;
      }
      set
      {
        this.descriptionField = value;
      }
    }

    [XmlAttribute]
    public string id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }
  }
}
