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
    public partial class TMain : Form
    {
        string eID;
        public TMain(string empID)
        {
            InitializeComponent();
            eID = empID;
        }
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        private void TMain_Load(object sender, EventArgs e)
        {
            //Style
            btnAssign.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));
            btnView.BackColor= Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));
            pnlBottom.BackColor = ColorTranslator.FromHtml("#033594");
            pnlTop.BackColor = ColorTranslator.FromHtml("#033594");
            btnMinimize.BackColor = ColorTranslator.FromHtml("#033594");
            btnClose.BackColor = ColorTranslator.FromHtml("#033594");

            DataTable dt = new Admin().DisplayTable();
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("EmpID LIKE '%{0}%'", eID);
            lblEmployeeName.Text = dv[0]["FirstName"].ToString() + " " + dv[0]["Surname"].ToString();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            TechSupport ts = new TechSupport(eID);
            ts.Show();
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            TechnicalSupportView tsv = new TechnicalSupportView(eID);
            tsv.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
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
