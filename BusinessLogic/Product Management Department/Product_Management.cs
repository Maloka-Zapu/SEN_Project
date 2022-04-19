using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using BusinessLogic.Technical_Support_Management;

namespace BusinessLogic.Product_Management_Department
{
    public class Product_Management:IProduct_Update,IComponents, ITechnicians
    {
        public DataTable DisplayProductTable()
        {
            DataTable rData = new DataHandler().DataRead("Product");
            return rData;
        }
        public void UpdateProd(int unitsAvailable1, int unitsAvailable2, int unitsAvailable3)
        {
            new DataHandler().UpdateUnits("1", "2", "3", unitsAvailable1, unitsAvailable2, unitsAvailable3);
        }
        public DataTable DisplayComponentTable(string ID)
        {
            DataTable rData = new DataHandler().LoadComponent(ID);
            return rData;
        }
        public DataTable DisplayTechnicians()
        {
            DataTable rData = new DataHandler().SearchTechnician();
            return rData;
        }

        public void UpdateComponents(int q1, int q2, int q3, int q4, int q5, int q6, int q7, int q8, int q9)
        {
            new DataHandler().UpdateComponentQuantity("001", "002", "003", "004", "005", "006", "007", "008", "009", q1, q2, q3, q4, q5, q6, q7, q8, q9);
        }
        public void Emp_Com(string empID, string prodID, string issueID)
        {
            new DataHandler().EmpCom(empID, prodID, issueID);
        }
        public void IssueComponents(DataTable IssueC)
        {
            new DataHandler().ComItem(IssueC);
        }
        public void OrderC(int q1, int q2, int q3, int q4, int q5, int q6, int q7, int q8, int q9)
        {
            new DataHandler().IncreaseComponentQuantity("001", "002", "003", "004", "005", "006", "007", "008", "009", q1, q2, q3, q4, q5, q6, q7, q8, q9);
        }


        public void Emp_Job(string empID, string jobID)
        {
            new DataHandler().EmpJob(empID, jobID);
        }
        public void AssignJob(string job_ID, string emp_ID, string jobType, string status, string description, string date)
        {
            new DataHandler().AddJob(job_ID, emp_ID, jobType, status, description, date);
        }
        public DataTable DisplayJobs()
        {
            DataTable rData = new DataHandler().ViewJobs();
            return rData;
        }
        public void UpdateJobStatus(string job_ID, string status,string dateUpdate)
        {
            new DataHandler().UpdateJob(job_ID, status, dateUpdate);
        }
    }
}
