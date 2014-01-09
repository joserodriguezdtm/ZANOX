// Type: ZanoxV2.Auth.userLoginItem
// Assembly: ZanoxV2, Version=1.0.4955.28682, Culture=neutral, PublicKeyToken=d1e62d2627a2f3e0
// MVID: 35AD163E-3C46-45E7-B3AA-50397E6E2193
// Assembly location: C:\Users\daniel.lopez\Desktop\Zanox.API\ZanoxV2.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace sqlPyO.Auth
{
  [XmlType(Namespace = "http://auth.zanox.com/2011-05-01/")]
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [Serializable]
  public class userLoginItem
  {
    private int programIdField;
    private bool programIdFieldSpecified;
    private string firstNameField;
    private string lastNameField;
    private string languageField;
    private string currencyField;
    private string loginNameField;
    private string descriptionField;
    private loginStatusEnum statusField;
    private loginTypeEnum loginTypeField;
    private bool loginTypeFieldSpecified;
    private bool isMasterField;
    private bool isMasterFieldSpecified;
    private int darwinUserIdField;
    private bool darwinUserIdFieldSpecified;
    private string connectIdField;

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public int programId
    {
      get
      {
        return this.programIdField;
      }
      set
      {
        this.programIdField = value;
      }
    }

    [XmlIgnore]
    public bool programIdSpecified
    {
      get
      {
        return this.programIdFieldSpecified;
      }
      set
      {
        this.programIdFieldSpecified = value;
      }
    }

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
    public string loginName
    {
      get
      {
        return this.loginNameField;
      }
      set
      {
        this.loginNameField = value;
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

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public bool isMaster
    {
      get
      {
        return this.isMasterField;
      }
      set
      {
        this.isMasterField = value;
      }
    }

    [XmlIgnore]
    public bool isMasterSpecified
    {
      get
      {
        return this.isMasterFieldSpecified;
      }
      set
      {
        this.isMasterFieldSpecified = value;
      }
    }

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public int darwinUserId
    {
      get
      {
        return this.darwinUserIdField;
      }
      set
      {
        this.darwinUserIdField = value;
      }
    }

    [XmlIgnore]
    public bool darwinUserIdSpecified
    {
      get
      {
        return this.darwinUserIdFieldSpecified;
      }
      set
      {
        this.darwinUserIdFieldSpecified = value;
      }
    }

    [XmlAttribute]
    public string connectId
    {
      get
      {
        return this.connectIdField;
      }
      set
      {
        this.connectIdField = value;
      }
    }
  }
}
