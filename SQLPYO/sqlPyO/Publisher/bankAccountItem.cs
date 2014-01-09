// Type: ZanoxV2.Publisher.bankAccountItem
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
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [DebuggerStepThrough]
  [Serializable]
  public class bankAccountItem
  {
    private string nameField;
    private string ibanField;
    private string swiftField;
    private string bankCodeField;
    private string accountNumberField;
    private string ownerField;
    private string addressField;
    private string countryField;
    private double minPayoutField;
    private string idField;

    public string name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    public string iban
    {
      get
      {
        return this.ibanField;
      }
      set
      {
        this.ibanField = value;
      }
    }

    public string swift
    {
      get
      {
        return this.swiftField;
      }
      set
      {
        this.swiftField = value;
      }
    }

    public string bankCode
    {
      get
      {
        return this.bankCodeField;
      }
      set
      {
        this.bankCodeField = value;
      }
    }

    public string accountNumber
    {
      get
      {
        return this.accountNumberField;
      }
      set
      {
        this.accountNumberField = value;
      }
    }

    public string owner
    {
      get
      {
        return this.ownerField;
      }
      set
      {
        this.ownerField = value;
      }
    }

    public string address
    {
      get
      {
        return this.addressField;
      }
      set
      {
        this.addressField = value;
      }
    }

    public string country
    {
      get
      {
        return this.countryField;
      }
      set
      {
        this.countryField = value;
      }
    }

    public double minPayout
    {
      get
      {
        return this.minPayoutField;
      }
      set
      {
        this.minPayoutField = value;
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
