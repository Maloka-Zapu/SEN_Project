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
using BusinessLogic.Contract_Management_Depatment;

namespace SmartHS
{
    public partial class NewContract : Form
    {
        
        public NewContract(string eID)
        {
            InitializeComponent();
            empID = eID;
        }
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        string empID;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }
        string ID;
        string EconID;

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dk = new Contract_Management().DisplayContractTable();
            DataView dvcc = new DataView(dk);
            ID = txtCustomerID.Text;
            DataTable Cdata = new Contract_Management().DisplayCustomerTable();
           
            DataView dv = new DataView(Cdata);
            dv.RowFilter = string.Format("CusID LIKE '%{0}%'", ID);
            
            if (dv.Count>0)
            {
                txtName.Text = dv[0][1].ToString();
                txtSurname.Text = dv[0][2].ToString();
                gbProducts.Enabled = true;
                
            }

            else 
            {
                MessageBox.Show("This customer ID is invalid","Error",MessageBoxButtons.OK);
                txtCustomerID.Text = "";
                
            }

            for (int i = 0; i < dvcc.Count; i++)
            {
                if (dvcc[i]["CusID"].ToString().Contains(ID))
                {
                    btnUpdate.Enabled = true;
                    btnGenerate.Enabled = false;
                    txtName.Text = dvcc[i]["Name"].ToString();
                    txtSurname.Text = dvcc[i]["Surname"].ToString();
                    if (dvcc[i]["UpgradeOpt"].ToString()=="Premium")
                    {
                        rdStandard.Checked = false;
                        rbPremium.Checked = true;
                    }
                    else if (dvcc[i]["UpgradeOpt"].ToString() == "Standard")
                    {
                        rbPremium.Checked = false;
                        rdStandard.Checked = true;
                    }
                    cmbServiceLevels.Text = dvcc[0]["ServiceLvl"].ToString();

                    if (dvcc[i]["SuiteName"].ToString()== "Home Energy Management System")
                    {
                        nudEnergyManagement.Value = Convert.ToInt32(dvcc[i]["Quantity"]);
                    }
                    if (dvcc[i]["SuiteName"].ToString() == "Home Safety Management System")
                    {
                        nudSafetyManagement.Value = Convert.ToInt32(dvcc[i]["Quantity"]);
                    }
                    if (dvcc[i]["SuiteName"].ToString() == "Home Convenience Management System")
                    {
                        nudConvieManagement.Value = Convert.ToInt32(dvcc[i]["Quantity"]);
                    }

                    EconID = dvcc[i]["ConID"].ToString();
                }
                else
                {

                    btnGenerate.Enabled = true;
                    btnUpdate.Enabled = false;
                    
                    nudConvieManagement.Value = 0;
                    nudEnergyManagement.Value = 0;
                    nudSafetyManagement.Value = 0;
                    cmbServiceLevels.Text = "";
                    rbPremium.Checked = false;
                    rdStandard.Checked = false;
                }
              
            }




        }
        char Ser;
        
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbServiceLevels.Text=="Customer-Based")
            {
                Ser = 'A';
            }
            else if (cmbServiceLevels.Text == "Service-Based")
            {
                Ser = 'B';
            }
            else if (cmbServiceLevels.Text == "Corparate-Based")
            {
                Ser = 'C';
            }
            else if (cmbServiceLevels.Text == "Multilevel")
            {
                Ser = 'D';
            }

            if (rbPremium.Checked || rdStandard.Checked && cmbServiceLevels.SelectedItem != null)
            {
                gpProductInfo.Enabled = true;
            }
        }
     
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }
        char Upg;
        string upgradeOpt;
       
        private void button3_Click(object sender, EventArgs e)
        {
            
            string d = DateTime.Now.Year.ToString();
            DataTable dk = new Contract_Management().DisplayContractTable();
            DataView dvcc = new DataView(dk);
            string ConID;
            

        
                Random num = new Random();
                int randomNum = num.Next(1000, 9999);
                ConID = (d + Upg + Ser + randomNum.ToString()).PadLeft(4, '0');

                totalHE = Convert.ToInt32(nudEnergyManagement.Value);
                totalHS = Convert.ToInt32(nudSafetyManagement.Value);
                totalHC = Convert.ToInt32(nudConvieManagement.Value);

                ctTable.Columns.Add("ConID", typeof(string));
                ctTable.Columns.Add("ProdID", typeof(string));
                ctTable.Columns.Add("Quantity", typeof(int));


                    ctTable.Rows.Add(ConID, "1", totalHE);
                    ctTable.Rows.Add(ConID, "2", totalHS);
                    ctTable.Rows.Add(ConID, "3", totalHC);


                
                new Contract_Management().CreateContract(ConID, txtCustomerID.Text, upgradeOpt, cmbServiceLevels.SelectedItem.ToString());
                new Contract_Management().UpdateProd(totalHE, totalHS, totalHC);
                new Contract_Management().Employee_Contract(empID, ConID);
                new Contract_Management().ContractItems(ctTable);
                
                MessageBox.Show("Contract ID: " + ConID + "\nGenerated Successully!", "Success");
                txtCustomerID.Text = "";
                txtName.Text = "";
                txtSurname.Text = "";
                nudConvieManagement.Value = 0;
                nudEnergyManagement.Value = 0;
                nudSafetyManagement.Value = 0;
                cmbServiceLevels.Text = "";
                rbPremium.Checked = false;
                rdStandard.Checked = false;
            
            
        }
       
        private void rdStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdStandard.Checked)
            {
                Upg = 'S';
                upgradeOpt = "Standard";
            }
        }

        private void rbPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPremium.Checked)
            {
                Upg = 'P';
                upgradeOpt = "Premium";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void NewContract_Load(object sender, EventArgs e)
        {
            //Style
            btnUpdate.BackColor = ColorTranslator.FromHtml("#033594");
            btnSearch.BackColor = ColorTranslator.FromHtml("#033594");
            btnGenerate.BackColor = ColorTranslator.FromHtml("#033594");

            gpProductInfo.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));
            gbProducts.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));
            gbInformation.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));

            pnlBottom.BackColor = ColorTranslator.FromHtml("#033594");
            pnlTop.BackColor = ColorTranslator.FromHtml("#033594");
            btnMinimize.BackColor = ColorTranslator.FromHtml("#033594");
            btnClose.BackColor = ColorTranslator.FromHtml("#033594");


            txtName.Enabled = false;
            txtSurname.Enabled = false;
            btnGenerate.Enabled = false;
            gbProducts.Enabled = false;
            gpProductInfo.Enabled = false;
            btnUpdate.Enabled = false;
        }
       
        int totalHS = 0;
        int totalHE = 0;
        int totalHC = 0;
        private void lstProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void nudEnergyManagement_ValueChanged(object sender, EventArgs e)
        {
            if (nudEnergyManagement.Value>0)
            {
                btnGenerate.Enabled = true;
            }
        }

        private void nudSafetyManagement_ValueChanged(object sender, EventArgs e)
        {
            if (nudSafetyManagement.Value > 0)
            {
                btnGenerate.Enabled = true;
            }
        }

        private void nudConvieManagement_ValueChanged(object sender, EventArgs e)
        {
            if (nudConvieManagement.Value > 0)
            {
                btnGenerate.Enabled = true;
            }
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            
        }
        DataTable ctTable = new DataTable();
        DataTable uctTable = new DataTable();

        private void btnUpdate_Click(object sender, EventArgs e)
            
        {
            //ServiceUpdate
            new Contract_Management().UpdateContract(txtCustomerID.Text, upgradeOpt, cmbServiceLevels.SelectedItem.ToString());
            //ProductUpdate
            totalHE = Convert.ToInt32(nudEnergyManagement.Value);
            totalHS = Convert.ToInt32(nudSafetyManagement.Value);
            totalHC = Convert.ToInt32(nudConvieManagement.Value);
            

            new Contract_Management().UpdateContractItems(EconID,totalHE,totalHS,totalHC);
            MessageBox.Show("Contract Updated Successfully");
            txtCustomerID.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            nudConvieManagement.Value = 0;
            nudEnergyManagement.Value = 0;
            nudSafetyManagement.Value = 0;
            cmbServiceLevels.Text = "";
            rbPremium.Checked = false;
            rdStandard.Checked = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
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

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            ContractManagement cm = new ContractManagement(empID);
            cm.Show();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
