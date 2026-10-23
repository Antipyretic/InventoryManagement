namespace InventoryManagementApp
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ProdDeleteButton = new Button();
            AddProdSaveButton = new Button();
            ProdAddButton = new Button();
            AddProdCancelButton = new Button();
            AddPartMaxLabel = new Label();
            AddPartMinLabel = new Label();
            AddPartPriceLabel = new Label();
            AddProdInvLabel = new Label();
            AddProdNameLabel = new Label();
            AddProdIDLabel = new Label();
            AddProdMaxTextBox = new TextBox();
            AddProdPriceTextBox = new TextBox();
            AddProdInvTextBox = new TextBox();
            AddProdNameTextBox = new TextBox();
            AddProdMinTextBox = new TextBox();
            AddProdIdTextBox = new TextBox();
            AllPartsDataGrid = new DataGridView();
            AddProdSearchBox = new TextBox();
            AssPartGridView = new DataGridView();
            AllPartsGridLabel = new Label();
            AssPartGridLabel = new Label();
            AddProdFormLabel = new Label();
            AllProdSearchButton = new Button();
            errorProviderProd = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)AllPartsDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AssPartGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderProd).BeginInit();
            SuspendLayout();
            // 
            // ProdDeleteButton
            // 
            ProdDeleteButton.Location = new Point(754, 707);
            ProdDeleteButton.Name = "ProdDeleteButton";
            ProdDeleteButton.Size = new Size(54, 35);
            ProdDeleteButton.TabIndex = 11;
            ProdDeleteButton.Text = "Delete";
            ProdDeleteButton.UseVisualStyleBackColor = true;
            ProdDeleteButton.Click += ProdDeleteButton_Click;
            // 
            // AddProdSaveButton
            // 
            AddProdSaveButton.Location = new Point(754, 774);
            AddProdSaveButton.Name = "AddProdSaveButton";
            AddProdSaveButton.Size = new Size(54, 35);
            AddProdSaveButton.TabIndex = 10;
            AddProdSaveButton.Text = "Save";
            AddProdSaveButton.UseVisualStyleBackColor = true;
            AddProdSaveButton.Click += AddProdSaveButton_Click;
            AddProdSaveButton.Validating += AddProdSaveButton_Validating;
            // 
            // ProdAddButton
            // 
            ProdAddButton.Location = new Point(160, 502);
            ProdAddButton.Name = "ProdAddButton";
            ProdAddButton.Size = new Size(54, 35);
            ProdAddButton.TabIndex = 9;
            ProdAddButton.Text = "Add";
            ProdAddButton.UseVisualStyleBackColor = true;
            ProdAddButton.Click += ProdAddButton_Click;
            // 
            // AddProdCancelButton
            // 
            AddProdCancelButton.Location = new Point(814, 774);
            AddProdCancelButton.Name = "AddProdCancelButton";
            AddProdCancelButton.Size = new Size(54, 35);
            AddProdCancelButton.TabIndex = 8;
            AddProdCancelButton.Text = "Cancel";
            AddProdCancelButton.UseVisualStyleBackColor = true;
            AddProdCancelButton.Click += AddProdCancelButton_Click;
            // 
            // AddPartMaxLabel
            // 
            AddPartMaxLabel.AutoSize = true;
            AddPartMaxLabel.Location = new Point(25, 438);
            AddPartMaxLabel.Name = "AddPartMaxLabel";
            AddPartMaxLabel.Size = new Size(32, 15);
            AddPartMaxLabel.TabIndex = 28;
            AddPartMaxLabel.Text = "Max:";
            // 
            // AddPartMinLabel
            // 
            AddPartMinLabel.AutoSize = true;
            AddPartMinLabel.Location = new Point(25, 379);
            AddPartMinLabel.Name = "AddPartMinLabel";
            AddPartMinLabel.Size = new Size(31, 15);
            AddPartMinLabel.TabIndex = 27;
            AddPartMinLabel.Text = "Min:";
            // 
            // AddPartPriceLabel
            // 
            AddPartPriceLabel.AutoSize = true;
            AddPartPriceLabel.Location = new Point(25, 326);
            AddPartPriceLabel.Name = "AddPartPriceLabel";
            AddPartPriceLabel.Size = new Size(36, 15);
            AddPartPriceLabel.TabIndex = 26;
            AddPartPriceLabel.Text = "Price:";
            // 
            // AddProdInvLabel
            // 
            AddProdInvLabel.AutoSize = true;
            AddProdInvLabel.Location = new Point(25, 273);
            AddProdInvLabel.Name = "AddProdInvLabel";
            AddProdInvLabel.Size = new Size(60, 15);
            AddProdInvLabel.TabIndex = 25;
            AddProdInvLabel.Text = "Inventory:";
            AddProdInvLabel.Click += AddProdInvLabel_Click;
            // 
            // AddProdNameLabel
            // 
            AddProdNameLabel.AutoSize = true;
            AddProdNameLabel.Location = new Point(25, 216);
            AddProdNameLabel.Name = "AddProdNameLabel";
            AddProdNameLabel.Size = new Size(42, 15);
            AddProdNameLabel.TabIndex = 24;
            AddProdNameLabel.Text = "Name:";
            // 
            // AddProdIDLabel
            // 
            AddProdIDLabel.AutoSize = true;
            AddProdIDLabel.Location = new Point(25, 161);
            AddProdIDLabel.Name = "AddProdIDLabel";
            AddProdIDLabel.Size = new Size(21, 15);
            AddProdIDLabel.TabIndex = 23;
            AddProdIDLabel.Text = "ID:";
            // 
            // AddProdMaxTextBox
            // 
            AddProdMaxTextBox.Location = new Point(25, 456);
            AddProdMaxTextBox.Name = "AddProdMaxTextBox";
            AddProdMaxTextBox.Size = new Size(189, 23);
            AddProdMaxTextBox.TabIndex = 22;
            // 
            // AddProdPriceTextBox
            // 
            AddProdPriceTextBox.Location = new Point(25, 344);
            AddProdPriceTextBox.Name = "AddProdPriceTextBox";
            AddProdPriceTextBox.Size = new Size(189, 23);
            AddProdPriceTextBox.TabIndex = 21;
            AddProdPriceTextBox.TextChanged += AddProdPriceTextBox_TextChanged;
            AddProdPriceTextBox.Validating += AddProdPriceTextBox_Validating;
            // 
            // AddProdInvTextBox
            // 
            AddProdInvTextBox.Location = new Point(25, 291);
            AddProdInvTextBox.Name = "AddProdInvTextBox";
            AddProdInvTextBox.Size = new Size(189, 23);
            AddProdInvTextBox.TabIndex = 20;
            AddProdInvTextBox.TextChanged += AddProdInvTextBox_TextChanged;
            AddProdInvTextBox.Validating += AddProdInvTextBox_Validating;
            // 
            // AddProdNameTextBox
            // 
            AddProdNameTextBox.Location = new Point(25, 234);
            AddProdNameTextBox.Name = "AddProdNameTextBox";
            AddProdNameTextBox.Size = new Size(189, 23);
            AddProdNameTextBox.TabIndex = 19;
            AddProdNameTextBox.TextChanged += AddProdNameTextBox_TextChanged;
            // 
            // AddProdMinTextBox
            // 
            AddProdMinTextBox.Location = new Point(25, 397);
            AddProdMinTextBox.Name = "AddProdMinTextBox";
            AddProdMinTextBox.Size = new Size(189, 23);
            AddProdMinTextBox.TabIndex = 18;
            AddProdMinTextBox.TextChanged += AddProdMinTextBox_TextChanged;
            // 
            // AddProdIdTextBox
            // 
            AddProdIdTextBox.Location = new Point(25, 179);
            AddProdIdTextBox.Name = "AddProdIdTextBox";
            AddProdIdTextBox.Size = new Size(189, 23);
            AddProdIdTextBox.TabIndex = 17;
            AddProdIdTextBox.TextChanged += AddProdIdTextBox_TextChanged;
            AddProdIdTextBox.Validating += AddProdIdTextBox_Validating;
            // 
            // AllPartsDataGrid
            // 
            AllPartsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllPartsDataGrid.Location = new Point(252, 89);
            AllPartsDataGrid.Name = "AllPartsDataGrid";
            AllPartsDataGrid.Size = new Size(573, 262);
            AllPartsDataGrid.TabIndex = 29;
            AllPartsDataGrid.CellContentClick += AllPartsGridView_CellContentClick;
            // 
            // AddProdSearchBox
            // 
            AddProdSearchBox.Location = new Point(556, 48);
            AddProdSearchBox.Name = "AddProdSearchBox";
            AddProdSearchBox.Size = new Size(269, 23);
            AddProdSearchBox.TabIndex = 31;
            AddProdSearchBox.TextChanged += AddProdSearchBox_TextChanged;
            // 
            // AssPartGridView
            // 
            AssPartGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AssPartGridView.Location = new Point(252, 438);
            AssPartGridView.Name = "AssPartGridView";
            AssPartGridView.Size = new Size(573, 262);
            AssPartGridView.TabIndex = 33;
            AssPartGridView.CellContentClick += AssPartGridView_CellContentClick;
            // 
            // AllPartsGridLabel
            // 
            AllPartsGridLabel.AutoSize = true;
            AllPartsGridLabel.Location = new Point(253, 61);
            AllPartsGridLabel.Name = "AllPartsGridLabel";
            AllPartsGridLabel.Size = new Size(107, 15);
            AllPartsGridLabel.TabIndex = 32;
            AllPartsGridLabel.Text = "All Candidate Parts";
            // 
            // AssPartGridLabel
            // 
            AssPartGridLabel.AutoSize = true;
            AssPartGridLabel.Location = new Point(253, 405);
            AssPartGridLabel.Name = "AssPartGridLabel";
            AssPartGridLabel.Size = new Size(184, 15);
            AssPartGridLabel.TabIndex = 34;
            AssPartGridLabel.Text = "Parts associated with this Product";
            AssPartGridLabel.Click += label1_Click;
            // 
            // AddProdFormLabel
            // 
            AddProdFormLabel.AutoSize = true;
            AddProdFormLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AddProdFormLabel.Location = new Point(20, 16);
            AddProdFormLabel.Name = "AddProdFormLabel";
            AddProdFormLabel.Size = new Size(76, 15);
            AddProdFormLabel.TabIndex = 35;
            AddProdFormLabel.Text = "Add Product";
            // 
            // AllProdSearchButton
            // 
            AllProdSearchButton.Location = new Point(480, 48);
            AllProdSearchButton.Name = "AllProdSearchButton";
            AllProdSearchButton.Size = new Size(57, 23);
            AllProdSearchButton.TabIndex = 36;
            AllProdSearchButton.Text = "Search";
            AllProdSearchButton.UseVisualStyleBackColor = true;
            AllProdSearchButton.Click += AllProdSearchButton_Click;
            // 
            // errorProviderProd
            // 
            errorProviderProd.ContainerControl = this;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 821);
            Controls.Add(AllProdSearchButton);
            Controls.Add(AddProdFormLabel);
            Controls.Add(AssPartGridLabel);
            Controls.Add(AssPartGridView);
            Controls.Add(AllPartsGridLabel);
            Controls.Add(AddProdSearchBox);
            Controls.Add(AllPartsDataGrid);
            Controls.Add(AddPartMaxLabel);
            Controls.Add(AddPartMinLabel);
            Controls.Add(AddPartPriceLabel);
            Controls.Add(AddProdInvLabel);
            Controls.Add(AddProdNameLabel);
            Controls.Add(AddProdIDLabel);
            Controls.Add(AddProdMaxTextBox);
            Controls.Add(AddProdPriceTextBox);
            Controls.Add(AddProdInvTextBox);
            Controls.Add(AddProdNameTextBox);
            Controls.Add(AddProdMinTextBox);
            Controls.Add(AddProdIdTextBox);
            Controls.Add(ProdDeleteButton);
            Controls.Add(AddProdSaveButton);
            Controls.Add(ProdAddButton);
            Controls.Add(AddProdCancelButton);
            Name = "AddProduct";
            Text = "AddProduct";
            Load += AddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)AllPartsDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)AssPartGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ProdDeleteButton;
        private Button AddProdSaveButton;
        private Button ProdAddButton;
        private Button AddProdCancelButton;
        private Label AddPartMaxLabel;
        private Label AddPartMinLabel;
        private Label AddPartPriceLabel;
        private Label AddProdInvLabel;
        private Label AddProdNameLabel;
        private Label AddProdIDLabel;
        private TextBox AddProdMaxTextBox;
        private TextBox AddProdPriceTextBox;
        private TextBox AddProdInvTextBox;
        private TextBox AddProdNameTextBox;
        private TextBox AddProdMinTextBox;
        private TextBox AddProdIdTextBox;
        private DataGridView AllPartsDataGrid;
        private TextBox AddProdSearchBox;
        private DataGridView AssPartGridView;
        private Label AllPartsGridLabel;
        private Label AssPartGridLabel;
        private Label AddProdFormLabel;
        private Button AllProdSearchButton;
        private ErrorProvider errorProviderProd;
    }
}