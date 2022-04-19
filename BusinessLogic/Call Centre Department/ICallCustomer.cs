using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace BusinessLogic
{
    interface ICallCustomer
    {
  

        void SaveCallInformation(string cus_ID, string call_ID, string audio, string callLog, string notes);
        void EmpCall(string empID, string callID);
        DataTable DisplayCallTable();
       

    }
}
