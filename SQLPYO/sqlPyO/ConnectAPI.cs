// Type: ZanoxV2.ConnectAPI
// Assembly: ZanoxV2, Version=1.0.4955.28682, Culture=neutral, PublicKeyToken=d1e62d2627a2f3e0
// MVID: 35AD163E-3C46-45E7-B3AA-50397E6E2193
// Assembly location: C:\Users\daniel.lopez\Desktop\Zanox.API\ZanoxV2.dll

using System;
using System.Net;
using sqlPyO.Auth;

namespace sqlPyO
{
  public class ConnectAPI
  {
    protected ConnectService connectService;

    public ConnectAPI()
      : this((IWebProxy) null)
    {
    }

    public ConnectAPI(IWebProxy proxy)
    {
      this.connectService = new ConnectService();
      this.connectService.Proxy = proxy;
      this.connectService.EnableDecompression = true;
      this.connectService.UserAgent = Constants.UserAgent;
    }

    public static string GetAuthURL(string applicationId)
    {
      return string.Format(Constants.AuthURLTemplate, (object) applicationId);
    }

    public sessionType GetSession(string publicKey, string secretKey, string authToken)
    {
      getSession getSession1 = new getSession();
      DateTime utcNow = DateTime.UtcNow;
      getSession1.authToken = authToken;
      getSession1.nonce = Signature.GetNonce();
      getSession1.publicKey = publicKey;
      getSession1.signature = Signature.SoapSignature(utcNow, secretKey, "connectservice", "getsession", getSession1.nonce);
      getSession1.timestamp = Signature.GetZDateTime(utcNow);
      getSessionResponse session = this.connectService.getSession(getSession1);
      if (session == null)
        return (sessionType) null;
      else
        return session.session;
    }

    public offlineSessionType GetOfflineSession(string publicKey, string secretKey, string offlineToken)
    {
      getOfflineSession getOfflineSession1 = new getOfflineSession();
      DateTime utcNow = DateTime.UtcNow;
      getOfflineSession1.offlineToken = offlineToken;
      getOfflineSession1.nonce = Signature.GetNonce();
      getOfflineSession1.publicKey = publicKey;
      getOfflineSession1.signature = Signature.SoapSignature(utcNow, secretKey, "connectservice", "getofflinesession", getOfflineSession1.nonce);
      getOfflineSession1.timestamp = Signature.GetZDateTime(utcNow);
      getOfflineSessionResponse offlineSession = this.connectService.getOfflineSession(getOfflineSession1);
      if (offlineSession == null)
        return (offlineSessionType) null;
      else
        return offlineSession.session;
    }

    public void CloseSession(sessionType session, string publicKey, string secretKey)
    {
      closeSession closeSession1 = new closeSession();
      DateTime utcNow = DateTime.UtcNow;
      closeSession1.nonce = Signature.GetNonce();
      closeSession1.connectId = session.connectId;
      closeSession1.signature = Signature.SoapSignature(utcNow, secretKey, "connectservice", "closesession", closeSession1.nonce);
      closeSession1.timestamp = Signature.GetZDateTime(utcNow);
      closeSession1.publicKey = publicKey;
      this.connectService.closeSession(closeSession1);
    }

    public promoteSessionResponse PromoteSession(sessionType session, string publicKey, string secretKey, promoteTypeEnum promoteType)
    {
      promoteSessionRequest promoteSessionRequest = new promoteSessionRequest();
      DateTime utcNow = DateTime.UtcNow;
      promoteSessionRequest.nonce = Signature.GetNonce();
      promoteSessionRequest.connectId = session.connectId;
      promoteSessionRequest.signature = Signature.SoapSignature(utcNow, secretKey, "connectservice", "promotesession", promoteSessionRequest.nonce);
      promoteSessionRequest.timestamp = Signature.GetZDateTime(utcNow);
      promoteSessionRequest.publicKey = publicKey;
      promoteSessionRequest.promoteType = promoteType;
      return this.connectService.promoteSession(promoteSessionRequest);
    }

    public string CreateConnect(string connectId, string secretKey, string publicKey, string applicationId, roleType role)
    {
      createConnectRequest createConnectRequest = new createConnectRequest();
      DateTime utcNow = DateTime.UtcNow;
      createConnectRequest.nonce = Signature.GetNonce();
      createConnectRequest.publicKey = publicKey;
      createConnectRequest.connectId = connectId;
      createConnectRequest.signature = Signature.SoapSignature(utcNow, secretKey, "connectservice", "createconnect", createConnectRequest.nonce);
      createConnectRequest.timestamp = Signature.GetZDateTime(utcNow);
      createConnectRequest.connectId = connectId;
      createConnectRequest.applicationId = applicationId;
      createConnectRequest.role = role;
      createConnectRequest.roleSpecified = true;
      createConnectResponse connect = this.connectService.createConnect(createConnectRequest);
      if (connect == null)
        return (string) null;
      else
        return connect.connectId;
    }

    public string GetZanoxUIUrl(sessionType session)
    {
      getUiUrl getUiUrl1 = new getUiUrl();
      DateTime utcNow = DateTime.UtcNow;
      getUiUrl1.nonce = Signature.GetNonce();
      getUiUrl1.connectId = session.connectId;
      getUiUrl1.timestamp = Signature.GetZDateTime(utcNow);
      getUiUrl1.signature = Signature.SoapSignature(utcNow, session.secretKey, "connectservice", "getuiurl", getUiUrl1.nonce);
      getUiUrl1.sessionKey = session.secretKey;
      getUiUrlResponse uiUrl = this.connectService.getUiUrl(getUiUrl1);
      if (uiUrl == null)
        return (string) null;
      else
        return uiUrl.url;
    }

    public string GetUserLogin()
    {
      throw new NotImplementedException();
    }

    public string CreateAnonymousUserLogin()
    {
      throw new NotImplementedException();
    }

    public string UpdateAnonymousUserLogin()
    {
      throw new NotImplementedException();
    }

    public string DeleteAnonymousUserLogin()
    {
      throw new NotImplementedException();
    }

    public string GetPermanentToken()
    {
      throw new NotImplementedException();
    }

    public string GetSessionForMarketplace()
    {
      throw new NotImplementedException();
    }
  }
}
