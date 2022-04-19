using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLogic
{
    public interface IProduct_Update
    {
       

        void UpdateProd(int unitsAvailable1, int unitsAvailable2, int unitsAvailable3);
        DataTable DisplayProductTable();
       

    }
}
