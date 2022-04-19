using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
	public class Contract: IContract_Employee
	{
		private string con_ID;
		private string cus_ID;
		private string upgradeOpt;
		private string serviceLvl;

		public string ServiceLvl
		{
			get { return serviceLvl; }
			set { serviceLvl = value; }
		}

		public string UpgradeOpt
		{
			get { return upgradeOpt; }
			set { upgradeOpt = value; }
		}

		public string Cus_ID
		{
			get { return cus_ID; }
			set { cus_ID = value; }
		}

		public string Con_ID
		{
			get { return con_ID; }
			set { con_ID = value; }
		}

		public IContract_Employee IContract_Employee
		{
			get => default;
			set
			{
			}
		}

		public Contract(string con_ID, string cus_ID, string upgradeOpt, string serviceLvl)
		{
			this.con_ID = Con_ID;
			this.cus_ID = Cus_ID;
			this.upgradeOpt = UpgradeOpt;
			this.serviceLvl = ServiceLvl;
		}
		public Contract()
		{ }


		public void CreateContract(string con_ID, string cus_ID, string upgradeOpt, string serviceLvl)
		{
			new DataHandler().NewContract(con_ID,cus_ID, upgradeOpt, serviceLvl);
		}

		public void UpdateCont(string con_ID, string upgradeOpt, string serviceLvl)
		{
			new DataHandler().UpdateContract(con_ID,upgradeOpt,serviceLvl);
		}

		public void Employee_Contract(string empID, string conID)
		{
			new DataHandler().EmpCon(empID,conID);
		}

		public void ContractItems(DataTable ct)
		{
			new DataHandler().ConItem(ct);
		}

		public DataTable DisplayContractTable()
		{

			DataTable rData = new DataHandler().ViewContractInformation();

			return rData;
		}
		public void UpdateContract(string cus_ID, string upgradeOpt, string serviceLvl)
		{
			new DataHandler().UpdateContract(cus_ID, upgradeOpt, serviceLvl);
		}
		public void UpdateContractItems(string con_ID, int newQ1, int newQ2,int newQ3)
		{
			new DataHandler().UpdateConItem(con_ID,"1","2","3",newQ1,newQ2,newQ3);
		}
	}
}
