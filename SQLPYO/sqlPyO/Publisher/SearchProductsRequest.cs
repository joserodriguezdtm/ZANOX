// Type: ZanoxV2.Publisher.SearchProductsRequest
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
  public class SearchProductsRequest
  {
    private string queryField;
    private searchTypeEnum searchTypeField;
    private bool searchTypeFieldSpecified;
    private string regionField;
    private int categoryIdField;
    private bool categoryIdFieldSpecified;
    private int[] programIdField;
    private bool hasImagesField;
    private bool hasImagesFieldSpecified;
    private int minPriceField;
    private bool minPriceFieldSpecified;
    private int maxPriceField;
    private bool maxPriceFieldSpecified;
    private int adspaceIdField;
    private bool adspaceIdFieldSpecified;
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

    public searchTypeEnum searchType
    {
      get
      {
        return this.searchTypeField;
      }
      set
      {
        this.searchTypeField = value;
      }
    }

    [XmlIgnore]
    public bool searchTypeSpecified
    {
      get
      {
        return this.searchTypeFieldSpecified;
      }
      set
      {
        this.searchTypeFieldSpecified = value;
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

    [XmlElement("programId")]
    public int[] programId
    {
      get
      {
        return this.programIdField;
      }
      set
      {
        this.programIdField = value;
      }
    }

    public bool hasImages
    {
      get
      {
        return this.hasImagesField;
      }
      set
      {
        this.hasImagesField = value;
      }
    }

    [XmlIgnore]
    public bool hasImagesSpecified
    {
      get
      {
        return this.hasImagesFieldSpecified;
      }
      set
      {
        this.hasImagesFieldSpecified = value;
      }
    }

    public int minPrice
    {
      get
      {
        return this.minPriceField;
      }
      set
      {
        this.minPriceField = value;
      }
    }

    [XmlIgnore]
    public bool minPriceSpecified
    {
      get
      {
        return this.minPriceFieldSpecified;
      }
      set
      {
        this.minPriceFieldSpecified = value;
      }
    }

    public int maxPrice
    {
      get
      {
        return this.maxPriceField;
      }
      set
      {
        this.maxPriceField = value;
      }
    }

    [XmlIgnore]
    public bool maxPriceSpecified
    {
      get
      {
        return this.maxPriceFieldSpecified;
      }
      set
      {
        this.maxPriceFieldSpecified = value;
      }
    }

    public int adspaceId
    {
      get
      {
        return this.adspaceIdField;
      }
      set
      {
        this.adspaceIdField = value;
      }
    }

    [XmlIgnore]
    public bool adspaceIdSpecified
    {
      get
      {
        return this.adspaceIdFieldSpecified;
      }
      set
      {
        this.adspaceIdFieldSpecified = value;
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
