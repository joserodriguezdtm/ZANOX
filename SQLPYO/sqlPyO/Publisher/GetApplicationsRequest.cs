// Type: ZanoxV2.Publisher.GetApplicationsRequest
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
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [Serializable]
  public class GetApplicationsRequest
  {
    private string nameField;
    private sizeType sizeField;
    private roleTypeEnum roleField;
    private bool roleFieldSpecified;
    private applicationTypeEnum applicationTypeField;
    private bool applicationTypeFieldSpecified;
    private int pageField;
    private bool pageFieldSpecified;
    private int itemsField;
    private bool itemsFieldSpecified;
    private string connectIdField;
    private string timestampField;
    private string nonceField;
    private string signatureField;

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

    public roleTypeEnum role
    {
      get
      {
        return this.roleField;
      }
      set
      {
        this.roleField = value;
      }
    }

    [XmlIgnore]
    public bool roleSpecified
    {
      get
      {
        return this.roleFieldSpecified;
      }
      set
      {
        this.roleFieldSpecified = value;
      }
    }

    public applicationTypeEnum applicationType
    {
      get
      {
        return this.applicationTypeField;
      }
      set
      {
        this.applicationTypeField = value;
      }
    }

    [XmlIgnore]
    public bool applicationTypeSpecified
    {
      get
      {
        return this.applicationTypeFieldSpecified;
      }
      set
      {
        this.applicationTypeFieldSpecified = value;
      }
    }

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

    [XmlIgnore]
    public bool pageSpecified
    {
      get
      {
        return this.pageFieldSpecified;
      }
      set
      {
        this.pageFieldSpecified = value;
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

    [XmlIgnore]
    public bool itemsSpecified
    {
      get
      {
        return this.itemsFieldSpecified;
      }
      set
      {
        this.itemsFieldSpecified = value;
      }
    }

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

    public string timestamp
    {
      get
      {
        return this.timestampField;
      }
      set
      {
        this.timestampField = value;
      }
    }

    public string nonce
    {
      get
      {
        return this.nonceField;
      }
      set
      {
        this.nonceField = value;
      }
    }

    public string signature
    {
      get
      {
        return this.signatureField;
      }
      set
      {
        this.signatureField = value;
      }
    }
  }
}
