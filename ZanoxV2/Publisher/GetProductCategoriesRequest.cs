// Type: ZanoxV2.Publisher.GetProductCategoriesRequest
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
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [DebuggerStepThrough]
  [Serializable]
  public class GetProductCategoriesRequest
  {
    private int rootCategoryField;
    private bool rootCategoryFieldSpecified;
    private bool includeChildsField;
    private bool includeChildsFieldSpecified;
    private string regionField;
    private string connectIdField;

    public int rootCategory
    {
      get
      {
        return this.rootCategoryField;
      }
      set
      {
        this.rootCategoryField = value;
      }
    }

    [XmlIgnore]
    public bool rootCategorySpecified
    {
      get
      {
        return this.rootCategoryFieldSpecified;
      }
      set
      {
        this.rootCategoryFieldSpecified = value;
      }
    }

    public bool includeChilds
    {
      get
      {
        return this.includeChildsField;
      }
      set
      {
        this.includeChildsField = value;
      }
    }

    [XmlIgnore]
    public bool includeChildsSpecified
    {
      get
      {
        return this.includeChildsFieldSpecified;
      }
      set
      {
        this.includeChildsFieldSpecified = value;
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
