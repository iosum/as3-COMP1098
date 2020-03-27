using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void splashScreenTimer_Tick(object sender, EventArgs e)
        {
            splashScreenTimer.Enabled = false;
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Hide();
        }
    }
}
