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

namespace SmartHS
{
    public partial class ContractManagement : Form
    {
        
        public ContractManagement(string empID)
        {
            InitializeComponent();
            eID = empID;
        }
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        string eID;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewContract vc = new ViewContract(eID);
            vc.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewContract nc = new NewContract(eID);
            nc.Show();
            this.Close();
        }

        private void ContractManagement_Load(object sender, EventArgs e)
        {
            //Style
            btnCreate.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));
            btnView.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));
            pnlBottom.BackColor = ColorTranslator.FromHtml("#033594");
            pnlTop.BackColor = ColorTranslator.FromHtml("#033594");
            btnMinimize.BackColor = ColorTranslator.FromHtml("#033594");
            btnClose.BackColor = ColorTranslator.FromHtml("#033594");


            DataTable dt = new Admin().DisplayTable();
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("EmpID LIKE '%{0}%'", eID);
            lblEmployeeName.Text = dv[0]["FirstName"].ToString() + " " + dv[0]["Surname"].ToString();
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

            if (eID.Contains("AA"))
            {
                AdminMain aMenu = new AdminMain(eID);
                this.Hide();
                aMenu.Show();
            }
            else
            {
                Login l = new Login();
                l.Show();
                this.Close();
            }
        }
    }
}
