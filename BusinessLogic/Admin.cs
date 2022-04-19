using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
    public class Admin: ICustomer,IEmployee
    {
		//EMPLOYEE
		public int Login(string emp_ID, string password)
		{
			DataTable rData = new DataHandler().Login( emp_ID, password);
			return rData.Rows.Count;

		}
		public void NewEmployee(string emp_ID, string name, string surname, string title, string password)
		{
			new DataHandler().AddEmployee(emp_ID, name, surname, title, password);
		}
		public DataTable DisplayTable()
		{

			List<Employee> employees = new List<Employee>();

			DataTable rData = new DataHandler().DataRead("Employee");

			return rData;
		}
		public void UpdateEmp(string emp_ID, string name, string surname, string title, string password)
		{
			new DataHandler().UpdateEmployee(emp_ID, name, surname, title, password);
		}


		//CUSTOMER
		public DataTable DisplayCustomerTable()
		{

			List<Customer> customers = new List<Customer>();

			DataTable rData = new DataHandler().DataRead("Customer");

			return rData;
		}
		public void NewCustomer(string cus_ID, string name, string surname, string address, string cellNo)
		{
			//The customer id has a specific format therefor it will be generated in C# then be committed to the Database
			new DataHandler().AddCustomer(cus_ID, name, surname, address, cellNo);
		}
		public DataTable SearchCus(string cus_ID)
		{

			DataTable rData = new DataHandler().DataRead("Customer");

			return rData;
		}
		public void UpdateCustomer(string cus_ID, string name, string surname, string address, string cellNo)
		{
			new DataHandler().UpdateCustomer(cus_ID, name, surname, address, cellNo);
		}





	}
}
