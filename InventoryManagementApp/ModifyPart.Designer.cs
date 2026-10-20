namespace InventoryManagementApp
{
    partial class ModifyPart
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
            ModPartComLabel = new Label();
            ModPartMaxLabel = new Label();
            ModPartMinLabel = new Label();
            ModPartPriceLabel = new Label();
            ModPartInvLabel = new Label();
            ModPartNameLabel = new Label();
            ModPartIDLabel = new Label();
            ModPartMaxTextbox = new TextBox();
            ModPriceTextBox = new TextBox();
            InvLabelTextBox = new TextBox();
            ModNameTextBox = new TextBox();
            ModPartMinTextbox = new TextBox();
            ModPartCompTextbox = new TextBox();
            ModIDTextBox = new TextBox();
            AddPartCancelButton = new Button();
            AddPartSaveButton = new Button();
            ModpartOutsourcedRadioButton = new RadioButton();
            ModInhouseRadioButton = new RadioButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // ModPartComLabel
            // 
            ModPartComLabel.Location = new Point(88, 324);
            ModPartComLabel.Name = "ModPartComLabel";
            ModPartComLabel.Size = new Size(71, 15);
            ModPartComLabel.TabIndex = 35;
            ModPartComLabel.Text = "select";
            ModPartComLabel.Click += AddPartComLabel_Click;
            // 
            // ModPartMaxLabel
            // 
            ModPartMaxLabel.AutoSize = true;
            ModPartMaxLabel.Location = new Point(251, 280);
            ModPartMaxLabel.Name = "ModPartMaxLabel";
            ModPartMaxLabel.Size = new Size(32, 15);
            ModPartMaxLabel.TabIndex = 34;
            ModPartMaxLabel.Text = "Max:";
            ModPartMaxLabel.Click += AddPartMaxLabel_Click;
            // 
            // ModPartMinLabel
            // 
            ModPartMinLabel.AutoSize = true;
            ModPartMinLabel.Location = new Point(128, 280);
            ModPartMinLabel.Name = "ModPartMinLabel";
            ModPartMinLabel.Size = new Size(31, 15);
            ModPartMinLabel.TabIndex = 33;
            ModPartMinLabel.Text = "Min:";
            // 
            // ModPartPriceLabel
            // 
            ModPartPriceLabel.AutoSize = true;
            ModPartPriceLabel.Location = new Point(123, 225);
            ModPartPriceLabel.Name = "ModPartPriceLabel";
            ModPartPriceLabel.Size = new Size(36, 15);
            ModPartPriceLabel.TabIndex = 32;
            ModPartPriceLabel.Text = "Price:";
            // 
            // ModPartInvLabel
            // 
            ModPartInvLabel.AutoSize = true;
            ModPartInvLabel.Location = new Point(68, 181);
            ModPartInvLabel.Name = "ModPartInvLabel";
            ModPartInvLabel.Size = new Size(91, 15);
            ModPartInvLabel.TabIndex = 31;
            ModPartInvLabel.Text = "Inventory Label:";
            // 
            // ModPartNameLabel
            // 
            ModPartNameLabel.AutoSize = true;
            ModPartNameLabel.Location = new Point(117, 134);
            ModPartNameLabel.Name = "ModPartNameLabel";
            ModPartNameLabel.Size = new Size(42, 15);
            ModPartNameLabel.TabIndex = 30;
            ModPartNameLabel.Text = "Name:";
            // 
            // ModPartIDLabel
            // 
            ModPartIDLabel.AutoSize = true;
            ModPartIDLabel.Location = new Point(138, 83);
            ModPartIDLabel.Name = "ModPartIDLabel";
            ModPartIDLabel.Size = new Size(21, 15);
            ModPartIDLabel.TabIndex = 29;
            ModPartIDLabel.Text = "ID:";
            // 
            // ModPartMaxTextbox
            // 
            ModPartMaxTextbox.Location = new Point(289, 272);
            ModPartMaxTextbox.Name = "ModPartMaxTextbox";
            ModPartMaxTextbox.Size = new Size(65, 23);
            ModPartMaxTextbox.TabIndex = 28;
            ModPartMaxTextbox.TextChanged += textBox7_TextChanged;
            // 
            // ModPriceTextBox
            // 
            ModPriceTextBox.Location = new Point(165, 222);
            ModPriceTextBox.Name = "ModPriceTextBox";
            ModPriceTextBox.Size = new Size(189, 23);
            ModPriceTextBox.TabIndex = 27;
            ModPriceTextBox.TextChanged += textBox6_TextChanged;
            // 
            // InvLabelTextBox
            // 
            InvLabelTextBox.Location = new Point(165, 178);
            InvLabelTextBox.Name = "InvLabelTextBox";
            InvLabelTextBox.Size = new Size(189, 23);
            InvLabelTextBox.TabIndex = 26;
            InvLabelTextBox.TextChanged += InvLabelTextBox_TextChanged;
            // 
            // ModNameTextBox
            // 
            ModNameTextBox.Location = new Point(165, 131);
            ModNameTextBox.Name = "ModNameTextBox";
            ModNameTextBox.Size = new Size(189, 23);
            ModNameTextBox.TabIndex = 25;
            ModNameTextBox.TextChanged += ModNameTextBox_TextChanged;
            // 
            // ModPartMinTextbox
            // 
            ModPartMinTextbox.Location = new Point(165, 272);
            ModPartMinTextbox.Name = "ModPartMinTextbox";
            ModPartMinTextbox.Size = new Size(68, 23);
            ModPartMinTextbox.TabIndex = 24;
            ModPartMinTextbox.TextChanged += textBox3_TextChanged;
            // 
            // ModPartCompTextbox
            // 
            ModPartCompTextbox.Location = new Point(165, 321);
            ModPartCompTextbox.Name = "ModPartCompTextbox";
            ModPartCompTextbox.Size = new Size(189, 23);
            ModPartCompTextbox.TabIndex = 23;
            ModPartCompTextbox.TextChanged += textBox2_TextChanged;
            // 
            // ModIDTextBox
            // 
            ModIDTextBox.Location = new Point(165, 80);
            ModIDTextBox.Name = "ModIDTextBox";
            ModIDTextBox.Size = new Size(189, 23);
            ModIDTextBox.TabIndex = 22;
            ModIDTextBox.TextChanged += ModIDTextBox_TextChanged;
            // 
            // AddPartCancelButton
            // 
            AddPartCancelButton.Location = new Point(304, 386);
            AddPartCancelButton.Name = "AddPartCancelButton";
            AddPartCancelButton.Size = new Size(59, 31);
            AddPartCancelButton.TabIndex = 21;
            AddPartCancelButton.Text = "Cancel";
            AddPartCancelButton.UseVisualStyleBackColor = true;
            AddPartCancelButton.Click += AddPartCancelButton_Click;
            // 
            // AddPartSaveButton
            // 
            AddPartSaveButton.Location = new Point(238, 386);
            AddPartSaveButton.Name = "AddPartSaveButton";
            AddPartSaveButton.Size = new Size(60, 31);
            AddPartSaveButton.TabIndex = 20;
            AddPartSaveButton.Text = "Save";
            AddPartSaveButton.UseVisualStyleBackColor = true;
            AddPartSaveButton.Click += ModPartSaveButton_Click;
            // 
            // ModpartOutsourcedRadioButton
            // 
            ModpartOutsourcedRadioButton.AutoSize = true;
            ModpartOutsourcedRadioButton.Location = new Point(238, 12);
            ModpartOutsourcedRadioButton.Name = "ModpartOutsourcedRadioButton";
            ModpartOutsourcedRadioButton.Size = new Size(87, 19);
            ModpartOutsourcedRadioButton.TabIndex = 19;
            ModpartOutsourcedRadioButton.TabStop = true;
            ModpartOutsourcedRadioButton.Text = "Outsourced";
            ModpartOutsourcedRadioButton.UseVisualStyleBackColor = true;
            ModpartOutsourcedRadioButton.CheckedChanged += ModpartOutsourcedRadioButton_CheckedChanged;
            // 
            // ModInhouseRadioButton
            // 
            ModInhouseRadioButton.AutoSize = true;
            ModInhouseRadioButton.Location = new Point(158, 12);
            ModInhouseRadioButton.Name = "ModInhouseRadioButton";
            ModInhouseRadioButton.Size = new Size(74, 19);
            ModInhouseRadioButton.TabIndex = 18;
            ModInhouseRadioButton.TabStop = true;
            ModInhouseRadioButton.Text = "In-House";
            ModInhouseRadioButton.UseVisualStyleBackColor = true;
            ModInhouseRadioButton.CheckedChanged += ModInhouseRadioButton_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 36;
            label1.Text = "Modify Part";
            // 
            // ModifyPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 441);
            Controls.Add(label1);
            Controls.Add(ModPartComLabel);
            Controls.Add(ModPartMaxLabel);
            Controls.Add(ModPartMinLabel);
            Controls.Add(ModPartPriceLabel);
            Controls.Add(ModPartInvLabel);
            Controls.Add(ModPartNameLabel);
            Controls.Add(ModPartIDLabel);
            Controls.Add(ModPartMaxTextbox);
            Controls.Add(ModPriceTextBox);
            Controls.Add(InvLabelTextBox);
            Controls.Add(ModNameTextBox);
            Controls.Add(ModPartMinTextbox);
            Controls.Add(ModPartCompTextbox);
            Controls.Add(ModIDTextBox);
            Controls.Add(AddPartCancelButton);
            Controls.Add(AddPartSaveButton);
            Controls.Add(ModpartOutsourcedRadioButton);
            Controls.Add(ModInhouseRadioButton);
            Name = "ModifyPart";
            Text = "Modify Part";
            Load += ModifyPart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ModPartMaxLabel;
        private Label ModPartMinLabel;
        private Label ModPartPriceLabel;
        private Label ModPartInvLabel;
        private Label ModPartNameLabel;
        private Label ModPartIDLabel;
        private Button AddPartCancelButton;
        private Button AddPartSaveButton;
        private RadioButton ModpartOutsourcedRadioButton;
        private RadioButton ModInhouseRadioButton;
        private Label label1;
        public Label ModPartComLabel;
        public TextBox ModPartMaxTextbox;
        public TextBox ModPriceTextBox;
        public TextBox InvLabelTextBox;
        public TextBox ModNameTextBox;
        public TextBox ModPartMinTextbox;
        public TextBox ModPartCompTextbox;
        public TextBox ModIDTextBox;
    }
}