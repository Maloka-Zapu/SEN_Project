using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogic.Product_Management_Department;

namespace SmartHS
{
    public partial class ProductManagement : Form
    {
        string empID;
        public ProductManagement(string eID)
        {
            InitializeComponent();
            empID = eID;
        }
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        string date = DateTime.Today.ToString("d");
        int q1,q2,q3,q4,q5,q6,q7,q8,q9=0;
        private void btnIssue_Click(object sender, EventArgs e)
        {
            string issueID;
            if (cmbTechnicians.SelectedItem==null)
            {
                MessageBox.Show("Select Technician");
            }
            if (lsttems.Items.Count==0)
            {
                MessageBox.Show("Please select components to issue");
            }
            else
            {
                Random num = new Random();
                int randomNum = num.Next(10000, 999999);
                issueID = randomNum.ToString().PadLeft(8, '0');
                for (int i = 0; i < lsttems.Items.Count; i++)
                {
                    string componentName = lsttems.Items[i].ToString();
                    if (componentName == "Motion Sensor")
                    {
                        q1++;
                    }
                    else if (componentName == "Smoke Detector")
                    {
                        q2++;
                    }
                    else if (componentName == "Camera")
                    {
                        q3++;
                    }
                    else if (componentName == "Alarm")
                    {
                        q4++;
                    }
                    else if (componentName == "Home Safety Software")
                    {
                        q5++;
                    }
                    else if (componentName == "Home Energy Software")
                    {
                        q6++;
                    }
                    else if (componentName == "Home Convenience Software")
                    {
                        q7++;
                    }
                    else if (componentName == "Monitors")
                    {
                        q8++;
                    }
                    else if (componentName == "Curtain Drawers")
                    {
                        q9++;
                    }
                }
                DataTable issueTable = new DataTable();

                issueTable.Columns.Add("IssueID", typeof(string));
                issueTable.Columns.Add("EmpID", typeof(string));
                issueTable.Columns.Add("SerialNo", typeof(string));
                issueTable.Columns.Add("Date", typeof(string));
                issueTable.Columns.Add("Quantity", typeof(int));

                if (q1 > 0) { issueTable.Rows.Add(issueID, cmbTechnicians.SelectedItem.ToString(), "001", date, q1); }
                if (q2 > 0) { issueTable.Rows.Add(issueID, cmbTechnicians.SelectedItem.ToString(), "002", date, q2); }
                if (q3 > 0) { issueTable.Rows.Add(issueID, cmbTechnicians.SelectedItem.ToString(), "003", date, q3); }
                if (q4 > 0) { issueTable.Rows.Add(issueID, cmbTechnicians.SelectedItem.ToString(), "004", date, q4); }
                if (q5 > 0) { issueTable.Rows.Add(issueID, cmbTechnicians.SelectedItem.ToString(), "005", date, q5); }
                if (q6 > 0) { issueTable.Rows.Add(issueID, cmbTechnicians.SelectedItem.ToString(), "006", date, q6); }
                if (q7 > 0) { issueTable.Rows.Add(issueID, cmbTechnicians.SelectedItem.ToString(), "007", date, q7); }
                if (q8 > 0) { issueTable.Rows.Add(issueID, cmbTechnicians.SelectedItem.ToString(), "008", date, q8); }
                if (q9 > 0) { issueTable.Rows.Add(issueID, cmbTechnicians.SelectedItem.ToString(), "009", date, q9); }

                new Product_Management().UpdateComponents(q1, q2, q3, q4, q5, q6, q7, q8, q9);
                new Product_Management().Emp_Com(empID, ID, issueID);
                new Product_Management().IssueComponents(issueTable);

                System.Text.StringBuilder b = new System.Text.StringBuilder();
                foreach (System.Data.DataRow r in issueTable.Rows)
                {
                    foreach (System.Data.DataColumn c in issueTable.Columns)
                    {
                        b.Append(c.ColumnName.ToString() + ":" + r[c.ColumnName].ToString() + "\t");
                    }
                    b.Append("\n\n");
                }
                MessageBox.Show(b.ToString());

                cmbProducts.Text = "";
                cmbComponents.Text = "";
                lsttems.Items.Clear();


            }

        }

