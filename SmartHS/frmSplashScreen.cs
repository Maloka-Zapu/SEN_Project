using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHS
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            this.BackColor = Color.Beige;
            this.TransparencyKey = Color.Beige;
        }
        int count = 5;
        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            count--;
            if (count==0)
            {
                tmrSplash.Stop();
                Login l = new Login();
                l.Show();
                this.Hide();
            }
            
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            
            tmrSplash.Start();
            

        }
    }
}
