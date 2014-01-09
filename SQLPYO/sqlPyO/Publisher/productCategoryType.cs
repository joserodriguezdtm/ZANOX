// Type: ZanoxV2.Publisher.productCategoryType
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
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class productCategoryType
  {
    private int idField;
    private string nameField;
    private int countField;
    private productCategoryType[] categoryField;

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

    public int count
    {
      get
      {
        return this.countField;
      }
      set
      {
        this.countField = value;
      }
    }

    [XmlElement("category")]
    public productCategoryType[] category
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
  }
}
