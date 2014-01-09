// Type: ZanoxV2.Auth.loginStatusEnum
// Assembly: ZanoxV2, Version=1.0.4955.28682, Culture=neutral, PublicKeyToken=d1e62d2627a2f3e0
// MVID: 35AD163E-3C46-45E7-B3AA-50397E6E2193
// Assembly location: C:\Users\daniel.lopez\Desktop\Zanox.API\ZanoxV2.dll

using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace sqlPyO.Auth
{
  [XmlType(Namespace = "http://auth.zanox.com/2011-05-01/")]
  [GeneratedCode("System.Xml", "4.0.30319.1009")]
  [Serializable]
  public enum loginStatusEnum
  {
    enabled,
    disabled,
    [XmlEnum("pre-deleted")] predeleted,
    deleted,
  }
}
