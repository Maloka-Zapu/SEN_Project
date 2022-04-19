using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
    public class Employee:IEmployee
    {
		private string emp_ID;
		private string name;
		private string surname;
		private string title;
		private string password;

		public string Password
		{
			get { return password; }
			set { password = value; }
		}


		public string Title
		{
			get { return title; }
			set { title = value; }
		}

		public string Surname
		{
			get { return surname; }
			set { surname = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Emp_ID
		{
			get { return emp_ID; }
			set { emp_ID = value; }
		}

		public Employee(string emp_ID, string name, string surname, string title, string password)
		{
			this.emp_ID = Emp_ID;
			this.name = Name;
			this.surname = Surname;
			this.title = Title;
			this.password = Password;
		}
		public Employee()
		{}
		
		public int Login(string emp_ID, string password)
		{
			DataTable rData = new DataHandler().Login(emp_ID,password);
			return rData.Rows.Count;
			
		}

		public DataTable DisplayTable()
		{
			DataTable rData = new DataHandler().DataRead("Employee");
			return rData;
		}
		public void NewEmployee(string emp_ID, string name, string surname, string title, string password)
		{
			new DataHandler().AddEmployee(emp_ID,name,surname,title,password);
		}

		public void UpdateEmp(string emp_ID, string name, string surname, string title, string password)
		{
			new DataHandler().UpdateEmployee(emp_ID, name, surname, title, password);
		}

		public void RemoveEmp(string emp_ID)
		{
			new DataHandler().RemoveEmployee(emp_ID);
		}
		

	}


}
