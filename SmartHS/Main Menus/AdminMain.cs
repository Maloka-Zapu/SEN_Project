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
    public partial class AdminMain : Form
    {
        string eID;
        public AdminMain(string empID)
        {
            InitializeComponent();
            eID = empID;
        }
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterCustomer rc = new RegisterCustomer(eID);
            rc.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterEmployee re = new RegisterEmployee(eID);
            re.Show();
            this.Close();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            //Style
            btnAddCus.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));
            btnAddEmp.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));
            msOther.BackColor = ColorTranslator.FromHtml("#033594");
            pnlTop.BackColor = ColorTranslator.FromHtml("#033594");
            btnMinimize.BackColor = ColorTranslator.FromHtml("#033594");
            btnClose.BackColor = ColorTranslator.FromHtml("#033594");

            DataTable dt = new Admin().DisplayTable();
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("EmpID LIKE '%{0}%'", eID);
            lblEmployeeName.Text = dv[0]["FirstName"].ToString() + " " + dv[0]["Surname"].ToString();


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void technicalSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TMain tm = new TMain(eID);
            this.Hide();
            tm.Show();
        }

        private void callCentreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CCMain ccMenu = new CCMain(eID);
            this.Hide();
            ccMenu.Show();
        }

        private void contractManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContractManagement cMenu = new ContractManagement(eID);
            this.Hide();
            cMenu.Show();
        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PMMain pMenu = new PMMain(eID);
            this.Hide();
            pMenu.Show();
        }

        private void technicalSupportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TMain tMenu = new TMain(eID);
            this.Hide();
            tMenu.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AdminView av = new AdminView(eID);
            av.Show();
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }
    }
}
