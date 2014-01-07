// Type: ZanoxV2.Publisher.applicationItem
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
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [Serializable]
  public class applicationItem
  {
    private string nameField;
    private string versionField;
    private int adrankField;
    private bool adrankFieldSpecified;
    private string tagsField;
    private int statusField;
    private bool statusFieldSpecified;
    private bool mediaSlotCompatibleField;
    private bool mediaSlotCompatibleFieldSpecified;
    private bool inlineField;
    private bool inlineFieldSpecified;
    private string integrationCodeField;
    private string integrationNotesField;
    private string descriptionField;
    private string termsField;
    private connectType connectField;
    private string connectUrlField;
    private string cancelUrlField;
    private string documentationUrlField;
    private string companyUrlField;
    private string developerField;
    private pricingType pricingField;
    private DateTime startDateField;
    private bool startDateFieldSpecified;
    private DateTime modifiedDateField;
    private bool modifiedDateFieldSpecified;
    private profileTypeEnum installableToField;
    private bool installableToFieldSpecified;
    private applicationTypeEnum applicationTypeField;
    private bool applicationTypeFieldSpecified;
    private sizeType sizeField;
    private string techniqueField;
    private string logoUrlField;
    private string[] previewUrlField;
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

    public string version
    {
      get
      {
        return this.versionField;
      }
      set
      {
        this.versionField = value;
      }
    }

    public int adrank
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

    [XmlIgnore]
    public bool adrankSpecified
    {
      get
      {
        return this.adrankFieldSpecified;
      }
      set
      {
        this.adrankFieldSpecified = value;
      }
    }

    public string tags
    {
      get
      {
        return this.tagsField;
      }
      set
      {
        this.tagsField = value;
      }
    }

    public int status
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

    public bool mediaSlotCompatible
    {
      get
      {
        return this.mediaSlotCompatibleField;
      }
      set
      {
        this.mediaSlotCompatibleField = value;
      }
    }

    [XmlIgnore]
    public bool mediaSlotCompatibleSpecified
    {
      get
      {
        return this.mediaSlotCompatibleFieldSpecified;
      }
      set
      {
        this.mediaSlotCompatibleFieldSpecified = value;
      }
    }

    public bool inline
    {
      get
      {
        return this.inlineField;
      }
      set
      {
        this.inlineField = value;
      }
    }

    [XmlIgnore]
    public bool inlineSpecified
    {
      get
      {
        return this.inlineFieldSpecified;
      }
      set
      {
        this.inlineFieldSpecified = value;
      }
    }

    public string integrationCode
    {
      get
      {
        return this.integrationCodeField;
      }
      set
      {
        this.integrationCodeField = value;
      }
    }

    public string integrationNotes
    {
      get
      {
        return this.integrationNotesField;
      }
      set
      {
        this.integrationNotesField = value;
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

    public string terms
    {
      get
      {
        return this.termsField;
      }
      set
      {
        this.termsField = value;
      }
    }

    public connectType connect
    {
      get
      {
        return this.connectField;
      }
      set
      {
        this.connectField = value;
      }
    }

    public string connectUrl
    {
      get
      {
        return this.connectUrlField;
      }
      set
      {
        this.connectUrlField = value;
      }
    }

    public string cancelUrl
    {
      get
      {
        return this.cancelUrlField;
      }
      set
      {
        this.cancelUrlField = value;
      }
    }

    public string documentationUrl
    {
      get
      {
        return this.documentationUrlField;
      }
      set
      {
        this.documentationUrlField = value;
      }
    }

    public string companyUrl
    {
      get
      {
        return this.companyUrlField;
      }
      set
      {
        this.companyUrlField = value;
      }
    }

    public string developer
    {
      get
      {
        return this.developerField;
      }
      set
      {
        this.developerField = value;
      }
    }

    public pricingType pricing
    {
      get
      {
        return this.pricingField;
      }
      set
      {
        this.pricingField = value;
      }
    }

    public DateTime startDate
    {
      get
      {
        return this.startDateField;
      }
      set
      {
        this.startDateField = value;
      }
    }

    [XmlIgnore]
    public bool startDateSpecified
    {
      get
      {
        return this.startDateFieldSpecified;
      }
      set
      {
        this.startDateFieldSpecified = value;
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

    public profileTypeEnum installableTo
    {
      get
      {
        return this.installableToField;
      }
      set
      {
        this.installableToField = value;
      }
    }

    [XmlIgnore]
    public bool installableToSpecified
    {
      get
      {
        return this.installableToFieldSpecified;
      }
      set
      {
        this.installableToFieldSpecified = value;
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

    public string technique
    {
      get
      {
        return this.techniqueField;
      }
      set
      {
        this.techniqueField = value;
      }
    }

    public string logoUrl
    {
      get
      {
        return this.logoUrlField;
      }
      set
      {
        this.logoUrlField = value;
      }
    }

    [XmlElement("previewUrl")]
    public string[] previewUrl
    {
      get
      {
        return this.previewUrlField;
      }
      set
      {
        this.previewUrlField = value;
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
