// Type: ZanoxV2.Publisher.imageType
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
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [Serializable]
  public class imageType
  {
    private string smallField;
    private string mediumField;
    private string largeField;

    [XmlElement(DataType = "anyURI")]
    public string small
    {
      get
      {
        return this.smallField;
      }
      set
      {
        this.smallField = value;
      }
    }

    [XmlElement(DataType = "anyURI")]
    public string medium
    {
      get
      {
        return this.mediumField;
      }
      set
      {
        this.mediumField = value;
      }
    }

    [XmlElement(DataType = "anyURI")]
    public string large
    {
      get
      {
        return this.largeField;
      }
      set
      {
        this.largeField = value;
      }
    }
  }
}
