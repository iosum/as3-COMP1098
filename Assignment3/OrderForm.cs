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
    public partial class OrderForm : Form
    {
        public ProductInfoForm productInfoForm { get; set; }

        public OrderForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Name : Chia-Ying Ho\n v : 1.0 \n Website: dollarcomputers.ca \n Contact : info@dollarcomputers.ca", "About");
        }
    }
}
