// Type: ZanoxV2.Publisher.productItem
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
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [DebuggerStepThrough]
  [Serializable]
  public class productItem
  {
    private string nameField;
    private DateTime modifiedField;
    private subStringIdentifierType programField;
    private float priceField;
    private string currencyField;
    private trackingLinkType[] trackingLinksField;
    private string descriptionField;
    private string descriptionLongField;
    private string manufacturerField;
    private string eanField;
    private string deliveryTimeField;
    private string termsField;
    private subStringIdentifierType categoryField;
    private imageType imageField;
    private float priceOldField;
    private bool priceOldFieldSpecified;
    private string shippingCostsField;
    private string shippingField;
    private string merchantCategoryField;
    private string merchantProductIdField;
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

    public DateTime modified
    {
      get
      {
        return this.modifiedField;
      }
      set
      {
        this.modifiedField = value;
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

    public float price
    {
      get
      {
        return this.priceField;
      }
      set
      {
        this.priceField = value;
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

    [XmlArrayItem("trackingLink", IsNullable = false)]
    public trackingLinkType[] trackingLinks
    {
      get
      {
        return this.trackingLinksField;
      }
      set
      {
        this.trackingLinksField = value;
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

    public string descriptionLong
    {
      get
      {
        return this.descriptionLongField;
      }
      set
      {
        this.descriptionLongField = value;
      }
    }

    public string manufacturer
    {
      get
      {
        return this.manufacturerField;
      }
      set
      {
        this.manufacturerField = value;
      }
    }

    public string ean
    {
      get
      {
        return this.eanField;
      }
      set
      {
        this.eanField = value;
      }
    }

    public string deliveryTime
    {
      get
      {
        return this.deliveryTimeField;
      }
      set
      {
        this.deliveryTimeField = value;
      }
    }

    public string terms
    {
      get
      {
        return this.termsField;
      }
      set
      {
        this.termsField = value;
      }
    }

    public subStringIdentifierType category
    {
      get
      {
        return this.categoryField;
      }
      set
      {
        this.categoryField = value;
      }
    }

    public imageType image
    {
      get
      {
        return this.imageField;
      }
      set
      {
        this.imageField = value;
      }
    }

    public float priceOld
    {
      get
      {
        return this.priceOldField;
      }
      set
      {
        this.priceOldField = value;
      }
    }

    [XmlIgnore]
    public bool priceOldSpecified
    {
      get
      {
        return this.priceOldFieldSpecified;
      }
      set
      {
        this.priceOldFieldSpecified = value;
      }
    }

    public string shippingCosts
    {
      get
      {
        return this.shippingCostsField;
      }
      set
      {
        this.shippingCostsField = value;
      }
    }

    public string shipping
    {
      get
      {
        return this.shippingField;
      }
      set
      {
        this.shippingField = value;
      }
    }

    public string merchantCategory
    {
      get
      {
        return this.merchantCategoryField;
      }
      set
      {
        this.merchantCategoryField = value;
      }
    }

    public string merchantProductId
    {
      get
      {
        return this.merchantProductIdField;
      }
      set
      {
        this.merchantProductIdField = value;
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
