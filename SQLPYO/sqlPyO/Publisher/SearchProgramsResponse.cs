// Type: ZanoxV2.Publisher.SearchProgramsResponse
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
  public class SearchProgramsResponse
  {
    private int pageField;
    private int itemsField;
    private long totalField;
    private string queryField;
    private programItem[] programItemsField;

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

    public long total
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

    [XmlArrayItem(IsNullable = false)]
    public programItem[] programItems
    {
      get
      {
        return this.programItemsField;
      }
      set
      {
        this.programItemsField = value;
      }
    }
  }
}
