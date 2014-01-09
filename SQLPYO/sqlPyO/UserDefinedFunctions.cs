// Type: UserDefinedFunctions
// Assembly: ZanoxV2, Version=1.0.4955.28682, Culture=neutral, PublicKeyToken=d1e62d2627a2f3e0
// MVID: 35AD163E-3C46-45E7-B3AA-50397E6E2193
// Assembly location: C:\Users\daniel.lopez\Desktop\Zanox.API\ZanoxV2.dll

using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using sqlPyO;
using sqlPyO.Auth;
using sqlPyO.Publisher;
using sqlPyO.belboon;

public class UserDefinedFunctions
{
	[SqlFunction(DataAccess = DataAccessKind.Read, FillRowMethodName = "GetZanoxSales_FillRow", TableDefinition = "trackingDate nvarchar(4000), trackingCategory nvarchar(4000), program nvarchar(4000), amount nvarchar(4000),commission nvarchar(4000), currency nvarchar(4000), adSpace nvarchar(4000), reviewState nvarchar(4000), clickDate nvarchar(4000), modifiedDate nvarchar(4000)")]
	public static IEnumerable GetZanoxSales(DateTime Fecha)
	{
		ArrayList arrayList1 = new ArrayList();
		try
		{
			PublisherAPI publisherApi = new PublisherAPI();
			sessionType session = new sessionType()
			{
				connectId = "375C4284CB3A326CBEAD",
				secretKey = "1a1c9584c3e447+0A89472b0bEaa53/726c08c4b"
			};
			int total = 0;
			IList<saleItem> sales = publisherApi.GetSales(session, Fecha, dateTypeEnum.trackingDate, new int?(), new int?(), new reviewStateEnum?(), 50, 0, out total);
			if (sales != null)
			{
				foreach (saleItem saleItem in (IEnumerable<saleItem>)sales)
				{
					ArrayList arrayList2 = arrayList1;
					SqlString trackingDate = (SqlString)saleItem.trackingDate.ToString();
					SqlString trackingCategory = (SqlString)(saleItem.trackingCategory != null ? saleItem.trackingCategory.Value : "");
					SqlString program = (SqlString)saleItem.program.Value;
					double num = saleItem.amount;
					SqlString amount = (SqlString)num.ToString();
					num = saleItem.commission;
					SqlString commission = (SqlString)num.ToString();
					SqlString currency = (SqlString)saleItem.currency;
					SqlString adSpace = (SqlString)saleItem.adspace.Value;
					SqlString reviewState = (SqlString)((object)saleItem.reviewState).ToString();
					SqlString clickDate = (SqlString)saleItem.clickDate.ToString();
					SqlString modifiedDate = (SqlString)saleItem.modifiedDate.ToString();
					UserDefinedFunctions.ZanoxResults zanoxResults = new UserDefinedFunctions.ZanoxResults(trackingDate, trackingCategory, program, amount, commission, currency, adSpace, reviewState, clickDate, modifiedDate);
					arrayList2.Add((object)zanoxResults);
				}
			}
			return (IEnumerable)arrayList1;
		}
		catch (Exception ex)
		{
			return (IEnumerable)new ArrayList()
      {
        (object) new UserDefinedFunctions.ZanoxResults((SqlString) DateTime.Now.ToString(), (SqlString) ex.Message, (SqlString) ex.InnerException.Message, (SqlString) ex.Source, (SqlString) ex.StackTrace, (SqlString) "", (SqlString) "", (SqlString) "", (SqlString) "", (SqlString) "")
      };
		}
	}

