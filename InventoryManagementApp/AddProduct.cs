using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementApp
{
    public partial class AddProduct : Form
    {

        private Form1 _form1;
        private BindingList<Part> pendAssPart;



        public AddProduct(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            pendAssPart = new BindingList<Part>();
            AllPartsDataGrid.DataSource = _form1.inventory.AllParts;
            AssPartGridView.DataSource = pendAssPart;

        }
        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void AllPartsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var selectedItem = AllPartsDataGrid.CurrentRow.DataBoundItem;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddProdIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProdNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProdInvTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProdPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProdMinTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProdSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AddProdSearchBox.Text))
            {
                AllPartsDataGrid.DataSource = _form1.inventory.AllParts;
            }

        }

        private void AllProdSearchButton_Click(object sender, EventArgs e)
        {
            Inventory partSearch = new Inventory();
            partSearch.AddPart(_form1.inventory.LookupPart(int.Parse(AddProdSearchBox.Text)));
            AllPartsDataGrid.DataSource = partSearch;
        }

        private void AddProdSaveButton_Click(object sender, EventArgs e)
        {
            Product prod = new Product
            {
                ProductID = int.Parse(AddProdIdTextBox.Text),
                Price = decimal.Parse(AddProdPriceTextBox.Text),
                Name = AddProdNameTextBox.Text.ToString(),
                InStock = int.Parse(AddProdInvTextBox.Text),
                Min = int.Parse(AddProdMinTextBox.Text),
                Max = int.Parse(AddProdMinTextBox.Text)

            };

            if (AssPartGridView.Columns.Count > 0)
            {
                foreach (Part part in pendAssPart)
                {
                    // MessageBox.Show();
                    prod.AddAssociatedPart(part);
                }

            }

            _form1.inventory.AddProduct(prod);
            this.Close();

        }

        private void ProdDeleteButton_Click(object sender, EventArgs e)
        {
            if (AssPartGridView.CurrentRow.Cells.Count > 0)
            {
                int selectedPart = int.Parse(AssPartGridView.CurrentRow.Cells[0].Value.ToString());
                foreach(Part part in pendAssPart.ToList())
                {
                    if(selectedPart == part.PartId)
                    {
                        pendAssPart.Remove(part);
                    }
                }
               
            }
        }

        private void ProdAddButton_Click(object sender, EventArgs e)
        {

            if (AllPartsDataGrid.Rows.Count > 0)
            {
                int selectedPart = int.Parse(AllPartsDataGrid.CurrentRow.Cells[0].Value.ToString());
                
                if(!DuplicateValidator(selectedPart))
                {
                    Part newPart = _form1.inventory.LookupPart(selectedPart);
                    pendAssPart.Add(newPart);
                }
                
                
            }
            else
            {
                MessageBox.Show(_form1.inventory.AllParts.ToString());
            }
        }

        private void AddProdCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProdInvLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddProdInvTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(AddProdInvTextBox.Text, out int inv))
            {
                e.Cancel = true;
                AddProdInvTextBox.Focus();
                errorProviderProd.SetError(AddProdInvTextBox, "Inventory must be a number.");
            }

        }

        private void AddProdPriceTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void AddProdSaveButton_Validating(object sender, CancelEventArgs e)
        {


            if (!decimal.TryParse(AddProdPriceTextBox.Text, out decimal price))
            {
                e.Cancel = true;
                errorProviderProd.SetError(AddProdPriceTextBox, "Price must be a number.");
            }

            if (int.TryParse(AddProdMinTextBox.Text, out int min))
            {
                e.Cancel = true;
                errorProviderProd.SetError(AddProdMinTextBox, "Min must be a number.");
            }

            if (int.TryParse(AddProdMaxTextBox.Text, out int max))
            {
                e.Cancel = true;
                errorProviderProd.SetError(AddProdMaxTextBox, "Max must be a number.");
            }



        }

        private void AddProdIdTextBox_Validating(object sender, CancelEventArgs e)
        {
            foreach (Product product in _form1.inventory.Products)
            {
                if (int.Parse(AddProdIdTextBox.Text) == product.ProductID)
                {
                    e.Cancel = true;
                    errorProviderProd.SetError(AddProdIdTextBox, "A product with that ID already exists.");
                }
            }
        }

        private void AssPartGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool DuplicateValidator(int partID)
        {
            foreach (Part part in pendAssPart)
            {
                if (partID == part.PartId)
                {
                    MessageBox.Show("There is already and item with that ID associated with this part.");
                    return true;
                }
                else return false;
            }
            return false;
        }

    }
}
