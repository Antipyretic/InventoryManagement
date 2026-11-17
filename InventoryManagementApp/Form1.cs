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
            partsDataGrid.DataBindingComplete += partsDataGrid_DataBindingComplete;
            prodDataGrid.DataBindingComplete += partsDataGrid_DataBindingComplete;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void partsDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetColumnHeaders();
        }

        private void SetColumnHeaders()
        {
            if(partsDataGrid.Columns.Contains("Instock"))
            {
                partsDataGrid.Columns["Instock"].HeaderText = "Inventory";
            }
            if (prodDataGrid.Columns.Contains("Instock"))
            {
                prodDataGrid.Columns["Instock"].HeaderText = "Inventory";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PartAddButton_Click(object sender, EventArgs e)
        {
            //Part part = new Inhouse();
            //{
            //    part.PartId = 1;
            //    part.Price = 1;
            //    part.Max = 10;
            //    part.Min = 1;
            //    part.InStock = 1;
            //    part.Name = "partOne";
            //}

            //inventory.AddPart(part);


            AddPartForm addPart = new AddPartForm(this);
            addPart.ShowDialog();

        }

        private void PartModifyButton_Click(object sender, EventArgs e)
        {

            if (partsDataGrid.CurrentRow !=null )
            {
                Part selectedPart = inventory.LookupPart(int.Parse(partsDataGrid.CurrentRow.Cells[0].Value.ToString()));
                ModifyPart modPartForm = new ModifyPart(this);
                if(selectedPart is Inhouse modPart1)                      
                { 
                     modPartForm.ModIDTextBox.Text = modPart1.PartId.ToString();
                     modPartForm.ModNameTextBox.Text = modPart1.Name;
                     modPartForm.ModPriceTextBox.Text = modPart1.Price.ToString();
                     modPartForm.InvLabelTextBox.Text = modPart1.InStock.ToString();
                     modPartForm.ModPartMinTextbox.Text = modPart1.Min.ToString();
                     modPartForm.ModPartMaxTextbox.Text = modPart1.Max.ToString();
                     modPartForm.ModPartCompTextbox.Text = modPart1.MachineID.ToString();
                     modPartForm.ModInhouseRadioButton.Checked = true;
                }
                if(selectedPart is OutSourced modPart2)
                {
                    modPartForm.ModIDTextBox.Text = modPart2.PartId.ToString();
                    modPartForm.ModNameTextBox.Text = modPart2.Name;
                    modPartForm.ModPriceTextBox.Text = modPart2.Price.ToString();
                    modPartForm.InvLabelTextBox.Text = modPart2.InStock.ToString();
                    modPartForm.ModPartMinTextbox.Text = modPart2.Min.ToString();
                    modPartForm.ModPartMaxTextbox.Text = modPart2.Max.ToString();
                    modPartForm.ModPartCompTextbox.Text = modPart2.CompanyName.ToString();
                    modPartForm.ModpartOutsourcedRadioButton.Checked = true;
                }

                modPartForm.Show();
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
            if (partsDataGrid.CurrentRow != null)
            {
                int selectedPart = int.Parse(partsDataGrid.CurrentRow.Cells[0].Value.ToString());
                Part deletePart = inventory.LookupPart(selectedPart);
                if (inventory.DeletePart(deletePart))
                {
                    inventory.AllParts.Remove(deletePart);
                }
            }
        }

        //Does the same as the part delete button.
        private void ProdDeleteButton_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure that you want to delete this product?", "Confrim Choice", MessageBoxButtons.YesNo);

            if(confirm == DialogResult.Yes)
            {
                try
                {
                    if (prodDataGrid.CurrentRow != null)
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
            if (string.IsNullOrEmpty(PartsTextbox.Text))
            {
                partsDataGrid.DataSource = inventory.AllParts;
            }
        }

        private void ProductSearchButton_Click(object sender, EventArgs e)
        {
            Inventory searchInv = new Inventory();
            Product searchProd = new Product();
            searchProd = inventory.LookupProduct(int.Parse(ProdTextbox.Text));
            searchInv.AddProduct(searchProd);
            MessageBox.Show(searchProd.ProductID.ToString());
            prodDataGrid.DataSource = searchInv.Products;
        }

        private void ProdTextbox_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(ProdTextbox.Text))
            {
                prodDataGrid.DataSource = inventory.Products;
            }

        }

        private void ProdModifyButton_Click(object sender, EventArgs e)
        {
            if (prodDataGrid.CurrentRow != null) 
            {
                Product modProd = inventory.LookupProduct(int.Parse(prodDataGrid.CurrentRow.Cells[0].Value.ToString()));

                ModifyProduct ModProdForm = new ModifyProduct(this);
                ModProdForm.ModProdIDTextbox.Text = modProd.ProductID.ToString();
                ModProdForm.ModProdNameTextBox.Text = modProd.Name;
                ModProdForm.ModProdPriceTextBox.Text = modProd.Price.ToString();
                ModProdForm.ModProdInvTextBox.Text = modProd.InStock.ToString();
                ModProdForm.ModProdMinTextBox.Text = modProd.Min.ToString();
                ModProdForm.ModProdMaxTextBox.Text = modProd.Max.ToString();
                ModProdForm.pendingAssPart = new BindingList<Part>(modProd.assPart.ToList());
                ModProdForm.ModAssPartGridView.DataSource = ModProdForm.pendingAssPart;
                ModProdForm.Show();
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
            Products.Add(product);

        }

        public bool RemoveProduct(int id)
        {
            foreach(Product prod in Products)
            {
                if (id == prod.ProductID)
                {
                    var confirm = MessageBox.Show("Are you sure that you want to delete this product?", "Confirm choice", MessageBoxButtons.YesNo);

                    if (confirm == DialogResult.Yes)
                    {
                        return true;
                    }
                    
                }
                
                else return false;
            }
            return false;
        }

        public Product? LookupProduct(int id)
        {
            
            foreach (Product prod in Products)
            {
                if(id == prod.ProductID)
                {
                    return prod;
                } 
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
                    prod.assPart = product.assPart;
                }
            }

        }

        public void AddPart(Part part)
        {
            
            allParts.Add(part); 
            
        }

        public bool DeletePart(Part part)
        {
            
            foreach (Part del in AllParts.ToList())
            {
                if (part == del)
                {
                    var confirm = MessageBox.Show("Are you sure that you want to delete this part?", "Confirm choice", MessageBoxButtons.YesNo);

                    if (confirm == DialogResult.Yes)
                    {
                        foreach(Product prod in Products)
                        {
                            if(prod.LookupAssociatedPart(del.PartId) == part && prod.LookupAssociatedPart(del.PartId) != null)
                            {
                                //AllParts.Remove(del);
                                MessageBox.Show("This part is an accociated part and cannot be deleted.");
                                
                            }
                            else 
                            { 
                                AllParts.Remove(del); 
                            }
                        }
                    }
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

        public void CheckAssociatedParts(int id)
        {
            
            foreach(Product prod in Products)
            {
              
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
            }
            return false;
            
        }

        public Part? LookupAssociatedPart(int id)
        {
            foreach(Part part in AssociatedParts)
            {
                if(id == part.PartId)
                {
                    return part;
                }
            }
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

