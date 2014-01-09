// Type: ZanoxV2.Publisher.programApplicationItem
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
  [XmlType(Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [Serializable]
  public class programApplicationItem
  {
    private subStringIdentifierTypeWithStatus programField;
    private subStringIdentifierType adspaceField;
    private programApplicationStatusEnum statusField;
    private DateTime createDateField;
    private bool allowTpvField;
    private DateTime approvedDateField;
    private bool approvedDateFieldSpecified;
    private string publisherCommentField;
    private string advertiserCommentField;
    private int idField;

    public subStringIdentifierTypeWithStatus program
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

    public programApplicationStatusEnum status
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

    public bool allowTpv
    {
      get
      {
        return this.allowTpvField;
      }
      set
      {
        this.allowTpvField = value;
      }
    }

    public DateTime approvedDate
    {
      get
      {
        return this.approvedDateField;
      }
      set
      {
        this.approvedDateField = value;
      }
    }

    [XmlIgnore]
    public bool approvedDateSpecified
    {
      get
      {
        return this.approvedDateFieldSpecified;
      }
      set
      {
        this.approvedDateFieldSpecified = value;
      }
    }

    public string publisherComment
    {
      get
      {
        return this.publisherCommentField;
      }
      set
      {
        this.publisherCommentField = value;
      }
    }

    public string advertiserComment
    {
      get
      {
        return this.advertiserCommentField;
      }
      set
      {
        this.advertiserCommentField = value;
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
