using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
	public class Product: IProduct_Update
	{
		private string prod_ID;
		private string suiteName;
		private string description;
		private int unitsAvailable;

		public int UnitsAvailable
		{
			get { return unitsAvailable; }
			set { unitsAvailable = value; }
		}


		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		public string SuiteName
		{
			get { return suiteName; }
			set { suiteName = value; }
		}

		public string Prod_ID
		{
			get { return prod_ID; }
			set { prod_ID = value; }
		}

		public IProduct_Update IProduct_Update
		{
			get => default;
			set
			{
			}
		}

		public Product(string prod_ID, string suiteName, string description, int unitsAvailable)
		{
			this.prod_ID = Prod_ID;
			this.suiteName = SuiteName;
			this.description = Description;
			this.unitsAvailable = UnitsAvailable;
		}
		public Product()
		{ }

		//public List<Product> DisplayProducts()
		//{
		//	DataHandler dh = new DataHandler();
		//	List<Product> products = new List<Product>();

		//	DataSet rData = dh.ReadData("Product");
		//	foreach (DataRow item in rData.Tables["Product"].Rows)
		//	{
		//		products.Add(
		//		new Product(
		//			item["ProdID"].ToString(),
		//			item["SuiteName"].ToString(),
		//			item["Description"].ToString(),
		//			int.Parse(item["UnitsAvailable"].ToString())
		//			));

		//	}
		//	return products;
		//}

		public void NewProduct(string prod_ID, string suiteName, string description, int unitsAvailable)
		{
			new DataHandler().AddProduct(prod_ID,suiteName,description,unitsAvailable);
		}

		public void UpdateProd( int unitsAvailable1, int unitsAvailable2,int unitsAvailable3)
		{
			new DataHandler().UpdateUnits("1","2","3", unitsAvailable1,unitsAvailable2,unitsAvailable3);
		}
		public DataTable DisplayProductTable()
		{
			DataTable rData = new DataHandler().DataRead("Product");
			return rData;
		}

	}
}
