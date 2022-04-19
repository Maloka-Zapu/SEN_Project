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
    public partial class TechnicalSupportView : Form
    {
        public TechnicalSupportView(string eID)
        {
            InitializeComponent();
            empID = eID;
        }
        string empID;
        DataTable viewJobs = new Technical_Management().DisplayJobs();
        DataView vj = new DataView();
        DataView nvj = new DataView();

        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        private void TechnicalSupportView_Load(object sender, EventArgs e)
        {
            //Style
            pnlBottom.BackColor = ColorTranslator.FromHtml("#033594");
            pnlTop.BackColor = ColorTranslator.FromHtml("#033594");
            btnMinimize.BackColor = ColorTranslator.FromHtml("#033594");
            btnClose.BackColor = ColorTranslator.FromHtml("#033594");

            vj = new DataView(viewJobs);

            nvj= new DataView(viewJobs); 

            tvJobs.Nodes.Add("Assigned");
            tvJobs.Nodes.Add("In Progress");
            tvJobs.Nodes.Add("On Hold");
            tvJobs.Nodes.Add("Completed");
            tvJobs.Nodes.Add("Unassigned");


            for (int i = 0; i < vj.Count; i++)
            {
                if (vj[i]["Status"].ToString() == "Assigned")
                {
                    tvJobs.Nodes[0].Nodes.Add(vj[i]["JobID"].ToString());
                }
                else if (vj[i]["Status"].ToString() == "Unassigned")
                {
                    tvJobs.Nodes[0].Nodes.Add(vj[i]["JobID"].ToString());
                }
                else if (vj[i]["Status"].ToString() == "In Progress")
                {
                    tvJobs.Nodes[1].Nodes.Add(vj[i]["JobID"].ToString());
                }
                else if (vj[i]["Status"].ToString() == "On Hold")
                {
                    tvJobs.Nodes[2].Nodes.Add(vj[i]["JobID"].ToString());
                }
                else if (vj[i]["Status"].ToString() == "Completed")
                {
                    tvJobs.Nodes[3].Nodes.Add(vj[i]["JobID"].ToString());
                    
                }

            }
            DataView des = new DataView(viewJobs);
            
            for (int i = 0; i < tvJobs.Nodes[0].GetNodeCount(false); i++)
            {
               
                tvJobs.Nodes[0].Nodes[i].Nodes.Add(vj[i]["JobType"].ToString() + "- By Technician: " + vj[i]["EmpID"].ToString());
                for (int j = 0; j < tvJobs.Nodes[0].Nodes[i].GetNodeCount(false); j++)
                {
                    des.RowFilter = string.Format("JobID Like '%{0}%'" ,tvJobs.Nodes[0].Nodes[i].Text);
                    tvJobs.Nodes[0].Nodes[i].Nodes[j].Nodes.Add(des[0]["Description"].ToString());
                }
            }
            for (int i = 0; i < tvJobs.Nodes[1].GetNodeCount(false); i++)
            {
                tvJobs.Nodes[1].Nodes[i].Nodes.Add(vj[i]["JobType"].ToString() + "- By Technician: " + vj[i]["EmpID"].ToString());
                for (int j = 0; j < tvJobs.Nodes[0].Nodes[i].GetNodeCount(false); j++)
                {
                    des.RowFilter = string.Format("JobID Like '%{0}%'", tvJobs.Nodes[1].Nodes[i].Text);
                    tvJobs.Nodes[1].Nodes[i].Nodes[j].Nodes.Add(des[0]["Description"].ToString());
                }
            }
            for (int i = 0; i < tvJobs.Nodes[2].GetNodeCount(false); i++)
            {
                tvJobs.Nodes[2].Nodes[i].Nodes.Add(vj[i]["JobType"].ToString() + "- By Technician: " + vj[i]["EmpID"].ToString());
                for (int j = 0; j < tvJobs.Nodes[0].Nodes[i].GetNodeCount(false); j++)
                {
                    des.RowFilter = string.Format("JobID Like '%{0}%'", tvJobs.Nodes[2].Nodes[i].Text);
                    tvJobs.Nodes[2].Nodes[i].Nodes[j].Nodes.Add(des[0]["Description"].ToString());
                }
            }
            for (int i = 0; i < tvJobs.Nodes[3].GetNodeCount(false); i++)
            {
                tvJobs.Nodes[3].Nodes[i].Nodes.Add(vj[i]["JobType"].ToString() + "- By Technician: " + vj[i]["EmpID"].ToString());
                for (int j = 0; j < tvJobs.Nodes[0].Nodes[i].GetNodeCount(false); j++)
                {
                    des.RowFilter = string.Format("JobID Like '%{0}%'", tvJobs.Nodes[3].Nodes[i].Text);
                    tvJobs.Nodes[3].Nodes[i].Nodes[j].Nodes.Add(des[0]["Description"].ToString());
                }
            }
            
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

        private void tvJobs_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            if (empID.Contains("TM") || empID.Contains("AA"))
            {
                TMain tm = new TMain(empID);
                tm.Show();
                this.Close();
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
