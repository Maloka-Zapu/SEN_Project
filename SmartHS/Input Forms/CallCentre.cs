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
    public partial class CallCentre : Form
    {
        string empID;
        public CallCentre(string eID)
        {
            InitializeComponent();
            empID = eID;
        }
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        int seconds;
        int minutes;
        int hours;
        string Seconds;
        string Minutes;
        string Hours;
        string date;
        string ID;
        //string Notes;
        //string Phone;
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
           
            tmrCallDuration.Start();
        }

        private void CallCentre_Load(object sender, EventArgs e)
        {
            //Style
            btnSave.BackColor =ColorTranslator.FromHtml("#033594");
            btnSearch.BackColor =ColorTranslator.FromHtml("#033594");

            gbCall.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));
            gbNotes.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));
            gpInformation.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));

            pnlBottom.BackColor = ColorTranslator.FromHtml("#033594");
            pnlTop.BackColor = ColorTranslator.FromHtml("#033594");
            btnMinimize.BackColor = ColorTranslator.FromHtml("#033594");
            btnClose.BackColor = ColorTranslator.FromHtml("#033594");


            txtPhoneNo.Enabled = false;  
            date = DateTime.Today.ToString("d");
            lblDate.Text = date;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CCMain menu = new CCMain(empID);
            menu.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tmrCallDuration_Tick(object sender, EventArgs e)
        {
            seconds++;
            
                if (seconds > 59)
                {
                    minutes++;
                    seconds = 0;

                }
                if (minutes > 59)
                {
                    hours++;
                    minutes = 0;

                }
            Seconds = (seconds.ToString()).PadLeft(2, '0');
            lblSeconds.Text = Seconds;
            Minutes = (minutes.ToString()).PadLeft(2, '0');
            lblMinutes.Text = Minutes;
            Hours = (hours.ToString()).PadLeft(2, '0');
            lblHours.Text = Hours;

        }
        
        private void lblSeconds_Click(object sender, EventArgs e)
        {  
        }

        private void lblMinutes_Click(object sender, EventArgs e)
        {
        }

        private void lblHours_Click(object sender, EventArgs e)
        {
        }
        //tmrCallDuration.Stop();
        private void btnEndCall_Click(object sender, EventArgs e)
        {
            
            tmrCallDuration.Stop();
        }
        string cusName;
        string cusSurname;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ID = txtCustomerID.Text;
            DataTable Cdata = new CallCentreManagememnt().SearchCus(ID);
            rtbNotes.Text = Cdata.ToString();
            DataView dv = new DataView(Cdata);
            dv.RowFilter = string.Format("CusID LIKE '%{0}%'", ID);
            dgvDisplay.DataSource = dv;
            if (dv.Count>0)
            {
                txtPhoneNo.Text = dgvDisplay.Rows[0].Cells[4].Value.ToString();
                cusName = dgvDisplay.Rows[0].Cells[1].Value.ToString();
                cusSurname = dgvDisplay.Rows[0].Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("This customer ID doesn't exist.", "Error!", MessageBoxButtons.OK);
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string CallID;
            char[] str = new char[3] { 'E', 'F', 'G' };
            Random al = new Random();
            Random num = new Random();

            int randomChar = al.Next(0, 2);
            int randomNum = num.Next(1000, 99999);

            CallID = (str[randomChar].ToString() + randomNum.ToString()).PadLeft(6, '0');
           

            string duration= Hours+":"+Minutes+":"+Seconds;
            string log= date;
            string cusID= dgvDisplay.Rows[0].Cells[0].Value.ToString(); 
            string notes=rtbNotes.Text;
            
            new CallCentreManagememnt().SaveCallInformation(cusID,CallID,duration,log,notes);
            new CallCentreManagememnt().EmpCall(empID,CallID);
            MessageBox.Show("Call ID: " + CallID + "\nDuration: " + duration + "\nHas been Saved to the database");
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void dgvDisplay_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDisplay.SelectedCells.Count>0)
            {
                int selectedIndex = dgvDisplay.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvDisplay.Rows[selectedIndex];
                txtPhoneNo.Text = Convert.ToString(selectedRow.Cells[4].Value);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void dgvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cusID;
            if (cmbPurpose.SelectedItem.ToString()=="Technical"&& dgvDisplay.SelectedCells.Count > 0)
            {
                
                    int selectedIndex = dgvDisplay.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvDisplay.Rows[selectedIndex];
                    cusID = Convert.ToString(selectedRow.Cells[0].Value);
                
                frmTechnical t = new frmTechnical(cusID);
                t.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tmrCallDuration.Start();
        }

        private void gpInformation_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            CCMain c = new CCMain(empID);
            c.Show();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            tmrCallDuration.Stop();
        }
    }
}
