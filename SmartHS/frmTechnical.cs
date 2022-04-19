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
using BusinessLogic.Technical_Support_Management;

namespace SmartHS
{
    public partial class frmTechnical : Form
    {
        string cusID;
        public frmTechnical(string cID)
        {
            InitializeComponent();
            cusID = cID.Trim();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        string JobID;
        string date;
        private void frmTechnical_Load(object sender, EventArgs e)
        {
            //Style
            pnlBottom.BackColor = ColorTranslator.FromHtml("#033594");
            pnlTop.BackColor = ColorTranslator.FromHtml("#033594");
            btnMinimize.BackColor = ColorTranslator.FromHtml("#033594");
            btnClose.BackColor = ColorTranslator.FromHtml("#033594");
            btnAssistance.BackColor = ColorTranslator.FromHtml("#033594");



            date = DateTime.Today.ToString("d");
            lblToday.Text = date;

            
            char[] str = new char[3] { 'X', 'Y', 'Z' };
            Random al = new Random();
            Random num = new Random();

            int randomChar = al.Next(0, 2);
            int randomNum = num.Next(1000, 99999);
            JobID = (str[randomChar] + randomNum.ToString()).PadLeft(10, '0');

            lblJobID.Text = JobID;
            MessageBox.Show(cusID); 
            DataTable Cdata = new CallCentreManagememnt().SearchCus(cusID);
            DataView dv = new DataView(Cdata);
            dv.RowFilter = string.Format("CusID LIKE '%{0}%'", cusID);

            rtbCustomerInformation.AppendText(
                "Customer ID: " + dv[0]["cusID"].ToString() + "\n" +
                "Name: " + dv[0]["Name"].ToString() + " " + dv[0]["Surname"].ToString() + "\n" +
                "Address: " + dv[0]["Address"].ToString() + "\n" +
                "Cell No: " + dv[0]["Cell"].ToString() + "\n\n" );

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Technical_Management().RequestAssistence(JobID,"-",cmbType.SelectedItem.ToString(),"Unassigned",rtbCustomerInformation.Text, date);
            MessageBox.Show("Technical Assistance Requested Successfully!");
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
