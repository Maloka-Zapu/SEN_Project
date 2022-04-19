using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLogic
{
    interface ICustomer
    {
	
		void NewCustomer(string cus_ID, string name, string surname, string address, string cellNo);
		DataTable DisplayCustomerTable();
		DataTable SearchCus(string cus_ID);
		void UpdateCustomer(string cus_ID, string name, string surname, string address, string cellNo);
		




	}
}
