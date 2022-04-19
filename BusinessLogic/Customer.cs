using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;


namespace BusinessLogic
{
    public class Customer: ICustomer,ICustomerSearch
    {
		private string cus_ID;
		private string surname;
		private string name;
		private string address;
		private string cellNo;

		public string CellNo
		{
			get { return cellNo; }
			set { cellNo = value; }
		}

		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Surname
		{
			get { return surname; }
			set { surname = value; }
		}

		public string Cus_ID
		{
			get { return cus_ID; }
			set { cus_ID = value; }
		}

		public ICustomerSearch ICustomerSearch
		{
			get => default;
			set
			{
			}
		}

		public Customer(string cus_ID, string name, string surname, string address, string cellNo)
		{
			this.cus_ID = Cus_ID;
			this.name = Name;
			this.surname = Surname;
			this.address = Address;
			this.cellNo = CellNo;
		}

		public Customer()
		{}

		
		public DataTable DisplayCustomerTable()
		{

			DataTable rData = new DataHandler().DataRead("Customer");

			return rData;
		}

		public void NewCustomer(string cus_ID, string name, string surname, string address, string cellNo)
		{
			//The customer id has a specific format therefor it will be generated in C# then be committed to the Database
			new DataHandler().AddCustomer(cus_ID, name, surname, address, cellNo);
		}

		public void UpdateCus(string cus_ID, string name, string surname, string address, string cellNo)
		{
			new DataHandler().UpdateCustomer(cus_ID, name, surname, address, cellNo);
		}
		public DataTable SearchCus(string cus_ID)
		{

			DataTable rData = new DataHandler().DataRead("Customer");

			return rData;
		}
		public void RemoveCus(string cus_ID)
		{
			new DataHandler().RemoveCustomer(cus_ID);
		}
		public void UpdateCustomer(string cus_ID, string name, string surname, string address, string cellNo)
		{
			new DataHandler().UpdateCustomer(cus_ID,name,surname,address,cellNo);
		}


	}
}
