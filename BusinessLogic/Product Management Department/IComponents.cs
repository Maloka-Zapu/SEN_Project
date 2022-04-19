using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLogic.Product_Management_Department
{
	public interface IComponents
	{
		//void UpdateComponent(string serialNo, int quantity);
		DataTable DisplayComponentTable(string ID);
		void UpdateComponents(int q1, int q2, int q3, int q4, int q5, int q6, int q7, int q8, int q9);
		void Emp_Com(string empID, string prodID, string issueID);
		void IssueComponents(DataTable IssueC);
		void OrderC(int q1, int q2, int q3, int q4, int q5, int q6, int q7, int q8, int q9);
		


	}
}
