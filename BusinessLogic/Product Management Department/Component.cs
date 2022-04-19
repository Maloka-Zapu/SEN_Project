using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using BusinessLogic.Product_Management_Department;

namespace BusinessLogic
{
    public class Component: IComponents
    {
		private string serialNo;
		private string type;
		private string name;
		private int quantity;

		public int Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}


		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		public string SerialNo
		{
			get { return serialNo; }
			set { serialNo = value; }
		}

		public Component(string serialNo, string type, string name, int quantity)
		{
			this.serialNo = SerialNo;
			this.type = Type;
			this.name = Name;
			this.quantity = Quantity;
		}

		public Component()
		{}

		//public List<Component> DisplayProducts()
		//{
		//	DataHandler dh = new DataHandler();
		//	List<Component> components = new List<Component>();

		//	DataSet rData = dh.ReadData("Component");
		//	foreach (DataRow item in rData.Tables["Component"].Rows)
		//	{
		//		components.Add(
		//		new Component(
		//			item["SerialNo"].ToString(),
		//			item["Type"].ToString(),
		//			item["Name"].ToString(),
		//			int.Parse(item["Quantity"].ToString())
		//			));

		//	}
		//	return components;
		//}

	

		public DataTable DisplayComponentTable(string ID)
		{
			DataTable rData = new DataHandler().LoadComponent(ID);
			return rData;
		}

		public void UpdateComponents(int q1, int q2, int q3, int q4, int q5, int q6, int q7, int q8, int q9)
		{
			new DataHandler().UpdateComponentQuantity("001","002","003","004","005","006","007","008","009",q1,q2,q3,q4,q5,q6,q7,q8,q9);
		}
		public void Emp_Com(string empID, string prodID, string issueID) 
		{
			new DataHandler().EmpCom(empID,prodID,issueID);
		}
		public void IssueComponents(DataTable IssueC)
		{
			new DataHandler().ComItem(IssueC);
		}
		public void OrderC(int q1, int q2, int q3, int q4, int q5, int q6, int q7, int q8, int q9)
		{
			new DataHandler().IncreaseComponentQuantity("001", "002", "003", "004", "005", "006", "007", "008", "009", q1, q2, q3, q4, q5, q6, q7, q8, q9);
		}

	}
}
