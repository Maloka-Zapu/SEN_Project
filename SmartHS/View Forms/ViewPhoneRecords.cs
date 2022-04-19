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
    public partial class ViewPhoneRecords : Form
    {
        string empID;
        public ViewPhoneRecords(string EID)
        {
            InitializeComponent();
            empID = EID;
        }
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        BindingSource bs = new BindingSource();
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            CCMain menu = new CCMain(empID);
            menu.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ViewPhoneRecords_Load(object sender, EventArgs e)
        {
            //Style
            
            btnSearch.BackColor = ColorTranslator.FromHtml("#033594");

            gbSearch.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));


            pnlBottom.BackColor = ColorTranslator.FromHtml("#033594");
            pnlTop.BackColor = ColorTranslator.FromHtml("#033594");
            btnMinimize.BackColor = ColorTranslator.FromHtml("#033594");
            btnClose.BackColor = ColorTranslator.FromHtml("#033594");

            bs.DataSource = new CallCentreManagememnt().DisplayCallTable();
            dgvViewRecords.DataSource = bs;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ID = txtSearch.Text;

            DataTable viewRecords = new CallCentreManagememnt().DisplayCallTable();
            DataView vr = new DataView(viewRecords);
            vr.RowFilter = string.Format("cusID LIKE'"+ID+"' OR EmpID LIKE'"+ID+"' OR CallID LIKE'"+ID+"'");
            dgvViewRecords.DataSource = vr;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            CCMain menu = new CCMain(empID);
            menu.Show();
            this.Close();
        }
    }
}
