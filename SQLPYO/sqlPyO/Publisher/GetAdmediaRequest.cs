// Type: ZanoxV2.Publisher.GetAdmediaRequest
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
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [Serializable]
  public class GetAdmediaRequest
  {
    private string qField;
    private int programIdField;
    private bool programIdFieldSpecified;
    private string regionField;
    private int formatField;
    private bool formatFieldSpecified;
    private partnerShipEnum partnerShipField;
    private bool partnerShipFieldSpecified;
    private admediaPurposeEnum purposeField;
    private bool purposeFieldSpecified;
    private admediaTypeEnum admediumTypeField;
    private bool admediumTypeFieldSpecified;
    private int categoryIdField;
    private bool categoryIdFieldSpecified;
    private int adspaceIdField;
    private bool adspaceIdFieldSpecified;
    private int pageField;
    private bool pageFieldSpecified;
    private int itemsField;
    private bool itemsFieldSpecified;
    private string connectIdField;

    public string q
    {
      get
      {
        return this.qField;
      }
      set
      {
        this.qField = value;
      }
    }

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

    public string region
    {
      get
      {
        return this.regionField;
      }
      set
      {
        this.regionField = value;
      }
    }

    public int format
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

    [XmlIgnore]
    public bool formatSpecified
    {
      get
      {
        return this.formatFieldSpecified;
      }
      set
      {
        this.formatFieldSpecified = value;
      }
    }

    public partnerShipEnum partnerShip
    {
      get
      {
        return this.partnerShipField;
      }
      set
      {
        this.partnerShipField = value;
      }
    }

    [XmlIgnore]
    public bool partnerShipSpecified
    {
      get
      {
        return this.partnerShipFieldSpecified;
      }
      set
      {
        this.partnerShipFieldSpecified = value;
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

    [XmlIgnore]
    public bool admediumTypeSpecified
    {
      get
      {
        return this.admediumTypeFieldSpecified;
      }
      set
      {
        this.admediumTypeFieldSpecified = value;
      }
    }

    public int categoryId
    {
      get
      {
        return this.categoryIdField;
      }
      set
      {
        this.categoryIdField = value;
      }
    }

    [XmlIgnore]
    public bool categoryIdSpecified
    {
      get
      {
        return this.categoryIdFieldSpecified;
      }
      set
      {
        this.categoryIdFieldSpecified = value;
      }
    }

    public int adspaceId
    {
      get
      {
        return this.adspaceIdField;
      }
      set
      {
        this.adspaceIdField = value;
      }
    }

    [XmlIgnore]
    public bool adspaceIdSpecified
    {
      get
      {
        return this.adspaceIdFieldSpecified;
      }
      set
      {
        this.adspaceIdFieldSpecified = value;
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
  }
}
