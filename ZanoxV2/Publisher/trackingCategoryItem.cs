// Type: ZanoxV2.Publisher.trackingCategoryItem
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [Serializable]
  public class trackingCategoryItem
  {
    private string nameField;
    private subStringIdentifierType programField;
    private subStringIdentifierType adspaceField;
    private transactionTypeEnum transactionTypeField;
    private bool transactionTypeFieldSpecified;
    private string processingTimeField;
    private string descriptionField;
    private float viewFixedField;
    private bool viewFixedFieldSpecified;
    private float clickFixedField;
    private bool clickFixedFieldSpecified;
    private float leadFixedField;
    private bool leadFixedFieldSpecified;
    private float saleFixedField;
    private bool saleFixedFieldSpecified;
    private float salePercentField;
    private bool salePercentFieldSpecified;
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

    public transactionTypeEnum transactionType
    {
      get
      {
        return this.transactionTypeField;
      }
      set
      {
        this.transactionTypeField = value;
      }
    }

    [XmlIgnore]
    public bool transactionTypeSpecified
    {
      get
      {
        return this.transactionTypeFieldSpecified;
      }
      set
      {
        this.transactionTypeFieldSpecified = value;
      }
    }

    public string processingTime
    {
      get
      {
        return this.processingTimeField;
      }
      set
      {
        this.processingTimeField = value;
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

    public float viewFixed
    {
      get
      {
        return this.viewFixedField;
      }
      set
      {
        this.viewFixedField = value;
      }
    }

    [XmlIgnore]
    public bool viewFixedSpecified
    {
      get
      {
        return this.viewFixedFieldSpecified;
      }
      set
      {
        this.viewFixedFieldSpecified = value;
      }
    }

    public float clickFixed
    {
      get
      {
        return this.clickFixedField;
      }
      set
      {
        this.clickFixedField = value;
      }
    }

    [XmlIgnore]
    public bool clickFixedSpecified
    {
      get
      {
        return this.clickFixedFieldSpecified;
      }
      set
      {
        this.clickFixedFieldSpecified = value;
      }
    }

    public float leadFixed
    {
      get
      {
        return this.leadFixedField;
      }
      set
      {
        this.leadFixedField = value;
      }
    }

    [XmlIgnore]
    public bool leadFixedSpecified
    {
      get
      {
        return this.leadFixedFieldSpecified;
      }
      set
      {
        this.leadFixedFieldSpecified = value;
      }
    }

    public float saleFixed
    {
      get
      {
        return this.saleFixedField;
      }
      set
      {
        this.saleFixedField = value;
      }
    }

    [XmlIgnore]
    public bool saleFixedSpecified
    {
      get
      {
        return this.saleFixedFieldSpecified;
      }
      set
      {
        this.saleFixedFieldSpecified = value;
      }
    }

    public float salePercent
    {
      get
      {
        return this.salePercentField;
      }
      set
      {
        this.salePercentField = value;
      }
    }

    [XmlIgnore]
    public bool salePercentSpecified
    {
      get
      {
        return this.salePercentFieldSpecified;
      }
      set
      {
        this.salePercentFieldSpecified = value;
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
