using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessLogic.Contract_Management_Depatment
{
    public class Contract_Management:IContract_Employee,ICustomerSearch,IProduct_Update
    {
        public void CreateContract(string con_ID, string cus_ID, string upgradeOpt, string serviceLvl)
        {
            new DataHandler().NewContract(con_ID, cus_ID, upgradeOpt, serviceLvl);
        }
        public DataTable SearchCus(string cus_ID)
        {
            DataTable rData = new DataHandler().DataRead("Customer");
            return rData;
        }

        public void UpdateProd(int unitsAvailable1, int unitsAvailable2, int unitsAvailable3)
        {
            new DataHandler().UpdateUnits("1","2","3",unitsAvailable1, unitsAvailable2, unitsAvailable3);
        }

        public void Employee_Contract(string empID, string conID)
        {
            new DataHandler().EmpCon(empID, conID);
        }

        public void ContractItems(DataTable ct)
        {
            new DataHandler().ConItem(ct);
        }

        public DataTable DisplayProductTable()
        {
            DataTable rData = new DataHandler().DataRead("Product");
            return rData;
        }
        public DataTable DisplayContractTable()
        {

            DataTable rData = new DataHandler().ViewContractInformation();

            return rData;
        }

        public DataTable DisplayCustomerTable()
        {

            DataTable rData = new DataHandler().DataRead("Customer");

            return rData;
        }
        public void UpdateContract(string cus_ID, string upgradeOpt, string serviceLvl)
        {
            new DataHandler().UpdateContract(cus_ID,upgradeOpt,serviceLvl);
        }
        public void UpdateContractItems(string con_ID, int newQ1, int newQ2, int newQ3)
        {
            new DataHandler().UpdateConItem(con_ID, "1", "2", "3", newQ1, newQ2, newQ3);
        }
    }
}
