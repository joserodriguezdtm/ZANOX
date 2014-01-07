// Type: ZanoxV2.Publisher.reportItem
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
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [Serializable]
  public class reportItem
  {
    private string currencyField;
    private subStringIdentifierType programField;
    private subStringIdentifierType admediumField;
    private subStringIdentifierType adspaceField;
    private subStringIdentifierType admediumFormatField;
    private subStringIdentifierType trackingCategoryField;
    private string yearField;
    private string monthField;
    private string dayField;
    private subStringIdentifierType applicationField;
    private subStringIdentifierType mediaSlotField;
    private statsType totalField;
    private statsType openField;
    private statsType approvedField;
    private statsType confirmedField;
    private statsType rejectedField;

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

    public subStringIdentifierType admediumFormat
    {
      get
      {
        return this.admediumFormatField;
      }
      set
      {
        this.admediumFormatField = value;
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

    public string year
    {
      get
      {
        return this.yearField;
      }
      set
      {
        this.yearField = value;
      }
    }

    public string month
    {
      get
      {
        return this.monthField;
      }
      set
      {
        this.monthField = value;
      }
    }

    public string day
    {
      get
      {
        return this.dayField;
      }
      set
      {
        this.dayField = value;
      }
    }

    public subStringIdentifierType application
    {
      get
      {
        return this.applicationField;
      }
      set
      {
        this.applicationField = value;
      }
    }

    public subStringIdentifierType mediaSlot
    {
      get
      {
        return this.mediaSlotField;
      }
      set
      {
        this.mediaSlotField = value;
      }
    }

    public statsType total
    {
      get
      {
        return this.totalField;
      }
      set
      {
        this.totalField = value;
      }
    }

    public statsType open
    {
      get
      {
        return this.openField;
      }
      set
      {
        this.openField = value;
      }
    }

    public statsType approved
    {
      get
      {
        return this.approvedField;
      }
      set
      {
        this.approvedField = value;
      }
    }

    public statsType confirmed
    {
      get
      {
        return this.confirmedField;
      }
      set
      {
        this.confirmedField = value;
      }
    }

    public statsType rejected
    {
      get
      {
        return this.rejectedField;
      }
      set
      {
        this.rejectedField = value;
      }
    }
  }
}
