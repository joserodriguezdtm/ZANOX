// Type: ZanoxV2.Publisher.settingItem
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
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [DesignerCategory("code")]
  [Serializable]
  public class settingItem
  {
    private subStringIdentifierStringType applicationField;
    private subStringIdentifierStringType mediaslotField;
    private string keyField;
    private string valueField;
    private string customValueField;
    private settingTypeEnum typeField;
    private bool typeFieldSpecified;
    private string nameField;
    private string descriptionField;
    private bool mandatoryField;

    public subStringIdentifierStringType application
    {
      get
      {
        return this.applicationField;
      }
      set
      {
        this.applicationField = value;
      }
    }

    public subStringIdentifierStringType mediaslot
    {
      get
      {
        return this.mediaslotField;
      }
      set
      {
        this.mediaslotField = value;
      }
    }

    public string key
    {
      get
      {
        return this.keyField;
      }
      set
      {
        this.keyField = value;
      }
    }

    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    public string customValue
    {
      get
      {
        return this.customValueField;
      }
      set
      {
        this.customValueField = value;
      }
    }

    public settingTypeEnum type
    {
      get
      {
        return this.typeField;
      }
      set
      {
        this.typeField = value;
      }
    }

    [XmlIgnore]
    public bool typeSpecified
    {
      get
      {
        return this.typeFieldSpecified;
      }
      set
      {
        this.typeFieldSpecified = value;
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

    [DefaultValue(false)]
    public bool mandatory
    {
      get
      {
        return this.mandatoryField;
      }
      set
      {
        this.mandatoryField = value;
      }
    }

    public settingItem()
    {
      this.mandatoryField = false;
    }
  }
}
