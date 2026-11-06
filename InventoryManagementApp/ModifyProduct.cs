using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementApp
{
    public partial class ModifyProduct : Form
    {

        private Form1 _form1;
        public BindingList<Part> pendingAssPart;
        public BindingList<Part> unChanged;
        
        public ModifyProduct(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            AllModPartsGridView.DataSource = _form1.inventory.AllParts;
            ModProdIDTextbox.Enabled = false;
            
            
        }

        private void ModProdIDTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModProdNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModProdInvTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModProdPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModProdMinTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModProdMaxTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModProdAddButton_Click(object sender, EventArgs e)
        {
            if (AllModPartsGridView.Rows.Count > 0)
            {
                int selectedPart = int.Parse(AllModPartsGridView.CurrentRow.Cells[0].Value.ToString());

                if (!DuplicateValidator(selectedPart))
                {
                    Part newPart = _form1.inventory.LookupPart(selectedPart);
                    pendingAssPart.Add(newPart);
                }


            }
            else
            {
                MessageBox.Show("There are no parts selected.");
            }
        }

        private void AllModProdProdSearchButton_Click(object sender, EventArgs e)
        {
            Inventory partSearch = new Inventory();
            partSearch.AddPart(_form1.inventory.LookupPart(int.Parse(ModProdSearchTextBox.Text)));
            AllModPartsGridView.DataSource = partSearch.AllParts;

        }

        private void ModProdSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(ModProdSearchTextBox.Text))
            {
                AllModPartsGridView.DataSource = _form1.inventory.AllParts;
            }
        }

        private void ModProdDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ModAssPartGridView.CurrentRow.Cells.Count > 0)
                {
                    Product prod = _form1.inventory.LookupProduct(int.Parse(ModProdIDTextbox.Text.ToString()));
                    int selectedPart = int.Parse(ModAssPartGridView.CurrentRow.Cells[0].Value.ToString());
                    foreach (Part part in pendingAssPart.ToList())
                    {
                        if(part.PartId == selectedPart && prod.RemoveAssociatedPart(selectedPart))
                        {
                            var confirm = MessageBox.Show("Are you sure you want to delete the associated part?", "Confirm Choice", MessageBoxButtons.YesNo);
                            if (confirm == DialogResult.Yes)
                            {
                                MessageBox.Show("something was here");
                                pendingAssPart.Remove(part);
                            }
                        }
                    }
                }
            }
            catch(Exception except)
            {
                MessageBox.Show("There are no associated parts to delete.");
            }
        }

        private void ModProdSaveButton_Click(object sender, EventArgs e)
        {
            Product modProd = new Product
            {
                Name = ModProdNameTextBox.Text,
                InStock = int.Parse(ModProdInvTextBox.Text.ToString()),
                Max = int.Parse(ModProdMaxTextBox.Text.ToString()),
                Min = int.Parse(ModProdMinTextBox.Text.ToString()),
                Price = decimal.Parse(ModProdPriceTextBox.Text.ToString()),
                assPart = pendingAssPart
            };
            _form1.inventory.UpdateProduct(int.Parse(ModProdIDTextbox.Text.ToString()), modProd);



            this.Close();


        }

        private void ModProdCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModProdIDTextbox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void ModProdNameTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private bool DuplicateValidator(int partID)
        {
            foreach (Part part in pendingAssPart)
            {
                if (partID == part.PartId)
                {
                    MessageBox.Show("There is already and item with that ID associated with this part.");
                    return true;
                }
            }
            return false;
        }
    }
}
