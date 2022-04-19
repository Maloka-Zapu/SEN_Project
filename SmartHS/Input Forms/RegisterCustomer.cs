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
    public partial class RegisterCustomer : Form
    {
        public RegisterCustomer(string eID)
        {
            InitializeComponent();
            empID = eID;
        }
        string empID;
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        string customerID;
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            

            string FirstName=txtName.Text;
            string Surname=txtSurname.Text;
            string Phone=txtPhoneNo.Text;
            string Address=rtAddress.Text;
            string ID = txtCustomerID.Text;

            if (txtName.Text.Equals("")||txtSurname.Text.Equals("")||txtPhoneNo.Text.Equals("")||rtAddress.Text.Equals(""))
            {
                MessageBox.Show("Please complete all the relevent fields");
            }
            else
            {
                char[] str = new char[5] { 'A', 'B', 'C', 'D', 'E' };
                Random al = new Random();
                Random num = new Random();

                int randomChar = al.Next(0, 4);
                int randomNum = num.Next(1000, 99999);

                customerID = (str[randomChar].ToString() + randomNum.ToString()).PadLeft(8, '0');
                txtCustomerID.Text = customerID;



                MessageBox.Show(FirstName + " has been added to the database. \nCustomer ID:" + customerID);

                new Admin().NewCustomer(customerID, FirstName, Surname, Address, Phone);
            }
            
            txtCustomerID.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtPhoneNo.Text = "";
            rtAddress.Text = "";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RegisterCustomer_Load(object sender, EventArgs e)
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

            btnUpdate.Enabled = false;
            txtCustomerID.Enabled = false;
            btnSearch.Enabled = false;
        }

        private void chkUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUpdate.Checked==true)
            {
                txtCustomerID.Enabled = true;
                btnGenerate.Enabled = false;
                btnUpdate.Enabled = true;
                txtName.Enabled = false;
                txtSurname.Enabled = false;
                txtPhoneNo.Enabled = false;
                rtAddress.Enabled = false;
                btnSearch.Enabled = true;

            }
            else
            {
                txtCustomerID.Enabled = false;
                btnGenerate.Enabled = true;
                btnUpdate.Enabled = false;
                txtName.Enabled = true;
                txtSurname.Enabled = true;
                txtPhoneNo.Enabled = true;
                rtAddress.Enabled = true;
                btnSearch.Enabled = false;
            }
        }
        
        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new Admin().UpdateCustomer(txtCustomerID.Text, txtName.Text, txtSurname.Text, txtPhoneNo.Text, rtAddress.Text);
            MessageBox.Show("Update Succesful!","Success",MessageBoxButtons.OK);
            txtCustomerID.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtPhoneNo.Text = "";
            rtAddress.Text = "";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ID = txtCustomerID.Text;
            DataTable dt = new Admin().DisplayCustomerTable();
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("CusID LIKE '%{0}%'", ID);

            if (dv.Count > 0)
            {

                txtName.Enabled = true;
                txtSurname.Enabled = true;
                txtPhoneNo.Enabled = true;
                rtAddress.Enabled = true;
                txtName.Text = dv[0]["Name"].ToString();
                txtSurname.Text = dv[0]["Surname"].ToString();
                txtPhoneNo.Text = dv[0]["Address"].ToString();
                rtAddress.Text = dv[0]["Cell"].ToString();


            }
            else
            {
                MessageBox.Show("This customer ID doesn't exist.", "Error!", MessageBoxButtons.OK);
                txtCustomerID.Text = "";
                txtName.Text = "";
                txtSurname.Text = "";
                txtPhoneNo.Text = "";
                rtAddress.Text = "";

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
