using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace BusinessLogic.Technical_Support_Management
{
    public class Technical_Management: ITechnicians
    {
        public DataTable DisplayTechnicians()
        {
            DataTable rData = new DataHandler().SearchTechnician();
            return rData;
        }
        public void Emp_Job(string empID, string jobID)
        {
            new DataHandler().EmpJob(empID, jobID);
        }

        public void AssignJob(string job_ID, string emp_ID, string jobType, string status, string description, string date)
        {
            new DataHandler().AddJob(job_ID, emp_ID, jobType, status, description, date);
        }

        public void RequestAssistence(string job_ID, string emp_ID, string jobType, string status, string description, string date)
        {
            new DataHandler().RequestTech(job_ID, emp_ID, jobType, status, description, date);
        }

        public DataTable DisplayJobs()
        {
            DataTable rData = new DataHandler().ViewJobs();
            return rData;
        }

        public void UpdateJobStatus(string job_ID, string status, string dateUpdate)
        {
            new DataHandler().UpdateJob(job_ID, status,dateUpdate);
        }
    }
}
