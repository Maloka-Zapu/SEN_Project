using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataHandler
    {
        //Data Source=LAPTOP-KBSFA3PE;Initial Catalog=SmartHomeSystem;Integrated Security=True
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        public DataHandler()
        {
            connection.DataSource = @"LAPTOP-KBSFA3PE";
            connection.InitialCatalog = "SmartHomeSystem";
            connection.IntegratedSecurity = true;
        }

        //Read(Doesnt work right but, too scraed to delete it.)
        public DataSet ReadData(string tableName)
        {
            DataSet rData = new DataSet();
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                string qry = string.Format("SELECT * FROM {0}", tableName);


                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                    adapter.FillSchema(rData, SchemaType.Source, tableName);
                    adapter.Fill(rData, tableName);
                }
                catch (Exception)
                {

                    throw;
                }


                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }


            }
            return rData;

        }

        //Login
        public DataTable Login(string empID, string password)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                string qry = string.Format("SELECT * FROM Employee WHERE EmpID='{0}' and Pass='{1}'", empID.ToString().Trim(), password.ToString().Trim());
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                    adapter.Fill(dataTable);
                }
                catch (Exception)
                {
                    throw;
                }

                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }

                return dataTable;
            }
        }

        //ALTERNATIVE READ
        public DataTable DataRead(string tableName)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                string qry = string.Format("SELECT * FROM {0}", tableName);
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                    adapter.Fill(dataTable);
                }
                catch (Exception)
                {
                    throw;
                }


                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }

                return dataTable;
            }
        }
        public DataTable ViewCallInformation()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                string qry = string.Format("SELECT CallCentre.EmpID,Customer.cusID,Customer.Name,Customer.Surname, Customer.Cell ,Call.CallID FROM Customer JOIN Call ON Call.CusID = Customer.cusID JOIN CallCentre ON Call.CallID = CallCentre.CallID");
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                    adapter.Fill(dataTable);
                }
                catch (Exception)
                {
                    throw;
                }


                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }

                return dataTable;
            }
        }

        public DataTable ViewContractInformation()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                string qry = string.Format("SELECT Customer.cusID, Customer.Name, Customer.Surname, Customer.Address, Customer.Cell, Contract.ServiceLvl, Contract.UpgradeOpt, Contract.ConID, Product.SuiteName, Product.Description, ContractItem.Quantity  FROM Customer JOIN Contract ON Customer.cusID = Contract.CusID JOIN ContractItem ON Contract.ConID = ContractItem.ConID JOIN Product ON ContractItem.ProdID = Product.ProdID");
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                    adapter.Fill(dataTable);
                }
                catch (Exception)
                {
                    throw;
                }


                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }

                return dataTable;
            }
        }

        public DataTable ViewJobs()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                string qry = string.Format("SELECT * FROM TechSupport");
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                    adapter.Fill(dataTable);
                }
                catch (Exception)
                {
                    throw;
                }


                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }

                return dataTable;
            }
        }


        // Insert Procedures
        public void AddCustomer(string cus_Id, string name, string surname, string address, string cell)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("AddCus", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@cus_ID", cus_Id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@surname", surname);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@cell", cell);

                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void AddEmployee(string emp_Id, string name, string surname, string title, string password)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("AddEmp", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@emp_ID", emp_Id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@surname", surname);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@password", password);

                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void NewContract(string con_Id, string cus_ID, string upgradeOpt, string serviceLvl)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("NewCont", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@con_ID", con_Id);
                command.Parameters.AddWithValue("@cus_ID", cus_ID);
                command.Parameters.AddWithValue("@upgradeOpt", upgradeOpt);
                command.Parameters.AddWithValue("@serviceLvl", serviceLvl);

                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void AddJob(string job_ID, string emp_Id, string jobType, string status, string description, string date)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("NewJob", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@job_ID", job_ID);
                command.Parameters.AddWithValue("@emp_ID", emp_Id);
                command.Parameters.AddWithValue("@jobType", jobType);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@date", date);

                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void AddProduct(string prod_ID, string suiteName, string description, int unitsAvailable)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("AddProduct", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@prod_ID", prod_ID);
                command.Parameters.AddWithValue("@suiteName", suiteName);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@unitsAvailable", unitsAvailable);

                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {

                throw e;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void AddComponent(string serialNo, string type, string name, int quantity)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("AddComponent", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@serialNo", serialNo);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@quantity", quantity);

                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void SaveLog(string cus_ID, string call_ID, string audio, string callLog, string notes)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SaveLog", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@cus_ID", cus_ID);
                command.Parameters.AddWithValue("@call_ID", call_ID);
                command.Parameters.AddWithValue("@audio", audio);
                command.Parameters.AddWithValue("@callLog", callLog);
                command.Parameters.AddWithValue("@notes", notes);

                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }
        public void ConItem(DataTable contractItems)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("AddContractItem", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@contractItems", contractItems);
                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }

        public void RequestTech(string job_ID, string emp_Id, string jobType, string status, string description, string date)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Request", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@job_ID", job_ID);
                command.Parameters.AddWithValue("@emp_ID", emp_Id);
                command.Parameters.AddWithValue("@jobType", jobType);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@date", date);

                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void ComItem(DataTable componentItems)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("AddComItem", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@componentItems", componentItems);
                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }
        //LookUp 
        public void EmpCall(string empID, string callID)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Emp_Call", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@emp_ID", empID);
                command.Parameters.AddWithValue("@call_ID", callID);

                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void EmpCon(string empID, string conID)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Emp_Con", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@emp_ID", empID);
                command.Parameters.AddWithValue("@con_ID", conID);

                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void EmpProd(string empID, string prodID)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Emp_Prod", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@emp_ID", empID);
                command.Parameters.AddWithValue("@prod_ID", prodID);

                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void EmpCom(string empID, string prodID,string issueID)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Emp_Com", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@empID", empID);
                command.Parameters.AddWithValue("@prodID", prodID);
                command.Parameters.AddWithValue("@issueID", issueID);

                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void EmpJob(string empID, string jobID)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Emp_Job", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@emp_ID", empID);
                command.Parameters.AddWithValue("@job_ID", jobID);
               

                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }




        //Update Procedures
        public void UpdateJob(string job_ID, string status, string comDate)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("UpdateJob", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@job_ID", job_ID);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@completionDate", comDate);
                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void UpdateEmployee(string emp_Id, string name, string surname, string title, string password)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("UpdateEmpInfo", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@emp_ID", emp_Id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@surname", surname);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@password", password);


                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void UpdateCustomer(string cus_Id, string name, string surname, string address, string cell)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("UpdateCusInfo", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@cus_ID", cus_Id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@surname", surname);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@cell", cell);

                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void UpdateContract(string cus_Id, string upgradeOpt, string serviceLvl)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("UpdateCont", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@cus_ID", cus_Id);
                command.Parameters.AddWithValue("@upgradeOpt", upgradeOpt);
                command.Parameters.AddWithValue("@serviceLvl", serviceLvl);

                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {

                throw e;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void UpdateComponentQuantity(string c1, string c2, string c3, string c4, string c5, string c6, string c7, string c8, string c9, int q1, int q2, int q3, int q4, int q5, int q6, int q7, int q8, int q9)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("ReduceComponents", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@c1", c1);
                command.Parameters.AddWithValue("@q1", q1);

                command.Parameters.AddWithValue("@c2", c2);
                command.Parameters.AddWithValue("@q2", q2);

                command.Parameters.AddWithValue("@c3", c3);
                command.Parameters.AddWithValue("@q3", q3);

                command.Parameters.AddWithValue("@c4", c4);
                command.Parameters.AddWithValue("@q4", q4);

                command.Parameters.AddWithValue("@c5", c5);
                command.Parameters.AddWithValue("@q5", q5);

                command.Parameters.AddWithValue("@c6", c6);
                command.Parameters.AddWithValue("@q6", q6);

                command.Parameters.AddWithValue("@c7", c7);
                command.Parameters.AddWithValue("@q7", q7);

                command.Parameters.AddWithValue("@c8", c8);
                command.Parameters.AddWithValue("@q8", q8);

                command.Parameters.AddWithValue("@c9", c9);
                command.Parameters.AddWithValue("@q9", q9);

                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void IncreaseComponentQuantity(string c1, string c2, string c3, string c4, string c5, string c6, string c7, string c8, string c9, int q1, int q2, int q3, int q4, int q5, int q6, int q7, int q8, int q9)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("IncreaseComponents", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@c1", c1);
                command.Parameters.AddWithValue("@q1", q1);

                command.Parameters.AddWithValue("@c2", c2);
                command.Parameters.AddWithValue("@q2", q2);

                command.Parameters.AddWithValue("@c3", c3);
                command.Parameters.AddWithValue("@q3", q3);

                command.Parameters.AddWithValue("@c4", c4);
                command.Parameters.AddWithValue("@q4", q4);

                command.Parameters.AddWithValue("@c5", c5);
                command.Parameters.AddWithValue("@q5", q5);

                command.Parameters.AddWithValue("@c6", c6);
                command.Parameters.AddWithValue("@q6", q6);

                command.Parameters.AddWithValue("@c7", c7);
                command.Parameters.AddWithValue("@q7", q7);

                command.Parameters.AddWithValue("@c8", c8);
                command.Parameters.AddWithValue("@q8", q8);

                command.Parameters.AddWithValue("@c9", c9);
                command.Parameters.AddWithValue("@q9", q9);

                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void UpdateUnits(string prod_ID1, string prod_ID2, string prod_ID3, int unitsAvailable1, int unitsAvailable2, int unitsAvailable3)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("ReduceQuantity", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@prod_ID1", prod_ID1);
                command.Parameters.AddWithValue("@unitsAvailable1", unitsAvailable1);
                command.Parameters.AddWithValue("@prod_ID2", prod_ID2);
                command.Parameters.AddWithValue("@unitsAvailable2", unitsAvailable2);
                command.Parameters.AddWithValue("@prod_ID3", prod_ID3);
                command.Parameters.AddWithValue("@unitsAvailable3", unitsAvailable3);

                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void UpdateConItem( string con_ID, string prod_ID1, string prod_ID2, string prod_ID3, int unitsAvailable1, int unitsAvailable2, int unitsAvailable3)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("UpdateConItems", conn);
              
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@con_ID", con_ID);
                command.Parameters.AddWithValue("@prod_ID1", prod_ID1);
                command.Parameters.AddWithValue("@unitsAvailable1", unitsAvailable1);
                command.Parameters.AddWithValue("@prod_ID2", prod_ID2);
                command.Parameters.AddWithValue("@unitsAvailable2", unitsAvailable2);
                command.Parameters.AddWithValue("@prod_ID3", prod_ID3);
                command.Parameters.AddWithValue("@unitsAvailable3", unitsAvailable3);

                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }


        //Delete Procedures
        public void RemoveCustomer(string cus_ID)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("DeleteCus", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@cus_ID", cus_ID);
                command.ExecuteNonQuery();
            }
            catch (SqlException se)
            {

                throw se;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }
        public void RemoveEmployee(string emp_ID)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("DeleteEmp", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@emp_ID", emp_ID);
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {

                throw e;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            //View Procedures

        }

        //Search Procedures
       
        public DataTable LoadComponent(string prodID)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                string qry = string.Format
                ("SELECT Component.SerialNo,Component.Type,Component.Name,Component.Quantity, ProductItem.ProdID FROM Component JOIN ProductItem ON Component.SerialNo = ProductItem.SerialNo AND ProductItem.ProdID = '{0}'", prodID);
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                    adapter.Fill(dataTable);
                }
                catch (Exception)
                {
                    throw;
                }

                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }

                return dataTable;
            }

        }
        public DataTable SearchTechnician()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                string qry = string.Format("SELECT * FROM Employee WHERE Title LIKE '%Technician%'");
                
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                    adapter.Fill(dataTable);
                }
                catch (Exception)
                {
                    throw;
                }

                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }

                return dataTable;
            }

        }
    }
}
