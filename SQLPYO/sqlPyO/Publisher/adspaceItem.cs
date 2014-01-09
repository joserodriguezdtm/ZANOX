// Type: ZanoxV2.Publisher.adspaceItem
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
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [Serializable]
  public class adspaceItem
  {
    private string nameField;
    private string urlField;
    private string descriptionField;
    private adspaceTypeEnum adspaceTypeField;
    private int visitorsField;
    private int impressionsField;
    private adspaceScopeEnum scopeField;
    private bool scopeFieldSpecified;
    private string[] regionsField;
    private subStringIdentifierType[] categoriesField;
    private string languageField;
    private int checkNumberField;
    private int idField;
    private bool idFieldSpecified;

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

    public adspaceTypeEnum adspaceType
    {
      get
      {
        return this.adspaceTypeField;
      }
      set
      {
        this.adspaceTypeField = value;
      }
    }

    public int visitors
    {
      get
      {
        return this.visitorsField;
      }
      set
      {
        this.visitorsField = value;
      }
    }

    public int impressions
    {
      get
      {
        return this.impressionsField;
      }
      set
      {
        this.impressionsField = value;
      }
    }

    public adspaceScopeEnum scope
    {
      get
      {
        return this.scopeField;
      }
      set
      {
        this.scopeField = value;
      }
    }

    [XmlIgnore]
    public bool scopeSpecified
    {
      get
      {
        return this.scopeFieldSpecified;
      }
      set
      {
        this.scopeFieldSpecified = value;
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

    public string language
    {
      get
      {
        return this.languageField;
      }
      set
      {
        this.languageField = value;
      }
    }

    public int checkNumber
    {
      get
      {
        return this.checkNumberField;
      }
      set
      {
        this.checkNumberField = value;
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

    [XmlIgnore]
    public bool idSpecified
    {
      get
      {
        return this.idFieldSpecified;
      }
      set
      {
        this.idFieldSpecified = value;
      }
    }
  }
}
