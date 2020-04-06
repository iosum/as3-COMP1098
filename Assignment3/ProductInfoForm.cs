using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        public OrderForm orderForm { get; set; }
        public StartForm startForm { get; set; }

        public ProductInfoForm(List<string> productDetails)
        {
            InitializeComponent();

            if(productDetails == null)
            {
                openToolStripMenuItem.PerformClick();
            }
            else
            {
                this.productDetails = productDetails;
            }
            
            
            fillProductInfo();
        }
        
        public ProductInfoForm()
        {
            InitializeComponent();
            this.openToolStripMenuItem.PerformClick();
        }

        private void fillProductInfo()
        {
            productIdTextBox.Text = this.productDetails[0];
            costTextBox.Text = this.productDetails[1];
            manufacturerTextBox.Text = this.productDetails[2];
            modelTextBox.Text = this.productDetails[3];
            memoryTextBox.Text = this.productDetails[4];
            lcdSizeTextBox.Text = this.productDetails[5];
            cpuBrandTextBox.Text = this.productDetails[6];
            cpuTypeTextBox.Text = this.productDetails[7];
            cpuNumberTextBox.Text = this.productDetails[8];
            cpuSpeedTextBox.Text = this.productDetails[9];
            conditionTextBox.Text = this.productDetails[10];
            platformTextBox.Text = this.productDetails[11];
            osTextBox.Text = this.productDetails[12];
            hddTextBox.Text = this.productDetails[13];
            gpuTextBox.Text = this.productDetails[14];
            webCamTextBox.Text = this.productDetails[15];
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            DialogResult result = this.openFileDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                StreamReader inputStream = new StreamReader(File.Open(openFileDialog.FileName, FileMode.Open));
                try
                {
                    loadProductsFromFile(inputStream);

                }
                catch (Exception ex)
                {
                    Debug.WriteLine("file errors" + ex.Message);
                }
                finally
                {
                    if(inputStream != null)
                    {
                        inputStream.Close();
                    }
                }
            }
            else
            {
                if(productIdTextBox.Text == "0")
                {
                    MessageBox.Show("Please restart your order!", "Load Order Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    StartForm startForm = new StartForm();
                    startForm.Show();
                    this.Hide();
                }
            }

        }

        private void loadProductsFromFile(StreamReader inputStream)
        {
            productIdTextBox.Text = inputStream.ReadLine();
            costTextBox.Text = inputStream.ReadLine();
            manufacturerTextBox.Text = inputStream.ReadLine();
            modelTextBox.Text = inputStream.ReadLine();
            memoryTextBox.Text = inputStream.ReadLine();
            lcdSizeTextBox.Text = inputStream.ReadLine();
            cpuBrandTextBox.Text = inputStream.ReadLine();
            cpuTypeTextBox.Text = inputStream.ReadLine();
            cpuNumberTextBox.Text = inputStream.ReadLine();
            cpuSpeedTextBox.Text = inputStream.ReadLine();
            conditionTextBox.Text = inputStream.ReadLine();
            platformTextBox.Text = inputStream.ReadLine();
            osTextBox.Text = inputStream.ReadLine();
            hddTextBox.Text = inputStream.ReadLine();
            gpuTextBox.Text = inputStream.ReadLine();
            webCamTextBox.Text = inputStream.ReadLine();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter outputStream = new StreamWriter(saveFileDialog.FileName);
                    for (int i = 0; i < this.productDetails.Count; i++)
                    {
                        outputStream.WriteLine(this.productDetails[i]);
                    }

                    outputStream.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("save file error : " + ex.Message);
                }
            }
        }

        private void ProductInfoForm_Click(object sender, EventArgs e)
        {
            Button clickHandler = sender as Button;
            //Debug.WriteLine(clickHandler.Tag.ToString());
            switch(clickHandler.Tag.ToString())
            {
                case "Another":
                    SelectForm selectForm = new SelectForm();
                    selectForm.productInfoForm = this;
                    selectForm.Show();
                    this.Hide();
                    break;

                case "Cancel":
                    DialogResult result = MessageBox.Show("Are You Sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if(result == DialogResult.Yes)
                    {
                        Application.Exit();
                    }

                    break;

                case "Next":
                    OrderForm orderForm = new OrderForm(this.productDetails);
                    orderForm.productInfoForm = this;
                    orderForm.Show();
                    this.Hide();
                    break;
            }
        }

        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectAnotherProductButton.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.cancelButton.PerformClick();
        }
    }
}
