// Type: ZanoxV2.Constants
// Assembly: ZanoxV2, Version=1.0.4955.28682, Culture=neutral, PublicKeyToken=d1e62d2627a2f3e0
// MVID: 35AD163E-3C46-45E7-B3AA-50397E6E2193
// Assembly location: C:\Users\daniel.lopez\Desktop\Zanox.API\ZanoxV2.dll

namespace sqlPyO
{
  public class Constants
  {
    public static readonly string UserAgent = "zanox .NET Client Library, V1.9.2.0";
    public static readonly string LOGOUT_BUTTON_URL = "https://apps.zanox.com/zanox-theme/images/custom/button_zanoxLogout.gif";
    public static readonly string LOGIN_BUTTON_URL = "https://apps.zanox.com/zanox-theme/images/custom/button_zanoxConnect.gif";
    public static readonly string AuthURLTemplate = "https://auth.zanox.com/login?appid={0}";
    public static readonly int PageSizeMax = 50;
    public static readonly int PageSizeDefault = 10;
    public const string AUTHTOKEN_NAME = "authtoken";

    static Constants()
    {
    }
  }
}
