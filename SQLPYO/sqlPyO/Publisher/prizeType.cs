// Type: ZanoxV2.Publisher.prizeType
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
  [DebuggerStepThrough]
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [Serializable]
  public class prizeType
  {
    private string nameField;
    private string descriptionField;
    private int countField;
    private int rankField;
    private string idField;

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

    public int rank
    {
      get
      {
        return this.rankField;
      }
      set
      {
        this.rankField = value;
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
