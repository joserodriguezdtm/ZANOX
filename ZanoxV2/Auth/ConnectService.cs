// Type: ZanoxV2.Auth.ConnectService
// Assembly: ZanoxV2, Version=1.0.4955.28682, Culture=neutral, PublicKeyToken=d1e62d2627a2f3e0
// MVID: 35AD163E-3C46-45E7-B3AA-50397E6E2193
// Assembly location: C:\Users\daniel.lopez\Desktop\Zanox.API\ZanoxV2.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace ZanoxV2.Auth
{
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [WebServiceBinding(Name = "ConnectServiceBinding", Namespace = "http://auth.zanox.com/2011-05-01/")]
  [GeneratedCode("System.Web.Services", "4.0.30319.1")]
  public class ConnectService : SoapHttpClientProtocol
  {
    private bool useDefaultCredentialsSetExplicitly;

    public new string Url
    {
      get
      {
        return base.Url;
      }
      set
      {
        if (this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly && !this.IsLocalFileSystemWebService(value))
          base.UseDefaultCredentials = false;
        base.Url = value;
      }
    }

    public new bool UseDefaultCredentials
    {
      get
      {
        return base.UseDefaultCredentials;
      }
      set
      {
        base.UseDefaultCredentials = value;
        this.useDefaultCredentialsSetExplicitly = true;
      }
    }

    public ConnectService()
    {
      this.Url = "https://auth.zanox.com/soap/2011-05-01";
      if (this.IsLocalFileSystemWebService(this.Url))
      {
        this.UseDefaultCredentials = true;
        this.useDefaultCredentialsSetExplicitly = false;
      }
      else
        this.useDefaultCredentialsSetExplicitly = true;
    }

    [SoapDocumentMethod("http://auth.zanox.com/2011-05-01/closeSession", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("closeSessionResponse", Namespace = "http://auth.zanox.com/2011-05-01/")]
    public closeSessionResponse closeSession([XmlElement("closeSession", Namespace = "http://auth.zanox.com/2011-05-01/")] closeSession closeSession1)
    {
      return (closeSessionResponse) this.Invoke("closeSession", new object[1]
      {
        (object) closeSession1
      })[0];
    }

    public IAsyncResult BegincloseSession(closeSession closeSession1, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("closeSession", new object[1]
      {
        (object) closeSession1
      }, callback, asyncState);
    }

    public closeSessionResponse EndcloseSession(IAsyncResult asyncResult)
    {
      return (closeSessionResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://auth.zanox.com/2011-05-01/createConnect", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("createConnectResponse", Namespace = "http://auth.zanox.com/2011-05-01/")]
    public createConnectResponse createConnect([XmlElement(Namespace = "http://auth.zanox.com/2011-05-01/")] createConnectRequest createConnectRequest)
    {
      return (createConnectResponse) this.Invoke("createConnect", new object[1]
      {
        (object) createConnectRequest
      })[0];
    }

    public IAsyncResult BegincreateConnect(createConnectRequest createConnectRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("createConnect", new object[1]
      {
        (object) createConnectRequest
      }, callback, asyncState);
    }

    public createConnectResponse EndcreateConnect(IAsyncResult asyncResult)
    {
      return (createConnectResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://auth.zanox.com/2011-05-01/createAnonymousUserLogin", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("createAnonymousUserLoginResponse", Namespace = "http://auth.zanox.com/2011-05-01/")]
    public createAnonymousUserLoginResponse createAnonymousUserLogin([XmlElement(Namespace = "http://auth.zanox.com/2011-05-01/")] createAnonymousUserLoginRequest createAnonymousUserLoginRequest)
    {
      return (createAnonymousUserLoginResponse) this.Invoke("createAnonymousUserLogin", new object[1]
      {
        (object) createAnonymousUserLoginRequest
      })[0];
    }

    public IAsyncResult BegincreateAnonymousUserLogin(createAnonymousUserLoginRequest createAnonymousUserLoginRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("createAnonymousUserLogin", new object[1]
      {
        (object) createAnonymousUserLoginRequest
      }, callback, asyncState);
    }

    public createAnonymousUserLoginResponse EndcreateAnonymousUserLogin(IAsyncResult asyncResult)
    {
      return (createAnonymousUserLoginResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://auth.zanox.com/2011-05-01/deleteAnonymousUserLogin", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("deleteAnonymousUserLoginResponse", Namespace = "http://auth.zanox.com/2011-05-01/")]
    public deleteAnonymousUserLoginResponse deleteAnonymousUserLogin([XmlElement(Namespace = "http://auth.zanox.com/2011-05-01/")] deleteAnonymousUserLoginRequest deleteAnonymousUserLoginRequest)
    {
      return (deleteAnonymousUserLoginResponse) this.Invoke("deleteAnonymousUserLogin", new object[1]
      {
        (object) deleteAnonymousUserLoginRequest
      })[0];
    }

    public IAsyncResult BegindeleteAnonymousUserLogin(deleteAnonymousUserLoginRequest deleteAnonymousUserLoginRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("deleteAnonymousUserLogin", new object[1]
      {
        (object) deleteAnonymousUserLoginRequest
      }, callback, asyncState);
    }

    public deleteAnonymousUserLoginResponse EnddeleteAnonymousUserLogin(IAsyncResult asyncResult)
    {
      return (deleteAnonymousUserLoginResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://auth.zanox.com/2011-05-01/getOfflineSession", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("getOfflineSessionResponse", Namespace = "http://auth.zanox.com/2011-05-01/")]
    public getOfflineSessionResponse getOfflineSession([XmlElement("getOfflineSession", Namespace = "http://auth.zanox.com/2011-05-01/")] getOfflineSession getOfflineSession1)
    {
      return (getOfflineSessionResponse) this.Invoke("getOfflineSession", new object[1]
      {
        (object) getOfflineSession1
      })[0];
    }

    public IAsyncResult BegingetOfflineSession(getOfflineSession getOfflineSession1, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("getOfflineSession", new object[1]
      {
        (object) getOfflineSession1
      }, callback, asyncState);
    }

    public getOfflineSessionResponse EndgetOfflineSession(IAsyncResult asyncResult)
    {
      return (getOfflineSessionResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://auth.zanox.com/2011-05-01/getUserLogin", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("getUserLoginResponse", Namespace = "http://auth.zanox.com/2011-05-01/")]
    public getUserLoginResponse getUserLogin([XmlElement(Namespace = "http://auth.zanox.com/2011-05-01/")] getUserLoginRequest getUserLoginRequest)
    {
      return (getUserLoginResponse) this.Invoke("getUserLogin", new object[1]
      {
        (object) getUserLoginRequest
      })[0];
    }

    public IAsyncResult BegingetUserLogin(getUserLoginRequest getUserLoginRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("getUserLogin", new object[1]
      {
        (object) getUserLoginRequest
      }, callback, asyncState);
    }

    public getUserLoginResponse EndgetUserLogin(IAsyncResult asyncResult)
    {
      return (getUserLoginResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://auth.zanox.com/2011-05-01/getSession", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("getSessionResponse", Namespace = "http://auth.zanox.com/2011-05-01/")]
    public getSessionResponse getSession([XmlElement("getSession", Namespace = "http://auth.zanox.com/2011-05-01/")] getSession getSession1)
    {
      return (getSessionResponse) this.Invoke("getSession", new object[1]
      {
        (object) getSession1
      })[0];
    }

    public IAsyncResult BegingetSession(getSession getSession1, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("getSession", new object[1]
      {
        (object) getSession1
      }, callback, asyncState);
    }

    public getSessionResponse EndgetSession(IAsyncResult asyncResult)
    {
      return (getSessionResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://auth.zanox.com/2011-05-01/getSessionForMarketplace", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("getSessionForMarketplaceResponse", Namespace = "http://auth.zanox.com/2011-05-01/")]
    public getSessionForMarketplaceResponse getSessionForMarketplace([XmlElement("getSessionForMarketplace", Namespace = "http://auth.zanox.com/2011-05-01/")] getSessionForMarketplace getSessionForMarketplace1)
    {
      return (getSessionForMarketplaceResponse) this.Invoke("getSessionForMarketplace", new object[1]
      {
        (object) getSessionForMarketplace1
      })[0];
    }

    public IAsyncResult BegingetSessionForMarketplace(getSessionForMarketplace getSessionForMarketplace1, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("getSessionForMarketplace", new object[1]
      {
        (object) getSessionForMarketplace1
      }, callback, asyncState);
    }

    public getSessionForMarketplaceResponse EndgetSessionForMarketplace(IAsyncResult asyncResult)
    {
      return (getSessionForMarketplaceResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://auth.zanox.com/2011-05-01/getUiUrl", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("getUiUrlResponse", Namespace = "http://auth.zanox.com/2011-05-01/")]
    public getUiUrlResponse getUiUrl([XmlElement("getUiUrl", Namespace = "http://auth.zanox.com/2011-05-01/")] getUiUrl getUiUrl1)
    {
      return (getUiUrlResponse) this.Invoke("getUiUrl", new object[1]
      {
        (object) getUiUrl1
      })[0];
    }

    public IAsyncResult BegingetUiUrl(getUiUrl getUiUrl1, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("getUiUrl", new object[1]
      {
        (object) getUiUrl1
      }, callback, asyncState);
    }

    public getUiUrlResponse EndgetUiUrl(IAsyncResult asyncResult)
    {
      return (getUiUrlResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://auth.zanox.com/2011-05-01/promoteSession", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("promoteSessionResponse", Namespace = "http://auth.zanox.com/2011-05-01/")]
    public promoteSessionResponse promoteSession([XmlElement(Namespace = "http://auth.zanox.com/2011-05-01/")] promoteSessionRequest promoteSessionRequest)
    {
      return (promoteSessionResponse) this.Invoke("promoteSession", new object[1]
      {
        (object) promoteSessionRequest
      })[0];
    }

    public IAsyncResult BeginpromoteSession(promoteSessionRequest promoteSessionRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("promoteSession", new object[1]
      {
        (object) promoteSessionRequest
      }, callback, asyncState);
    }

    public promoteSessionResponse EndpromoteSession(IAsyncResult asyncResult)
    {
      return (promoteSessionResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://auth.zanox.com/2011-05-01/getPermanentToken", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("getPermanentTokenResponse", Namespace = "http://auth.zanox.com/2011-05-01/")]
    public getPermanentTokenResponse getPermanentToken([XmlElement("getPermanentToken", Namespace = "http://auth.zanox.com/2011-05-01/")] getPermanentToken getPermanentToken1)
    {
      return (getPermanentTokenResponse) this.Invoke("getPermanentToken", new object[1]
      {
        (object) getPermanentToken1
      })[0];
    }

    public IAsyncResult BegingetPermanentToken(getPermanentToken getPermanentToken1, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("getPermanentToken", new object[1]
      {
        (object) getPermanentToken1
      }, callback, asyncState);
    }

    public getPermanentTokenResponse EndgetPermanentToken(IAsyncResult asyncResult)
    {
      return (getPermanentTokenResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://auth.zanox.com/2011-05-01/updateAnonymousUserLogin", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("updateAnonymousUserLoginResponse", Namespace = "http://auth.zanox.com/2011-05-01/")]
    public updateAnonymousUserLoginResponse updateAnonymousUserLogin([XmlElement(Namespace = "http://auth.zanox.com/2011-05-01/")] updateAnonymousUserLoginRequest updateAnonymousUserLoginRequest)
    {
      return (updateAnonymousUserLoginResponse) this.Invoke("updateAnonymousUserLogin", new object[1]
      {
        (object) updateAnonymousUserLoginRequest
      })[0];
    }

    public IAsyncResult BeginupdateAnonymousUserLogin(updateAnonymousUserLoginRequest updateAnonymousUserLoginRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("updateAnonymousUserLogin", new object[1]
      {
        (object) updateAnonymousUserLoginRequest
      }, callback, asyncState);
    }

    public updateAnonymousUserLoginResponse EndupdateAnonymousUserLogin(IAsyncResult asyncResult)
    {
      return (updateAnonymousUserLoginResponse) this.EndInvoke(asyncResult)[0];
    }

    private bool IsLocalFileSystemWebService(string url)
    {
      if (url == null || url == string.Empty)
        return false;
      Uri uri = new Uri(url);
      return uri.Port >= 1024 && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0;
    }
  }
}
