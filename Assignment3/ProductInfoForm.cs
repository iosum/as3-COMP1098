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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader fileReader = new StreamReader(openFileDialog.FileName);
                    for(int i = 0; i < productDetails.Count; i++)
                    {
                        productDetails.Add(fileReader.ReadLine());
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
                    for (int i = 0; i < productDetails.Count; i++)
                    {
                        fileWriter.WriteLine(productDetails[i]);
                    }

                    fileWriter.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("save file error : " + ex.Message);
                }
            }
        }
    }
}
