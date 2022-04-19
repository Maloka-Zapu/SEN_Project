using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace SmartHS
{
    public partial class RegisterEmployee : Form
    {
        public RegisterEmployee(string eID)
        {
            InitializeComponent();
            empID = eID;
        }
        string empID;
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        private void RegisterEmployee_Load(object sender, EventArgs e)
        {
            //Style
            btnSearch.BackColor = ColorTranslator.FromHtml("#033594");
            btnUpdate.BackColor = ColorTranslator.FromHtml("#033594");
            btnGenerate.BackColor = ColorTranslator.FromHtml("#033594");



            groupBox1.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));



            pnlBottom.BackColor = ColorTranslator.FromHtml("#033594");
            pnlTop.BackColor = ColorTranslator.FromHtml("#033594");
            btnMinimize.BackColor = ColorTranslator.FromHtml("#033594");
            btnClose.BackColor = ColorTranslator.FromHtml("#033594");

            txtEmployeeID.Enabled = false;
            btnSearch.Enabled = false;
            btnUpdate.Enabled = false;

        }
        string preFix;
        string employeeID;
        Random al = new Random();
        Random num = new Random();
        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTitle.SelectedItem.ToString()=="Call Centre Agent")
            {
                preFix = "CC";
            }
            else if(cmbTitle.SelectedItem.ToString() == "Contract Management Consultant")
            {
                preFix = "CM";
            }
            else if (cmbTitle.SelectedItem.ToString() == "Technical Support Manager")
            {
                preFix = "TM";
            }
            else if (cmbTitle.SelectedItem.ToString() == "Technician")
            {
                preFix = "TE";
            }
            else if (cmbTitle.SelectedItem.ToString() == "Product Management Agent")
            {
                preFix = "PM";
            }
            else if (cmbTitle.SelectedItem.ToString() == "Administator")
            {
                preFix = "AA";
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbTitle.SelectedItem == null || txtName.Text.Equals("")||txtSurname.Text.Equals("")||txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Please complete all the necessary fields");
            }
            else
            {
               

                string FirstName = txtName.Text;
                string Surname = txtSurname.Text;
                string Title = cmbTitle.SelectedItem.ToString();
                string Password = txtPassword.Text;

                int randomChar = al.Next(0, 4);
                int randomNum = num.Next(1000, 99999);
                employeeID = (preFix + randomNum.ToString()).PadLeft(8, '0');
                txtEmployeeID.Text = employeeID;
               

                new Admin().NewEmployee(employeeID,FirstName,Surname,Title,Password);

                MessageBox.Show(FirstName+" "+Surname+" has been added to the database. \nEmployee ID:"+employeeID);

            }
            
        }

        private void chkUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUpdate.Checked == true)
            {
                txtEmployeeID.Enabled = true;
                btnGenerate.Enabled = false;
                btnUpdate.Enabled = true;
                btnSearch.Enabled = true;
                txtName.Enabled=false;
                txtSurname.Enabled=false;
                cmbTitle.Enabled=false;
                txtPassword.Enabled=false;
            }
            else
            {
                txtEmployeeID.Enabled = false;
                txtName.Enabled = true;
                txtSurname.Enabled = true;
                cmbTitle.Enabled = true;
                txtPassword.Enabled = true;
                btnGenerate.Enabled = true;

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        string ID;
        
        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new Admin().UpdateEmp(ID, txtName.Text, txtSurname.Text, cmbTitle.Text, txtPassword.Text);
            MessageBox.Show("Update Succesful!", "Success", MessageBoxButtons.OK);
            txtName.Text = "";
            txtSurname.Text = "";
            cmbTitle.Text = "";
            txtPassword.Text = "";
            txtEmployeeID.Text="";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ID = txtEmployeeID.Text;
            DataTable dt = new Admin().DisplayTable();
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("EmpID LIKE '%{0}%'", ID);

            if (dv.Count>0)
            {
                txtName.Text = dv[0]["FirstName"].ToString();
                txtSurname.Text = dv[0]["Surname"].ToString();
                cmbTitle.Text = dv[0]["Title"].ToString();
                txtPassword.Text = dv[0]["Pass"].ToString();
                txtName.Enabled = true;
                txtSurname.Enabled = true;
                cmbTitle.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {
                MessageBox.Show("This employee ID doesn't exist.", "Error!", MessageBoxButtons.OK);
                txtName.Text = "";
                txtSurname.Text ="";
                cmbTitle.Text = "";
                txtPassword.Text = "";
                txtEmployeeID.Text = "";
            }
           
             
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
            AdminMain am = new AdminMain(empID);
            am.Show();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
