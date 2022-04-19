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
    public partial class TechSupport : Form
    {
        DataTable technicians = new DataTable();
        DataView t = new DataView();
        string empID;
        public TechSupport(string EID)
        {
            InitializeComponent();
            empID = EID;
        }
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TechSupport_Load(object sender, EventArgs e)
        {
            //Style
            btnSearch.BackColor = ColorTranslator.FromHtml("#033594");
            btnView.BackColor = ColorTranslator.FromHtml("#033594");
            btnAssign.BackColor = ColorTranslator.FromHtml("#033594");
            btnChange.BackColor = ColorTranslator.FromHtml("#033594");



            gbAllocation.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));
            gbStatus.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));


            pnlBottom.BackColor = ColorTranslator.FromHtml("#033594");
            pnlTop.BackColor = ColorTranslator.FromHtml("#033594");
            btnMinimize.BackColor = ColorTranslator.FromHtml("#033594");
            btnClose.BackColor = ColorTranslator.FromHtml("#033594");

            vj = new DataView(viewJob);
            vj.RowFilter = string.Format("Status LIKE '%{0}%'", "Unassigned");
            for (int i = 0; i < vj.Count; i++)
            {
                cmbUnassigned.Items.Add(vj[i].Row["JobID"]);
            }
            rtbJobInformtion.Enabled = false;
            technicians = new Technical_Management().DisplayTechnicians();
            t = new DataView(technicians);
            for (int i = 0; i < t.Count; i++)
            {
                cmbTechnicians.Items.Add(t[i].Row["EmpID"]);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string ChangeStatus = cmbStatus.SelectedItem.ToString();
            new Technical_Management().UpdateJobStatus(txtSearch.Text,ChangeStatus,"-");
            MessageBox.Show("Job Status Changed to: "+ ChangeStatus);


            string date = DateTime.Today.ToString("d");
           

            if (ChangeStatus=="Completed")
            {
                new Technical_Management().UpdateJobStatus(txtSearch.Text, ChangeStatus, date);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TechnicalSupportView tsv = new TechnicalSupportView(empID);
            tsv.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string date;
        private void button1_Click(object sender, EventArgs e)
        {

            string JobID = cmbUnassigned.SelectedItem.ToString();
           
            string Description = rtbDescription.Text;
            string Status = "Assigned";
            string JobStatus = Status;
            string JobType = txtType.Text;


            new Technical_Management().AssignJob(JobID,  cmbTechnicians.SelectedItem.ToString(),JobType,JobStatus,Description, date);
            new Technical_Management().Emp_Job(empID, JobID);
            MessageBox.Show("Job: "+JobID+" has been assigned to "+txtTechnicianName.Text);
            rtbDescription.Text = "";
            cmbTechnicians.Text = "";
            txtTechnicianName.Text = "";
            cmbUnassigned.Text = "";
            txtType.Text = "";

        }

        private void cmbTechnicians_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTechnicianName.Text = t[cmbTechnicians.SelectedIndex].Row["FirstName"] + " " + t[cmbTechnicians.SelectedIndex].Row["Surname"];
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        DataTable viewJob = new Technical_Management().DisplayJobs();
        DataView vj = new DataView();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            vj = new DataView(viewJob);
            vj.RowFilter = string.Format("JobID LIKE '%{0}%'", txtSearch.Text);

            rtbJobInformtion.Text = "" 
                +"JobID: "+vj[0]["JobID"].ToString()+"\n"
                + "Assigned To: " + vj[0]["EmpID"].ToString() + "\n"
                + "Job Type: " + vj[0]["JobType"].ToString() + "\n"
                + "Status: " + vj[0]["Status"].ToString() + "\n"
                + "Description: " + vj[0]["Description"].ToString() + "\n\n"
                + "Date Assigned: " + vj[0]["Date"].ToString() + "\n";

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbUnassigned_SelectedIndexChanged(object sender, EventArgs e)
        {
            vj = new DataView(viewJob);
            vj.RowFilter = string.Format("JobID LIKE '%{0}%'", cmbUnassigned.SelectedItem.ToString());

            txtType.Text = vj[0]["JobType"].ToString();
            rtbDescription.Text = vj[0]["Description"].ToString();
            date= vj[0]["Date"].ToString();


        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            TMain tm = new TMain(empID);
            tm.Show();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
