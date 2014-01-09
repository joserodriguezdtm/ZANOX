// Type: ZanoxV2.Publisher.paymentItem
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
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [Serializable]
  public class paymentItem
  {
    private DateTime createDateField;
    private DateTime modifiedDateField;
    private bool modifiedDateFieldSpecified;
    private DateTime payoutDateField;
    private bool payoutDateFieldSpecified;
    private string statusField;
    private float amountField;
    private string currencyField;
    private bankAccountItem bankAccountItemField;
    private string idField;

    public DateTime createDate
    {
      get
      {
        return this.createDateField;
      }
      set
      {
        this.createDateField = value;
      }
    }

    public DateTime modifiedDate
    {
      get
      {
        return this.modifiedDateField;
      }
      set
      {
        this.modifiedDateField = value;
      }
    }

    [XmlIgnore]
    public bool modifiedDateSpecified
    {
      get
      {
        return this.modifiedDateFieldSpecified;
      }
      set
      {
        this.modifiedDateFieldSpecified = value;
      }
    }

    public DateTime payoutDate
    {
      get
      {
        return this.payoutDateField;
      }
      set
      {
        this.payoutDateField = value;
      }
    }

    [XmlIgnore]
    public bool payoutDateSpecified
    {
      get
      {
        return this.payoutDateFieldSpecified;
      }
      set
      {
        this.payoutDateFieldSpecified = value;
      }
    }

    public string status
    {
      get
      {
        return this.statusField;
      }
      set
      {
        this.statusField = value;
      }
    }

    public float amount
    {
      get
      {
        return this.amountField;
      }
      set
      {
        this.amountField = value;
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

    public bankAccountItem bankAccountItem
    {
      get
      {
        return this.bankAccountItemField;
      }
      set
      {
        this.bankAccountItemField = value;
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