	public static void GetZanoxSales_FillRow(object zanoxResultObj, out SqlString trackingDate, out SqlString trackingCategory, out SqlString program, out SqlString amount, out SqlString commission, out SqlString currency, out SqlString adSpace, out SqlString reviewState, out SqlString clickDate, out SqlString modifiedDate)
	{
		UserDefinedFunctions.ZanoxResults zanoxResults = (UserDefinedFunctions.ZanoxResults)zanoxResultObj;
		trackingDate = zanoxResults.trackingDate;
		trackingCategory = zanoxResults.trackingCategory;
		program = zanoxResults.program;
		amount = zanoxResults.amount;
		commission = zanoxResults.commission;
		currency = zanoxResults.currency;
		adSpace = zanoxResults.adSpace;
		reviewState = zanoxResults.reviewState;
		clickDate = zanoxResults.clickDate;
		modifiedDate = zanoxResults.modifiedDate;
	}

	private class ZanoxResults
	{
		public SqlString trackingDate;
		public SqlString trackingCategory;
		public SqlString program;
		public SqlString amount;
		public SqlString commission;
		public SqlString currency;
		public SqlString adSpace;
		public SqlString reviewState;
		public SqlString clickDate;
		public SqlString modifiedDate;

		public ZanoxResults(SqlString trackingDate, SqlString trackingCategory, SqlString program, SqlString amount, SqlString commission, SqlString currency, SqlString adSpace, SqlString reviewState, SqlString clickDate, SqlString modifiedDate)
		{
			this.trackingDate = trackingDate;
			this.trackingCategory = trackingCategory;
			this.program = program;
			this.amount = amount;
			this.commission = commission;
			this.currency = currency;
			this.adSpace = adSpace;
			this.reviewState = reviewState;
			this.clickDate = clickDate;
			this.modifiedDate = modifiedDate;
		}
	}
	private class BelboonResults
	{
		public SqlString eventdate;
		public SqlString programmid;
		public SqlString programmname;
		public SqlString eventcurrency;
		public SqlString clicks;
		public SqlString clickcommission;
		public SqlString views;
		public SqlString viewcommission;
		public SqlString leads;
		public SqlString leadcommission;
		public SqlString sales;
		public SqlString salecommission;
		public SqlString totalcommission;
		public SqlString clickthroughrate;
		public SqlString leadconversionrate;
		public SqlString saleconversionrate;

		public BelboonResults(
			SqlString eventdate,
			SqlString programmid,
		SqlString programmname,
		  SqlString eventcurrency,
		 SqlString clicks,
		 SqlString clickcommission,
		 SqlString views,
		 SqlString viewcommission,
		 SqlString leads,
		 SqlString leadcommission,
		 SqlString sales,
		 SqlString salecommission,
		 SqlString totalcommission,
		SqlString clickthroughrate,
		 SqlString leadconversionrate,
		 SqlString saleconversionrate)
		{
			this.eventdate = eventdate;
			this.programmid = programmid;
			this.programmname = programmname;
			this.eventcurrency = eventcurrency;
			this.clicks = clicks;
			this.clickcommission = clickcommission;
			this.views = views;
			this.viewcommission = viewcommission;
			this.leads = leads;
			this.leadcommission = leadcommission;
			this.sales = sales;
			this.salecommission = salecommission;
			this.totalcommission = totalcommission;
			this.leadconversionrate = leadconversionrate;
			this.clickthroughrate = clickthroughrate;
			this.saleconversionrate = saleconversionrate;
		}

	}

