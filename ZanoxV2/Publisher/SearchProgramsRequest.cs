// Type: ZanoxV2.Publisher.SearchProgramsRequest
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
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class SearchProgramsRequest
  {
    private string queryField;
    private DateTime startDateField;
    private bool startDateFieldSpecified;
    private partnerShipEnum partnerShipField;
    private bool partnerShipFieldSpecified;
    private bool hasProductsField;
    private bool hasProductsFieldSpecified;
    private string regionField;
    private int categoryIdField;
    private bool categoryIdFieldSpecified;
    private int pageField;
    private bool pageFieldSpecified;
    private int itemsField;
    private bool itemsFieldSpecified;
    private string connectIdField;

    public string query
    {
      get
      {
        return this.queryField;
      }
      set
      {
        this.queryField = value;
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

    [XmlIgnore]
    public bool startDateSpecified
    {
      get
      {
        return this.startDateFieldSpecified;
      }
      set
      {
        this.startDateFieldSpecified = value;
      }
    }

    public partnerShipEnum partnerShip
    {
      get
      {
        return this.partnerShipField;
      }
      set
      {
        this.partnerShipField = value;
      }
    }

    [XmlIgnore]
    public bool partnerShipSpecified
    {
      get
      {
        return this.partnerShipFieldSpecified;
      }
      set
      {
        this.partnerShipFieldSpecified = value;
      }
    }

    public bool hasProducts
    {
      get
      {
        return this.hasProductsField;
      }
      set
      {
        this.hasProductsField = value;
      }
    }

    [XmlIgnore]
    public bool hasProductsSpecified
    {
      get
      {
        return this.hasProductsFieldSpecified;
      }
      set
      {
        this.hasProductsFieldSpecified = value;
      }
    }

    public string region
    {
      get
      {
        return this.regionField;
      }
      set
      {
        this.regionField = value;
      }
    }

    public int categoryId
    {
      get
      {
        return this.categoryIdField;
      }
      set
      {
        this.categoryIdField = value;
      }
    }

    [XmlIgnore]
    public bool categoryIdSpecified
    {
      get
      {
        return this.categoryIdFieldSpecified;
      }
      set
      {
        this.categoryIdFieldSpecified = value;
      }
    }

    public int page
    {
      get
      {
        return this.pageField;
      }
      set
      {
        this.pageField = value;
      }
    }

    [XmlIgnore]
    public bool pageSpecified
    {
      get
      {
        return this.pageFieldSpecified;
      }
      set
      {
        this.pageFieldSpecified = value;
      }
    }

    public int items
    {
      get
      {
        return this.itemsField;
      }
      set
      {
        this.itemsField = value;
      }
    }

    [XmlIgnore]
    public bool itemsSpecified
    {
      get
      {
        return this.itemsFieldSpecified;
      }
      set
      {
        this.itemsFieldSpecified = value;
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
  }
}
