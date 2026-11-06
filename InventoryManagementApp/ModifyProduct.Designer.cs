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
            components = new System.ComponentModel.Container();
            AllModProdProdSearchButton = new Button();
            ModProdFormLabel = new Label();
            ModAssPartGridLabel = new Label();
            ModAssPartGridView = new DataGridView();
            ModProdAllPartsGridLabel = new Label();
            ModProdSearchTextBox = new TextBox();
            AllModPartsGridView = new DataGridView();
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
            errorProviderModProd = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ModAssPartGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllModPartsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderModProd).BeginInit();
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
            AllModProdProdSearchButton.Click += AllModProdProdSearchButton_Click;
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
            ModAssPartGridView.Location = new Point(243, 432);
            ModAssPartGridView.Name = "ModAssPartGridView";
            ModAssPartGridView.Size = new Size(573, 262);
            ModAssPartGridView.TabIndex = 56;
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
            ModProdSearchTextBox.TextChanged += ModProdSearchTextBox_TextChanged;
            // 
            // AllModPartsGridView
            // 
            AllModPartsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllModPartsGridView.Location = new Point(243, 83);
            AllModPartsGridView.Name = "AllModPartsGridView";
            AllModPartsGridView.Size = new Size(573, 262);
            AllModPartsGridView.TabIndex = 53;
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
            ModProdMaxTextBox.TextChanged += ModProdMaxTextBox_TextChanged;
            // 
            // ModProdPriceTextBox
            // 
            ModProdPriceTextBox.Location = new Point(16, 338);
            ModProdPriceTextBox.Name = "ModProdPriceTextBox";
            ModProdPriceTextBox.Size = new Size(189, 23);
            ModProdPriceTextBox.TabIndex = 45;
            ModProdPriceTextBox.TextChanged += ModProdPriceTextBox_TextChanged;
            // 
            // ModProdInvTextBox
            // 
            ModProdInvTextBox.Location = new Point(16, 285);
            ModProdInvTextBox.Name = "ModProdInvTextBox";
            ModProdInvTextBox.Size = new Size(189, 23);
            ModProdInvTextBox.TabIndex = 44;
            ModProdInvTextBox.TextChanged += ModProdInvTextBox_TextChanged;
            // 
            // ModProdNameTextBox
            // 
            ModProdNameTextBox.Location = new Point(16, 228);
            ModProdNameTextBox.Name = "ModProdNameTextBox";
            ModProdNameTextBox.Size = new Size(189, 23);
            ModProdNameTextBox.TabIndex = 43;
            ModProdNameTextBox.TextChanged += ModProdNameTextBox_TextChanged;
            ModProdNameTextBox.Validating += ModProdNameTextBox_Validating;
            // 
            // ModProdMinTextBox
            // 
            ModProdMinTextBox.Location = new Point(16, 391);
            ModProdMinTextBox.Name = "ModProdMinTextBox";
            ModProdMinTextBox.Size = new Size(189, 23);
            ModProdMinTextBox.TabIndex = 42;
            ModProdMinTextBox.TextChanged += ModProdMinTextBox_TextChanged;
            // 
            // ModProdIDTextbox
            // 
            ModProdIDTextbox.Location = new Point(16, 173);
            ModProdIDTextbox.Name = "ModProdIDTextbox";
            ModProdIDTextbox.Size = new Size(189, 23);
            ModProdIDTextbox.TabIndex = 41;
            ModProdIDTextbox.TextChanged += ModProdIDTextbox_TextChanged;
            ModProdIDTextbox.Validating += ModProdIDTextbox_Validating;
            // 
            // ModProdDeleteButton
            // 
            ModProdDeleteButton.Location = new Point(745, 701);
            ModProdDeleteButton.Name = "ModProdDeleteButton";
            ModProdDeleteButton.Size = new Size(54, 35);
            ModProdDeleteButton.TabIndex = 40;
            ModProdDeleteButton.Text = "Delete";
            ModProdDeleteButton.UseVisualStyleBackColor = true;
            ModProdDeleteButton.Click += ModProdDeleteButton_Click;
            // 
            // ModProdSaveButton
            // 
            ModProdSaveButton.Location = new Point(745, 768);
            ModProdSaveButton.Name = "ModProdSaveButton";
            ModProdSaveButton.Size = new Size(54, 35);
            ModProdSaveButton.TabIndex = 39;
            ModProdSaveButton.Text = "Save";
            ModProdSaveButton.UseVisualStyleBackColor = true;
            ModProdSaveButton.Click += ModProdSaveButton_Click;
            // 
            // ModProdAddButton
            // 
            ModProdAddButton.Location = new Point(745, 353);
            ModProdAddButton.Name = "ModProdAddButton";
            ModProdAddButton.Size = new Size(54, 35);
            ModProdAddButton.TabIndex = 38;
            ModProdAddButton.Text = "Add";
            ModProdAddButton.UseVisualStyleBackColor = true;
            ModProdAddButton.Click += ModProdAddButton_Click;
            // 
            // ModProdCancelButton
            // 
            ModProdCancelButton.Location = new Point(805, 768);
            ModProdCancelButton.Name = "ModProdCancelButton";
            ModProdCancelButton.Size = new Size(54, 35);
            ModProdCancelButton.TabIndex = 37;
            ModProdCancelButton.Text = "Cancel";
            ModProdCancelButton.UseVisualStyleBackColor = true;
            ModProdCancelButton.Click += ModProdCancelButton_Click;
            // 
            // errorProviderModProd
            // 
            errorProviderModProd.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)errorProviderModProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AllModProdProdSearchButton;
        private Label ModProdFormLabel;
        private Label ModAssPartGridLabel;
        private Label ModProdAllPartsGridLabel;
        private TextBox ModProdSearchTextBox;
        private DataGridView AllModPartsGridView;
        private Label ModProdMaxLabel;
        private Label ModProdMinLabel;
        private Label ModProdPriceLabel;
        private Label ModProdInvLabel;
        private Label ModProdNameLabel;
        private Label ModProdIDLabel;
        private Button ModProdDeleteButton;
        private Button ModProdSaveButton;
        private Button ModProdAddButton;
        private Button ModProdCancelButton;
        private ErrorProvider errorProviderModProd;
        public TextBox ModProdIDTextbox;
        public TextBox ModProdMaxTextBox;
        public TextBox ModProdPriceTextBox;
        public TextBox ModProdInvTextBox;
        public TextBox ModProdNameTextBox;
        public TextBox ModProdMinTextBox;
        public DataGridView ModAssPartGridView;
    }
}