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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)partsDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // 
            // PartModifyButton
            // 
            PartModifyButton.Location = new Point(465, 339);
            PartModifyButton.Name = "PartModifyButton";
            PartModifyButton.Size = new Size(54, 35);
            PartModifyButton.TabIndex = 1;
            PartModifyButton.Text = "Modify";
            PartModifyButton.UseVisualStyleBackColor = true;
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
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(617, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(560, 220);
            dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 479);
            Controls.Add(dataGridView1);
            Controls.Add(partsDataGrid);
            Controls.Add(ProdDeleteButton);
            Controls.Add(ProdModifyButton);
            Controls.Add(ProdAddButton);
            Controls.Add(Exit);
            Controls.Add(PartDeleteButton);
            Controls.Add(PartModifyButton);
            Controls.Add(PartAddButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)partsDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
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
        private DataGridView dataGridView1;
    }
}
