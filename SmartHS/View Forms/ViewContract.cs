using BusinessLogic;
using BusinessLogic.Contract_Management_Depatment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHS
{
    public partial class ViewContract : Form
    {
        
        public ViewContract(string EID)
        {
            InitializeComponent();
            empID = EID;
        }
        string empID;
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            NewContract nc = new NewContract(empID);
            nc.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtbContractView.Text = "";
            txtSearch.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ID = txtSearch.Text;

            DataTable dt = new Contract_Management().DisplayContractTable();
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("CusID LIKE '%{0}%'", ID);
            rtbContractView.AppendText("Contract ID: " + dv[0]["ConID"].ToString() + "\n\n" +
                "Customer ID: " + dv[0]["cusID"].ToString() + "\n" +
                "Name: " + dv[0]["Name"].ToString() + " " + dv[0]["Surname"].ToString() + "\n" +
                "Address: " + dv[0]["Address"].ToString() + "\n" +
                "Cell No: " + dv[0]["Cell"].ToString() + "\n\n" +
                "Service Level: " + dv[0]["ServiceLvl"].ToString() + "\n" +
                "Upgrade Options: " + dv[0]["UpgradeOpt"].ToString() + "\n\n"+"Product List:" + "\n\n" );
                




            for (int i = 0; i < dv.Count; i++)
            {
                if (dv[i]["Quantity"].ToString()!="0")
                {
                    rtbContractView.AppendText(dv[i]["SuiteName"].ToString() + "\n" +
                    "Description: " + dv[i]["Description"].ToString() + "\n" +
                    "Quantity: " + dv[i]["Quantity"].ToString()+"\n\n");
                }
                
            }



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            NewContract nc = new NewContract(empID);
            nc.Show();
            this.Close();
        }

        private void ViewContract_Load(object sender, EventArgs e)
        {
            //Style
            btnUpdate.BackColor = ColorTranslator.FromHtml("#033594");
            btnSearch.BackColor = ColorTranslator.FromHtml("#033594");
            btnClear.BackColor = ColorTranslator.FromHtml("#033594");

            gbInformation.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));
            

            pnlBottom.BackColor = ColorTranslator.FromHtml("#033594");
            pnlTop.BackColor = ColorTranslator.FromHtml("#033594");
            btnMinimize.BackColor = ColorTranslator.FromHtml("#033594");
            btnClose.BackColor = ColorTranslator.FromHtml("#033594");

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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            ContractManagement cm = new ContractManagement(empID);
            cm.Show();
            this.Close();
        }
    }
}
