// Type: ZanoxV2.Publisher.incentiveItem
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
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class incentiveItem
  {
    private string nameField;
    private subStringIdentifierType programField;
    private admediumItem[] admediaField;
    private incentiveTypeEnum incentiveTypeField;
    private string[] regionsField;
    private DateTime createDateField;
    private DateTime modifiedDateField;
    private DateTime startDateField;
    private DateTime endDateField;
    private bool endDateFieldSpecified;
    private string info4publisherField;
    private string info4customerField;
    private string couponCodeField;
    private float totalField;
    private bool totalFieldSpecified;
    private string currencyField;
    private float percentageField;
    private bool percentageFieldSpecified;
    private string restrictionsField;
    private bool newCustomerOnlyField;
    private float minimumBasketValueField;
    private bool minimumBasketValueFieldSpecified;
    private prizeType[] prizesField;
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

    [XmlArrayItem(IsNullable = false)]
    public admediumItem[] admedia
    {
      get
      {
        return this.admediaField;
      }
      set
      {
        this.admediaField = value;
      }
    }

    public incentiveTypeEnum incentiveType
    {
      get
      {
        return this.incentiveTypeField;
      }
      set
      {
        this.incentiveTypeField = value;
      }
    }

    [XmlArrayItem("region", IsNullable = false)]
    public string[] regions
    {
      get
      {
        return this.regionsField;
      }
      set
      {
        this.regionsField = value;
      }
    }

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

    public DateTime startDate
    {
      get
      {
        return this.startDateField;
      }
      set
      {
        this.startDateField = value;
      }
    }

    public DateTime endDate
    {
      get
      {
        return this.endDateField;
      }
      set
      {
        this.endDateField = value;
      }
    }

    [XmlIgnore]
    public bool endDateSpecified
    {
      get
      {
        return this.endDateFieldSpecified;
      }
      set
      {
        this.endDateFieldSpecified = value;
      }
    }

    public string info4publisher
    {
      get
      {
        return this.info4publisherField;
      }
      set
      {
        this.info4publisherField = value;
      }
    }

    public string info4customer
    {
      get
      {
        return this.info4customerField;
      }
      set
      {
        this.info4customerField = value;
      }
    }

    public string couponCode
    {
      get
      {
        return this.couponCodeField;
      }
      set
      {
        this.couponCodeField = value;
      }
    }

    public float total
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

    [XmlIgnore]
    public bool totalSpecified
    {
      get
      {
        return this.totalFieldSpecified;
      }
      set
      {
        this.totalFieldSpecified = value;
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

    public float percentage
    {
      get
      {
        return this.percentageField;
      }
      set
      {
        this.percentageField = value;
      }
    }

    [XmlIgnore]
    public bool percentageSpecified
    {
      get
      {
        return this.percentageFieldSpecified;
      }
      set
      {
        this.percentageFieldSpecified = value;
      }
    }

    public string restrictions
    {
      get
      {
        return this.restrictionsField;
      }
      set
      {
        this.restrictionsField = value;
      }
    }

    public bool newCustomerOnly
    {
      get
      {
        return this.newCustomerOnlyField;
      }
      set
      {
        this.newCustomerOnlyField = value;
      }
    }

    public float minimumBasketValue
    {
      get
      {
        return this.minimumBasketValueField;
      }
      set
      {
        this.minimumBasketValueField = value;
      }
    }

    [XmlIgnore]
    public bool minimumBasketValueSpecified
    {
      get
      {
        return this.minimumBasketValueFieldSpecified;
      }
      set
      {
        this.minimumBasketValueFieldSpecified = value;
      }
    }

    [XmlArrayItem("prize", IsNullable = false)]
    public prizeType[] prizes
    {
      get
      {
        return this.prizesField;
      }
      set
      {
        this.prizesField = value;
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
