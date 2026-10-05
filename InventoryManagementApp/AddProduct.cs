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
        public AddProduct()
        {
            InitializeComponent();
        }
        DataTable dataTable = new DataTable();
        private void AddProduct_Load(object sender, EventArgs e)
        {
            dataTable.Columns["Part ID"].AutoIncrement = true;
            dataTable.Columns["Part ID"].AutoIncrementSeed = 1;
        }

        private void AllPartsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
