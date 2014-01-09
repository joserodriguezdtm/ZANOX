// Type: ZanoxV2.Publisher.profileItem
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
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [DebuggerStepThrough]
  [Serializable]
  public class profileItem
  {
    private float adrankField;
    private string firstNameField;
    private string lastNameField;
    private string emailField;
    private string countryField;
    private string street1Field;
    private string cityField;
    private string zipcodeField;
    private string companyField;
    private string street2Field;
    private string phoneField;
    private string mobileField;
    private string faxField;
    private string languageField;
    private string currencyField;
    private string titleField;
    private string loginNameField;
    private string userNameField;
    private bool isAdvertiserField;
    private bool isSubloginField;
    private int idField;
    private bool idFieldSpecified;

    public float adrank
    {
      get
      {
        return this.adrankField;
      }
      set
      {
        this.adrankField = value;
      }
    }

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

    public string email
    {
      get
      {
        return this.emailField;
      }
      set
      {
        this.emailField = value;
      }
    }

    public string country
    {
      get
      {
        return this.countryField;
      }
      set
      {
        this.countryField = value;
      }
    }

    public string street1
    {
      get
      {
        return this.street1Field;
      }
      set
      {
        this.street1Field = value;
      }
    }

    public string city
    {
      get
      {
        return this.cityField;
      }
      set
      {
        this.cityField = value;
      }
    }

    public string zipcode
    {
      get
      {
        return this.zipcodeField;
      }
      set
      {
        this.zipcodeField = value;
      }
    }

    public string company
    {
      get
      {
        return this.companyField;
      }
      set
      {
        this.companyField = value;
      }
    }

    public string street2
    {
      get
      {
        return this.street2Field;
      }
      set
      {
        this.street2Field = value;
      }
    }

    public string phone
    {
      get
      {
        return this.phoneField;
      }
      set
      {
        this.phoneField = value;
      }
    }

    public string mobile
    {
      get
      {
        return this.mobileField;
      }
      set
      {
        this.mobileField = value;
      }
    }

    public string fax
    {
      get
      {
        return this.faxField;
      }
      set
      {
        this.faxField = value;
      }
    }

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

    public string title
    {
      get
      {
        return this.titleField;
      }
      set
      {
        this.titleField = value;
      }
    }

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

    public string userName
    {
      get
      {
        return this.userNameField;
      }
      set
      {
        this.userNameField = value;
      }
    }

    public bool isAdvertiser
    {
      get
      {
        return this.isAdvertiserField;
      }
      set
      {
        this.isAdvertiserField = value;
      }
    }

    public bool isSublogin
    {
      get
      {
        return this.isSubloginField;
      }
      set
      {
        this.isSubloginField = value;
      }
    }

    [XmlAttribute]
    public int id
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

    [XmlIgnore]
    public bool idSpecified
    {
      get
      {
        return this.idFieldSpecified;
      }
      set
      {
        this.idFieldSpecified = value;
      }
    }
  }
}
