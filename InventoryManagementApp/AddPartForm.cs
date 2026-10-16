using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementApp
{
    public partial class AddPartForm : Form
    {
        private Form1 _form1;
        public int rowID = 0;
        public AddPartForm(Form1 form1)
        {
            InitializeComponent();
            AddPartIdTextBox.Enabled = false;
            _form1 = form1;

        }

        private void AddPartForm_Load(object sender, EventArgs e)
        {

            if (_form1.inventory.AllParts.Count == 0)
            {
                rowID = 1;
                AddPartIdTextBox.Text = rowID.ToString();
            }
            else
            {
                rowID = _form1.inventory.AllParts.Max(x => x.PartId) + 1;
                AddPartIdTextBox.Text = rowID.ToString();
            }
        }

        private void AddPartComLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddPartMaxLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddPartInvLabel_Click(object sender, EventArgs e)
        {

        }

        private void InhouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (InhouseRadioButton.Checked == true)
            {
                AddPartComLabel.Text = "Machine ID";
            }
            else
            {
                AddPartComLabel.Text = "Company name";
            }
        }

        private void AddPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPartSaveButton_Click(object sender, EventArgs e)
        {
            if (_form1.inventory.AllParts.Count == 0)
            {
                rowID = 1;
            }
            else
            {
                rowID = _form1.inventory.AllParts.Max(x => x.PartId) + 1;
            }

            switch(InhouseRadioButton.Checked)
            {
                case true:
                    Inhouse _part = new Inhouse
                    {
                        PartId = rowID,
                        Name = AddPartNameTextBox.Text,
                        Price = decimal.Parse(AddPartPriceTextBox.Text),
                        InStock = int.Parse(AddPartInvTextBox.Text),
                        Min = int.Parse(AddPartMinTextBox.Text),
                        Max = int.Parse(AddPartMaxTextBox.Text),
                        MachineID = int.Parse(AddPartCompTextBox.Text)

                    };
                    
                    
                    if (_part.InStock < _part.Min || _part.InStock > _part.Max)
                    {
                        MessageBox.Show("Please enter a valid Inventory quantity.");

                    }
                    else
                    {
                        _form1.inventory.AddPart(_part);
                        this.Close();
                    }
                    break;

                case false:
                    OutSourced _outPart = new OutSourced
                    {
                        PartId = rowID,
                        Name = AddPartNameTextBox.Text,
                        Price = decimal.Parse(AddPartPriceTextBox.Text),
                        InStock = int.Parse(AddPartInvTextBox.Text),
                        Min = int.Parse(AddPartMinTextBox.Text),
                        Max = int.Parse(AddPartMaxTextBox.Text),
                        CompanyName = AddPartCompTextBox.Text,
                    };
                    
                    if (_outPart.InStock < _outPart.Min || _outPart.InStock > _outPart.Max)
                    {
                        MessageBox.Show("Please enter a valid Inventory quantity.");

                    }
                    else
                    {
                        _form1.partsDataGrid.CurrentRow.Cells[7].Value = AddPartCompTextBox.Text;
                        _form1.inventory.AddPart(_outPart);
                        this.Close();
                    }
                    break;
            }


            //MessageBox.Show(_form1.inventory.AllParts.Count.ToString());
            


            
        }

        private void AddPartIdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(AddPartIdTextBox.Text, out int partId))
            {
                MessageBox.Show("no worky");
            }
        }

        private void AddPartInvTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPartMaxTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPartMinTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPartInvTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(AddPartInvTextBox.Text))
            {
                e.Cancel = true;
                AddPartInvTextBox.Focus();
                errorProvider1.SetError(AddPartInvTextBox, "Inventory cannot be empty.");
            }
            if (!int.TryParse(AddPartInvTextBox.Text, out int inv))
            {
                e.Cancel = true;
                AddPartInvTextBox.Focus();
                errorProvider1.SetError(AddPartInvTextBox, "Inventory must be a number.");

            }

        }

        private void AddPartNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(AddPartNameTextBox.Text))
            //{
            //    e.Cancel = true;
            //    AddPartNameTextBox.Focus();
            //    errorProvider1.SetError(AddPartNameTextBox, "Part name cannot be empty.");
            //}
        }

        private void AddPartPriceTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(!int.TryParse(AddPartPriceTextBox.Text, out int price))
            {
                e.Cancel= true;
                AddPartPriceTextBox.Focus();
                errorProvider1.SetError(AddPartPriceTextBox, "Price must be an int");
            }
        }
    }
}
