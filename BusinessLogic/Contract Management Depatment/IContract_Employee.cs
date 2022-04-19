using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLogic
{
    public interface IContract_Employee
    {
       

        void CreateContract(string con_ID, string cus_ID, string upgradeOpt, string serviceLvl);
        void Employee_Contract(string empID, string conID);
        void ContractItems(DataTable ct);
        DataTable DisplayContractTable();
        void UpdateContract(string cus_ID, string upgradeOpt, string serviceLvl);
        void UpdateContractItems(string con_ID, int newQ1, int newQ2, int newQ3);
       




    }
}
