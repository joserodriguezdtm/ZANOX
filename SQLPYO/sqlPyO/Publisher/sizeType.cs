// Type: ZanoxV2.Publisher.sizeType
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
  public class sizeType
  {
    private int widthField;
    private bool widthFieldSpecified;
    private int heightField;
    private bool heightFieldSpecified;
    private subStringIdentifierType formatField;

    public int width
    {
      get
      {
        return this.widthField;
      }
      set
      {
        this.widthField = value;
      }
    }

    [XmlIgnore]
    public bool widthSpecified
    {
      get
      {
        return this.widthFieldSpecified;
      }
      set
      {
        this.widthFieldSpecified = value;
      }
    }

    public int height
    {
      get
      {
        return this.heightField;
      }
      set
      {
        this.heightField = value;
      }
    }

    [XmlIgnore]
    public bool heightSpecified
    {
      get
      {
        return this.heightFieldSpecified;
      }
      set
      {
        this.heightFieldSpecified = value;
      }
    }

    public subStringIdentifierType format
    {
      get
      {
        return this.formatField;
      }
      set
      {
        this.formatField = value;
      }
    }
  }
}
