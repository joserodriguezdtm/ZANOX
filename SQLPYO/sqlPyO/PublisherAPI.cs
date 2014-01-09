// Type: ZanoxV2.PublisherAPI
// Assembly: ZanoxV2, Version=1.0.4955.28682, Culture=neutral, PublicKeyToken=d1e62d2627a2f3e0
// MVID: 35AD163E-3C46-45E7-B3AA-50397E6E2193
// Assembly location: C:\Users\daniel.lopez\Desktop\Zanox.API\ZanoxV2.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using sqlPyO.Auth;
using sqlPyO.Publisher;

namespace sqlPyO
{
  public class PublisherAPI
  {
    protected PublisherService publisherService;

    public PublisherAPI()
      : this((IWebProxy) null)
    {
    }

    public PublisherAPI(IWebProxy proxy)
    {
      this.publisherService = new PublisherService();
      this.publisherService.Proxy = proxy;
      this.publisherService.EnableDecompression = true;
      this.publisherService.UserAgent = Constants.UserAgent;
    }

    public profileItem GetProfile(sessionType session)
    {
      GetProfileRequest GetProfileRequest = new GetProfileRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetProfileRequest.nonce = Signature.GetNonce();
      GetProfileRequest.connectId = session.connectId;
      GetProfileRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "getprofile", GetProfileRequest.nonce);
      GetProfileRequest.timestamp = Signature.GetZDateTime(utcNow);
      GetProfileResponse profile = this.publisherService.GetProfile(GetProfileRequest);
      if (profile == null)
        return (profileItem) null;
      else
        return profile.profileItem;
    }

