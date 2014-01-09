// Type: ZanoxV2.Publisher.saleItem
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
  public class saleItem
  {
    private reviewStateEnum reviewStateField;
    private DateTime trackingDateField;
    private bool trackingDateFieldSpecified;
    private DateTime modifiedDateField;
    private bool modifiedDateFieldSpecified;
    private DateTime clickDateField;
    private bool clickDateFieldSpecified;
    private subStringIdentifierType adspaceField;
    private subStringIdentifierType admediumField;
    private subStringIdentifierType programField;
    private long clickIdField;
    private long clickInIdField;
    private double amountField;
    private double commissionField;
    private string currencyField;
    private subPublisherType subPublisherField;
    private gppType[] gppsField;
    private string reviewNoteField;
    private subStringIdentifierType trackingCategoryField;
    private string idField;

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

    public DateTime trackingDate
    {
      get
      {
        return this.trackingDateField;
      }
      set
      {
        this.trackingDateField = value;
      }
    }

    [XmlIgnore]
    public bool trackingDateSpecified
    {
      get
      {
        return this.trackingDateFieldSpecified;
      }
      set
      {
        this.trackingDateFieldSpecified = value;
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

    public DateTime clickDate
    {
      get
      {
        return this.clickDateField;
      }
      set
      {
        this.clickDateField = value;
      }
    }

    [XmlIgnore]
    public bool clickDateSpecified
    {
      get
      {
        return this.clickDateFieldSpecified;
      }
      set
      {
        this.clickDateFieldSpecified = value;
      }
    }

    public subStringIdentifierType adspace
    {
      get
      {
        return this.adspaceField;
      }
      set
      {
        this.adspaceField = value;
      }
    }

    public subStringIdentifierType admedium
    {
      get
      {
        return this.admediumField;
      }
      set
      {
        this.admediumField = value;
      }
    }

    public subStringIdentifierType program
    {
      get
      {
        return this.programField;
      }
      set
      {
        this.programField = value;
      }
    }

    public long clickId
    {
      get
      {
        return this.clickIdField;
      }
      set
      {
        this.clickIdField = value;
      }
    }

    public long clickInId
    {
      get
      {
        return this.clickInIdField;
      }
      set
      {
        this.clickInIdField = value;
      }
    }

    public double amount
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

    public double commission
    {
      get
      {
        return this.commissionField;
      }
      set
      {
        this.commissionField = value;
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

    public subPublisherType subPublisher
    {
      get
      {
        return this.subPublisherField;
      }
      set
      {
        this.subPublisherField = value;
      }
    }

    [XmlArrayItem("gpp", IsNullable = false)]
    public gppType[] gpps
    {
      get
      {
        return this.gppsField;
      }
      set
      {
        this.gppsField = value;
      }
    }

    public string reviewNote
    {
      get
      {
        return this.reviewNoteField;
      }
      set
      {
        this.reviewNoteField = value;
      }
    }

    public subStringIdentifierType trackingCategory
    {
      get
      {
        return this.trackingCategoryField;
      }
      set
      {
        this.trackingCategoryField = value;
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
