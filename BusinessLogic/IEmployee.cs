using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLogic
{
    interface IEmployee
    {
		
		void NewEmployee(string emp_ID, string name, string surname, string title, string password);
		DataTable DisplayTable();
		int Login(string emp_ID, string password);
		void UpdateEmp(string emp_ID, string name, string surname, string title, string password);
		


	}

}
