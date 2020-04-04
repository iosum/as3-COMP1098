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
    public partial class ProductInfoForm : Form
    {

        private List<string> productDetails;

        public SelectForm selectForm { get; set; }

        public ProductInfoForm(List<string> productDetails)
        {
            InitializeComponent();

            fillProductInfo(productDetails);
        }

        private void fillProductInfo(List<string> productDetails)
        {
            productIdTextBox.Text = productDetails[0];
            costTextBox.Text = productDetails[1];
            manufacturerTextBox.Text = productDetails[2];
            modelTextBox.Text = productDetails[3];
            memoryTextBox.Text = productDetails[4];
            lcdSizeTextBox.Text = productDetails[5];
            cpuBrandTextBox.Text = productDetails[6];
            cpuTypeTextBox.Text = productDetails[7];
            cpuNumberTextBox.Text = productDetails[8];
            cpuSpeedTextBox.Text = productDetails[9];
            conditionTextBox.Text = productDetails[10];
            platformTextBox.Text = productDetails[11];
            osTextBox.Text = productDetails[12];
            hddTextBox.Text = productDetails[13];
            gpuTextBox.Text = productDetails[14];
            webCamTextBox.Text = productDetails[15];
        }
    }
}
