using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLogic.Technical_Support_Management
{
    public interface ITechnicians
    {
        DataTable DisplayTechnicians();
        void Emp_Job(string empID, string jobID);
        void AssignJob(string job_ID, string emp_ID, string jobType, string status, string description, string date);
        void UpdateJobStatus(string job_ID, string status, string dateUpdate);
        
        DataTable DisplayJobs();
        

    }
}
