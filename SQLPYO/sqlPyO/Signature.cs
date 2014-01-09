// Type: ZanoxV2.Signature
// Assembly: ZanoxV2, Version=1.0.4955.28682, Culture=neutral, PublicKeyToken=d1e62d2627a2f3e0
// MVID: 35AD163E-3C46-45E7-B3AA-50397E6E2193
// Assembly location: C:\Users\daniel.lopez\Desktop\Zanox.API\ZanoxV2.dll

using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace sqlPyO
{
  public class Signature
  {
    public static string SoapSignature(DateTime datetime, string secretKey, string service, string operation, string nonce)
    {
      HMACSHA1 hmacshA1 = new HMACSHA1(Encoding.UTF8.GetBytes(secretKey));
      string zdateTime = Signature.GetZDateTime(datetime);
      string s = service + operation + zdateTime + nonce;
      return Convert.ToBase64String(hmacshA1.ComputeHash(Encoding.UTF8.GetBytes(s)));
    }

    public static string RestSignature(DateTime datetime, string secretKey, string httpVerb, string uri, string nonce)
    {
      HMACSHA1 hmacshA1 = new HMACSHA1(Encoding.UTF8.GetBytes(secretKey));
      string gmtDateTime = Signature.GetGMTDateTime(datetime);
      string s = httpVerb + uri + gmtDateTime + nonce;
      return Convert.ToBase64String(hmacshA1.ComputeHash(Encoding.UTF8.GetBytes(s)));
    }

    public static string GetGMTDateTime(DateTime dateTime)
    {
      CultureInfo cultureInfo = new CultureInfo("en-US");
      return dateTime.AddHours(-1.0).ToString("ddd, dd MMM yyyy HH':'mm':'ss 'GMT'", (IFormatProvider) cultureInfo);
    }

    public static string GetZDateTime(DateTime dateTime)
    {
      CultureInfo cultureInfo = new CultureInfo("en-US");
      return dateTime.ToString("yyyy-MM-ddTHH:mm:ss.000Z", (IFormatProvider) cultureInfo);
    }

    public static string GetNonce()
    {
      return Guid.NewGuid().ToString();
    }
  }
}