	[SqlFunction(DataAccess = DataAccessKind.Read, FillRowMethodName = "GetBelboonSales_FillRow", TableDefinition = "eventdate nvarchar(4000), programmid nvarchar(4000),programmname nvarchar(4000), eventcurrency nvarchar(4000), clicks nvarchar(4000), clickcommission nvarchar(4000),views nvarchar(4000), viewcommission nvarchar(4000), leads nvarchar(4000), leadcommission nvarchar(4000), sales nvarchar(4000), salecommission nvarchar(4000), totalcommission nvarchar(4000),clickthroughrate nvarchar(4000),leadconversionrate nvarchar(4000),saleconversionrate nvarchar(4000) ")]
	public static IEnumerable GetBelboonSales(int dias)
	{
		ArrayList arrayList1 = new ArrayList();
		BelboonHandler ws = new BelboonHandler();
		try
		{

			BelboonResults bResults;
			HandlerResultSoap result;
			ArrayList arrayList2 = arrayList1;
			result = ws.getStatisticsDaily("EUR", 587450, true, false, false, false, false, null, dias, 0);
			System.Xml.XmlNode[] nodos = (System.Xml.XmlNode[])result.handler;

			foreach (var item in nodos)
			{
				if (item.Name == "statistics")
				{
					foreach (var estadisticaDia in item.ChildNodes)
					{
						System.Xml.XmlNode eD = estadisticaDia as System.Xml.XmlNode;

						bResults = new BelboonResults(eD.ChildNodes[0].ChildNodes[1].InnerText, eD.ChildNodes[1].ChildNodes[1].InnerText, eD.ChildNodes[2].ChildNodes[1].InnerText, eD.ChildNodes[3].ChildNodes[1].InnerText, eD.ChildNodes[4].ChildNodes[1].InnerText,
							eD.ChildNodes[5].ChildNodes[1].InnerText, eD.ChildNodes[6].ChildNodes[1].InnerText, eD.ChildNodes[7].ChildNodes[1].InnerText, eD.ChildNodes[8].ChildNodes[1].InnerText, eD.ChildNodes[9].ChildNodes[1].InnerText, eD.ChildNodes[10].ChildNodes[1].InnerText,
							eD.ChildNodes[11].ChildNodes[1].InnerText, eD.ChildNodes[12].ChildNodes[1].InnerText, eD.ChildNodes[13].ChildNodes[1].InnerText, eD.ChildNodes[14].ChildNodes[1].InnerText, eD.ChildNodes[15].ChildNodes[1].InnerText);

						arrayList2.Add((object)bResults);
					}
				}
			}
			return arrayList1;
		}
		catch (Exception ex)
		{
			return (IEnumerable)new ArrayList()
				{
					(object) new UserDefinedFunctions.BelboonResults((SqlString) DateTime.Now.ToString(), (SqlString) ex.Message, (SqlString) ex.InnerException.Message, (SqlString) ex.Source, (SqlString) ex.StackTrace, (SqlString) "", (SqlString) "", (SqlString) "", (SqlString) "", (SqlString) "",(SqlString) "",(SqlString) "",(SqlString) "",(SqlString) "",(SqlString) "",(SqlString) "")
				};
		}


	}

	public static void GetBelboonSales_FillRow(object belboonResultObj, out SqlString eventdate, out SqlString programmid, out SqlString programmname, out SqlString eventcurrency, out SqlString clicks, out SqlString clickcommission, out SqlString views, out SqlString viewcommission, out SqlString leads, out SqlString leadcommission, out SqlString sales, out SqlString salecommission, out SqlString totalcommission, out SqlString clickthroughrate, out SqlString leadconversionrate, out SqlString saleconversionrate)
	{
		UserDefinedFunctions.BelboonResults belboonResults = (UserDefinedFunctions.BelboonResults)belboonResultObj;
		eventdate = belboonResults.eventdate;
		programmid = belboonResults.programmid;
		programmname = belboonResults.programmname;
		eventcurrency = belboonResults.eventcurrency;
		clicks = belboonResults.clicks;
		clickcommission = belboonResults.clickcommission;
		views = belboonResults.views;
		viewcommission = belboonResults.viewcommission;
		leads = belboonResults.leads;
		leadcommission = belboonResults.leadcommission;
		sales = belboonResults.sales;
		salecommission = belboonResults.salecommission;
		totalcommission = belboonResults.totalcommission;
		leadconversionrate = belboonResults.leadconversionrate;
		clickthroughrate = belboonResults.clickthroughrate;
		saleconversionrate = belboonResults.saleconversionrate;
	}
}