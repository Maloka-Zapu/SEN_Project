using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
    public class CallCentreManagememnt:ICallCustomer,ICustomerSearch
    {
        public DataTable SearchCus(string cus_ID)
        {

            DataTable rData = new DataHandler().DataRead("Customer");

            return rData;
        }

        public void SaveCallInformation(string cus_ID, string call_ID, string audio, string callLog, string notes)
        {
           new DataHandler().SaveLog(cus_ID, call_ID, audio, callLog, notes);
        }
        public void EmpCall(string empID, string callID)
        {
            new DataHandler().EmpCall(empID, callID);
        }

        public DataTable DisplayCallTable()
        {

            DataTable rData = new DataHandler().ViewCallInformation();

            return rData;
        }
        public DataTable DisplayCustomerTable()
        {

            DataTable rData = new DataHandler().DataRead("Customer");

            return rData;
        }
    }
}
