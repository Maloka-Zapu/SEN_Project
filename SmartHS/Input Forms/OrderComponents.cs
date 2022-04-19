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
using BusinessLogic.Product_Management_Department;

namespace SmartHS
{
    public partial class OrderComponents : Form
    {
        string empID;
        public OrderComponents(string eID)
        {
            InitializeComponent();
            empID = eID;
        }
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        DataTable dt = new DataTable();
        DataView dvc = new DataView();
        int q1, q2, q3, q4, q5, q6, q7, q8, q9 = 0;
        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            PMMain p = new PMMain(empID);
            p.Show();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstOrderList.Items.Remove(lstOrderList.SelectedItem);
        }

        private void OrderComponents_Load(object sender, EventArgs e)
        {
            //Style
            btnAddToOrder.BackColor = ColorTranslator.FromHtml("#033594");
            btnRemove.BackColor = ColorTranslator.FromHtml("#033594");
            btnOrderComponent.BackColor = ColorTranslator.FromHtml("#033594");

            gbProduct.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));
            gbOrder.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));
            gbComponents.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));

            pnlBottom.BackColor = ColorTranslator.FromHtml("#033594");
            pnlTop.BackColor = ColorTranslator.FromHtml("#033594");
            btnMinimize.BackColor = ColorTranslator.FromHtml("#033594");
            btnClose.BackColor = ColorTranslator.FromHtml("#033594");

            DataTable Cdata = new Product_Management().DisplayProductTable();
            DataView dv = new DataView(Cdata);
            for (int i = 0; i < dv.Count; i++)
            {
                cmbProducts.Items.Add(dv[i]["SuiteName"]);
            }
        }
        string ID;
        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbProducts.SelectedItem.ToString() == "Home Energy Management System")
            {
                lstSearchResults.Items.Clear();
                ID = "1";
            }
            if (cmbProducts.SelectedItem.ToString() == "Home Safety Management System")
            {
                lstSearchResults.Items.Clear();
                ID = "2";
            }
            if (cmbProducts.SelectedItem.ToString() == "Home Convenience Management System")
            {
                lstSearchResults.Items.Clear();
                ID = "3";
            }
            dt = new Product_Management().DisplayComponentTable(ID);
            dvc = new DataView(dt);
            for (int i = 0; i < dvc.Count; i++)
            {
                
                lstSearchResults.Items.Add(dvc[i]["SerialNo"]+""+dvc[i]["Name"]);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dt = new Product_Management().DisplayComponentTable(ID);
            dvc = new DataView(dt);
            string comID = txtSearch.Text;
            dvc.RowFilter = string.Format("SerialNo LIKE '%{0}%'", comID);
            lstSearchResults.Items.Clear();
            lstSearchResults.Items.Add(dvc[0]["SerialNo"] + "" + dvc[0]["Name"]);
        }

        private void lstSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTable searchResults = new Product_Management().DisplayComponentTable(ID);
            DataView resultView = new DataView(searchResults);
            string component = lstSearchResults.SelectedItem.ToString();

            dvc.RowFilter = string.Format("Name LIKE '%{0}%'", component);
            txtType.Text = resultView[lstSearchResults.SelectedIndex]["Type"].ToString();
            txtName.Text = resultView[lstSearchResults.SelectedIndex]["Name"].ToString();
            txtQuantity.Text = "";

        }
        
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Please add the quantity of components you would like to order.");
            }
            else 
            { lstOrderList.Items.Add(txtName.Text + "-" + txtQuantity.Text); }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstOrderList.Items.Count==0)
            {
                MessageBox.Show("Please select Components to order");
            }
            else
            {
                for (int i = 0; i < lstOrderList.Items.Count; i++)
                {
                    string[] calculation = lstOrderList.Items[i].ToString().Split('-');
                    if (calculation[0] == "Motion Sensor")
                    {
                        q1 = q1 + Convert.ToInt32(calculation[1]);
                    }
                    else if (calculation[0] == "Smoke Detector")
                    {
                        q2 = q2 + Convert.ToInt32(calculation[1]);
                    }

                    else if (calculation[0] == "Camera")
                    {
                        q3 = q3 + Convert.ToInt32(calculation[1]);
                    }

                    else if (calculation[0] == "Alarm")
                    {
                        q4 = q4 + Convert.ToInt32(calculation[1]);
                    }

                    else if (calculation[0] == "Home Safety Software")
                    {
                        q5 = q5 + Convert.ToInt32(calculation[1]);
                    }

                    else if (calculation[0] == "Home Energy Software")
                    {
                        q6 = q6 + Convert.ToInt32(calculation[1]);
                    }

                    else if (calculation[0] == "Home Convenience Software")
                    {
                        q7 = q7 + Convert.ToInt32(calculation[1]);
                    }

                    else if (calculation[0] == "Monitors")
                    {
                        q8 = q8 + Convert.ToInt32(calculation[1]);
                    }

                    else if (calculation[0] == "Curtain Drawers")
                    {
                        q9 = q9 + Convert.ToInt32(calculation[1]);
                    }

                }
                new Product_Management().OrderC(q1, q2, q3, q4, q5, q6, q7, q8, q9);
                MessageBox.Show("Order Has Been Processed!");
                lstOrderList.Items.Clear();
                txtName.Text = "";
                txtQuantity.Text = "";
                txtSearch.Text = "";
                txtType.Text = "";
                q1 = 0;
                q2 = 0;
                q3 = 0;
                q4 = 0;
                q5 = 0;
                q6 = 0;
                q7 = 0;
                q8 = 0;
                q9 = 0;

            }

        }
    }
}
