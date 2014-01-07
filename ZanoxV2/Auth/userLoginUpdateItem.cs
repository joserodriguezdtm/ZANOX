// Type: ZanoxV2.Auth.userLoginUpdateItem
// Assembly: ZanoxV2, Version=1.0.4955.28682, Culture=neutral, PublicKeyToken=d1e62d2627a2f3e0
// MVID: 35AD163E-3C46-45E7-B3AA-50397E6E2193
// Assembly location: C:\Users\daniel.lopez\Desktop\Zanox.API\ZanoxV2.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ZanoxV2.Auth
{
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://auth.zanox.com/2011-05-01/")]
  [DebuggerStepThrough]
  [Serializable]
  public class userLoginUpdateItem
  {
    private string firstNameField;
    private string lastNameField;
    private string languageField;
    private string currencyField;
    private string descriptionField;
    private loginStatusEnum statusField;
    private bool statusFieldSpecified;
    private loginTypeEnum loginTypeField;
    private bool loginTypeFieldSpecified;

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public string firstName
    {
      get
      {
        return this.firstNameField;
      }
      set
      {
        this.firstNameField = value;
      }
    }

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public string lastName
    {
      get
      {
        return this.lastNameField;
      }
      set
      {
        this.lastNameField = value;
      }
    }

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public string language
    {
      get
      {
        return this.languageField;
      }
      set
      {
        this.languageField = value;
      }
    }

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public string currency
    {
      get
      {
        return this.currencyField;
      }
      set
      {
        this.currencyField = value;
      }
    }

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
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

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public loginStatusEnum status
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

    [XmlIgnore]
    public bool statusSpecified
    {
      get
      {
        return this.statusFieldSpecified;
      }
      set
      {
        this.statusFieldSpecified = value;
      }
    }

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public loginTypeEnum loginType
    {
      get
      {
        return this.loginTypeField;
      }
      set
      {
        this.loginTypeField = value;
      }
    }

    [XmlIgnore]
    public bool loginTypeSpecified
    {
      get
      {
        return this.loginTypeFieldSpecified;
      }
      set
      {
        this.loginTypeFieldSpecified = value;
      }
    }
  }
}
