namespace InventoryManagementApp
{
    partial class AddPartForm
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
            InhouseRadioButton = new RadioButton();
            OutsourcedRadioButton = new RadioButton();
            AddPartSaveButton = new Button();
            AddPartCancelButton = new Button();
            AddPartIdTextBox = new TextBox();
            AddPartCompTextBox = new TextBox();
            AddPartMinTextBox = new TextBox();
            AddPartNameTextBox = new TextBox();
            AddPartInvTextBox = new TextBox();
            AddPartPriceTextBox = new TextBox();
            AddPartMaxTextBox = new TextBox();
            AddPartIDLabel = new Label();
            AddPartNameLabel = new Label();
            AddPartInvLabel = new Label();
            AddPartPriceLabel = new Label();
            AddPartMinLabel = new Label();
            AddPartMaxLabel = new Label();
            AddPartComLabel = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // InhouseRadioButton
            // 
            InhouseRadioButton.AutoSize = true;
            InhouseRadioButton.Location = new Point(134, 12);
            InhouseRadioButton.Name = "InhouseRadioButton";
            InhouseRadioButton.Size = new Size(74, 19);
            InhouseRadioButton.TabIndex = 0;
            InhouseRadioButton.TabStop = true;
            InhouseRadioButton.Text = "In-House";
            InhouseRadioButton.UseVisualStyleBackColor = true;
            InhouseRadioButton.CheckedChanged += InhouseRadioButton_CheckedChanged;
            // 
            // OutsourcedRadioButton
            // 
            OutsourcedRadioButton.AutoSize = true;
            OutsourcedRadioButton.Location = new Point(228, 12);
            OutsourcedRadioButton.Name = "OutsourcedRadioButton";
            OutsourcedRadioButton.Size = new Size(87, 19);
            OutsourcedRadioButton.TabIndex = 1;
            OutsourcedRadioButton.TabStop = true;
            OutsourcedRadioButton.Text = "Outsourced";
            OutsourcedRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddPartSaveButton
            // 
            AddPartSaveButton.Location = new Point(215, 389);
            AddPartSaveButton.Name = "AddPartSaveButton";
            AddPartSaveButton.Size = new Size(56, 31);
            AddPartSaveButton.TabIndex = 2;
            AddPartSaveButton.Text = "Save";
            AddPartSaveButton.UseVisualStyleBackColor = true;
            AddPartSaveButton.Click += AddPartSaveButton_Click;
            // 
            // AddPartCancelButton
            // 
            AddPartCancelButton.Location = new Point(277, 389);
            AddPartCancelButton.Name = "AddPartCancelButton";
            AddPartCancelButton.Size = new Size(58, 31);
            AddPartCancelButton.TabIndex = 3;
            AddPartCancelButton.Text = "Cancel";
            AddPartCancelButton.UseVisualStyleBackColor = true;
            AddPartCancelButton.Click += AddPartCancelButton_Click;
            // 
            // AddPartIdTextBox
            // 
            AddPartIdTextBox.Location = new Point(150, 78);
            AddPartIdTextBox.Name = "AddPartIdTextBox";
            AddPartIdTextBox.Size = new Size(189, 23);
            AddPartIdTextBox.TabIndex = 4;
            AddPartIdTextBox.TextChanged += AddPartIdTextBox_TextChanged;
            // 
            // AddPartCompTextBox
            // 
            AddPartCompTextBox.Location = new Point(150, 332);
            AddPartCompTextBox.Name = "AddPartCompTextBox";
            AddPartCompTextBox.Size = new Size(189, 23);
            AddPartCompTextBox.TabIndex = 5;
            // 
            // AddPartMinTextBox
            // 
            AddPartMinTextBox.Location = new Point(150, 282);
            AddPartMinTextBox.Name = "AddPartMinTextBox";
            AddPartMinTextBox.Size = new Size(68, 23);
            AddPartMinTextBox.TabIndex = 6;
            AddPartMinTextBox.TextChanged += AddPartMinTextBox_TextChanged;
            // 
            // AddPartNameTextBox
            // 
            AddPartNameTextBox.Location = new Point(150, 130);
            AddPartNameTextBox.Name = "AddPartNameTextBox";
            AddPartNameTextBox.Size = new Size(189, 23);
            AddPartNameTextBox.TabIndex = 7;
            AddPartNameTextBox.Validating += AddPartNameTextBox_Validating;
            // 
            // AddPartInvTextBox
            // 
            AddPartInvTextBox.Location = new Point(150, 185);
            AddPartInvTextBox.Name = "AddPartInvTextBox";
            AddPartInvTextBox.Size = new Size(189, 23);
            AddPartInvTextBox.TabIndex = 8;
            AddPartInvTextBox.TextChanged += AddPartInvTextBox_TextChanged;
            AddPartInvTextBox.Validating += AddPartInvTextBox_Validating;
            // 
            // AddPartPriceTextBox
            // 
            AddPartPriceTextBox.Location = new Point(150, 234);
            AddPartPriceTextBox.Name = "AddPartPriceTextBox";
            AddPartPriceTextBox.Size = new Size(189, 23);
            AddPartPriceTextBox.TabIndex = 9;
            AddPartPriceTextBox.Validating += AddPartPriceTextBox_Validating;
            // 
            // AddPartMaxTextBox
            // 
            AddPartMaxTextBox.Location = new Point(266, 282);
            AddPartMaxTextBox.Name = "AddPartMaxTextBox";
            AddPartMaxTextBox.Size = new Size(73, 23);
            AddPartMaxTextBox.TabIndex = 10;
            AddPartMaxTextBox.TextChanged += AddPartMaxTextBox_TextChanged;
            // 
            // AddPartIDLabel
            // 
            AddPartIDLabel.AutoSize = true;
            AddPartIDLabel.Location = new Point(123, 81);
            AddPartIDLabel.Name = "AddPartIDLabel";
            AddPartIDLabel.Size = new Size(21, 15);
            AddPartIDLabel.TabIndex = 11;
            AddPartIDLabel.Text = "ID:";
            // 
            // AddPartNameLabel
            // 
            AddPartNameLabel.AutoSize = true;
            AddPartNameLabel.Location = new Point(102, 133);
            AddPartNameLabel.Name = "AddPartNameLabel";
            AddPartNameLabel.Size = new Size(42, 15);
            AddPartNameLabel.TabIndex = 12;
            AddPartNameLabel.Text = "Name:";
            // 
            // AddPartInvLabel
            // 
            AddPartInvLabel.AutoSize = true;
            AddPartInvLabel.Location = new Point(84, 188);
            AddPartInvLabel.Name = "AddPartInvLabel";
            AddPartInvLabel.Size = new Size(60, 15);
            AddPartInvLabel.TabIndex = 13;
            AddPartInvLabel.Text = "Inventory:";
            AddPartInvLabel.Click += AddPartInvLabel_Click;
            // 
            // AddPartPriceLabel
            // 
            AddPartPriceLabel.AutoSize = true;
            AddPartPriceLabel.Location = new Point(107, 237);
            AddPartPriceLabel.Name = "AddPartPriceLabel";
            AddPartPriceLabel.Size = new Size(36, 15);
            AddPartPriceLabel.TabIndex = 14;
            AddPartPriceLabel.Text = "Price:";
            // 
            // AddPartMinLabel
            // 
            AddPartMinLabel.AutoSize = true;
            AddPartMinLabel.Location = new Point(112, 285);
            AddPartMinLabel.Name = "AddPartMinLabel";
            AddPartMinLabel.Size = new Size(31, 15);
            AddPartMinLabel.TabIndex = 15;
            AddPartMinLabel.Text = "Min:";
            // 
            // AddPartMaxLabel
            // 
            AddPartMaxLabel.AutoSize = true;
            AddPartMaxLabel.Location = new Point(228, 285);
            AddPartMaxLabel.Name = "AddPartMaxLabel";
            AddPartMaxLabel.Size = new Size(32, 15);
            AddPartMaxLabel.TabIndex = 16;
            AddPartMaxLabel.Text = "Max:";
            AddPartMaxLabel.Click += AddPartMaxLabel_Click;
            // 
            // AddPartComLabel
            // 
            AddPartComLabel.AutoSize = true;
            AddPartComLabel.Location = new Point(53, 335);
            AddPartComLabel.Name = "AddPartComLabel";
            AddPartComLabel.Size = new Size(37, 15);
            AddPartComLabel.TabIndex = 17;
            AddPartComLabel.Text = "select";
            AddPartComLabel.Click += AddPartComLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 18;
            label1.Text = "Add Part";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 468);
            Controls.Add(label1);
            Controls.Add(AddPartComLabel);
            Controls.Add(AddPartMaxLabel);
            Controls.Add(AddPartMinLabel);
            Controls.Add(AddPartPriceLabel);
            Controls.Add(AddPartInvLabel);
            Controls.Add(AddPartNameLabel);
            Controls.Add(AddPartIDLabel);
            Controls.Add(AddPartMaxTextBox);
            Controls.Add(AddPartPriceTextBox);
            Controls.Add(AddPartInvTextBox);
            Controls.Add(AddPartNameTextBox);
            Controls.Add(AddPartMinTextBox);
            Controls.Add(AddPartCompTextBox);
            Controls.Add(AddPartIdTextBox);
            Controls.Add(AddPartCancelButton);
            Controls.Add(AddPartSaveButton);
            Controls.Add(OutsourcedRadioButton);
            Controls.Add(InhouseRadioButton);
            Name = "AddPartForm";
            Text = " Add Part";
            Load += AddPartForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton InhouseRadioButton;
        private RadioButton OutsourcedRadioButton;
        private Button AddPartSaveButton;
        private Button AddPartCancelButton;
        private TextBox AddPartIdTextBox;
        private TextBox AddPartCompTextBox;
        private TextBox AddPartMinTextBox;
        private TextBox AddPartNameTextBox;
        private TextBox AddPartInvTextBox;
        private TextBox AddPartPriceTextBox;
        private TextBox AddPartMaxTextBox;
        private Label AddPartIDLabel;
        private Label AddPartNameLabel;
        private Label AddPartInvLabel;
        private Label AddPartPriceLabel;
        private Label AddPartMinLabel;
        private Label AddPartMaxLabel;
        private Label AddPartComLabel;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}