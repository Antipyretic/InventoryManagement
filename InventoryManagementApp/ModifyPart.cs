using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementApp
{
    public partial class ModifyPart : Form
    {
        private Form1 _form1;

        public ModifyPart(Form1 form1)
        {
            InitializeComponent();
            ModIDTextBox.Enabled = false;
            _form1 = form1;
        }

        private void ModifyPart_Load(object sender, EventArgs e)
        {
            
        }

        private void AddPartMaxLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddPartComLabel_Click(object sender, EventArgs e)
        {

        }        

        private void ModInhouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ModInhouseRadioButton.Checked == true)
            {
                ModPartComLabel.Text = "Machine ID";
            }
            else
            {
                ModPartComLabel.Text = "Company name";
            }
        }

        private void ModpartOutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ModIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InvLabelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ModPartSaveButton_Click(object sender, EventArgs e)
        {

            

            switch(ModInhouseRadioButton.Checked)
            {
                case true:
                    Inhouse inhousePart = new Inhouse
                    {
                        PartId = int.Parse(ModIDTextBox.Text),
                        Name = ModNameTextBox.Text,
                        Price = decimal.Parse(ModPriceTextBox.Text),
                        InStock = int.Parse(InvLabelTextBox.Text),
                        Min = int.Parse(ModPartMinTextbox.Text),
                        Max = int.Parse(ModPartMaxTextbox.Text),
                        MachineID = int.Parse(ModPartCompTextbox.Text)

                    };
                    _form1.inventory.UpdatePart(inhousePart.PartId, inhousePart);
                    break;
                case false:
                    OutSourced outSourcePart = new OutSourced
                    {
                        PartId = int.Parse(ModIDTextBox.Text),
                        Name = ModNameTextBox.Text,
                        Price = decimal.Parse(ModPriceTextBox.Text),
                        InStock = int.Parse(InvLabelTextBox.Text),
                        Min = int.Parse(ModPartMinTextbox.Text),
                        Max = int.Parse(ModPartMaxTextbox.Text),
                        CompanyName = ModPartCompTextbox.Text
                    };

                    _form1.inventory.UpdatePart(outSourcePart.PartId, outSourcePart);
                    break;
            }
               

        }

        private void AddPartCancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
