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
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader fileReader = new StreamReader(openFileDialog.FileName);
                    for(int i = 0; i < this.productDetails.Count; i++)
                    {
                        this.productDetails.Add(fileReader.ReadLine());
                    }
                    fileReader.Close();
                    fillProductInfo();
                }
                catch(Exception ex)
                {
                    Debug.WriteLine("file errors" + ex.Message);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter fileWriter = new StreamWriter(saveFileDialog.FileName);
                    for (int i = 0; i < this.productDetails.Count; i++)
                    {
                        fileWriter.WriteLine(this.productDetails[i]);
                    }

                    fileWriter.Close();
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
