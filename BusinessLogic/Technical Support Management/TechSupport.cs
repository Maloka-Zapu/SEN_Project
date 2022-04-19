using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using BusinessLogic.Technical_Support_Management;

namespace BusinessLogic
{
    public class TechSupport:ITechnicians
    {
		private string job_ID;
		private string emp_ID;
		private string jobType;
		private string status;
		private string description;

		public string Description
		{
			get { return description; }
			set { description = value; }
		}


		public string Status
		{
			get { return status; }
			set { status = value; }
		}

		public string JobType
		{
			get { return jobType; }
			set { jobType = value; }
		}

		public string Emp_ID
		{
			get { return emp_ID; }
			set { emp_ID = value; }
		}

		public string Job_ID
		{
			get { return job_ID; }
			set { job_ID = value; }
		}

		

		public TechSupport(string job_ID, string emp_ID, string jobType, string status)
		{
			this.job_ID = Job_ID;
			this.emp_ID = Emp_ID;
			this.jobType = JobType;
			this.status = Status;
		}

		public TechSupport()
		{}

		//public List<TechSupport> DisplayJobs()
		//{
		//	DataHandler dh = new DataHandler();
		//	List<TechSupport> jobs = new List<TechSupport>();

		//	DataSet rData = dh.ReadData("TechSupport");
		//	foreach (DataRow item in rData.Tables["TechSupport"].Rows)
		//	{
		//		jobs.Add(
		//		new TechSupport(
		//			item["JobID"].ToString(),
		//			item["EmpID"].ToString(),
		//			item["JobType"].ToString(),
		//			item["Status"].ToString()
		//			));

		//	}
		//	return jobs;
		//}

		public void AssignJob(string job_ID, string emp_ID, string jobType, string status, string description, string date)
		{
			new DataHandler().AddJob(job_ID,emp_ID,jobType,status, description,date);
		}

		//Update(For changing the job status)
		public void UpdateJobStatus(string job_ID, string status, string dateUpdate)
		{
			new DataHandler().UpdateJob(job_ID, status, dateUpdate);
		}

		public DataTable DisplayTechnicians()
		{
			DataTable rData = new DataHandler().SearchTechnician();
			return rData;
		}

		public void Emp_Job(string empID,string jobID)
		{
			new DataHandler().EmpJob(empID,jobID);
		}
		public DataTable DisplayJobs()
		{
			DataTable rData = new DataHandler().ViewJobs();
			return rData;
		}

		//Will not be deleting from the database for the sake of keeping record/statistics

	}
}
