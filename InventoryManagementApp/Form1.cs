using System.ComponentModel;
using System.Data;
using System.Xml.Serialization;

namespace InventoryManagementApp
{
    public partial class Form1 : Form
    {

        public Inventory inventory = new Inventory();
        public Form1()
        {
            InitializeComponent();
            partsDataGrid.DataSource = inventory.AllParts;
            prodDataGrid.DataSource = inventory.Products;

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
            AddPartForm addPart = new AddPartForm(this);
            addPart.ShowDialog();

        }

        private void PartModifyButton_Click(object sender, EventArgs e)
        {
            if (partsDataGrid.Rows.Count > 0)
            {
                ModifyPart modPart = new ModifyPart(this);
                modPart.ModIDTextBox.Text = partsDataGrid.CurrentRow.Cells[0].Value.ToString();
                modPart.ModNameTextBox.Text = partsDataGrid.CurrentRow.Cells[1].Value.ToString();
                modPart.ModPriceTextBox.Text = partsDataGrid.CurrentRow.Cells[2].Value.ToString();
                modPart.InvLabelTextBox.Text = partsDataGrid.CurrentRow.Cells[3].Value.ToString();
                modPart.ModPartMinTextbox.Text = partsDataGrid.CurrentRow.Cells[4].Value.ToString();
                modPart.ModPartMaxTextbox.Text = partsDataGrid.CurrentRow.Cells[5].Value.ToString();

                modPart.Show();
            }
            else MessageBox.Show("No Selected Part.");
        }

        private void ProdAddButton_Click(object sender, EventArgs e)
        {
            AddProduct addProd = new AddProduct(this);
            addProd.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //Deletes the selected row of the parts data grid
        private void PartDeleteButton_Click(object sender, EventArgs e)
        {
            if (partsDataGrid.SelectedRows.Count > 0)
            {
                inventory.DeletePart(
                    inventory.LookupPart(
                        int.Parse(partsDataGrid.CurrentRow.Cells[0].Value.ToString())
                ));
            }
        }

        //Does the same as the part delete button.
        private void ProdDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodDataGrid.SelectedRows.Count > 0)
                {
                    int selecedProd = int.Parse(prodDataGrid.CurrentRow.Cells[0].Value.ToString());
                    Product delProd = inventory.LookupProduct(selecedProd);

                    switch (inventory.RemoveProduct(selecedProd))
                    {
                        case true:
                            inventory.Products.Remove(delProd);
                            //MessageBox.Show("Selected Product was Deleted.");
                            break;
                        case false:
                            MessageBox.Show("Could not find part");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("There are no products to delete, or no row is selected.");
                }
            }

            catch (Exception execpt)
            {
                MessageBox.Show(execpt.Message);
            }
            
        }
        //Search through the list
        private void PartsSearchButton_Click(object sender, EventArgs e)
        {
            Inventory searchInv = new Inventory();
            searchInv.AddPart(inventory.LookupPart(int.Parse(PartsTextbox.Text)));
            partsDataGrid.DataSource = searchInv.AllParts;
        }
        //Removes search condition if the search text box is empty
        private void PartsTextbox_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(PartsTextbox.Text))
            {
                partsDataGrid.DataSource = inventory.AllParts;
            }
        }
    }

    public class Inventory
    {
        //Product and AllParts properties for the Inventory class
        private BindingList<Product> products;
        private BindingList<Part> allParts;

        public BindingList<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        public BindingList<Part> AllParts
        {
            get { return allParts; }
            set { allParts = value; }
        }

        //inventory constuctor
        public Inventory()
        {
            products = new BindingList<Product>();
            allParts = new BindingList<Part>();
        }

        /////////Methods//////////////////////////////////////////////////////

        public void AddProduct(Product product)
        {
            products.Add(product);

        }

        public bool RemoveProduct(int id)
        {
            foreach(Product prod in products)
            {
                if (id == prod.ProductID)
                {
                    
                    return true;
                }
                else if (id != prod.ProductID)
                {
                    return false;
                }
                else return false;
            }
            return false;
        }

        public Product? LookupProduct(int id)
        {
            
            foreach (Product prod in products)
            {
                if(id == prod.ProductID)
                {
                    return prod;
                }

                else { return null; }
            }

            return null;

        }

        public void UpdateProduct(int id, Product product)
        {
            
            foreach(Product prod in products)
            {
                if(id == prod.ProductID)
                {
                    prod.Name = product.Name;
                    prod.InStock = product.InStock;
                    prod.Max = product.Max;
                    prod.Min = product.Min;
                    prod.Price = product.Price;
                }
            }

        }

        public void AddPart(Part part)
        {
            
            allParts.Add(part); 
            
        }

        public bool DeletePart(Part part)
        {
           foreach(Part del in AllParts)
            {
                if (part == del)
                {
                    AllParts.Remove(del);
                    return true;
                }
                
            }
           return false;

        }

        public Part? LookupPart(int id)
        {
            foreach(Part part in AllParts)
            {
                if (id == part.PartId)
                {
                    return part;
                }
                
            }
            return null;
            
        }

        public void UpdatePart(int id, Part part)
        {
            foreach(Part modPart in AllParts)
            {
                if (id == modPart.PartId)
                {
                    modPart.InStock = part.InStock;
                    modPart.Name = part.Name;
                    modPart.Max = part.Max;
                    modPart.Min = part.Min;
                    modPart.InStock = part.InStock;
                }

            }
        }

    }

    public class Product
    {
        //AssosiatedParts property for the Product class.
        private BindingList<Part> AssociatedParts;
        public BindingList<Part> assPart
        {
            get { return AssociatedParts; }
            set { AssociatedParts = value; }
        }

        public Product()
        {
            AssociatedParts = new BindingList<Part>();
        }
        // other Product class properties that use auto-implementation.
        public int ProductID { get; set; }
        public string Name { get; set;  }
        public decimal Price { get; set;  }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        ////////Methods/////////
        
        public void AddAssociatedPart(Part part)
        {
            assPart.Add(part);
        }

        public bool RemoveAssociatedPart(int id)
        {

            foreach(Part part in AssociatedParts)
            {
                if (id == part.PartId)
                {
                    return true;
                }
                else return false;
            };
            return false;
            
        }

        public Part? lookupAssociatedPart(int id)
        {
            foreach(Part part in AssociatedParts)
            {
                if (id == part.PartId)
                {
                    return part;
                }
            };
            return null;

        }

        

    }

    public abstract class Part
    {
        //Part class properties using auto-implementaion

        public int PartId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

    }

    public  class Inhouse : Part
    {
        public int MachineID { get; set; }
    }

    public class OutSourced : Part
    {
        public string CompanyName { get; set; }
    }

}

