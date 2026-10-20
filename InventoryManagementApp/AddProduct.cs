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

        }

        private void AllProdSearchButton_Click(object sender, EventArgs e)
        {

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

        private void ProdAddButton_Click(object sender, EventArgs e)
        {



            if (AllPartsDataGrid.Rows.Count > 0)
            {
                var selectedPart = int.Parse(AllPartsDataGrid.CurrentRow.Cells[0].Value.ToString());
                var newPart = _form1.inventory.LookupPart(selectedPart);
                pendAssPart.Add(newPart);
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
    }
}
