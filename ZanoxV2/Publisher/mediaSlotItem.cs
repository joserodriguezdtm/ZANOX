// Type: ZanoxV2.Publisher.mediaSlotItem
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
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [Serializable]
  public class mediaSlotItem
  {
    private string nameField;
    private sizeType sizeField;
    private subStringIdentifierType adspaceField;
    private subStringIdentifierStringType[] applicationsField;
    private mediaSlotStatusEnum statusField;
    private DateTime createDateField;
    private bool createDateFieldSpecified;
    private DateTime modifiedDateField;
    private bool modifiedDateFieldSpecified;
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

    public sizeType size
    {
      get
      {
        return this.sizeField;
      }
      set
      {
        this.sizeField = value;
      }
    }

    public subStringIdentifierType adspace
    {
      get
      {
        return this.adspaceField;
      }
      set
      {
        this.adspaceField = value;
      }
    }

    [XmlArrayItem("application", IsNullable = false)]
    public subStringIdentifierStringType[] applications
    {
      get
      {
        return this.applicationsField;
      }
      set
      {
        this.applicationsField = value;
      }
    }

    public mediaSlotStatusEnum status
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

    public DateTime createDate
    {
      get
      {
        return this.createDateField;
      }
      set
      {
        this.createDateField = value;
      }
    }

    [XmlIgnore]
    public bool createDateSpecified
    {
      get
      {
        return this.createDateFieldSpecified;
      }
      set
      {
        this.createDateFieldSpecified = value;
      }
    }

    public DateTime modifiedDate
    {
      get
      {
        return this.modifiedDateField;
      }
      set
      {
        this.modifiedDateField = value;
      }
    }

    [XmlIgnore]
    public bool modifiedDateSpecified
    {
      get
      {
        return this.modifiedDateFieldSpecified;
      }
      set
      {
        this.modifiedDateFieldSpecified = value;
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
