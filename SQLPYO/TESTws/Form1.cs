using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.Data.SqlTypes;
using System.Collections;
using TESTws.belboon;

namespace TESTws
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{


			ArrayList arrayList1 = new ArrayList();
			BelboonHandler ws = new BelboonHandler();
			try
			{

				BelboonResults bResults;
				HandlerResultSoap result;
				ArrayList arrayList2 = arrayList1;
				result = ws.getStatisticsDaily("EUR", 587450, true, false, false, false, false, null, 1, 0);
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
				//return arrayList1;
			}
			catch (Exception ex)
			{
				/*return (IEnumerable)new ArrayList()
				{
					(object) new BelboonResults((SqlString) DateTime.Now.ToString(), (SqlString) ex.Message, (SqlString) ex.InnerException.Message, (SqlString) ex.Source, (SqlString) ex.StackTrace, (SqlString) "", (SqlString) "", (SqlString) "", (SqlString) "", (SqlString) "",(SqlString) "",(SqlString) "",(SqlString) "",(SqlString) "")
				};*/
			}

		}
	}

	public class BelboonResults
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

		public BelboonResults(SqlString eventdate,
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
}


