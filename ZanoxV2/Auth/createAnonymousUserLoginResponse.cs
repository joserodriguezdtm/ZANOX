// Type: ZanoxV2.Auth.createAnonymousUserLoginResponse
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
  [XmlType(AnonymousType = true, Namespace = "http://auth.zanox.com/2011-05-01/")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [DebuggerStepThrough]
  [Serializable]
  public class createAnonymousUserLoginResponse
  {
    private userLoginItem userLoginItemField;
    private string permanentTokenField;

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public userLoginItem userLoginItem
    {
      get
      {
        return this.userLoginItemField;
      }
      set
      {
        this.userLoginItemField = value;
      }
    }

    [XmlElement(Form = XmlSchemaForm.Unqualified)]
    public string permanentToken
    {
      get
      {
        return this.permanentTokenField;
      }
      set
      {
        this.permanentTokenField = value;
      }
    }
  }
}
