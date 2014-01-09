// Type: ZanoxV2.Utils
// Assembly: ZanoxV2, Version=1.0.4955.28682, Culture=neutral, PublicKeyToken=d1e62d2627a2f3e0
// MVID: 35AD163E-3C46-45E7-B3AA-50397E6E2193
// Assembly location: C:\Users\daniel.lopez\Desktop\Zanox.API\ZanoxV2.dll

namespace sqlPyO
{
  public static class Utils
  {
    public static string CleanShopName(string name)
    {
      int length = name.Length;
      if (length > 3 && (name.Substring(length - 3, 1).Equals(" ") || name.Substring(length - 3, 1).Equals(".")))
        return name.Substring(0, length - 3);
      else
        return Utils.UppercaseFirst(name);
    }

    public static string UppercaseFirst(string s)
    {
      if (string.IsNullOrEmpty(s))
        return string.Empty;
      char[] chArray = s.ToCharArray();
      chArray[0] = char.ToUpper(chArray[0]);
      return new string(chArray);
    }

    public static string GetPartnerCode(string trackingLink)
    {
      return trackingLink.Split("?&".ToCharArray())[1];
    }
  }
}
