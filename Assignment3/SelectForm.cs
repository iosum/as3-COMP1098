using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class SelectForm : Form
    {
        // connect to the db
        ProductsContext productDb = new ProductsContext();

        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {

            try
            {
                // select all the products in the Products table of the Products DB
                var productList = (from product in productDb.Products
                                             select product).ToList();
                productDataGridView.DataSource = productList;
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message); ;
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            highlightSelectedRow();
            
        }

        private void highlightSelectedRow()
        {
            int rowIndex = productDataGridView.CurrentRow.Index;
            productDataGridView.Rows[rowIndex].Selected = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit the select form?", "Exit", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.Show();
            this.Hide();
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          
        }

        private void productDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // display selected product details in the selection Text Box
                selectionTextBox.Text = productDataGridView.SelectedCells[2].Value.ToString() + " "
                    + productDataGridView.SelectedCells[3].Value.ToString() + " Priced at: "
                    + productDataGridView.SelectedCells[1].Value.ToString();

                // enable the next button on selection being made
                nextButton.Enabled = true;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }
    }
}
