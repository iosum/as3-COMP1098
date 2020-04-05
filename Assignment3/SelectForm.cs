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

        // references to the forms
        public StartForm startForm { get; set; }
        public ProductInfoForm productInfoForm { get; set; }

        List<string> hardware = new List<string>();


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
            DialogResult dialogResult = MessageBox.Show("Do you want to exit the select form?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            ProductInfoForm productInfoForm = new ProductInfoForm(getSelectedValue());

            productInfoForm.selectForm = this;
            productInfoForm.Show();
            this.Hide();
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          
        }

        private void productDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(productDataGridView.SelectedRows.Count > 0)
            {
                // display selected product details in the selection Text Box
                selectionTextBox.Text = productDataGridView.SelectedCells[2].Value.ToString() + " "
                    + productDataGridView.SelectedCells[3].Value.ToString() + " Priced at: "
                    + productDataGridView.SelectedCells[1].Value.ToString();

                // enable the next button on selection being made
                nextButton.Enabled = true;
            }



        }

        private List<string> getSelectedValue()
        {
            List<string> hardware = new List<string>
            {
                productDataGridView.SelectedRows[0].Cells[0].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[1].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[2].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[3].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[4].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[5].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[6].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[7].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[8].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[9].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[10].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[11].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[12].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[13].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[14].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[15].Value.ToString()
            };
            

            return hardware;
        }
    }
}
