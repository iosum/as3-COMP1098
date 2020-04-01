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
        ProductsModel productDb = new ProductsModel();

        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productContext.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.productContext.Products);
            try
            {
                var productList = (from product in productDb.Products
                                   select product).ToList();

                foreach (var product in productList)
                {
                    Debug.WriteLine(product.Cost);
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message); ;
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int rowIndex = productDataGridView.CurrentRow.Index;
            int currentId = (int)productDataGridView.Rows[rowIndex].Cells[0].Value;

            try
            {
                var selectedName = (from product in productDb.Products
                                    where product.ID == currentId
                                    select product).FirstOrDefault();
                Debug.WriteLine(selectedName.Model);
                selectionTextBox.Text = selectedName.MFG + " " + selectedName.Model + "Priced at : " + selectedName.Cost;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message); 
            }
        }

        private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = productDataGridView.CurrentRow.Index;
            productDataGridView.Rows[rowIndex].Selected = true;
        }
    }
}
