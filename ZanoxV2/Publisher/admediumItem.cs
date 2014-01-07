// Type: ZanoxV2.Publisher.admediumItem
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
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [Serializable]
  public class admediumItem
  {
    private string nameField;
    private float adrankField;
    private admediaTypeEnum admediumTypeField;
    private subStringIdentifierType programField;
    private string titleField;
    private int heightField;
    private bool heightFieldSpecified;
    private int widthField;
    private bool widthFieldSpecified;
    private subStringIdentifierType formatField;
    private string codeField;
    private string descriptionField;
    private string instructionField;
    private admediaPurposeEnum purposeField;
    private bool purposeFieldSpecified;
    private subStringIdentifierType categoryField;
    private subStringIdentifierType groupField;
    private string[] tagsField;
    private trackingLinkType[] trackingLinksField;
    private int idField;

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

    public admediaTypeEnum admediumType
    {
      get
      {
        return this.admediumTypeField;
      }
      set
      {
        this.admediumTypeField = value;
      }
    }

    public subStringIdentifierType program
    {
      get
      {
        return this.programField;
      }
      set
      {
        this.programField = value;
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

    public int height
    {
      get
      {
        return this.heightField;
      }
      set
      {
        this.heightField = value;
      }
    }

    [XmlIgnore]
    public bool heightSpecified
    {
      get
      {
        return this.heightFieldSpecified;
      }
      set
      {
        this.heightFieldSpecified = value;
      }
    }

    public int width
    {
      get
      {
        return this.widthField;
      }
      set
      {
        this.widthField = value;
      }
    }

    [XmlIgnore]
    public bool widthSpecified
    {
      get
      {
        return this.widthFieldSpecified;
      }
      set
      {
        this.widthFieldSpecified = value;
      }
    }

    public subStringIdentifierType format
    {
      get
      {
        return this.formatField;
      }
      set
      {
        this.formatField = value;
      }
    }

    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
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

    public string instruction
    {
      get
      {
        return this.instructionField;
      }
      set
      {
        this.instructionField = value;
      }
    }

    public admediaPurposeEnum purpose
    {
      get
      {
        return this.purposeField;
      }
      set
      {
        this.purposeField = value;
      }
    }

    [XmlIgnore]
    public bool purposeSpecified
    {
      get
      {
        return this.purposeFieldSpecified;
      }
      set
      {
        this.purposeFieldSpecified = value;
      }
    }

    public subStringIdentifierType category
    {
      get
      {
        return this.categoryField;
      }
      set
      {
        this.categoryField = value;
      }
    }

    public subStringIdentifierType group
    {
      get
      {
        return this.groupField;
      }
      set
      {
        this.groupField = value;
      }
    }

    [XmlArrayItem("tag", IsNullable = false)]
    public string[] tags
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

    [XmlArrayItem("trackingLink", IsNullable = false)]
    public trackingLinkType[] trackingLinks
    {
      get
      {
        return this.trackingLinksField;
      }
      set
      {
        this.trackingLinksField = value;
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
  }
}
