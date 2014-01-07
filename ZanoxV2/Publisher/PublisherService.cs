// Type: ZanoxV2.Publisher.PublisherService
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

namespace ZanoxV2.Publisher
{
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [WebServiceBinding(Name = "PublisherSoapBinding", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
  [GeneratedCode("System.Web.Services", "4.0.30319.1")]
  public class PublisherService : SoapHttpClientProtocol
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

    public PublisherService()
    {
      this.Url = "http://api.zanox.com/soap/2011-03-01";
      if (this.IsLocalFileSystemWebService(this.Url))
      {
        this.UseDefaultCredentials = true;
        this.useDefaultCredentialsSetExplicitly = false;
      }
      else
        this.useDefaultCredentialsSetExplicitly = true;
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetApplication", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetApplicationResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetApplicationResponse GetApplication([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetApplicationRequest GetApplicationRequest)
    {
      return (GetApplicationResponse) this.Invoke("GetApplication", new object[1]
      {
        (object) GetApplicationRequest
      })[0];
    }

    public IAsyncResult BeginGetApplication(GetApplicationRequest GetApplicationRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetApplication", new object[1]
      {
        (object) GetApplicationRequest
      }, callback, asyncState);
    }

    public GetApplicationResponse EndGetApplication(IAsyncResult asyncResult)
    {
      return (GetApplicationResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetApplications", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetApplicationsResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetApplicationsResponse GetApplications([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetApplicationsRequest GetApplicationsRequest)
    {
      return (GetApplicationsResponse) this.Invoke("GetApplications", new object[1]
      {
        (object) GetApplicationsRequest
      })[0];
    }

    public IAsyncResult BeginGetApplications(GetApplicationsRequest GetApplicationsRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetApplications", new object[1]
      {
        (object) GetApplicationsRequest
      }, callback, asyncState);
    }

    public GetApplicationsResponse EndGetApplications(IAsyncResult asyncResult)
    {
      return (GetApplicationsResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/CreateApplication", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("CreateApplicationResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public CreateApplicationResponse CreateApplication([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] CreateApplicationRequest CreateApplicationRequest)
    {
      return (CreateApplicationResponse) this.Invoke("CreateApplication", new object[1]
      {
        (object) CreateApplicationRequest
      })[0];
    }

    public IAsyncResult BeginCreateApplication(CreateApplicationRequest CreateApplicationRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("CreateApplication", new object[1]
      {
        (object) CreateApplicationRequest
      }, callback, asyncState);
    }

    public CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult)
    {
      return (CreateApplicationResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/UpdateApplication", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("UpdateApplicationResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public UpdateApplicationResponse UpdateApplication([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] UpdateApplicationRequest UpdateApplicationRequest)
    {
      return (UpdateApplicationResponse) this.Invoke("UpdateApplication", new object[1]
      {
        (object) UpdateApplicationRequest
      })[0];
    }

    public IAsyncResult BeginUpdateApplication(UpdateApplicationRequest UpdateApplicationRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("UpdateApplication", new object[1]
      {
        (object) UpdateApplicationRequest
      }, callback, asyncState);
    }

    public UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult)
    {
      return (UpdateApplicationResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/DeleteApplication", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("DeleteApplicationResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public DeleteApplicationResponse DeleteApplication([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] DeleteApplicationRequest DeleteApplicationRequest)
    {
      return (DeleteApplicationResponse) this.Invoke("DeleteApplication", new object[1]
      {
        (object) DeleteApplicationRequest
      })[0];
    }

    public IAsyncResult BeginDeleteApplication(DeleteApplicationRequest DeleteApplicationRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("DeleteApplication", new object[1]
      {
        (object) DeleteApplicationRequest
      }, callback, asyncState);
    }

    public DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult)
    {
      return (DeleteApplicationResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetIncentive", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetIncentiveResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetIncentiveResponse GetIncentive([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetIncentiveRequest GetIncentiveRequest)
    {
      return (GetIncentiveResponse) this.Invoke("GetIncentive", new object[1]
      {
        (object) GetIncentiveRequest
      })[0];
    }

    public IAsyncResult BeginGetIncentive(GetIncentiveRequest GetIncentiveRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetIncentive", new object[1]
      {
        (object) GetIncentiveRequest
      }, callback, asyncState);
    }

    public GetIncentiveResponse EndGetIncentive(IAsyncResult asyncResult)
    {
      return (GetIncentiveResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetExclusiveIncentive", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetExclusiveIncentiveResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetExclusiveIncentiveResponse GetExclusiveIncentive([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetExclusiveIncentiveRequest GetExclusiveIncentiveRequest)
    {
      return (GetExclusiveIncentiveResponse) this.Invoke("GetExclusiveIncentive", new object[1]
      {
        (object) GetExclusiveIncentiveRequest
      })[0];
    }

    public IAsyncResult BeginGetExclusiveIncentive(GetExclusiveIncentiveRequest GetExclusiveIncentiveRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetExclusiveIncentive", new object[1]
      {
        (object) GetExclusiveIncentiveRequest
      }, callback, asyncState);
    }

    public GetExclusiveIncentiveResponse EndGetExclusiveIncentive(IAsyncResult asyncResult)
    {
      return (GetExclusiveIncentiveResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/SearchIncentives", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("SearchIncentivesResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public SearchIncentivesResponse SearchIncentives([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] SearchIncentivesRequest SearchIncentivesRequest)
    {
      return (SearchIncentivesResponse) this.Invoke("SearchIncentives", new object[1]
      {
        (object) SearchIncentivesRequest
      })[0];
    }

    public IAsyncResult BeginSearchIncentives(SearchIncentivesRequest SearchIncentivesRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("SearchIncentives", new object[1]
      {
        (object) SearchIncentivesRequest
      }, callback, asyncState);
    }

    public SearchIncentivesResponse EndSearchIncentives(IAsyncResult asyncResult)
    {
      return (SearchIncentivesResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/SearchExclusiveIncentives", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("SearchExclusiveIncentivesResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public SearchExclusiveIncentivesResponse SearchExclusiveIncentives([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] SearchExclusiveIncentivesRequest SearchExclusiveIncentivesRequest)
    {
      return (SearchExclusiveIncentivesResponse) this.Invoke("SearchExclusiveIncentives", new object[1]
      {
        (object) SearchExclusiveIncentivesRequest
      })[0];
    }

    public IAsyncResult BeginSearchExclusiveIncentives(SearchExclusiveIncentivesRequest SearchExclusiveIncentivesRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("SearchExclusiveIncentives", new object[1]
      {
        (object) SearchExclusiveIncentivesRequest
      }, callback, asyncState);
    }

    public SearchExclusiveIncentivesResponse EndSearchExclusiveIncentives(IAsyncResult asyncResult)
    {
      return (SearchExclusiveIncentivesResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetMediaSlot", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetMediaSlotResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetMediaSlotResponse GetMediaSlot([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetMediaSlotRequest GetMediaSlotRequest)
    {
      return (GetMediaSlotResponse) this.Invoke("GetMediaSlot", new object[1]
      {
        (object) GetMediaSlotRequest
      })[0];
    }

    public IAsyncResult BeginGetMediaSlot(GetMediaSlotRequest GetMediaSlotRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetMediaSlot", new object[1]
      {
        (object) GetMediaSlotRequest
      }, callback, asyncState);
    }

    public GetMediaSlotResponse EndGetMediaSlot(IAsyncResult asyncResult)
    {
      return (GetMediaSlotResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetMediaSlots", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetMediaSlotsResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetMediaSlotsResponse GetMediaSlots([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetMediaSlotsRequest GetMediaSlotsRequest)
    {
      return (GetMediaSlotsResponse) this.Invoke("GetMediaSlots", new object[1]
      {
        (object) GetMediaSlotsRequest
      })[0];
    }

    public IAsyncResult BeginGetMediaSlots(GetMediaSlotsRequest GetMediaSlotsRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetMediaSlots", new object[1]
      {
        (object) GetMediaSlotsRequest
      }, callback, asyncState);
    }

    public GetMediaSlotsResponse EndGetMediaSlots(IAsyncResult asyncResult)
    {
      return (GetMediaSlotsResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/CreateMediaSlot", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("CreateMediaSlotResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public CreateMediaSlotResponse CreateMediaSlot([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] CreateMediaSlotRequest CreateMediaSlotRequest)
    {
      return (CreateMediaSlotResponse) this.Invoke("CreateMediaSlot", new object[1]
      {
        (object) CreateMediaSlotRequest
      })[0];
    }

    public IAsyncResult BeginCreateMediaSlot(CreateMediaSlotRequest CreateMediaSlotRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("CreateMediaSlot", new object[1]
      {
        (object) CreateMediaSlotRequest
      }, callback, asyncState);
    }

    public CreateMediaSlotResponse EndCreateMediaSlot(IAsyncResult asyncResult)
    {
      return (CreateMediaSlotResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/UpdateMediaSlot", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("UpdateMediaSlotResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public UpdateMediaSlotResponse UpdateMediaSlot([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] UpdateMediaSlotRequest UpdateMediaSlotRequest)
    {
      return (UpdateMediaSlotResponse) this.Invoke("UpdateMediaSlot", new object[1]
      {
        (object) UpdateMediaSlotRequest
      })[0];
    }

    public IAsyncResult BeginUpdateMediaSlot(UpdateMediaSlotRequest UpdateMediaSlotRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("UpdateMediaSlot", new object[1]
      {
        (object) UpdateMediaSlotRequest
      }, callback, asyncState);
    }

    public UpdateMediaSlotResponse EndUpdateMediaSlot(IAsyncResult asyncResult)
    {
      return (UpdateMediaSlotResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/DeleteMediaSlot", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("DeleteMediaSlotResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public DeleteMediaSlotResponse DeleteMediaSlot([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] DeleteMediaSlotRequest DeleteMediaSlotRequest)
    {
      return (DeleteMediaSlotResponse) this.Invoke("DeleteMediaSlot", new object[1]
      {
        (object) DeleteMediaSlotRequest
      })[0];
    }

    public IAsyncResult BeginDeleteMediaSlot(DeleteMediaSlotRequest DeleteMediaSlotRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("DeleteMediaSlot", new object[1]
      {
        (object) DeleteMediaSlotRequest
      }, callback, asyncState);
    }

    public DeleteMediaSlotResponse EndDeleteMediaSlot(IAsyncResult asyncResult)
    {
      return (DeleteMediaSlotResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetSettings", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetSettingsResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetSettingsResponse GetSettings([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetSettingsRequest GetSettingsRequest)
    {
      return (GetSettingsResponse) this.Invoke("GetSettings", new object[1]
      {
        (object) GetSettingsRequest
      })[0];
    }

    public IAsyncResult BeginGetSettings(GetSettingsRequest GetSettingsRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetSettings", new object[1]
      {
        (object) GetSettingsRequest
      }, callback, asyncState);
    }

    public GetSettingsResponse EndGetSettings(IAsyncResult asyncResult)
    {
      return (GetSettingsResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetSetting", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetSettingResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetSettingResponse GetSetting([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetSettingRequest GetSettingRequest)
    {
      return (GetSettingResponse) this.Invoke("GetSetting", new object[1]
      {
        (object) GetSettingRequest
      })[0];
    }

    public IAsyncResult BeginGetSetting(GetSettingRequest GetSettingRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetSetting", new object[1]
      {
        (object) GetSettingRequest
      }, callback, asyncState);
    }

    public GetSettingResponse EndGetSetting(IAsyncResult asyncResult)
    {
      return (GetSettingResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/CreateSetting", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("CreateSettingResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public CreateSettingResponse CreateSetting([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] CreateSettingRequest CreateSettingRequest)
    {
      return (CreateSettingResponse) this.Invoke("CreateSetting", new object[1]
      {
        (object) CreateSettingRequest
      })[0];
    }

    public IAsyncResult BeginCreateSetting(CreateSettingRequest CreateSettingRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("CreateSetting", new object[1]
      {
        (object) CreateSettingRequest
      }, callback, asyncState);
    }

    public CreateSettingResponse EndCreateSetting(IAsyncResult asyncResult)
    {
      return (CreateSettingResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/UpdateSetting", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("UpdateSettingResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public UpdateSettingResponse UpdateSetting([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] UpdateSettingRequest UpdateSettingRequest)
    {
      return (UpdateSettingResponse) this.Invoke("UpdateSetting", new object[1]
      {
        (object) UpdateSettingRequest
      })[0];
    }

    public IAsyncResult BeginUpdateSetting(UpdateSettingRequest UpdateSettingRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("UpdateSetting", new object[1]
      {
        (object) UpdateSettingRequest
      }, callback, asyncState);
    }

    public UpdateSettingResponse EndUpdateSetting(IAsyncResult asyncResult)
    {
      return (UpdateSettingResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/DeleteSetting", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("DeleteSettingResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public DeleteSettingResponse DeleteSetting([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] DeleteSettingRequest DeleteSettingRequest)
    {
      return (DeleteSettingResponse) this.Invoke("DeleteSetting", new object[1]
      {
        (object) DeleteSettingRequest
      })[0];
    }

    public IAsyncResult BeginDeleteSetting(DeleteSettingRequest DeleteSettingRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("DeleteSetting", new object[1]
      {
        (object) DeleteSettingRequest
      }, callback, asyncState);
    }

    public DeleteSettingResponse EndDeleteSetting(IAsyncResult asyncResult)
    {
      return (DeleteSettingResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/CreateAdspace", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("CreateAdspaceResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public CreateAdspaceResponse CreateAdspace([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] CreateAdspaceRequest CreateAdspaceRequest)
    {
      return (CreateAdspaceResponse) this.Invoke("CreateAdspace", new object[1]
      {
        (object) CreateAdspaceRequest
      })[0];
    }

    public IAsyncResult BeginCreateAdspace(CreateAdspaceRequest CreateAdspaceRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("CreateAdspace", new object[1]
      {
        (object) CreateAdspaceRequest
      }, callback, asyncState);
    }

    public CreateAdspaceResponse EndCreateAdspace(IAsyncResult asyncResult)
    {
      return (CreateAdspaceResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/CreateProgramApplication", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("CreateProgramApplicationResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public CreateProgramApplicationResponse CreateProgramApplication([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] CreateProgramApplicationRequest CreateProgramApplicationRequest)
    {
      return (CreateProgramApplicationResponse) this.Invoke("CreateProgramApplication", new object[1]
      {
        (object) CreateProgramApplicationRequest
      })[0];
    }

    public IAsyncResult BeginCreateProgramApplication(CreateProgramApplicationRequest CreateProgramApplicationRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("CreateProgramApplication", new object[1]
      {
        (object) CreateProgramApplicationRequest
      }, callback, asyncState);
    }

    public CreateProgramApplicationResponse EndCreateProgramApplication(IAsyncResult asyncResult)
    {
      return (CreateProgramApplicationResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/DeleteAdspace", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("DeleteAdspaceResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public DeleteAdspaceResponse DeleteAdspace([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] DeleteAdspaceRequest DeleteAdspaceRequest)
    {
      return (DeleteAdspaceResponse) this.Invoke("DeleteAdspace", new object[1]
      {
        (object) DeleteAdspaceRequest
      })[0];
    }

    public IAsyncResult BeginDeleteAdspace(DeleteAdspaceRequest DeleteAdspaceRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("DeleteAdspace", new object[1]
      {
        (object) DeleteAdspaceRequest
      }, callback, asyncState);
    }

    public DeleteAdspaceResponse EndDeleteAdspace(IAsyncResult asyncResult)
    {
      return (DeleteAdspaceResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/DeleteProgramApplication", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("DeleteProgramApplicationResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public DeleteProgramApplicationResponse DeleteProgramApplication([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] DeleteProgramApplicationRequest DeleteProgramApplicationRequest)
    {
      return (DeleteProgramApplicationResponse) this.Invoke("DeleteProgramApplication", new object[1]
      {
        (object) DeleteProgramApplicationRequest
      })[0];
    }

    public IAsyncResult BeginDeleteProgramApplication(DeleteProgramApplicationRequest DeleteProgramApplicationRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("DeleteProgramApplication", new object[1]
      {
        (object) DeleteProgramApplicationRequest
      }, callback, asyncState);
    }

    public DeleteProgramApplicationResponse EndDeleteProgramApplication(IAsyncResult asyncResult)
    {
      return (DeleteProgramApplicationResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetBankAccounts", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetBankAccountsResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetBankAccountsResponse GetBankAccounts([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetBankAccountsRequest GetBankAccountsRequest)
    {
      return (GetBankAccountsResponse) this.Invoke("GetBankAccounts", new object[1]
      {
        (object) GetBankAccountsRequest
      })[0];
    }

    public IAsyncResult BeginGetBankAccounts(GetBankAccountsRequest GetBankAccountsRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetBankAccounts", new object[1]
      {
        (object) GetBankAccountsRequest
      }, callback, asyncState);
    }

    public GetBankAccountsResponse EndGetBankAccounts(IAsyncResult asyncResult)
    {
      return (GetBankAccountsResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetAdmedia", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetAdmediaResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetAdmediaResponse GetAdmedia([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetAdmediaRequest GetAdmediaRequest)
    {
      return (GetAdmediaResponse) this.Invoke("GetAdmedia", new object[1]
      {
        (object) GetAdmediaRequest
      })[0];
    }

    public IAsyncResult BeginGetAdmedia(GetAdmediaRequest GetAdmediaRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetAdmedia", new object[1]
      {
        (object) GetAdmediaRequest
      }, callback, asyncState);
    }

    public GetAdmediaResponse EndGetAdmedia(IAsyncResult asyncResult)
    {
      return (GetAdmediaResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetAdmedium", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetAdmediumResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetAdmediumResponse GetAdmedium([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetAdmediumRequest GetAdmediumRequest)
    {
      return (GetAdmediumResponse) this.Invoke("GetAdmedium", new object[1]
      {
        (object) GetAdmediumRequest
      })[0];
    }

    public IAsyncResult BeginGetAdmedium(GetAdmediumRequest GetAdmediumRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetAdmedium", new object[1]
      {
        (object) GetAdmediumRequest
      }, callback, asyncState);
    }

    public GetAdmediumResponse EndGetAdmedium(IAsyncResult asyncResult)
    {
      return (GetAdmediumResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetAdmediumCategories", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetAdmediumCategoriesResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetAdmediumCategoriesResponse GetAdmediumCategories([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetAdmediumCategoriesRequest GetAdmediumCategoriesRequest)
    {
      return (GetAdmediumCategoriesResponse) this.Invoke("GetAdmediumCategories", new object[1]
      {
        (object) GetAdmediumCategoriesRequest
      })[0];
    }

    public IAsyncResult BeginGetAdmediumCategories(GetAdmediumCategoriesRequest GetAdmediumCategoriesRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetAdmediumCategories", new object[1]
      {
        (object) GetAdmediumCategoriesRequest
      }, callback, asyncState);
    }

    public GetAdmediumCategoriesResponse EndGetAdmediumCategories(IAsyncResult asyncResult)
    {
      return (GetAdmediumCategoriesResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetAdspace", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetAdspaceResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetAdspaceResponse GetAdspace([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetAdspaceRequest GetAdspaceRequest)
    {
      return (GetAdspaceResponse) this.Invoke("GetAdspace", new object[1]
      {
        (object) GetAdspaceRequest
      })[0];
    }

    public IAsyncResult BeginGetAdspace(GetAdspaceRequest GetAdspaceRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetAdspace", new object[1]
      {
        (object) GetAdspaceRequest
      }, callback, asyncState);
    }

    public GetAdspaceResponse EndGetAdspace(IAsyncResult asyncResult)
    {
      return (GetAdspaceResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetAdspaces", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetAdspacesResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetAdspacesResponse GetAdspaces([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetAdspacesRequest GetAdspacesRequest)
    {
      return (GetAdspacesResponse) this.Invoke("GetAdspaces", new object[1]
      {
        (object) GetAdspacesRequest
      })[0];
    }

    public IAsyncResult BeginGetAdspaces(GetAdspacesRequest GetAdspacesRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetAdspaces", new object[1]
      {
        (object) GetAdspacesRequest
      }, callback, asyncState);
    }

    public GetAdspacesResponse EndGetAdspaces(IAsyncResult asyncResult)
    {
      return (GetAdspacesResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetBalances", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetBalancesResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetBalancesResponse GetBalances([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetBalancesRequest GetBalancesRequest)
    {
      return (GetBalancesResponse) this.Invoke("GetBalances", new object[1]
      {
        (object) GetBalancesRequest
      })[0];
    }

    public IAsyncResult BeginGetBalances(GetBalancesRequest GetBalancesRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetBalances", new object[1]
      {
        (object) GetBalancesRequest
      }, callback, asyncState);
    }

    public GetBalancesResponse EndGetBalances(IAsyncResult asyncResult)
    {
      return (GetBalancesResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetLeads", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetLeadsResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetLeadsResponse GetLeads([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetLeadsRequest GetLeadsRequest)
    {
      return (GetLeadsResponse) this.Invoke("GetLeads", new object[1]
      {
        (object) GetLeadsRequest
      })[0];
    }

    public IAsyncResult BeginGetLeads(GetLeadsRequest GetLeadsRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetLeads", new object[1]
      {
        (object) GetLeadsRequest
      }, callback, asyncState);
    }

    public GetLeadsResponse EndGetLeads(IAsyncResult asyncResult)
    {
      return (GetLeadsResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetPayments", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetPaymentsResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetPaymentsResponse GetPayments([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetPaymentsRequest GetPaymentsRequest)
    {
      return (GetPaymentsResponse) this.Invoke("GetPayments", new object[1]
      {
        (object) GetPaymentsRequest
      })[0];
    }

    public IAsyncResult BeginGetPayments(GetPaymentsRequest GetPaymentsRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetPayments", new object[1]
      {
        (object) GetPaymentsRequest
      }, callback, asyncState);
    }

    public GetPaymentsResponse EndGetPayments(IAsyncResult asyncResult)
    {
      return (GetPaymentsResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetProduct", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetProductResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetProductResponse GetProduct([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetProductRequest GetProductRequest)
    {
      return (GetProductResponse) this.Invoke("GetProduct", new object[1]
      {
        (object) GetProductRequest
      })[0];
    }

    public IAsyncResult BeginGetProduct(GetProductRequest GetProductRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetProduct", new object[1]
      {
        (object) GetProductRequest
      }, callback, asyncState);
    }

    public GetProductResponse EndGetProduct(IAsyncResult asyncResult)
    {
      return (GetProductResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetProductCategories", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetProductCategoriesResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetProductCategoriesResponse GetProductCategories([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetProductCategoriesRequest GetProductCategoriesRequest)
    {
      return (GetProductCategoriesResponse) this.Invoke("GetProductCategories", new object[1]
      {
        (object) GetProductCategoriesRequest
      })[0];
    }

    public IAsyncResult BeginGetProductCategories(GetProductCategoriesRequest GetProductCategoriesRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetProductCategories", new object[1]
      {
        (object) GetProductCategoriesRequest
      }, callback, asyncState);
    }

    public GetProductCategoriesResponse EndGetProductCategories(IAsyncResult asyncResult)
    {
      return (GetProductCategoriesResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetProfile", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetProfileResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetProfileResponse GetProfile([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetProfileRequest GetProfileRequest)
    {
      return (GetProfileResponse) this.Invoke("GetProfile", new object[1]
      {
        (object) GetProfileRequest
      })[0];
    }

    public IAsyncResult BeginGetProfile(GetProfileRequest GetProfileRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetProfile", new object[1]
      {
        (object) GetProfileRequest
      }, callback, asyncState);
    }

    public GetProfileResponse EndGetProfile(IAsyncResult asyncResult)
    {
      return (GetProfileResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetProgram", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetProgramResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetProgramResponse GetProgram([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetProgramRequest GetProgramRequest)
    {
      return (GetProgramResponse) this.Invoke("GetProgram", new object[1]
      {
        (object) GetProgramRequest
      })[0];
    }

    public IAsyncResult BeginGetProgram(GetProgramRequest GetProgramRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetProgram", new object[1]
      {
        (object) GetProgramRequest
      }, callback, asyncState);
    }

    public GetProgramResponse EndGetProgram(IAsyncResult asyncResult)
    {
      return (GetProgramResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetProgramCategories", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetProgramCategoriesResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetProgramCategoriesResponse GetProgramCategories([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetProgramCategoriesRequest GetProgramCategoriesRequest)
    {
      return (GetProgramCategoriesResponse) this.Invoke("GetProgramCategories", new object[1]
      {
        (object) GetProgramCategoriesRequest
      })[0];
    }

    public IAsyncResult BeginGetProgramCategories(GetProgramCategoriesRequest GetProgramCategoriesRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetProgramCategories", new object[1]
      {
        (object) GetProgramCategoriesRequest
      }, callback, asyncState);
    }

    public GetProgramCategoriesResponse EndGetProgramCategories(IAsyncResult asyncResult)
    {
      return (GetProgramCategoriesResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetProgramApplications", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetProgramApplicationsResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetProgramApplicationsResponse GetProgramApplications([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetProgramApplicationsRequest GetProgramApplicationsRequest)
    {
      return (GetProgramApplicationsResponse) this.Invoke("GetProgramApplications", new object[1]
      {
        (object) GetProgramApplicationsRequest
      })[0];
    }

    public IAsyncResult BeginGetProgramApplications(GetProgramApplicationsRequest GetProgramApplicationsRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetProgramApplications", new object[1]
      {
        (object) GetProgramApplicationsRequest
      }, callback, asyncState);
    }

    public GetProgramApplicationsResponse EndGetProgramApplications(IAsyncResult asyncResult)
    {
      return (GetProgramApplicationsResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetSales", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetSalesResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetSalesResponse GetSales([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetSalesRequest GetSalesRequest)
    {
      return (GetSalesResponse) this.Invoke("GetSales", new object[1]
      {
        (object) GetSalesRequest
      })[0];
    }

    public IAsyncResult BeginGetSales(GetSalesRequest GetSalesRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetSales", new object[1]
      {
        (object) GetSalesRequest
      }, callback, asyncState);
    }

    public GetSalesResponse EndGetSales(IAsyncResult asyncResult)
    {
      return (GetSalesResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetSale", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetSaleResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetSaleResponse GetSale([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetSaleRequest GetSaleRequest)
    {
      return (GetSaleResponse) this.Invoke("GetSale", new object[1]
      {
        (object) GetSaleRequest
      })[0];
    }

    public IAsyncResult BeginGetSale(GetSaleRequest GetSaleRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetSale", new object[1]
      {
        (object) GetSaleRequest
      }, callback, asyncState);
    }

    public GetSaleResponse EndGetSale(IAsyncResult asyncResult)
    {
      return (GetSaleResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetLead", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetLeadResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetLeadResponse GetLead([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetLeadRequest GetLeadRequest)
    {
      return (GetLeadResponse) this.Invoke("GetLead", new object[1]
      {
        (object) GetLeadRequest
      })[0];
    }

    public IAsyncResult BeginGetLead(GetLeadRequest GetLeadRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetLead", new object[1]
      {
        (object) GetLeadRequest
      }, callback, asyncState);
    }

    public GetLeadResponse EndGetLead(IAsyncResult asyncResult)
    {
      return (GetLeadResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetTrackingCategories", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetTrackingCategoriesResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetTrackingCategoriesResponse GetTrackingCategories([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetTrackingCategoriesRequest GetTrackingCategoriesRequest)
    {
      return (GetTrackingCategoriesResponse) this.Invoke("GetTrackingCategories", new object[1]
      {
        (object) GetTrackingCategoriesRequest
      })[0];
    }

    public IAsyncResult BeginGetTrackingCategories(GetTrackingCategoriesRequest GetTrackingCategoriesRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetTrackingCategories", new object[1]
      {
        (object) GetTrackingCategoriesRequest
      }, callback, asyncState);
    }

    public GetTrackingCategoriesResponse EndGetTrackingCategories(IAsyncResult asyncResult)
    {
      return (GetTrackingCategoriesResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/SearchProducts", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("SearchProductsResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public SearchProductsResponse SearchProducts([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] SearchProductsRequest SearchProductsRequest)
    {
      return (SearchProductsResponse) this.Invoke("SearchProducts", new object[1]
      {
        (object) SearchProductsRequest
      })[0];
    }

    public IAsyncResult BeginSearchProducts(SearchProductsRequest SearchProductsRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("SearchProducts", new object[1]
      {
        (object) SearchProductsRequest
      }, callback, asyncState);
    }

    public SearchProductsResponse EndSearchProducts(IAsyncResult asyncResult)
    {
      return (SearchProductsResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/SearchPrograms", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("SearchProgramsResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public SearchProgramsResponse SearchPrograms([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] SearchProgramsRequest SearchProgramsRequest)
    {
      return (SearchProgramsResponse) this.Invoke("SearchPrograms", new object[1]
      {
        (object) SearchProgramsRequest
      })[0];
    }

    public IAsyncResult BeginSearchPrograms(SearchProgramsRequest SearchProgramsRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("SearchPrograms", new object[1]
      {
        (object) SearchProgramsRequest
      }, callback, asyncState);
    }

    public SearchProgramsResponse EndSearchPrograms(IAsyncResult asyncResult)
    {
      return (SearchProgramsResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/UpdateAdspace", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("UpdateAdspaceResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public UpdateAdspaceResponse UpdateAdspace([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] UpdateAdspaceRequest UpdateAdspaceRequest)
    {
      return (UpdateAdspaceResponse) this.Invoke("UpdateAdspace", new object[1]
      {
        (object) UpdateAdspaceRequest
      })[0];
    }

    public IAsyncResult BeginUpdateAdspace(UpdateAdspaceRequest UpdateAdspaceRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("UpdateAdspace", new object[1]
      {
        (object) UpdateAdspaceRequest
      }, callback, asyncState);
    }

    public UpdateAdspaceResponse EndUpdateAdspace(IAsyncResult asyncResult)
    {
      return (UpdateAdspaceResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/UpdateProfile", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("UpdateProfileResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public UpdateProfileResponse UpdateProfile([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] UpdateProfileRequest UpdateProfileRequest)
    {
      return (UpdateProfileResponse) this.Invoke("UpdateProfile", new object[1]
      {
        (object) UpdateProfileRequest
      })[0];
    }

    public IAsyncResult BeginUpdateProfile(UpdateProfileRequest UpdateProfileRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("UpdateProfile", new object[1]
      {
        (object) UpdateProfileRequest
      }, callback, asyncState);
    }

    public UpdateProfileResponse EndUpdateProfile(IAsyncResult asyncResult)
    {
      return (UpdateProfileResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetReportBasic", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetReportBasicResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetReportBasicResponse GetReportBasic([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetReportBasicRequest GetReportBasicRequest)
    {
      return (GetReportBasicResponse) this.Invoke("GetReportBasic", new object[1]
      {
        (object) GetReportBasicRequest
      })[0];
    }

    public IAsyncResult BeginGetReportBasic(GetReportBasicRequest GetReportBasicRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetReportBasic", new object[1]
      {
        (object) GetReportBasicRequest
      }, callback, asyncState);
    }

    public GetReportBasicResponse EndGetReportBasic(IAsyncResult asyncResult)
    {
      return (GetReportBasicResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetBankAccount", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetBankAccountResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetBankAccountResponse GetBankAccount([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetBankAccountRequest GetBankAccountRequest)
    {
      return (GetBankAccountResponse) this.Invoke("GetBankAccount", new object[1]
      {
        (object) GetBankAccountRequest
      })[0];
    }

    public IAsyncResult BeginGetBankAccount(GetBankAccountRequest GetBankAccountRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetBankAccount", new object[1]
      {
        (object) GetBankAccountRequest
      }, callback, asyncState);
    }

    public GetBankAccountResponse EndGetBankAccount(IAsyncResult asyncResult)
    {
      return (GetBankAccountResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetPayment", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetPaymentResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetPaymentResponse GetPayment([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetPaymentRequest GetPaymentRequest)
    {
      return (GetPaymentResponse) this.Invoke("GetPayment", new object[1]
      {
        (object) GetPaymentRequest
      })[0];
    }

    public IAsyncResult BeginGetPayment(GetPaymentRequest GetPaymentRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetPayment", new object[1]
      {
        (object) GetPaymentRequest
      }, callback, asyncState);
    }

    public GetPaymentResponse EndGetPayment(IAsyncResult asyncResult)
    {
      return (GetPaymentResponse) this.EndInvoke(asyncResult)[0];
    }

    [SoapDocumentMethod("http://api.zanox.com/namespace/2011-03-01/GetBalance", ParameterStyle = SoapParameterStyle.Bare, Use = SoapBindingUse.Literal)]
    [return: XmlElement("GetBalanceResponse", Namespace = "http://api.zanox.com/namespace/2011-03-01/")]
    public GetBalanceResponse GetBalance([XmlElement(Namespace = "http://api.zanox.com/namespace/2011-03-01/")] GetBalanceRequest GetBalanceRequest)
    {
      return (GetBalanceResponse) this.Invoke("GetBalance", new object[1]
      {
        (object) GetBalanceRequest
      })[0];
    }

    public IAsyncResult BeginGetBalance(GetBalanceRequest GetBalanceRequest, AsyncCallback callback, object asyncState)
    {
      return this.BeginInvoke("GetBalance", new object[1]
      {
        (object) GetBalanceRequest
      }, callback, asyncState);
    }

    public GetBalanceResponse EndGetBalance(IAsyncResult asyncResult)
    {
      return (GetBalanceResponse) this.EndInvoke(asyncResult)[0];
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
