using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
	public class Call :ICallCustomer
	{
		private string call_ID;
		private string cus_ID;
		private string audio;
		private string callLog;
		private string notes;

		public string Notes
		{
			get { return notes; }
			set { notes = value; }
		}
		public string CallLog
		{
			get { return callLog; }
			set { callLog = value; }
		}

		public string Audio
		{
			get { return audio; }
			set { audio = value; }
		}

		public string Cus_ID
		{
			get { return cus_ID; }
			set { cus_ID = value; }
		}

		public string Call_ID
		{
			get { return call_ID; }
			set { call_ID = value; }
		}

		internal ICallCustomer ICallCustomer
		{
			get => default;
			set
			{
			}
		}

		public Call(string call_ID, string cus_ID, string audio, string callLog, string notes)
		{
			this.call_ID = Call_ID;
			this.cus_ID = Cus_ID;
			this.audio = Audio;
			this.callLog = CallLog;
			this.notes = Notes;
		}

		public Call()
		{ }


		public void SaveCallInformation(string cus_ID, string call_ID, string audio, string callLog, string notes)
		{
			//The customer id has a specific format therefor it will be generated in C# then be committed to the Database
			new DataHandler().SaveLog(cus_ID, call_ID, audio, callLog, notes);
		}

		public void EmpCall(string empID,string callID)
		{
			new DataHandler().EmpCall(empID,callID);
		}

		public DataTable DisplayCallTable()
		{

			DataTable rData = new DataHandler().ViewCallInformation();

			return rData;
		}

	}
}
