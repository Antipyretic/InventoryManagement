namespace InventoryManagementApp
{
    partial class ModifyProduct
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
            AllModProdProdSearchButton = new Button();
            ModProdFormLabel = new Label();
            ModAssPartGridLabel = new Label();
            ModAssPartGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            ModProdAllPartsGridLabel = new Label();
            ModProdSearchTextBox = new TextBox();
            AllModPartsGridView = new DataGridView();
            PartID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Inventory = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Min = new DataGridViewTextBoxColumn();
            Max = new DataGridViewTextBoxColumn();
            ModProdMaxLabel = new Label();
            ModProdMinLabel = new Label();
            ModProdPriceLabel = new Label();
            ModProdInvLabel = new Label();
            ModProdNameLabel = new Label();
            ModProdIDLabel = new Label();
            ModProdMaxTextBox = new TextBox();
            ModProdPriceTextBox = new TextBox();
            ModProdInvTextBox = new TextBox();
            ModProdNameTextBox = new TextBox();
            ModProdMinTextBox = new TextBox();
            ModProdIDTextbox = new TextBox();
            ModProdDeleteButton = new Button();
            ModProdSaveButton = new Button();
            ModProdAddButton = new Button();
            ModProdCancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ModAssPartGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllModPartsGridView).BeginInit();
            SuspendLayout();
            // 
            // AllModProdProdSearchButton
            // 
            AllModProdProdSearchButton.Location = new Point(471, 42);
            AllModProdProdSearchButton.Name = "AllModProdProdSearchButton";
            AllModProdProdSearchButton.Size = new Size(57, 23);
            AllModProdProdSearchButton.TabIndex = 59;
            AllModProdProdSearchButton.Text = "Search";
            AllModProdProdSearchButton.UseVisualStyleBackColor = true;
            // 
            // ModProdFormLabel
            // 
            ModProdFormLabel.AutoSize = true;
            ModProdFormLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ModProdFormLabel.Location = new Point(11, 10);
            ModProdFormLabel.Name = "ModProdFormLabel";
            ModProdFormLabel.Size = new Size(93, 15);
            ModProdFormLabel.TabIndex = 58;
            ModProdFormLabel.Text = "Modify Product";
            // 
            // ModAssPartGridLabel
            // 
            ModAssPartGridLabel.AutoSize = true;
            ModAssPartGridLabel.Location = new Point(244, 399);
            ModAssPartGridLabel.Name = "ModAssPartGridLabel";
            ModAssPartGridLabel.Size = new Size(184, 15);
            ModAssPartGridLabel.TabIndex = 57;
            ModAssPartGridLabel.Text = "Parts associated with this Product";
            // 
            // ModAssPartGridView
            // 
            ModAssPartGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ModAssPartGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            ModAssPartGridView.Location = new Point(243, 432);
            ModAssPartGridView.Name = "ModAssPartGridView";
            ModAssPartGridView.Size = new Size(573, 262);
            ModAssPartGridView.TabIndex = 56;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Frozen = true;
            dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Frozen = true;
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.Frozen = true;
            dataGridViewTextBoxColumn3.HeaderText = "Inventory";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.Frozen = true;
            dataGridViewTextBoxColumn4.HeaderText = "Price";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.Frozen = true;
            dataGridViewTextBoxColumn5.HeaderText = "Min";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.Frozen = true;
            dataGridViewTextBoxColumn6.HeaderText = "Max";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 75;
            // 
            // ModProdAllPartsGridLabel
            // 
            ModProdAllPartsGridLabel.AutoSize = true;
            ModProdAllPartsGridLabel.Location = new Point(244, 55);
            ModProdAllPartsGridLabel.Name = "ModProdAllPartsGridLabel";
            ModProdAllPartsGridLabel.Size = new Size(107, 15);
            ModProdAllPartsGridLabel.TabIndex = 55;
            ModProdAllPartsGridLabel.Text = "All Candidate Parts";
            // 
            // ModProdSearchTextBox
            // 
            ModProdSearchTextBox.Location = new Point(547, 42);
            ModProdSearchTextBox.Name = "ModProdSearchTextBox";
            ModProdSearchTextBox.Size = new Size(269, 23);
            ModProdSearchTextBox.TabIndex = 54;
            // 
            // AllModPartsGridView
            // 
            AllModPartsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllModPartsGridView.Columns.AddRange(new DataGridViewColumn[] { PartID, Name, Inventory, Price, Min, Max });
            AllModPartsGridView.Location = new Point(243, 83);
            AllModPartsGridView.Name = "AllModPartsGridView";
            AllModPartsGridView.Size = new Size(573, 262);
            AllModPartsGridView.TabIndex = 53;
            // 
            // PartID
            // 
            PartID.Frozen = true;
            PartID.HeaderText = "Part ID";
            PartID.Name = "PartID";
            // 
            // Name
            // 
            Name.Frozen = true;
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // Inventory
            // 
            Inventory.Frozen = true;
            Inventory.HeaderText = "Inventory";
            Inventory.Name = "Inventory";
            Inventory.Width = 75;
            // 
            // Price
            // 
            Price.Frozen = true;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // Min
            // 
            Min.Frozen = true;
            Min.HeaderText = "Min";
            Min.Name = "Min";
            Min.Width = 75;
            // 
            // Max
            // 
            Max.Frozen = true;
            Max.HeaderText = "Max";
            Max.Name = "Max";
            Max.Width = 75;
            // 
            // ModProdMaxLabel
            // 
            ModProdMaxLabel.AutoSize = true;
            ModProdMaxLabel.Location = new Point(16, 432);
            ModProdMaxLabel.Name = "ModProdMaxLabel";
            ModProdMaxLabel.Size = new Size(32, 15);
            ModProdMaxLabel.TabIndex = 52;
            ModProdMaxLabel.Text = "Max:";
            // 
            // ModProdMinLabel
            // 
            ModProdMinLabel.AutoSize = true;
            ModProdMinLabel.Location = new Point(16, 373);
            ModProdMinLabel.Name = "ModProdMinLabel";
            ModProdMinLabel.Size = new Size(31, 15);
            ModProdMinLabel.TabIndex = 51;
            ModProdMinLabel.Text = "Min:";
            // 
            // ModProdPriceLabel
            // 
            ModProdPriceLabel.AutoSize = true;
            ModProdPriceLabel.Location = new Point(16, 320);
            ModProdPriceLabel.Name = "ModProdPriceLabel";
            ModProdPriceLabel.Size = new Size(36, 15);
            ModProdPriceLabel.TabIndex = 50;
            ModProdPriceLabel.Text = "Price:";
            // 
            // ModProdInvLabel
            // 
            ModProdInvLabel.AutoSize = true;
            ModProdInvLabel.Location = new Point(16, 267);
            ModProdInvLabel.Name = "ModProdInvLabel";
            ModProdInvLabel.Size = new Size(91, 15);
            ModProdInvLabel.TabIndex = 49;
            ModProdInvLabel.Text = "Inventory Label:";
            // 
            // ModProdNameLabel
            // 
            ModProdNameLabel.AutoSize = true;
            ModProdNameLabel.Location = new Point(16, 210);
            ModProdNameLabel.Name = "ModProdNameLabel";
            ModProdNameLabel.Size = new Size(42, 15);
            ModProdNameLabel.TabIndex = 48;
            ModProdNameLabel.Text = "Name:";
            // 
            // ModProdIDLabel
            // 
            ModProdIDLabel.AutoSize = true;
            ModProdIDLabel.Location = new Point(16, 155);
            ModProdIDLabel.Name = "ModProdIDLabel";
            ModProdIDLabel.Size = new Size(21, 15);
            ModProdIDLabel.TabIndex = 47;
            ModProdIDLabel.Text = "ID:";
            // 
            // ModProdMaxTextBox
            // 
            ModProdMaxTextBox.Location = new Point(16, 450);
            ModProdMaxTextBox.Name = "ModProdMaxTextBox";
            ModProdMaxTextBox.Size = new Size(189, 23);
            ModProdMaxTextBox.TabIndex = 46;
            // 
            // ModProdPriceTextBox
            // 
            ModProdPriceTextBox.Location = new Point(16, 338);
            ModProdPriceTextBox.Name = "ModProdPriceTextBox";
            ModProdPriceTextBox.Size = new Size(189, 23);
            ModProdPriceTextBox.TabIndex = 45;
            // 
            // ModProdInvTextBox
            // 
            ModProdInvTextBox.Location = new Point(16, 285);
            ModProdInvTextBox.Name = "ModProdInvTextBox";
            ModProdInvTextBox.Size = new Size(189, 23);
            ModProdInvTextBox.TabIndex = 44;
            // 
            // ModProdNameTextBox
            // 
            ModProdNameTextBox.Location = new Point(16, 228);
            ModProdNameTextBox.Name = "ModProdNameTextBox";
            ModProdNameTextBox.Size = new Size(189, 23);
            ModProdNameTextBox.TabIndex = 43;
            // 
            // ModProdMinTextBox
            // 
            ModProdMinTextBox.Location = new Point(16, 391);
            ModProdMinTextBox.Name = "ModProdMinTextBox";
            ModProdMinTextBox.Size = new Size(189, 23);
            ModProdMinTextBox.TabIndex = 42;
            // 
            // ModProdIDTextbox
            // 
            ModProdIDTextbox.Location = new Point(16, 173);
            ModProdIDTextbox.Name = "ModProdIDTextbox";
            ModProdIDTextbox.Size = new Size(189, 23);
            ModProdIDTextbox.TabIndex = 41;
            // 
            // ModProdDeleteButton
            // 
            ModProdDeleteButton.Location = new Point(745, 701);
            ModProdDeleteButton.Name = "ModProdDeleteButton";
            ModProdDeleteButton.Size = new Size(54, 35);
            ModProdDeleteButton.TabIndex = 40;
            ModProdDeleteButton.Text = "Delete";
            ModProdDeleteButton.UseVisualStyleBackColor = true;
            // 
            // ModProdSaveButton
            // 
            ModProdSaveButton.Location = new Point(745, 768);
            ModProdSaveButton.Name = "ModProdSaveButton";
            ModProdSaveButton.Size = new Size(54, 35);
            ModProdSaveButton.TabIndex = 39;
            ModProdSaveButton.Text = "Save";
            ModProdSaveButton.UseVisualStyleBackColor = true;
            // 
            // ModProdAddButton
            // 
            ModProdAddButton.Location = new Point(151, 496);
            ModProdAddButton.Name = "ModProdAddButton";
            ModProdAddButton.Size = new Size(54, 35);
            ModProdAddButton.TabIndex = 38;
            ModProdAddButton.Text = "Add";
            ModProdAddButton.UseVisualStyleBackColor = true;
            // 
            // ModProdCancelButton
            // 
            ModProdCancelButton.Location = new Point(805, 768);
            ModProdCancelButton.Name = "ModProdCancelButton";
            ModProdCancelButton.Size = new Size(54, 35);
            ModProdCancelButton.TabIndex = 37;
            ModProdCancelButton.Text = "Cancel";
            ModProdCancelButton.UseVisualStyleBackColor = true;
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 819);
            Controls.Add(AllModProdProdSearchButton);
            Controls.Add(ModProdFormLabel);
            Controls.Add(ModAssPartGridLabel);
            Controls.Add(ModAssPartGridView);
            Controls.Add(ModProdAllPartsGridLabel);
            Controls.Add(ModProdSearchTextBox);
            Controls.Add(AllModPartsGridView);
            Controls.Add(ModProdMaxLabel);
            Controls.Add(ModProdMinLabel);
            Controls.Add(ModProdPriceLabel);
            Controls.Add(ModProdInvLabel);
            Controls.Add(ModProdNameLabel);
            Controls.Add(ModProdIDLabel);
            Controls.Add(ModProdMaxTextBox);
            Controls.Add(ModProdPriceTextBox);
            Controls.Add(ModProdInvTextBox);
            Controls.Add(ModProdNameTextBox);
            Controls.Add(ModProdMinTextBox);
            Controls.Add(ModProdIDTextbox);
            Controls.Add(ModProdDeleteButton);
            Controls.Add(ModProdSaveButton);
            Controls.Add(ModProdAddButton);
            Controls.Add(ModProdCancelButton);
            Name = "ModifyProduct";
            Text = "ModifyProduct";
            ((System.ComponentModel.ISupportInitialize)ModAssPartGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)AllModPartsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AllModProdProdSearchButton;
        private Label ModProdFormLabel;
        private Label ModAssPartGridLabel;
        private DataGridView ModAssPartGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Label ModProdAllPartsGridLabel;
        private TextBox ModProdSearchTextBox;
        private DataGridView AllModPartsGridView;
        private DataGridViewTextBoxColumn PartID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Inventory;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Min;
        private DataGridViewTextBoxColumn Max;
        private Label ModProdMaxLabel;
        private Label ModProdMinLabel;
        private Label ModProdPriceLabel;
        private Label ModProdInvLabel;
        private Label ModProdNameLabel;
        private Label ModProdIDLabel;
        private TextBox ModProdMaxTextBox;
        private TextBox ModProdPriceTextBox;
        private TextBox ModProdInvTextBox;
        private TextBox ModProdNameTextBox;
        private TextBox ModProdMinTextBox;
        private TextBox ModProdIDTextbox;
        private Button ModProdDeleteButton;
        private Button ModProdSaveButton;
        private Button ModProdAddButton;
        private Button ModProdCancelButton;
    }
}