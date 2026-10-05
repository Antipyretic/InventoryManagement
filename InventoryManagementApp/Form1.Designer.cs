namespace InventoryManagementApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PartAddButton = new Button();
            PartModifyButton = new Button();
            PartDeleteButton = new Button();
            Exit = new Button();
            ProdDeleteButton = new Button();
            ProdModifyButton = new Button();
            ProdAddButton = new Button();
            partsDataGrid = new DataGridView();
            prodDataGrid = new DataGridView();
            ProductSearchButton = new Button();
            PartsSearchButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            PartsTextbox = new TextBox();
            ProdTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)partsDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prodDataGrid).BeginInit();
            SuspendLayout();
            // 
            // PartAddButton
            // 
            PartAddButton.Location = new Point(405, 339);
            PartAddButton.Name = "PartAddButton";
            PartAddButton.Size = new Size(54, 35);
            PartAddButton.TabIndex = 0;
            PartAddButton.Text = "Add";
            PartAddButton.UseVisualStyleBackColor = true;
            PartAddButton.Click += PartAddButton_Click;
            // 
            // PartModifyButton
            // 
            PartModifyButton.Location = new Point(465, 339);
            PartModifyButton.Name = "PartModifyButton";
            PartModifyButton.Size = new Size(54, 35);
            PartModifyButton.TabIndex = 1;
            PartModifyButton.Text = "Modify";
            PartModifyButton.UseVisualStyleBackColor = true;
            PartModifyButton.Click += PartModifyButton_Click;
            // 
            // PartDeleteButton
            // 
            PartDeleteButton.Location = new Point(525, 339);
            PartDeleteButton.Name = "PartDeleteButton";
            PartDeleteButton.Size = new Size(54, 35);
            PartDeleteButton.TabIndex = 2;
            PartDeleteButton.Text = "Delete";
            PartDeleteButton.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            Exit.Location = new Point(1123, 407);
            Exit.Name = "Exit";
            Exit.Size = new Size(54, 35);
            Exit.TabIndex = 4;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            // 
            // ProdDeleteButton
            // 
            ProdDeleteButton.Location = new Point(1123, 339);
            ProdDeleteButton.Name = "ProdDeleteButton";
            ProdDeleteButton.Size = new Size(54, 35);
            ProdDeleteButton.TabIndex = 7;
            ProdDeleteButton.Text = "Delete";
            ProdDeleteButton.UseVisualStyleBackColor = true;
            // 
            // ProdModifyButton
            // 
            ProdModifyButton.Location = new Point(1063, 339);
            ProdModifyButton.Name = "ProdModifyButton";
            ProdModifyButton.Size = new Size(54, 35);
            ProdModifyButton.TabIndex = 6;
            ProdModifyButton.Text = "Modify";
            ProdModifyButton.UseVisualStyleBackColor = true;
            // 
            // ProdAddButton
            // 
            ProdAddButton.Location = new Point(1003, 339);
            ProdAddButton.Name = "ProdAddButton";
            ProdAddButton.Size = new Size(54, 35);
            ProdAddButton.TabIndex = 5;
            ProdAddButton.Text = "Add";
            ProdAddButton.UseVisualStyleBackColor = true;
            // 
            // partsDataGrid
            // 
            partsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partsDataGrid.Location = new Point(22, 88);
            partsDataGrid.Name = "partsDataGrid";
            partsDataGrid.Size = new Size(560, 220);
            partsDataGrid.TabIndex = 8;
            partsDataGrid.CellContentClick += partsDataGrid_CellContentClick;
            // 
            // prodDataGrid
            // 
            prodDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prodDataGrid.Location = new Point(617, 88);
            prodDataGrid.Name = "prodDataGrid";
            prodDataGrid.Size = new Size(560, 220);
            prodDataGrid.TabIndex = 9;
            // 
            // ProductSearchButton
            // 
            ProductSearchButton.Location = new Point(916, 47);
            ProductSearchButton.Name = "ProductSearchButton";
            ProductSearchButton.Size = new Size(54, 23);
            ProductSearchButton.TabIndex = 11;
            ProductSearchButton.Text = "Search";
            ProductSearchButton.UseVisualStyleBackColor = true;
            // 
            // PartsSearchButton
            // 
            PartsSearchButton.Location = new Point(318, 47);
            PartsSearchButton.Name = "PartsSearchButton";
            PartsSearchButton.Size = new Size(54, 23);
            PartsSearchButton.TabIndex = 10;
            PartsSearchButton.Text = "Search";
            PartsSearchButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 12;
            label1.Text = "Inventory Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 55);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 13;
            label2.Text = "Parts";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(617, 55);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 14;
            label3.Text = "Products";
            // 
            // PartsTextbox
            // 
            PartsTextbox.Location = new Point(378, 47);
            PartsTextbox.Name = "PartsTextbox";
            PartsTextbox.Size = new Size(201, 23);
            PartsTextbox.TabIndex = 15;
            // 
            // ProdTextbox
            // 
            ProdTextbox.Location = new Point(976, 47);
            ProdTextbox.Name = "ProdTextbox";
            ProdTextbox.Size = new Size(201, 23);
            ProdTextbox.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 479);
            Controls.Add(ProdTextbox);
            Controls.Add(PartsTextbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ProductSearchButton);
            Controls.Add(PartsSearchButton);
            Controls.Add(prodDataGrid);
            Controls.Add(partsDataGrid);
            Controls.Add(ProdDeleteButton);
            Controls.Add(ProdModifyButton);
            Controls.Add(ProdAddButton);
            Controls.Add(Exit);
            Controls.Add(PartDeleteButton);
            Controls.Add(PartModifyButton);
            Controls.Add(PartAddButton);
            Name = "Form1";
            Text = "Inventory Application";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)partsDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)prodDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PartAddButton;
        private Button PartModifyButton;
        private Button PartDeleteButton;
        private Button Exit;
        private Button ProdDeleteButton;
        private Button ProdModifyButton;
        private Button ProdAddButton;
        private DataGridView partsDataGrid;
        private DataGridView prodDataGrid;
        private Button ProductSearchButton;
        private Button PartsSearchButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox PartsTextbox;
        private TextBox ProdTextbox;
    }
}
