// Type: ZanoxV2.Publisher.balanceItem
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
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class balanceItem
  {
    private float openField;
    private float confirmedField;
    private string idField;

    public float open
    {
      get
      {
        return this.openField;
      }
      set
      {
        this.openField = value;
      }
    }

    public float confirmed
    {
      get
      {
        return this.confirmedField;
      }
      set
      {
        this.confirmedField = value;
      }
    }

    [XmlAttribute]
    public string id
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
