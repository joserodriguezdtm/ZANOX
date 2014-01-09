// Type: ZanoxV2.Publisher.programItem
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
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class programItem
  {
    private string nameField;
    private float adrankField;
    private bool applicationRequiredField;
    private string descriptionField;
    private string descriptionLocalField;
    private long productsField;
    private subStringIdentifierType verticalField;
    private string[] regionsField;
    private subStringIdentifierType[] categoriesField;
    private DateTime startDateField;
    private string urlField;
    private string imageField;
    private string currencyField;
    private programStatusEnum statusField;
    private string termsField;
    private string termsUrlField;
    private subStringIdentifierType[] policiesField;
    private string returnTimeLeadsField;
    private string returnTimeSalesField;
    private int idField;

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

    public float adrank
    {
      get
      {
        return this.adrankField;
      }
      set
      {
        this.adrankField = value;
      }
    }

    public bool applicationRequired
    {
      get
      {
        return this.applicationRequiredField;
      }
      set
      {
        this.applicationRequiredField = value;
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

    public string descriptionLocal
    {
      get
      {
        return this.descriptionLocalField;
      }
      set
      {
        this.descriptionLocalField = value;
      }
    }

    public long products
    {
      get
      {
        return this.productsField;
      }
      set
      {
        this.productsField = value;
      }
    }

    public subStringIdentifierType vertical
    {
      get
      {
        return this.verticalField;
      }
      set
      {
        this.verticalField = value;
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

    [XmlArrayItem("category", IsNullable = false)]
    public subStringIdentifierType[] categories
    {
      get
      {
        return this.categoriesField;
      }
      set
      {
        this.categoriesField = value;
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

    public string url
    {
      get
      {
        return this.urlField;
      }
      set
      {
        this.urlField = value;
      }
    }

    public string image
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

    public programStatusEnum status
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

    public string termsUrl
    {
      get
      {
        return this.termsUrlField;
      }
      set
      {
        this.termsUrlField = value;
      }
    }

    [XmlArrayItem("policy", IsNullable = false)]
    public subStringIdentifierType[] policies
    {
      get
      {
        return this.policiesField;
      }
      set
      {
        this.policiesField = value;
      }
    }

    public string returnTimeLeads
    {
      get
      {
        return this.returnTimeLeadsField;
      }
      set
      {
        this.returnTimeLeadsField = value;
      }
    }

    public string returnTimeSales
    {
      get
      {
        return this.returnTimeSalesField;
      }
      set
      {
        this.returnTimeSalesField = value;
      }
    }

    [XmlAttribute]
    public int id
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
