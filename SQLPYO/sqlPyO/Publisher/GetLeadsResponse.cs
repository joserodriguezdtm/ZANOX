﻿// Type: ZanoxV2.Publisher.GetLeadsResponse
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [Serializable]
  public class GetLeadsResponse
  {
    private int pageField;
    private int itemsField;
    private long totalField;
    private leadItem[] leadItemsField;

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

    [XmlArrayItem(IsNullable = false)]
    public leadItem[] leadItems
    {
      get
      {
        return this.leadItemsField;
      }
      set
      {
        this.leadItemsField = value;
      }
    }
  }
}
