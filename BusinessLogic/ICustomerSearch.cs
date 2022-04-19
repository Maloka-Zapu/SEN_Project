using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLogic
{
    public interface ICustomerSearch
    {
 
        DataTable SearchCus(string cus_ID);
        DataTable DisplayCustomerTable();
        
    }
        
}