    public profileItem UpdateProfile(sessionType session, profileItem profile)
    {
      UpdateProfileRequest UpdateProfileRequest = new UpdateProfileRequest();
      DateTime utcNow = DateTime.UtcNow;
      UpdateProfileRequest.nonce = Signature.GetNonce();
      UpdateProfileRequest.connectId = session.connectId;
      UpdateProfileRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "updateprofile", UpdateProfileRequest.nonce);
      UpdateProfileRequest.timestamp = Signature.GetZDateTime(utcNow);
      UpdateProfileRequest.profileItem = new profileItem()
      {
        id = profile.id,
        idSpecified = true,
        firstName = profile.firstName,
        lastName = profile.lastName,
        company = profile.company,
        country = profile.country,
        city = profile.city,
        zipcode = profile.zipcode,
        street1 = profile.street1,
        street2 = profile.street2,
        fax = profile.fax,
        phone = profile.phone,
        mobile = profile.mobile
      };
      UpdateProfileResponse updateProfileResponse = this.publisherService.UpdateProfile(UpdateProfileRequest);
      if (updateProfileResponse == null)
        return (profileItem) null;
      else
        return updateProfileResponse.profileItem;
    }

    public adspaceItem GetAdspace(sessionType session, int adspaceId)
    {
      GetAdspaceRequest GetAdspaceRequest = new GetAdspaceRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetAdspaceRequest.nonce = Signature.GetNonce();
      GetAdspaceRequest.connectId = session.connectId;
      GetAdspaceRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "getadspace", GetAdspaceRequest.nonce);
      GetAdspaceRequest.timestamp = Signature.GetZDateTime(utcNow);
      GetAdspaceRequest.adspaceId = adspaceId;
      GetAdspaceResponse adspace = this.publisherService.GetAdspace(GetAdspaceRequest);
      if (adspace == null || adspace.adspaceItem == null)
        return (adspaceItem) null;
      else
        return adspace.adspaceItem;
    }

    public List<adspaceItem> GetAdspaces(sessionType session, int items, int page, out int total)
    {
      GetAdspacesRequest GetAdspacesRequest = new GetAdspacesRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetAdspacesRequest.nonce = Signature.GetNonce();
      GetAdspacesRequest.connectId = session.connectId;
      GetAdspacesRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "getadspaces", GetAdspacesRequest.nonce);
      GetAdspacesRequest.timestamp = Signature.GetZDateTime(utcNow);
      GetAdspacesRequest.items = items;
      GetAdspacesRequest.itemsSpecified = true;
      GetAdspacesRequest.page = page;
      GetAdspacesRequest.pageSpecified = true;
      GetAdspacesResponse adspaces = this.publisherService.GetAdspaces(GetAdspacesRequest);
      if (adspaces == null)
      {
        total = 0;
        return (List<adspaceItem>) null;
      }
      else if (adspaces.adspaceItems == null)
      {
        total = 0;
        return (List<adspaceItem>) null;
      }
      else
      {
        total = (int) adspaces.total;
        return Enumerable.ToList<adspaceItem>((IEnumerable<adspaceItem>) adspaces.adspaceItems);
      }
    }

    public adspaceItem CreateAdspace(sessionType session, adspaceItem adspace)
    {
      CreateAdspaceRequest CreateAdspaceRequest = new CreateAdspaceRequest();
      DateTime utcNow = DateTime.UtcNow;
      CreateAdspaceRequest.nonce = Signature.GetNonce();
      CreateAdspaceRequest.connectId = session.connectId;
      CreateAdspaceRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "createadspace", CreateAdspaceRequest.nonce);
      CreateAdspaceRequest.timestamp = Signature.GetZDateTime(utcNow);
      CreateAdspaceRequest.adspaceItem = adspace;
      CreateAdspaceResponse adspace1 = this.publisherService.CreateAdspace(CreateAdspaceRequest);
      if (adspace1 == null)
        return (adspaceItem) null;
      else
        return adspace1.adspaceItem;
    }

    public adspaceItem UpdateAdspace(sessionType session, adspaceItem adspace)
    {
      UpdateAdspaceRequest UpdateAdspaceRequest = new UpdateAdspaceRequest();
      DateTime utcNow = DateTime.UtcNow;
      UpdateAdspaceRequest.nonce = Signature.GetNonce();
      UpdateAdspaceRequest.connectId = session.connectId;
      UpdateAdspaceRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "updateadspace", UpdateAdspaceRequest.nonce);
      UpdateAdspaceRequest.timestamp = Signature.GetZDateTime(utcNow);
      UpdateAdspaceRequest.adspaceItem = adspace;
      UpdateAdspaceResponse updateAdspaceResponse = this.publisherService.UpdateAdspace(UpdateAdspaceRequest);
      if (updateAdspaceResponse == null)
        return (adspaceItem) null;
      else
        return updateAdspaceResponse.adspaceItem;
    }

    public int DeleteAdspace(sessionType session, int adspaceId)
    {
      DeleteAdspaceRequest DeleteAdspaceRequest = new DeleteAdspaceRequest();
      DateTime utcNow = DateTime.UtcNow;
      DeleteAdspaceRequest.nonce = Signature.GetNonce();
      DeleteAdspaceRequest.connectId = session.connectId;
      DeleteAdspaceRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "deleteadspace", DeleteAdspaceRequest.nonce);
      DeleteAdspaceRequest.timestamp = Signature.GetZDateTime(utcNow);
      DeleteAdspaceRequest.adspaceId = adspaceId;
      DeleteAdspaceResponse deleteAdspaceResponse = this.publisherService.DeleteAdspace(DeleteAdspaceRequest);
      if (deleteAdspaceResponse == null)
        return 0;
      else
        return deleteAdspaceResponse.count;
    }

    public programItem GetProgram(sessionType session, int programId)
    {
      GetProgramResponse program = this.publisherService.GetProgram(new GetProgramRequest()
      {
        connectId = session.connectId,
        programId = programId
      });
      if (program == null)
        return (programItem) null;
      else
        return program.programItem;
    }

    public List<programItem> SearchPrograms(sessionType session, string query, string region, bool hasProducts, int? categoryId, DateTime? startDate, partnerShipEnum? partnerShip, int page, int items, out int total)
    {
      List<programItem> list = new List<programItem>();
      SearchProgramsRequest SearchProgramsRequest = new SearchProgramsRequest();
      SearchProgramsRequest.connectId = session.connectId;
      SearchProgramsRequest.query = query;
      SearchProgramsRequest.region = region;
      if (startDate.HasValue)
      {
        SearchProgramsRequest.startDate = startDate.Value;
        SearchProgramsRequest.startDateSpecified = true;
      }
      if (partnerShip.HasValue)
      {
        SearchProgramsRequest.partnerShip = partnerShip.Value;
        SearchProgramsRequest.partnerShipSpecified = true;
      }
      if (hasProducts)
      {
        SearchProgramsRequest.hasProducts = hasProducts;
        SearchProgramsRequest.hasProductsSpecified = true;
      }
      if (categoryId.HasValue)
      {
        SearchProgramsRequest.categoryId = categoryId.Value;
        SearchProgramsRequest.categoryIdSpecified = true;
      }
      SearchProgramsRequest.page = page;
      SearchProgramsRequest.pageSpecified = true;
      SearchProgramsRequest.items = items;
      SearchProgramsRequest.itemsSpecified = true;
      SearchProgramsResponse programsResponse = this.publisherService.SearchPrograms(SearchProgramsRequest);
      if (programsResponse == null)
      {
        total = 0;
        return (List<programItem>) null;
      }
      else if (programsResponse.programItems == null)
      {
        total = 0;
        return (List<programItem>) null;
      }
      else
      {
        total = (int) programsResponse.total;
        return Enumerable.ToList<programItem>((IEnumerable<programItem>) programsResponse.programItems);
      }
    }

    public List<subStringIdentifierType> GetProgramCategories(sessionType session)
    {
      GetProgramCategoriesResponse programCategories = this.publisherService.GetProgramCategories(new GetProgramCategoriesRequest()
      {
        connectId = session.connectId
      });
      if (programCategories == null || programCategories == null || programCategories.categories == null)
        return (List<subStringIdentifierType>) null;
      else
        return Enumerable.ToList<subStringIdentifierType>((IEnumerable<subStringIdentifierType>) programCategories.categories);
    }

    public programApplicationItem CreateProgramApplication(sessionType session, int adspaceId, int programId, string comment)
    {
      CreateProgramApplicationRequest CreateProgramApplicationRequest = new CreateProgramApplicationRequest();
      DateTime utcNow = DateTime.UtcNow;
      CreateProgramApplicationRequest.nonce = Signature.GetNonce();
      CreateProgramApplicationRequest.connectId = session.connectId;
      CreateProgramApplicationRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "createprogramapplication", CreateProgramApplicationRequest.nonce);
      CreateProgramApplicationRequest.timestamp = Signature.GetZDateTime(utcNow);
      CreateProgramApplicationRequest.adspaceId = adspaceId;
      CreateProgramApplicationRequest.programId = programId;
      CreateProgramApplicationRequest.publisherComment = comment;
      CreateProgramApplicationResponse programApplication = this.publisherService.CreateProgramApplication(CreateProgramApplicationRequest);
      if (programApplication == null || programApplication.programApplicationItem == null)
        return (programApplicationItem) null;
      else
        return programApplication.programApplicationItem;
    }

    public List<programApplicationItem> GetProgramApplications(sessionType session, int? adspaceId, int? programId, programApplicationStatusEnum? status, int items, int page, out int total)
    {
      GetProgramApplicationsRequest GetProgramApplicationsRequest = new GetProgramApplicationsRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetProgramApplicationsRequest.nonce = Signature.GetNonce();
      GetProgramApplicationsRequest.connectId = session.connectId;
      GetProgramApplicationsRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "getprogramapplications", GetProgramApplicationsRequest.nonce);
      GetProgramApplicationsRequest.timestamp = Signature.GetZDateTime(utcNow);
      if (adspaceId.HasValue)
      {
        GetProgramApplicationsRequest.adspaceId = adspaceId.Value;
        GetProgramApplicationsRequest.adspaceIdSpecified = true;
      }
      if (programId.HasValue)
      {
        GetProgramApplicationsRequest.programId = programId.Value;
        GetProgramApplicationsRequest.programIdSpecified = true;
      }
      if (status.HasValue)
      {
        GetProgramApplicationsRequest.status = status.Value;
        GetProgramApplicationsRequest.statusSpecified = true;
      }
      GetProgramApplicationsRequest.page = page;
      GetProgramApplicationsRequest.pageSpecified = true;
      GetProgramApplicationsRequest.items = items;
      GetProgramApplicationsRequest.itemsSpecified = true;
      GetProgramApplicationsResponse programApplications = this.publisherService.GetProgramApplications(GetProgramApplicationsRequest);
      if (programApplications == null)
      {
        total = 0;
        return (List<programApplicationItem>) null;
      }
      else if (programApplications.programApplicationItems == null)
      {
        total = 0;
        return (List<programApplicationItem>) null;
      }
      else
      {
        total = (int) programApplications.total;
        return Enumerable.ToList<programApplicationItem>((IEnumerable<programApplicationItem>) programApplications.programApplicationItems);
      }
    }

    public int DeleteProgramApplication(sessionType session, int adspaceId, int programId)
    {
      DeleteProgramApplicationRequest DeleteProgramApplicationRequest = new DeleteProgramApplicationRequest();
      DateTime utcNow = DateTime.UtcNow;
      DeleteProgramApplicationRequest.nonce = Signature.GetNonce();
      DeleteProgramApplicationRequest.connectId = session.connectId;
      DeleteProgramApplicationRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "deleteprogramapplication", DeleteProgramApplicationRequest.nonce);
      DeleteProgramApplicationRequest.timestamp = Signature.GetZDateTime(utcNow);
      DeleteProgramApplicationRequest.adspaceId = adspaceId;
      DeleteProgramApplicationRequest.programId = programId;
      DeleteProgramApplicationResponse applicationResponse = this.publisherService.DeleteProgramApplication(DeleteProgramApplicationRequest);
      if (applicationResponse == null)
        return 0;
      else
        return applicationResponse.count;
    }

    public admediumItem GetAdmedium(sessionType session, int admediumId, int? adspaceId)
    {
      GetAdmediumRequest GetAdmediumRequest = new GetAdmediumRequest();
      GetAdmediumRequest.connectId = session.connectId;
      GetAdmediumRequest.admediumId = admediumId;
      if (adspaceId.HasValue)
      {
        GetAdmediumRequest.adspaceId = adspaceId.Value;
        GetAdmediumRequest.adspaceIdSpecified = true;
      }
      GetAdmediumResponse admedium = this.publisherService.GetAdmedium(GetAdmediumRequest);
      if (admedium == null)
        return (admediumItem) null;
      else
        return admedium.admediumItem;
    }

    public admediumItem GetAdmedium(sessionType session, string trackingLink, int? adspaceId)
    {
      GetAdmediumRequest GetAdmediumRequest = new GetAdmediumRequest();
      GetAdmediumRequest.connectId = session.connectId;
      GetAdmediumRequest.trackingLink = trackingLink;
      if (adspaceId.HasValue)
      {
        GetAdmediumRequest.adspaceId = adspaceId.Value;
        GetAdmediumRequest.adspaceIdSpecified = true;
      }
      GetAdmediumResponse admedium = this.publisherService.GetAdmedium(GetAdmediumRequest);
      if (admedium == null)
        return (admediumItem) null;
      else
        return admedium.admediumItem;
    }

    public List<admediumItem> GetAdmedia(sessionType session, int? programId, int? adspaceId, int? categoryId, admediaTypeEnum? admediaType, int? format, partnerShipEnum? partnerShip, admediaPurposeEnum? admediaPurpose, string region, int page, int items, out int total)
    {
      List<admediumItem> list = new List<admediumItem>();
      GetAdmediaRequest GetAdmediaRequest = new GetAdmediaRequest();
      GetAdmediaRequest.connectId = session.connectId;
      if (programId.HasValue)
      {
        GetAdmediaRequest.programId = programId.Value;
        GetAdmediaRequest.programIdSpecified = true;
      }
      if (adspaceId.HasValue)
      {
        GetAdmediaRequest.adspaceId = adspaceId.Value;
        GetAdmediaRequest.adspaceIdSpecified = true;
      }
      if (categoryId.HasValue)
      {
        GetAdmediaRequest.categoryId = categoryId.Value;
        GetAdmediaRequest.categoryIdSpecified = true;
      }
      if (format.HasValue)
      {
        GetAdmediaRequest.format = format.Value;
        GetAdmediaRequest.formatSpecified = true;
      }
      if (admediaType.HasValue)
      {
        GetAdmediaRequest.admediumType = admediaType.Value;
        GetAdmediaRequest.admediumTypeSpecified = true;
      }
      if (partnerShip.HasValue)
      {
        GetAdmediaRequest.partnerShip = partnerShip.Value;
        GetAdmediaRequest.partnerShipSpecified = true;
      }
      if (admediaPurpose.HasValue)
      {
        GetAdmediaRequest.purpose = admediaPurpose.Value;
        GetAdmediaRequest.purposeSpecified = true;
      }
      if (!string.IsNullOrEmpty(region))
        GetAdmediaRequest.region = region;
      GetAdmediaRequest.items = items;
      GetAdmediaRequest.itemsSpecified = true;
      GetAdmediaRequest.page = page;
      GetAdmediaRequest.pageSpecified = true;
      GetAdmediaResponse admedia = this.publisherService.GetAdmedia(GetAdmediaRequest);
      if (admedia == null)
      {
        total = 0;
        return (List<admediumItem>) null;
      }
      else if (admedia.admediumItems == null)
      {
        total = 0;
        return (List<admediumItem>) null;
      }
      else
      {
        total = (int) admedia.total;
        return Enumerable.ToList<admediumItem>((IEnumerable<admediumItem>) admedia.admediumItems);
      }
    }

    public IList<subStringIdentifierType> GetAdmediumCategories(sessionType session, int programId)
    {
      List<admediumItem> list = new List<admediumItem>();
      GetAdmediumCategoriesResponse admediumCategories = this.publisherService.GetAdmediumCategories(new GetAdmediumCategoriesRequest()
      {
        connectId = session.connectId,
        programId = programId
      });
      if (admediumCategories == null)
        return (IList<subStringIdentifierType>) null;
      else
        return (IList<subStringIdentifierType>) admediumCategories.categories;
    }

    public productItem GetProduct(sessionType session, string productId, int? adspaceId)
    {
      GetProductRequest GetProductRequest = new GetProductRequest();
      GetProductRequest.connectId = session.connectId;
      GetProductRequest.zupId = productId;
      if (adspaceId.HasValue)
      {
        GetProductRequest.adspaceId = adspaceId.Value;
        GetProductRequest.adspaceIdSpecified = true;
      }
      GetProductResponse product = this.publisherService.GetProduct(GetProductRequest);
      if (product == null)
        return (productItem) null;
      else
        return product.productItem;
    }

    public IList<productItem> SearchProducts(sessionType session, int page, int items, string query, searchTypeEnum? searchType, string region, int[] programIds, int? categoryId, int? adSpaceId, int? minPrice, int? maxPrice, bool? hasImage, out int total)
    {
      SearchProductsRequest SearchProductsRequest = new SearchProductsRequest();
      SearchProductsRequest.connectId = session.connectId;
      SearchProductsRequest.query = query;
      SearchProductsRequest.region = region;
      SearchProductsRequest.programId = programIds;
      if (searchType.HasValue)
      {
        SearchProductsRequest.searchType = searchType.Value;
        SearchProductsRequest.searchTypeSpecified = true;
      }
      if (minPrice.HasValue)
      {
        SearchProductsRequest.minPrice = minPrice.Value;
        SearchProductsRequest.minPriceSpecified = true;
      }
      if (maxPrice.HasValue)
      {
        SearchProductsRequest.maxPrice = maxPrice.Value;
        SearchProductsRequest.maxPriceSpecified = true;
      }
      if (categoryId.HasValue)
      {
        SearchProductsRequest.categoryId = categoryId.Value;
        SearchProductsRequest.categoryIdSpecified = true;
      }
      if (adSpaceId.HasValue)
      {
        SearchProductsRequest.adspaceId = adSpaceId.Value;
        SearchProductsRequest.adspaceIdSpecified = true;
      }
      if (hasImage.HasValue)
      {
        SearchProductsRequest.hasImages = hasImage.Value;
        SearchProductsRequest.hasImagesSpecified = true;
      }
      SearchProductsRequest.page = page;
      SearchProductsRequest.pageSpecified = true;
      SearchProductsRequest.items = items;
      SearchProductsRequest.itemsSpecified = true;
      SearchProductsResponse productsResponse = this.publisherService.SearchProducts(SearchProductsRequest);
      if (productsResponse == null)
      {
        total = 0;
        return (IList<productItem>) null;
      }
      else if (productsResponse.productItems == null)
      {
        total = 0;
        return (IList<productItem>) null;
      }
      else
      {
        total = (int) productsResponse.total;
        return (IList<productItem>) Enumerable.ToList<productItem>((IEnumerable<productItem>) productsResponse.productItems);
      }
    }

    public IList<productCategoryType> GetProductCategories(sessionType session, string region, int? rootCategory, bool? includeChilds)
    {
      GetProductCategoriesRequest GetProductCategoriesRequest = new GetProductCategoriesRequest();
      GetProductCategoriesRequest.connectId = session.connectId;
      GetProductCategoriesRequest.region = region;
      if (rootCategory.HasValue)
      {
        GetProductCategoriesRequest.rootCategory = rootCategory.Value;
        GetProductCategoriesRequest.rootCategorySpecified = true;
      }
      if (includeChilds.HasValue)
      {
        GetProductCategoriesRequest.includeChilds = includeChilds.Value;
        GetProductCategoriesRequest.includeChildsSpecified = true;
      }
      GetProductCategoriesResponse productCategories = this.publisherService.GetProductCategories(GetProductCategoriesRequest);
      if (productCategories == null || productCategories.categories == null)
        return (IList<productCategoryType>) null;
      else
        return (IList<productCategoryType>) Enumerable.ToList<productCategoryType>((IEnumerable<productCategoryType>) productCategories.categories);
    }

    public saleItem GetSale(sessionType session, string saleId)
    {
      GetSaleRequest GetSaleRequest = new GetSaleRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetSaleRequest.nonce = Signature.GetNonce();
      GetSaleRequest.connectId = session.connectId;
      GetSaleRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "getsale", GetSaleRequest.nonce);
      GetSaleRequest.timestamp = Signature.GetZDateTime(utcNow);
      GetSaleRequest.saleId = saleId;
      GetSaleResponse sale = this.publisherService.GetSale(GetSaleRequest);
      if (sale == null)
        return (saleItem) null;
      else
        return sale.saleItem;
    }

    public leadItem GetLead(sessionType session, string leadId)
    {
      GetLeadRequest GetLeadRequest = new GetLeadRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetLeadRequest.nonce = Signature.GetNonce();
      GetLeadRequest.connectId = session.connectId;
      GetLeadRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "getlead", GetLeadRequest.nonce);
      GetLeadRequest.timestamp = Signature.GetZDateTime(utcNow);
      GetLeadRequest.leadId = leadId;
      GetLeadResponse lead = this.publisherService.GetLead(GetLeadRequest);
      if (lead == null)
        return (leadItem) null;
      else
        return lead.leadItem;
    }

    public IList<saleItem> GetSales(sessionType session, DateTime date, dateTypeEnum dateType, int? adSpaceId, int? programId, reviewStateEnum? reviewState, int items, int page, out int total)
    {
      GetSalesRequest GetSalesRequest = new GetSalesRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetSalesRequest.nonce = Signature.GetNonce();
      GetSalesRequest.connectId = session.connectId;
      GetSalesRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "getsales", GetSalesRequest.nonce);
      GetSalesRequest.timestamp = Signature.GetZDateTime(utcNow);
      if (adSpaceId.HasValue)
      {
        GetSalesRequest.adspaceId = adSpaceId.Value;
        GetSalesRequest.adspaceIdSpecified = true;
      }
      if (programId.HasValue)
      {
        GetSalesRequest.programId = programId.Value;
        GetSalesRequest.programIdSpecified = true;
      }
      if (reviewState.HasValue)
      {
        GetSalesRequest.reviewState = reviewState.Value;
        GetSalesRequest.reviewStateSpecified = true;
      }
      GetSalesRequest.date = date;
      GetSalesRequest.dateType = dateType;
      GetSalesRequest.items = items;
      GetSalesRequest.itemsSpecified = true;
      GetSalesRequest.page = page;
      GetSalesRequest.pageSpecified = true;
      GetSalesResponse sales = this.publisherService.GetSales(GetSalesRequest);
      if (sales == null)
      {
        total = 0;
        return (IList<saleItem>) null;
      }
      else if (sales.saleItems == null)
      {
        total = 0;
        return (IList<saleItem>) null;
      }
      else
      {
        total = (int) sales.total;
        return (IList<saleItem>) Enumerable.ToList<saleItem>((IEnumerable<saleItem>) sales.saleItems);
      }
    }

    public IList<leadItem> GetLeads(sessionType session, DateTime date, dateTypeEnum dateType, int? adSpaceId, int? programId, reviewStateEnum? reviewState, int items, int page, out int total)
    {
      GetLeadsRequest GetLeadsRequest = new GetLeadsRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetLeadsRequest.nonce = Signature.GetNonce();
      GetLeadsRequest.connectId = session.connectId;
      GetLeadsRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "getleads", GetLeadsRequest.nonce);
      GetLeadsRequest.timestamp = Signature.GetZDateTime(utcNow);
      if (adSpaceId.HasValue)
      {
        GetLeadsRequest.adspaceId = adSpaceId.Value;
        GetLeadsRequest.adspaceIdSpecified = true;
      }
      if (programId.HasValue)
      {
        GetLeadsRequest.programId = programId.Value;
        GetLeadsRequest.programIdSpecified = true;
      }
      if (reviewState.HasValue)
      {
        GetLeadsRequest.reviewState = reviewState.Value;
        GetLeadsRequest.reviewStateSpecified = true;
      }
      GetLeadsRequest.date = date;
      GetLeadsRequest.dateType = dateType;
      GetLeadsRequest.items = items;
      GetLeadsRequest.itemsSpecified = true;
      GetLeadsRequest.page = page;
      GetLeadsRequest.pageSpecified = true;
      GetLeadsResponse leads = this.publisherService.GetLeads(GetLeadsRequest);
      if (leads == null)
      {
        total = 0;
        return (IList<leadItem>) null;
      }
      else if (leads.leadItems == null)
      {
        total = 0;
        return (IList<leadItem>) null;
      }
      else
      {
        total = (int) leads.total;
        return (IList<leadItem>) Enumerable.ToList<leadItem>((IEnumerable<leadItem>) leads.leadItems);
      }
    }

    public IList<reportItem> GetReportBasic(sessionType session, DateTime fromDate, DateTime toDate, string currency, groupByEnum[] groupBy, int? adspaceId, int? programId, int? admediumId, reviewStateEnum? reviewState)
    {
      GetReportBasicRequest GetReportBasicRequest = new GetReportBasicRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetReportBasicRequest.nonce = Signature.GetNonce();
      GetReportBasicRequest.connectId = session.connectId;
      GetReportBasicRequest.timestamp = Signature.GetZDateTime(utcNow);
      GetReportBasicRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "getreportbasic", GetReportBasicRequest.nonce);
      GetReportBasicRequest.groupBy = groupBy;
      GetReportBasicRequest.fromDate = fromDate;
      GetReportBasicRequest.toDate = toDate;
      GetReportBasicRequest.currency = currency;
      if (programId.HasValue)
      {
        GetReportBasicRequest.programId = programId.Value;
        GetReportBasicRequest.programIdSpecified = true;
      }
      if (reviewState.HasValue)
      {
        GetReportBasicRequest.reviewState = reviewState.Value;
        GetReportBasicRequest.reviewStateSpecified = true;
      }
      if (adspaceId.HasValue)
      {
        GetReportBasicRequest.adspaceId = adspaceId.Value;
        GetReportBasicRequest.adspaceIdSpecified = true;
      }
      if (admediumId.HasValue)
      {
        GetReportBasicRequest.admediumId = admediumId.Value;
        GetReportBasicRequest.admediumIdSpecified = true;
      }
      GetReportBasicResponse reportBasic = this.publisherService.GetReportBasic(GetReportBasicRequest);
      if (reportBasic == null || reportBasic.reportItems == null)
        return (IList<reportItem>) null;
      else
        return (IList<reportItem>) Enumerable.ToList<reportItem>((IEnumerable<reportItem>) reportBasic.reportItems);
    }

    public paymentItem GetPayment(sessionType session, string paymentId)
    {
      GetPaymentRequest GetPaymentRequest = new GetPaymentRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetPaymentRequest.nonce = Signature.GetNonce();
      GetPaymentRequest.connectId = session.connectId;
      GetPaymentRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "getpayment", GetPaymentRequest.nonce);
      GetPaymentRequest.timestamp = Signature.GetZDateTime(utcNow);
      GetPaymentRequest.paymentId = paymentId;
      GetPaymentResponse payment = this.publisherService.GetPayment(GetPaymentRequest);
      if (payment == null)
        return (paymentItem) null;
      else
        return payment.paymentItem;
    }

    public IList<paymentItem> GetPayments(sessionType session, int items, int page, out int total)
    {
      GetPaymentsRequest GetPaymentsRequest = new GetPaymentsRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetPaymentsRequest.nonce = Signature.GetNonce();
      GetPaymentsRequest.connectId = session.connectId;
      GetPaymentsRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "getpayments", GetPaymentsRequest.nonce);
      GetPaymentsRequest.timestamp = Signature.GetZDateTime(utcNow);
      GetPaymentsRequest.items = items;
      GetPaymentsRequest.itemsSpecified = true;
      GetPaymentsRequest.page = page;
      GetPaymentsRequest.pageSpecified = true;
      GetPaymentsResponse payments = this.publisherService.GetPayments(GetPaymentsRequest);
      if (payments == null)
      {
        total = 0;
        return (IList<paymentItem>) null;
      }
      else if (payments.paymentItems == null)
      {
        total = 0;
        return (IList<paymentItem>) null;
      }
      else
      {
        total = (int) payments.total;
        return (IList<paymentItem>) Enumerable.ToList<paymentItem>((IEnumerable<paymentItem>) payments.paymentItems);
      }
    }

    public balanceItem GetBalance(sessionType session, string currency)
    {
      GetBalanceRequest GetBalanceRequest = new GetBalanceRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetBalanceRequest.nonce = Signature.GetNonce();
      GetBalanceRequest.connectId = session.connectId;
      GetBalanceRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "getbalance", GetBalanceRequest.nonce);
      GetBalanceRequest.timestamp = Signature.GetZDateTime(utcNow);
      GetBalanceRequest.currency = currency;
      GetBalanceResponse balance = this.publisherService.GetBalance(GetBalanceRequest);
      if (balance == null)
        return (balanceItem) null;
      else
        return balance.balanceItem;
    }

    public IList<balanceItem> GetBalances(sessionType session, int items, int page, out int total)
    {
      GetBalancesRequest GetBalancesRequest = new GetBalancesRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetBalancesRequest.nonce = Signature.GetNonce();
      GetBalancesRequest.connectId = session.connectId;
      GetBalancesRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "getbalances", GetBalancesRequest.nonce);
      GetBalancesRequest.timestamp = Signature.GetZDateTime(utcNow);
      GetBalancesRequest.items = items;
      GetBalancesRequest.itemsSpecified = true;
      GetBalancesRequest.page = page;
      GetBalancesRequest.pageSpecified = true;
      GetBalancesResponse balances = this.publisherService.GetBalances(GetBalancesRequest);
      if (balances == null)
      {
        total = 0;
        return (IList<balanceItem>) null;
      }
      else if (balances.balanceItems == null)
      {
        total = 0;
        return (IList<balanceItem>) null;
      }
      else
      {
        total = (int) balances.total;
        return (IList<balanceItem>) Enumerable.ToList<balanceItem>((IEnumerable<balanceItem>) balances.balanceItems);
      }
    }

    public bankAccountItem GetBankAccount(sessionType session, string bankAccountId)
    {
      GetBankAccountRequest GetBankAccountRequest = new GetBankAccountRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetBankAccountRequest.nonce = Signature.GetNonce();
      GetBankAccountRequest.connectId = session.connectId;
      GetBankAccountRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "getbankaccount", GetBankAccountRequest.nonce);
      GetBankAccountRequest.timestamp = Signature.GetZDateTime(utcNow);
      GetBankAccountRequest.bankAccountId = bankAccountId;
      GetBankAccountResponse bankAccount = this.publisherService.GetBankAccount(GetBankAccountRequest);
      if (bankAccount == null)
        return (bankAccountItem) null;
      else
        return bankAccount.bankAccountItem;
    }

    public IList<bankAccountItem> GetBankAccounts(sessionType session, int items, int page, out int total)
    {
      GetBankAccountsRequest GetBankAccountsRequest = new GetBankAccountsRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetBankAccountsRequest.nonce = Signature.GetNonce();
      GetBankAccountsRequest.connectId = session.connectId;
      GetBankAccountsRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "getbankaccounts", GetBankAccountsRequest.nonce);
      GetBankAccountsRequest.timestamp = Signature.GetZDateTime(utcNow);
      GetBankAccountsRequest.items = items;
      GetBankAccountsRequest.itemsSpecified = true;
      GetBankAccountsRequest.page = page;
      GetBankAccountsRequest.pageSpecified = true;
      GetBankAccountsResponse bankAccounts = this.publisherService.GetBankAccounts(GetBankAccountsRequest);
      if (bankAccounts == null)
      {
        total = 0;
        return (IList<bankAccountItem>) null;
      }
      else if (bankAccounts.bankAccountItems == null)
      {
        total = 0;
        return (IList<bankAccountItem>) null;
      }
      else
      {
        total = (int) bankAccounts.total;
        return (IList<bankAccountItem>) Enumerable.ToList<bankAccountItem>((IEnumerable<bankAccountItem>) bankAccounts.bankAccountItems);
      }
    }

    public applicationItem GetApplication(sessionType session, string applicationId)
    {
      GetApplicationRequest GetApplicationRequest = new GetApplicationRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetApplicationRequest.nonce = Signature.GetNonce();
      GetApplicationRequest.connectId = session.connectId;
      GetApplicationRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "getapplication", GetApplicationRequest.nonce);
      GetApplicationRequest.timestamp = Signature.GetZDateTime(utcNow);
      GetApplicationRequest.applicationId = applicationId;
      GetApplicationResponse application = this.publisherService.GetApplication(GetApplicationRequest);
      if (application == null)
        return (applicationItem) null;
      else
        return application.applicationItem;
    }

    public IList<applicationItem> GetApplications(sessionType session, applicationTypeEnum? applicationType, roleTypeEnum? role, string name, int items, int page, out int total)
    {
      GetApplicationsRequest GetApplicationsRequest = new GetApplicationsRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetApplicationsRequest.nonce = Signature.GetNonce();
      GetApplicationsRequest.connectId = session.connectId;
      GetApplicationsRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "mediaslotservice", "getapplications", GetApplicationsRequest.nonce);
      GetApplicationsRequest.timestamp = Signature.GetZDateTime(utcNow);
      if (applicationType.HasValue)
      {
        GetApplicationsRequest.applicationType = applicationType.Value;
        GetApplicationsRequest.applicationTypeSpecified = true;
      }
      if (role.HasValue)
      {
        GetApplicationsRequest.role = role.Value;
        GetApplicationsRequest.roleSpecified = true;
      }
      if (name != null && name != " ")
        GetApplicationsRequest.name = name;
      GetApplicationsRequest.items = items;
      GetApplicationsRequest.itemsSpecified = true;
      GetApplicationsRequest.page = page;
      GetApplicationsRequest.pageSpecified = true;
      GetApplicationsResponse applications = this.publisherService.GetApplications(GetApplicationsRequest);
      if (applications == null)
      {
        total = 0;
        return (IList<applicationItem>) null;
      }
      else if (applications.applicationItems == null)
      {
        total = 0;
        return (IList<applicationItem>) null;
      }
      else
      {
        List<applicationItem> list = Enumerable.ToList<applicationItem>((IEnumerable<applicationItem>) applications.applicationItems);
        total = (int) applications.total;
        return (IList<applicationItem>) list;
      }
    }

    public applicationItem CreateApplication()
    {
      throw new NotImplementedException();
    }

    public applicationItem UpdateApplication()
    {
      throw new NotImplementedException();
    }

    public void DeleteApplication()
    {
      throw new NotImplementedException();
    }

    public mediaSlotItem GetMediaSlot(sessionType session, string mediaslotId)
    {
      GetMediaSlotRequest GetMediaSlotRequest = new GetMediaSlotRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetMediaSlotRequest.nonce = Signature.GetNonce();
      GetMediaSlotRequest.connectId = session.connectId;
      GetMediaSlotRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "getmediaslot", GetMediaSlotRequest.nonce);
      GetMediaSlotRequest.timestamp = Signature.GetZDateTime(utcNow);
      GetMediaSlotRequest.mediaSlotId = mediaslotId;
      GetMediaSlotResponse mediaSlot = this.publisherService.GetMediaSlot(GetMediaSlotRequest);
      if (mediaSlot == null)
        return (mediaSlotItem) null;
      else
        return mediaSlot.mediaSlotItem;
    }

    public IList<mediaSlotItem> GetMediaSlots(sessionType session, int? adspaceId, int? width, int? height, int? format, int items, int page, out int total)
    {
      GetMediaSlotsRequest GetMediaSlotsRequest = new GetMediaSlotsRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetMediaSlotsRequest.nonce = Signature.GetNonce();
      GetMediaSlotsRequest.connectId = session.connectId;
      GetMediaSlotsRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "getmediaslots", GetMediaSlotsRequest.nonce);
      GetMediaSlotsRequest.timestamp = Signature.GetZDateTime(utcNow);
      GetMediaSlotsRequest.items = items;
      GetMediaSlotsRequest.itemsSpecified = true;
      GetMediaSlotsRequest.page = page;
      GetMediaSlotsRequest.adspaceIdSpecified = true;
      if (adspaceId.HasValue)
      {
        GetMediaSlotsRequest.adspaceId = adspaceId.Value;
        GetMediaSlotsRequest.adspaceIdSpecified = true;
      }
      GetMediaSlotsRequest.size = new sizeType();
      if (height.HasValue)
      {
        GetMediaSlotsRequest.size.height = height.Value;
        GetMediaSlotsRequest.size.heightSpecified = true;
      }
      if (width.HasValue)
      {
        GetMediaSlotsRequest.size.width = width.Value;
        GetMediaSlotsRequest.size.widthSpecified = true;
      }
      if (format.HasValue)
      {
        GetMediaSlotsRequest.size.format = new subStringIdentifierType();
        GetMediaSlotsRequest.size.format.id = format.Value;
      }
      GetMediaSlotsResponse mediaSlots = this.publisherService.GetMediaSlots(GetMediaSlotsRequest);
      if (mediaSlots == null)
      {
        total = 0;
        return (IList<mediaSlotItem>) null;
      }
      else if (mediaSlots.mediaSlotItems == null)
      {
        total = 0;
        return (IList<mediaSlotItem>) null;
      }
      else
      {
        total = (int) mediaSlots.total;
        return (IList<mediaSlotItem>) Enumerable.ToList<mediaSlotItem>((IEnumerable<mediaSlotItem>) mediaSlots.mediaSlotItems);
      }
    }

    public mediaSlotItem CreateMediaSlot(sessionType session, mediaSlotItem mediaSlot)
    {
      CreateMediaSlotRequest CreateMediaSlotRequest = new CreateMediaSlotRequest();
      DateTime utcNow = DateTime.UtcNow;
      CreateMediaSlotRequest.nonce = Signature.GetNonce();
      CreateMediaSlotRequest.connectId = session.connectId;
      CreateMediaSlotRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "createmediaslot", CreateMediaSlotRequest.nonce);
      CreateMediaSlotRequest.timestamp = Signature.GetZDateTime(utcNow);
      CreateMediaSlotRequest.mediaSlotItem = mediaSlot;
      CreateMediaSlotResponse mediaSlot1 = this.publisherService.CreateMediaSlot(CreateMediaSlotRequest);
      if (mediaSlot1 == null)
        return (mediaSlotItem) null;
      else
        return mediaSlot1.mediaSlotItem;
    }

    public mediaSlotItem UpdateMediaSlot(sessionType session, mediaSlotItem mediaSlot)
    {
      UpdateMediaSlotRequest UpdateMediaSlotRequest = new UpdateMediaSlotRequest();
      DateTime utcNow = DateTime.UtcNow;
      UpdateMediaSlotRequest.nonce = Signature.GetNonce();
      UpdateMediaSlotRequest.connectId = session.connectId;
      UpdateMediaSlotRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "updatemediaslot", UpdateMediaSlotRequest.nonce);
      UpdateMediaSlotRequest.timestamp = Signature.GetZDateTime(utcNow);
      UpdateMediaSlotRequest.mediaSlotItem = mediaSlot;
      UpdateMediaSlotResponse mediaSlotResponse = this.publisherService.UpdateMediaSlot(UpdateMediaSlotRequest);
      if (mediaSlotResponse == null)
        return (mediaSlotItem) null;
      else
        return mediaSlotResponse.mediaSlotItem;
    }

    public int DeleteMediaSlot(sessionType session, string mediaSlotId)
    {
      DeleteMediaSlotRequest DeleteMediaSlotRequest = new DeleteMediaSlotRequest();
      DateTime utcNow = DateTime.UtcNow;
      DeleteMediaSlotRequest.nonce = Signature.GetNonce();
      DeleteMediaSlotRequest.connectId = session.connectId;
      DeleteMediaSlotRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "updatemediaslot", DeleteMediaSlotRequest.nonce);
      DeleteMediaSlotRequest.timestamp = Signature.GetZDateTime(utcNow);
      DeleteMediaSlotRequest.mediaSlotId = mediaSlotId;
      DeleteMediaSlotResponse mediaSlotResponse = this.publisherService.DeleteMediaSlot(DeleteMediaSlotRequest);
      if (mediaSlotResponse == null)
        return 0;
      else
        return mediaSlotResponse.count;
    }

    public settingItem GetSetting(sessionType session, string mediaSlotId, string applicationId, string key)
    {
      GetSettingResponse setting = this.publisherService.GetSetting(new GetSettingRequest()
      {
        connectId = session.connectId,
        mediaSlotId = mediaSlotId,
        applicationId = applicationId,
        key = key
      });
      if (setting == null)
        return (settingItem) null;
      else
        return setting.settingItem;
    }

    public IList<settingItem> GetSettings(sessionType session, string mediaSlotId, string applicationId, int items, int page, out int total)
    {
      GetSettingsResponse settings = this.publisherService.GetSettings(new GetSettingsRequest()
      {
        connectId = session.connectId,
        mediaSlotId = mediaSlotId,
        applicationId = applicationId,
        items = items,
        itemsSpecified = true,
        page = page,
        pageSpecified = true
      });
      if (settings == null)
      {
        total = 0;
        return (IList<settingItem>) null;
      }
      else if (settings.settingItems == null)
      {
        total = 0;
        return (IList<settingItem>) null;
      }
      else
      {
        total = (int) settings.total;
        return (IList<settingItem>) Enumerable.ToList<settingItem>((IEnumerable<settingItem>) settings.settingItems);
      }
    }

    public settingItem CreateSetting(sessionType session, settingItem setting)
    {
      CreateSettingRequest CreateSettingRequest = new CreateSettingRequest();
      DateTime utcNow = DateTime.UtcNow;
      CreateSettingRequest.nonce = Signature.GetNonce();
      CreateSettingRequest.connectId = session.connectId;
      CreateSettingRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "createsetting", CreateSettingRequest.nonce);
      CreateSettingRequest.timestamp = Signature.GetZDateTime(utcNow);
      CreateSettingRequest.settingItem = setting;
      CreateSettingResponse setting1 = this.publisherService.CreateSetting(CreateSettingRequest);
      if (setting1 == null)
        return (settingItem) null;
      else
        return setting1.settingItem;
    }

    public settingItem UpdateSetting(sessionType session, settingItem setting)
    {
      UpdateSettingRequest UpdateSettingRequest = new UpdateSettingRequest();
      DateTime utcNow = DateTime.UtcNow;
      UpdateSettingRequest.nonce = Signature.GetNonce();
      UpdateSettingRequest.connectId = session.connectId;
      UpdateSettingRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "updatesetting", UpdateSettingRequest.nonce);
      UpdateSettingRequest.timestamp = Signature.GetZDateTime(utcNow);
      UpdateSettingRequest.settingItem = setting;
      UpdateSettingResponse updateSettingResponse = this.publisherService.UpdateSetting(UpdateSettingRequest);
      if (updateSettingResponse == null)
        return (settingItem) null;
      else
        return updateSettingResponse.settingItem;
    }

    public int DeleteSetting(sessionType session, string mediaSlotId, string applicationId, string key)
    {
      DeleteSettingRequest DeleteSettingRequest = new DeleteSettingRequest();
      DateTime utcNow = DateTime.UtcNow;
      DeleteSettingRequest.nonce = Signature.GetNonce();
      DeleteSettingRequest.connectId = session.connectId;
      DeleteSettingRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "deletesetting", DeleteSettingRequest.nonce);
      DeleteSettingRequest.timestamp = Signature.GetZDateTime(utcNow);
      DeleteSettingRequest.key = key;
      DeleteSettingRequest.applicationId = applicationId;
      DeleteSettingResponse deleteSettingResponse = this.publisherService.DeleteSetting(DeleteSettingRequest);
      if (deleteSettingResponse == null)
        return 0;
      else
        return deleteSettingResponse.count;
    }

    public incentiveItem GetIncentive(sessionType session, string incentiveId, int? adspaceId)
    {
      GetIncentiveRequest GetIncentiveRequest = new GetIncentiveRequest();
      GetIncentiveRequest.connectId = session.connectId;
      GetIncentiveRequest.incentiveId = incentiveId;
      if (adspaceId.HasValue)
      {
        GetIncentiveRequest.adspaceId = adspaceId.Value;
        GetIncentiveRequest.adspaceIdSpecified = true;
      }
      GetIncentiveResponse incentive = this.publisherService.GetIncentive(GetIncentiveRequest);
      if (incentive == null)
        return (incentiveItem) null;
      else
        return incentive.incentiveItem;
    }

    public IList<incentiveItem> SearchIncentives(sessionType session, string region, incentiveTypeEnum? incentiveType, int? programId, int? adspaceId, int page, int items, out int total)
    {
      SearchIncentivesRequest SearchIncentivesRequest = new SearchIncentivesRequest();
      SearchIncentivesRequest.connectId = session.connectId;
      if (adspaceId.HasValue)
      {
        SearchIncentivesRequest.adspaceId = adspaceId.Value;
        SearchIncentivesRequest.adspaceIdSpecified = true;
      }
      if (programId.HasValue)
      {
        SearchIncentivesRequest.programId = programId.Value;
        SearchIncentivesRequest.programIdSpecified = true;
      }
      if (incentiveType.HasValue)
      {
        SearchIncentivesRequest.incentiveType = incentiveType.Value;
        SearchIncentivesRequest.incentiveTypeSpecified = true;
      }
      if (!string.IsNullOrEmpty(region))
        SearchIncentivesRequest.region = region;
      SearchIncentivesRequest.page = page;
      SearchIncentivesRequest.pageSpecified = true;
      SearchIncentivesRequest.items = items;
      SearchIncentivesRequest.itemsSpecified = true;
      SearchIncentivesResponse incentivesResponse = this.publisherService.SearchIncentives(SearchIncentivesRequest);
      if (incentivesResponse == null)
      {
        total = 0;
        return (IList<incentiveItem>) null;
      }
      else if (incentivesResponse.incentiveItems == null)
      {
        total = 0;
        return (IList<incentiveItem>) null;
      }
      else
      {
        total = (int) incentivesResponse.total;
        return (IList<incentiveItem>) Enumerable.ToList<incentiveItem>((IEnumerable<incentiveItem>) incentivesResponse.incentiveItems);
      }
    }

    public incentiveItem GetExclusiveIncentive(sessionType session, string incentiveId, int? adspaceId)
    {
      GetExclusiveIncentiveRequest GetExclusiveIncentiveRequest = new GetExclusiveIncentiveRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetExclusiveIncentiveRequest.nonce = Signature.GetNonce();
      GetExclusiveIncentiveRequest.connectId = session.connectId;
      GetExclusiveIncentiveRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "getexclusiveincentive", GetExclusiveIncentiveRequest.nonce);
      GetExclusiveIncentiveRequest.timestamp = Signature.GetZDateTime(utcNow);
      GetExclusiveIncentiveRequest.incentiveId = incentiveId;
      if (adspaceId.HasValue)
      {
        GetExclusiveIncentiveRequest.adspaceId = adspaceId.Value;
        GetExclusiveIncentiveRequest.adspaceIdSpecified = true;
      }
      GetExclusiveIncentiveResponse exclusiveIncentive = this.publisherService.GetExclusiveIncentive(GetExclusiveIncentiveRequest);
      if (exclusiveIncentive == null)
        return (incentiveItem) null;
      else
        return exclusiveIncentive.incentiveItem;
    }

    public IList<incentiveItem> GetExclusiveIncentives(sessionType session, string region, incentiveTypeEnum? incentiveType, int? programId, int? adspaceId, int page, int items, out int total)
    {
      SearchExclusiveIncentivesRequest SearchExclusiveIncentivesRequest = new SearchExclusiveIncentivesRequest();
      DateTime utcNow = DateTime.UtcNow;
      SearchExclusiveIncentivesRequest.nonce = Signature.GetNonce();
      SearchExclusiveIncentivesRequest.connectId = session.connectId;
      SearchExclusiveIncentivesRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "searchexclusiveincentives", SearchExclusiveIncentivesRequest.nonce);
      SearchExclusiveIncentivesRequest.timestamp = Signature.GetZDateTime(utcNow);
      if (adspaceId.HasValue)
      {
        SearchExclusiveIncentivesRequest.adspaceId = adspaceId.Value;
        SearchExclusiveIncentivesRequest.adspaceIdSpecified = true;
      }
      if (programId.HasValue)
      {
        SearchExclusiveIncentivesRequest.programId = programId.Value;
        SearchExclusiveIncentivesRequest.programIdSpecified = true;
      }
      if (incentiveType.HasValue)
      {
        SearchExclusiveIncentivesRequest.incentiveType = incentiveType.Value;
        SearchExclusiveIncentivesRequest.incentiveTypeSpecified = true;
      }
      if (!string.IsNullOrEmpty(region))
        SearchExclusiveIncentivesRequest.region = region;
      SearchExclusiveIncentivesRequest.page = page;
      SearchExclusiveIncentivesRequest.pageSpecified = true;
      SearchExclusiveIncentivesRequest.items = items;
      SearchExclusiveIncentivesRequest.itemsSpecified = true;
      SearchExclusiveIncentivesResponse incentivesResponse = this.publisherService.SearchExclusiveIncentives(SearchExclusiveIncentivesRequest);
      if (incentivesResponse == null)
      {
        total = 0;
        return (IList<incentiveItem>) null;
      }
      else if (incentivesResponse.incentiveItems == null)
      {
        total = 0;
        return (IList<incentiveItem>) null;
      }
      else
      {
        total = (int) incentivesResponse.total;
        return (IList<incentiveItem>) Enumerable.ToList<incentiveItem>((IEnumerable<incentiveItem>) incentivesResponse.incentiveItems);
      }
    }

    public IList<trackingCategoryItem> GetTrackingCategories(sessionType session, int programId, int adspaceId, int items, int page, out int total)
    {
      GetTrackingCategoriesRequest GetTrackingCategoriesRequest = new GetTrackingCategoriesRequest();
      DateTime utcNow = DateTime.UtcNow;
      GetTrackingCategoriesRequest.nonce = Signature.GetNonce();
      GetTrackingCategoriesRequest.connectId = session.connectId;
      GetTrackingCategoriesRequest.signature = Signature.SoapSignature(utcNow, session.secretKey, "publisherservice", "gettrackingcategories", GetTrackingCategoriesRequest.nonce);
      GetTrackingCategoriesRequest.timestamp = Signature.GetZDateTime(utcNow);
      GetTrackingCategoriesRequest.adspaceId = adspaceId;
      GetTrackingCategoriesRequest.programId = programId;
      GetTrackingCategoriesRequest.page = page;
      GetTrackingCategoriesRequest.pageSpecified = true;
      GetTrackingCategoriesRequest.items = items;
      GetTrackingCategoriesRequest.itemsSpecified = true;
      GetTrackingCategoriesResponse trackingCategories = this.publisherService.GetTrackingCategories(GetTrackingCategoriesRequest);
      if (trackingCategories == null)
      {
        total = 0;
        return (IList<trackingCategoryItem>) null;
      }
      else if (trackingCategories.trackingCategoryItem == null)
      {
        total = 0;
        return (IList<trackingCategoryItem>) null;
      }
      else
      {
        total = (int) trackingCategories.total;
        return (IList<trackingCategoryItem>) Enumerable.ToList<trackingCategoryItem>((IEnumerable<trackingCategoryItem>) trackingCategories.trackingCategoryItem);
      }
    }
  }
}
