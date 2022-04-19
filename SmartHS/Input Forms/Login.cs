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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

           string EmployeeID = txtEmployeeID.Text;
           string Password = txtPassword.Text;
           int rowsChanged= new Admin().Login(EmployeeID,Password);

            if (rowsChanged == 1)
            {
                if (EmployeeID.Contains("CC"))
                {
                    CCMain ccMenu = new CCMain(EmployeeID);
                    this.Hide();
                    ccMenu.Show();
                }
                if (EmployeeID.Contains("CM"))
                {
                    ContractManagement cMenu = new ContractManagement(EmployeeID);
                    this.Hide();
                    cMenu.Show();
                }
                if (EmployeeID.Contains("TM"))
                {
                    TMain tMenu = new TMain(EmployeeID);
                    this.Hide();
                    tMenu.Show();
                }
                if (EmployeeID.Contains("TE"))
                {
                    TechnicalSupportView t = new TechnicalSupportView(EmployeeID);
                    this.Hide();
                    t.Show();
                }
                if (EmployeeID.Contains("PM"))
                {
                    PMMain pMenu = new PMMain(EmployeeID);
                    this.Hide();
                    pMenu.Show();
                }
                if (EmployeeID.Contains("AA"))
                {
                    AdminMain aMenu = new AdminMain(EmployeeID);
                    this.Hide();
                    aMenu.Show();
                }
            }
            else 
            {
                MessageBox.Show("EmployeeID/Password incorrect");
            
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Styling
            btnLogin.BackColor = ColorTranslator.FromHtml("#033594");
            pnlBottom.BackColor = ColorTranslator.FromHtml("#033594");
            pnlTop.BackColor = ColorTranslator.FromHtml("#033594");
            btnMinimize.BackColor = ColorTranslator.FromHtml("#033594");
            btnClose.BackColor = ColorTranslator.FromHtml("#033594");
            panel1.BackColor = Color.FromArgb(160, ColorTranslator.FromHtml("#033594"));
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

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
