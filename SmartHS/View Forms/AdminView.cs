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
    public partial class AdminView : Form
    {
        string empID;
        public AdminView(string eID)
        {
            InitializeComponent();
            empID = eID;
        }

      
        BindingSource bs = new BindingSource();
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);

        public void RefreshCustomer()
        {
            bs.DataSource = new Admin().DisplayCustomerTable();
            dgvDisplay.DataSource = bs;   
        }

        public void RefreshEmployee()
        {
            bs.DataSource = new Admin().DisplayTable();
            dgvDisplay.DataSource = bs;
            this.dgvDisplay.Columns["Pass"].Visible = false;
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            //Style
            btnFirst.BackColor = ColorTranslator.FromHtml("#033594");
            btnLast.BackColor = ColorTranslator.FromHtml("#033594");
            btnNext.BackColor = ColorTranslator.FromHtml("#033594");
            btnPrevious.BackColor = ColorTranslator.FromHtml("#033594");

            gbSearch.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));


            pnlBottom.BackColor = ColorTranslator.FromHtml("#033594");
            pnlTop.BackColor = ColorTranslator.FromHtml("#033594");
            btnMinimize.BackColor = ColorTranslator.FromHtml("#033594");
            btnClose.BackColor = ColorTranslator.FromHtml("#033594");
        }

        private void rbEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmployee.Checked)
            {
                RefreshEmployee();
            }
        }

        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustomer.Checked)
            {
                RefreshCustomer();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (rbCustomer.Checked)
            {
                string ID = txtID.Text;
                DataTable dt = new Admin().SearchCus(ID);
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("CusID LIKE '%{0}%'", ID);
                dgvDisplay.DataSource = dv;
            }
            else if (rbEmployee.Checked)
            {
                string ID = txtID.Text;
                DataTable dt = new Admin().DisplayTable();
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("EmpID LIKE '%{0}%'", ID);
                dgvDisplay.DataSource = dv;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
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
            AdminMain am = new AdminMain(empID);
            am.Show();
            this.Close();
        }
    }
}