        DataTable dt = new DataTable();
        DataView dvc = new DataView();
        DataTable technicians = new DataTable();
        DataView t = new DataView();
        private void ProductManagement_Load(object sender, EventArgs e)
        {
            //Style
            btnAddComponent.BackColor = ColorTranslator.FromHtml("#033594");
            btnRemove.BackColor = ColorTranslator.FromHtml("#033594");
            btnAddProduct.BackColor = ColorTranslator.FromHtml("#033594");
            btnView.BackColor = ColorTranslator.FromHtml("#033594");
            btnIssue.BackColor = ColorTranslator.FromHtml("#033594");
            

            gbProducts.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));
            gbComponents.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));
            

            pnlBottom.BackColor = ColorTranslator.FromHtml("#033594");
            pnlTop.BackColor = ColorTranslator.FromHtml("#033594");
            btnMinimize.BackColor = ColorTranslator.FromHtml("#033594");
            btnClose.BackColor = ColorTranslator.FromHtml("#033594");

            DataTable Cdata = new Product_Management().DisplayProductTable();
            DataView dv = new DataView(Cdata);
            for (int i = 0; i < dv.Count; i++)
            {
                cmbProducts.Items.Add(dv[i]["SuiteName"]);
            }
            technicians = new Product_Management().DisplayTechnicians();
            t = new DataView(technicians);
            
            for (int i = 0; i < t.Count; i++)
            {
                cmbTechnicians.Items.Add(t[i].Row["EmpID"]);
            }
        }

        private void lsttems_SelectedIndexChanged(object sender, EventArgs e)
        {     
        }

        private void txtTechnicianName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);

            }
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            PMMain pm = new PMMain(empID);
            pm.Show();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        string ID;
       
        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cmbProducts.SelectedItem.ToString()== "Home Energy Management System")
            {
                cmbComponents.Items.Clear();
                ID = "1";
                btnAddProduct.Enabled = true;
            }
            if (cmbProducts.SelectedItem.ToString() == "Home Safety Management System")
            {
                cmbComponents.Items.Clear();
                ID = "2";
                btnAddProduct.Enabled = true;
            }
            if (cmbProducts.SelectedItem.ToString() == "Home Convenience Management System")
            {
                cmbComponents.Items.Clear();
                ID = "3";
                btnAddProduct.Enabled = true;
            }
            dt = new Product_Management().DisplayComponentTable(ID);
            dvc = new DataView(dt);

            for (int i = 0; i < dvc.Count; i++)
            {
                cmbComponents.Items.Add(dvc[i]["Name"]);
                if (dvc[i][3].ToString()=="0")
                {
                    btnAddProduct.Enabled = false;
                }
              
               
            }

           

           
            

        }

        private void cmbComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dvc[cmbComponents.SelectedIndex][3].ToString() == "0")
            {
                btnAddComponent.Enabled = false;
            }
            else
            {
                btnAddComponent.Enabled = true;
            }

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dvc.Count; i++)
            {
                lsttems.Items.Add(dvc[i]["Name"]);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lsttems.Items.Remove(lsttems.SelectedItem);
        }

        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            lsttems.Items.Add(cmbComponents.SelectedItem);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dvc.RowFilter = string.Format("Name LIKE '%{0}%'", cmbComponents.SelectedItem.ToString());
            MessageBox.Show("Serial No: "+dvc[0][0]+"\n"+"Component Name: "+ dvc[0][2] + "\n"+"Type: "+ dvc[0][1] + "\n"+"Available Quantity: "+ dvc[0][3]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                txtTechnicianName.Text = t[cmbTechnicians.SelectedIndex].Row["FirstName"] + " " + t[cmbTechnicians.SelectedIndex].Row["Surname"];
        }
    }
}
