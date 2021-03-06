﻿// Type: ZanoxV2.Publisher.GetAdmediumRequest
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
  public class GetAdmediumRequest
  {
    private int admediumIdField;
    private bool admediumIdFieldSpecified;
    private int adspaceIdField;
    private bool adspaceIdFieldSpecified;
    private string trackingLinkField;
    private string connectIdField;

    public int admediumId
    {
      get
      {
        return this.admediumIdField;
      }
      set
      {
        this.admediumIdField = value;
      }
    }

    [XmlIgnore]
    public bool admediumIdSpecified
    {
      get
      {
        return this.admediumIdFieldSpecified;
      }
      set
      {
        this.admediumIdFieldSpecified = value;
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

    public string trackingLink
    {
      get
      {
        return this.trackingLinkField;
      }
      set
      {
        this.trackingLinkField = value;
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
