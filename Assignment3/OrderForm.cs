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
        private List<string> productDetails;

        public OrderForm(List<string> productDetails)
        {
            InitializeComponent();
            this.productDetails = productDetails;
            fillProductInfo();
        }

        private void fillProductInfo()
        {
            manufacturerTextBox.Text = this.productDetails[2];
            modelTextBox.Text = this.productDetails[3];
            conditionTextBox.Text = this.productDetails[10];
            platformTextBox.Text = this.productDetails[11];

          
            productDetailsListBox.Items.Add(productDetails.ElementAt(5));
            productDetailsListBox.Items.Add(""); // blank element for formatting (display purposes)
            productDetailsListBox.Items.Add(productDetails.ElementAt(4));
            productDetailsListBox.Items.Add(""); // blank element for formatting (display purposes)
            productDetailsListBox.Items.Add(productDetails.ElementAt(6));
            productDetailsListBox.Items.Add(""); // blank element for formatting (display purposes)
            productDetailsListBox.Items.Add(productDetails.ElementAt(7));
            productDetailsListBox.Items.Add(""); // blank element for formatting (display purposes)
            productDetailsListBox.Items.Add(productDetails.ElementAt(13));
            productDetailsListBox.Items.Add(""); // blank element for formatting (display purposes)
            productDetailsListBox.Items.Add(productDetails.ElementAt(14));
            productDetailsListBox.Items.Add(""); // blank element for formatting (display purposes)
            productDetailsListBox.Items.Add(productDetails.ElementAt(15));
            productDetailsListBox.Items.Add(""); // blank element for formatting (display purposes)
            productDetailsListBox.Items.Add(productDetails.ElementAt(12));

            // fill the PriceInfoGroupBox
            costTextBox.Text = productDetails[1];
            string cost = productDetails[1].Trim('$');
            double salesTax = Convert.ToDouble(cost) * 0.13;
            double total = Convert.ToDouble(cost) * 1.13;
            salesTaxTextBox.Text = "$" + salesTax.ToString();
            totalTextBox.Text = "$" + total.ToString();


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Name : Chia-Ying Ho\n v : 1.0 \n Website: dollarcomputers.ca \n Contact : info@dollarcomputers.ca", "About");
        }

        private void buttonClickHandler(object sender, EventArgs e)
        {
            Button clickHandler = sender as Button;

            switch(clickHandler.Tag.ToString())
            {
                case "Back":
                    ProductInfoForm productInfoForm = new ProductInfoForm(null);

                    productInfoForm.orderForm = this;

                    productInfoForm.Show();

                    this.Hide();
                    break;

                case "Cancel":

                    DialogResult result = MessageBox.Show("Are You Sure you want to exit?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if(result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                    break;

                case "Finish":

                    DialogResult finish = MessageBox.Show("Thank you for your business." + Environment.NewLine + "Your order will be processed in 7 - 10 business days.", "Thank You!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (finish == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                    break;
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing... Your selection is in process to print.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        
    }
}
