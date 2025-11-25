namespace LibrayManagemntSystem
{
    partial class AddNewItemFormDVD
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
            AllCurrentDVDLabel = new Label();
            AllCurentDVDsListBox = new ListBox();
            VHSRadioButton = new RadioButton();
            BlueRayRadioButton = new RadioButton();
            HDDVDRadioButton = new RadioButton();
            EnterDVDTypeLabel = new Label();
            AddBookButton = new Button();
            EnterDVDYearPublishedTextBox = new TextBox();
            EnterDVDYearPublishedLabel = new Label();
            EnterDVDStockTextBox = new TextBox();
            EnterDVDStockLabel = new Label();
            EnterDVDPriceTextBox = new TextBox();
            EnterDVDPriceLabel = new Label();
            EnterDVDDirectorTextBox = new TextBox();
            EnterDVDDirectorLabel = new Label();
            EnterDVDNameTextBox = new TextBox();
            EnterBookNameLabel = new Label();
            MainMenuButton = new Button();
            AddNewDVDLabel = new Label();
            SuspendLayout();
            // 
            // AllCurrentDVDLabel
            // 
            AllCurrentDVDLabel.AutoSize = true;
            AllCurrentDVDLabel.Font = new Font("Segoe UI", 10F);
            AllCurrentDVDLabel.ForeColor = Color.White;
            AllCurrentDVDLabel.Location = new Point(187, 56);
            AllCurrentDVDLabel.Name = "AllCurrentDVDLabel";
            AllCurrentDVDLabel.Size = new Size(98, 19);
            AllCurrentDVDLabel.TabIndex = 38;
            AllCurrentDVDLabel.Text = "All DVD Books";
            AllCurrentDVDLabel.Click += AllCurrentDVDLabel_Click;
            // 
            // AllCurentDVDsListBox
            // 
            AllCurentDVDsListBox.FormattingEnabled = true;
            AllCurentDVDsListBox.ItemHeight = 15;
            AllCurentDVDsListBox.Location = new Point(187, 86);
            AllCurentDVDsListBox.Name = "AllCurentDVDsListBox";
            AllCurentDVDsListBox.Size = new Size(908, 304);
            AllCurentDVDsListBox.TabIndex = 37;
            AllCurentDVDsListBox.SelectedIndexChanged += AllCurentDVDsListBox_SelectedIndexChanged;
            // 
            // VHSRadioButton
            // 
            VHSRadioButton.AutoSize = true;
            VHSRadioButton.ForeColor = Color.White;
            VHSRadioButton.Location = new Point(12, 378);
            VHSRadioButton.Name = "VHSRadioButton";
            VHSRadioButton.Size = new Size(47, 19);
            VHSRadioButton.TabIndex = 36;
            VHSRadioButton.TabStop = true;
            VHSRadioButton.Text = "VHS";
            VHSRadioButton.UseVisualStyleBackColor = true;
            VHSRadioButton.CheckedChanged += VHSRadioButton_CheckedChanged;
            // 
            // BlueRayRadioButton
            // 
            BlueRayRadioButton.AutoSize = true;
            BlueRayRadioButton.ForeColor = Color.White;
            BlueRayRadioButton.Location = new Point(12, 353);
            BlueRayRadioButton.Name = "BlueRayRadioButton";
            BlueRayRadioButton.Size = new Size(67, 19);
            BlueRayRadioButton.TabIndex = 35;
            BlueRayRadioButton.TabStop = true;
            BlueRayRadioButton.Text = "BlueRay";
            BlueRayRadioButton.UseVisualStyleBackColor = true;
            BlueRayRadioButton.CheckedChanged += BlueRayRadioButton_CheckedChanged;
            // 
            // HDDVDRadioButton
            // 
            HDDVDRadioButton.AutoSize = true;
            HDDVDRadioButton.ForeColor = Color.White;
            HDDVDRadioButton.Location = new Point(12, 328);
            HDDVDRadioButton.Name = "HDDVDRadioButton";
            HDDVDRadioButton.Size = new Size(65, 19);
            HDDVDRadioButton.TabIndex = 34;
            HDDVDRadioButton.TabStop = true;
            HDDVDRadioButton.Text = "HDDVD";
            HDDVDRadioButton.UseVisualStyleBackColor = true;
            HDDVDRadioButton.CheckedChanged += HDDVDRadioButton_CheckedChanged;
            // 
            // EnterDVDTypeLabel
            // 
            EnterDVDTypeLabel.AutoSize = true;
            EnterDVDTypeLabel.Font = new Font("Segoe UI", 10F);
            EnterDVDTypeLabel.ForeColor = Color.White;
            EnterDVDTypeLabel.Location = new Point(12, 306);
            EnterDVDTypeLabel.Name = "EnterDVDTypeLabel";
            EnterDVDTypeLabel.Size = new Size(106, 19);
            EnterDVDTypeLabel.TabIndex = 33;
            EnterDVDTypeLabel.Text = "Enter DVD Type";
            EnterDVDTypeLabel.Click += EnterDVDTypeLabel_Click;
            // 
            // AddBookButton
            // 
            AddBookButton.BackColor = Color.Red;
            AddBookButton.Font = new Font("Segoe UI", 10F);
            AddBookButton.ForeColor = Color.White;
            AddBookButton.Location = new Point(12, 410);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(123, 30);
            AddBookButton.TabIndex = 32;
            AddBookButton.Text = "Add DVD";
            AddBookButton.UseVisualStyleBackColor = false;
            AddBookButton.Click += AddBookButton_Click;
            // 
            // EnterDVDYearPublishedTextBox
            // 
            EnterDVDYearPublishedTextBox.Location = new Point(12, 280);
            EnterDVDYearPublishedTextBox.Name = "EnterDVDYearPublishedTextBox";
            EnterDVDYearPublishedTextBox.Size = new Size(100, 23);
            EnterDVDYearPublishedTextBox.TabIndex = 31;
            EnterDVDYearPublishedTextBox.TextChanged += EnterDVDYearPublishedTextBox_TextChanged;
            // 
            // EnterDVDYearPublishedLabel
            // 
            EnterDVDYearPublishedLabel.AutoSize = true;
            EnterDVDYearPublishedLabel.Font = new Font("Segoe UI", 10F);
            EnterDVDYearPublishedLabel.ForeColor = Color.White;
            EnterDVDYearPublishedLabel.Location = new Point(12, 256);
            EnterDVDYearPublishedLabel.Name = "EnterDVDYearPublishedLabel";
            EnterDVDYearPublishedLabel.Size = new Size(167, 19);
            EnterDVDYearPublishedLabel.TabIndex = 30;
            EnterDVDYearPublishedLabel.Text = "Enter DVD Year Published";
            EnterDVDYearPublishedLabel.Click += EnterDVDYearPublishedLabel_Click;
            // 
            // EnterDVDStockTextBox
            // 
            EnterDVDStockTextBox.Location = new Point(12, 230);
            EnterDVDStockTextBox.Name = "EnterDVDStockTextBox";
            EnterDVDStockTextBox.Size = new Size(100, 23);
            EnterDVDStockTextBox.TabIndex = 29;
            EnterDVDStockTextBox.TextChanged += EnterDVDStockTextBox_TextChanged;
            // 
            // EnterDVDStockLabel
            // 
            EnterDVDStockLabel.AutoSize = true;
            EnterDVDStockLabel.Font = new Font("Segoe UI", 10F);
            EnterDVDStockLabel.ForeColor = Color.White;
            EnterDVDStockLabel.Location = new Point(12, 206);
            EnterDVDStockLabel.Name = "EnterDVDStockLabel";
            EnterDVDStockLabel.Size = new Size(111, 19);
            EnterDVDStockLabel.TabIndex = 28;
            EnterDVDStockLabel.Text = "Enter DVD Stock";
            EnterDVDStockLabel.Click += EnterDVDStockLabel_Click;
            // 
            // EnterDVDPriceTextBox
            // 
            EnterDVDPriceTextBox.Location = new Point(12, 180);
            EnterDVDPriceTextBox.Name = "EnterDVDPriceTextBox";
            EnterDVDPriceTextBox.Size = new Size(100, 23);
            EnterDVDPriceTextBox.TabIndex = 27;
            EnterDVDPriceTextBox.TextChanged += EnterDVDPriceTextBox_TextChanged;
            // 
            // EnterDVDPriceLabel
            // 
            EnterDVDPriceLabel.AutoSize = true;
            EnterDVDPriceLabel.Font = new Font("Segoe UI", 10F);
            EnterDVDPriceLabel.ForeColor = Color.White;
            EnterDVDPriceLabel.Location = new Point(12, 156);
            EnterDVDPriceLabel.Name = "EnterDVDPriceLabel";
            EnterDVDPriceLabel.Size = new Size(107, 19);
            EnterDVDPriceLabel.TabIndex = 26;
            EnterDVDPriceLabel.Text = "Enter DVD Price";
            EnterDVDPriceLabel.Click += EnterDVDPriceLabel_Click;
            // 
            // EnterDVDDirectorTextBox
            // 
            EnterDVDDirectorTextBox.Location = new Point(12, 130);
            EnterDVDDirectorTextBox.Name = "EnterDVDDirectorTextBox";
            EnterDVDDirectorTextBox.Size = new Size(100, 23);
            EnterDVDDirectorTextBox.TabIndex = 25;
            EnterDVDDirectorTextBox.TextChanged += EnterDVDDirectorTextBox_TextChanged;
            // 
            // EnterDVDDirectorLabel
            // 
            EnterDVDDirectorLabel.AutoSize = true;
            EnterDVDDirectorLabel.Font = new Font("Segoe UI", 10F);
            EnterDVDDirectorLabel.ForeColor = Color.White;
            EnterDVDDirectorLabel.Location = new Point(12, 106);
            EnterDVDDirectorLabel.Name = "EnterDVDDirectorLabel";
            EnterDVDDirectorLabel.Size = new Size(127, 19);
            EnterDVDDirectorLabel.TabIndex = 24;
            EnterDVDDirectorLabel.Text = "Enter DVD Director";
            EnterDVDDirectorLabel.Click += EnterDVDDirectorLabel_Click;
            // 
            // EnterDVDNameTextBox
            // 
            EnterDVDNameTextBox.Location = new Point(12, 80);
            EnterDVDNameTextBox.Name = "EnterDVDNameTextBox";
            EnterDVDNameTextBox.Size = new Size(100, 23);
            EnterDVDNameTextBox.TabIndex = 23;
            EnterDVDNameTextBox.TextChanged += EnterDVDNameTextBox_TextChanged;
            // 
            // EnterBookNameLabel
            // 
            EnterBookNameLabel.AutoSize = true;
            EnterBookNameLabel.Font = new Font("Segoe UI", 10F);
            EnterBookNameLabel.ForeColor = Color.White;
            EnterBookNameLabel.Location = new Point(12, 56);
            EnterBookNameLabel.Name = "EnterBookNameLabel";
            EnterBookNameLabel.Size = new Size(114, 19);
            EnterBookNameLabel.TabIndex = 22;
            EnterBookNameLabel.Text = "Enter DVD Name";
            EnterBookNameLabel.Click += EnterBookNameLabel_Click;
            // 
            // MainMenuButton
            // 
            MainMenuButton.BackColor = Color.Red;
            MainMenuButton.Font = new Font("Segoe UI", 20F);
            MainMenuButton.ForeColor = Color.White;
            MainMenuButton.Location = new Point(1129, 11);
            MainMenuButton.Name = "MainMenuButton";
            MainMenuButton.Size = new Size(168, 61);
            MainMenuButton.TabIndex = 21;
            MainMenuButton.Text = "Main Menu";
            MainMenuButton.UseVisualStyleBackColor = false;
            MainMenuButton.Click += MainMenuButton_Click;
            // 
            // AddNewDVDLabel
            // 
            AddNewDVDLabel.AutoSize = true;
            AddNewDVDLabel.Font = new Font("Segoe UI", 20F);
            AddNewDVDLabel.ForeColor = Color.White;
            AddNewDVDLabel.Location = new Point(12, 11);
            AddNewDVDLabel.Name = "AddNewDVDLabel";
            AddNewDVDLabel.Size = new Size(188, 37);
            AddNewDVDLabel.TabIndex = 20;
            AddNewDVDLabel.Text = "Add New DVD";
            AddNewDVDLabel.Click += AddNewDVDLabel_Click;
            // 
            // AddNewItemFormDVD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1309, 450);
            Controls.Add(AllCurrentDVDLabel);
            Controls.Add(AllCurentDVDsListBox);
            Controls.Add(VHSRadioButton);
            Controls.Add(BlueRayRadioButton);
            Controls.Add(HDDVDRadioButton);
            Controls.Add(EnterDVDTypeLabel);
            Controls.Add(AddBookButton);
            Controls.Add(EnterDVDYearPublishedTextBox);
            Controls.Add(EnterDVDYearPublishedLabel);
            Controls.Add(EnterDVDStockTextBox);
            Controls.Add(EnterDVDStockLabel);
            Controls.Add(EnterDVDPriceTextBox);
            Controls.Add(EnterDVDPriceLabel);
            Controls.Add(EnterDVDDirectorTextBox);
            Controls.Add(EnterDVDDirectorLabel);
            Controls.Add(EnterDVDNameTextBox);
            Controls.Add(EnterBookNameLabel);
            Controls.Add(MainMenuButton);
            Controls.Add(AddNewDVDLabel);
            Name = "AddNewItemFormDVD";
            Text = "AddNewItemFormDVD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AllCurrentDVDLabel;
        private ListBox AllCurentDVDsListBox;
        private RadioButton VHSRadioButton;
        private RadioButton BlueRayRadioButton;
        private RadioButton HDDVDRadioButton;
        private Label EnterDVDTypeLabel;
        private Button AddBookButton;
        private TextBox EnterDVDYearPublishedTextBox;
        private Label EnterDVDYearPublishedLabel;
        private TextBox EnterDVDStockTextBox;
        private Label EnterDVDStockLabel;
        private TextBox EnterDVDPriceTextBox;
        private Label EnterDVDPriceLabel;
        private TextBox EnterDVDDirectorTextBox;
        private Label EnterDVDDirectorLabel;
        private TextBox EnterDVDNameTextBox;
        private Label EnterBookNameLabel;
        private Button MainMenuButton;
        private Label AddNewDVDLabel;
    }
}