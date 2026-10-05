using System.ComponentModel;

namespace InventoryManagementApp
{
    public partial class Form1 : Form
    {

        private Inventory inventory = new Inventory();

        public Form1()
        {
            InitializeComponent();
            partsDataGrid.DataSource = inventory.parts;
            prodDataGrid.DataSource = inventory.products;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void partsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PartAddButton_Click(object sender, EventArgs e)
        {
            AddPartForm addPart = new AddPartForm();
            addPart.Show();
        }

        private void PartModifyButton_Click(object sender, EventArgs e)
        {
            
        }
    }

    public class Inventory
    {
        //Product and AllParts properties for the Inventory class
        private BindingList<Product> Products;
        private BindingList<Part> AllParts;

        public BindingList<Product> products
        {
            get { return Products; }
            set { Products = value; }
        }

        public BindingList<Part> parts
        {
            get { return AllParts; }
            set { AllParts = value; }
        }

        public Inventory()
        {
            Products = new BindingList<Product>();
            AllParts = new BindingList<Part>();
        }

    }

    public class Product
    {
        //AssosiatedParts property for the Product class.
        private BindingList<Part> AssosiatedParts;
        BindingList<Part> assPart
        {
            get { return AssosiatedParts; }
            set { AssosiatedParts = value; }
        }
    }
    
    public class Part
    {

        

    }

}
