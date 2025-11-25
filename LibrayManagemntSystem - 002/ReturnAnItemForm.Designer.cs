namespace LibrayManagemntSystem
{
    partial class ReturnAnItemForm
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
            ReturnItemsButton = new Button();
            AddItemToUpdateListButton = new Button();
            ItemAddIDTextBox = new TextBox();
            AddItemToStockInsturctionsLabel = new Label();
            MainMenuButton = new Button();
            ReturnItemsListBox = new ListBox();
            CartLabels = new Label();
            ItemStockListBox = new ListBox();
            AvaiableItemsLabel = new Label();
            RetrunAnItemLabel = new Label();
            SuspendLayout();
            // 
            // ReturnItemsButton
            // 
            ReturnItemsButton.BackColor = Color.Red;
            ReturnItemsButton.Font = new Font("Segoe UI", 10F);
            ReturnItemsButton.ForeColor = Color.White;
            ReturnItemsButton.Location = new Point(855, 315);
            ReturnItemsButton.Name = "ReturnItemsButton";
            ReturnItemsButton.Size = new Size(100, 49);
            ReturnItemsButton.TabIndex = 20;
            ReturnItemsButton.Text = "Return Items";
            ReturnItemsButton.UseVisualStyleBackColor = false;
            ReturnItemsButton.Click += ReturnItemsButton_Click;
            // 
            // AddItemToUpdateListButton
            // 
            AddItemToUpdateListButton.BackColor = Color.Red;
            AddItemToUpdateListButton.Font = new Font("Segoe UI", 10F);
            AddItemToUpdateListButton.ForeColor = Color.White;
            AddItemToUpdateListButton.Location = new Point(855, 100);
            AddItemToUpdateListButton.Name = "AddItemToUpdateListButton";
            AddItemToUpdateListButton.Size = new Size(100, 49);
            AddItemToUpdateListButton.TabIndex = 19;
            AddItemToUpdateListButton.Text = "Add Item to update List";
            AddItemToUpdateListButton.UseVisualStyleBackColor = false;
            AddItemToUpdateListButton.Click += AddItemToUpdateListButton_Click;
            // 
            // ItemAddIDTextBox
            // 
            ItemAddIDTextBox.Location = new Point(855, 71);
            ItemAddIDTextBox.Name = "ItemAddIDTextBox";
            ItemAddIDTextBox.Size = new Size(100, 23);
            ItemAddIDTextBox.TabIndex = 18;
            ItemAddIDTextBox.TextChanged += ItemAddIDTextBox_TextChanged;
            // 
            // AddItemToStockInsturctionsLabel
            // 
            AddItemToStockInsturctionsLabel.AutoSize = true;
            AddItemToStockInsturctionsLabel.Font = new Font("Segoe UI", 10F);
            AddItemToStockInsturctionsLabel.ForeColor = Color.White;
            AddItemToStockInsturctionsLabel.Location = new Point(855, 49);
            AddItemToStockInsturctionsLabel.Name = "AddItemToStockInsturctionsLabel";
            AddItemToStockInsturctionsLabel.Size = new Size(158, 19);
            AddItemToStockInsturctionsLabel.TabIndex = 17;
            AddItemToStockInsturctionsLabel.Text = "Enter ID to Add to stock";
            AddItemToStockInsturctionsLabel.Click += AddItemToStockInsturctionsLabel_Click;
            // 
            // MainMenuButton
            // 
            MainMenuButton.BackColor = Color.Red;
            MainMenuButton.Font = new Font("Segoe UI", 20F);
            MainMenuButton.ForeColor = Color.White;
            MainMenuButton.Location = new Point(12, 535);
            MainMenuButton.Name = "MainMenuButton";
            MainMenuButton.Size = new Size(169, 68);
            MainMenuButton.TabIndex = 16;
            MainMenuButton.Text = "Main Menu";
            MainMenuButton.UseVisualStyleBackColor = false;
            MainMenuButton.Click += MainMenuButton_Click;
            // 
            // ReturnItemsListBox
            // 
            ReturnItemsListBox.FormattingEnabled = true;
            ReturnItemsListBox.ItemHeight = 15;
            ReturnItemsListBox.Location = new Point(12, 315);
            ReturnItemsListBox.Name = "ReturnItemsListBox";
            ReturnItemsListBox.Size = new Size(837, 214);
            ReturnItemsListBox.TabIndex = 15;
            ReturnItemsListBox.SelectedIndexChanged += ReturnItemsListBox_SelectedIndexChanged;
            // 
            // CartLabels
            // 
            CartLabels.AutoSize = true;
            CartLabels.Font = new Font("Segoe UI", 10F);
            CartLabels.ForeColor = Color.White;
            CartLabels.Location = new Point(12, 293);
            CartLabels.Name = "CartLabels";
            CartLabels.Size = new Size(75, 19);
            CartLabels.TabIndex = 14;
            CartLabels.Text = "UpdateList";
            CartLabels.Click += CartLabels_Click;
            // 
            // ItemStockListBox
            // 
            ItemStockListBox.FormattingEnabled = true;
            ItemStockListBox.ItemHeight = 15;
            ItemStockListBox.Location = new Point(12, 70);
            ItemStockListBox.Name = "ItemStockListBox";
            ItemStockListBox.Size = new Size(837, 214);
            ItemStockListBox.TabIndex = 13;
            ItemStockListBox.SelectedIndexChanged += ItemStockListBox_SelectedIndexChanged;
            // 
            // AvaiableItemsLabel
            // 
            AvaiableItemsLabel.AutoSize = true;
            AvaiableItemsLabel.Font = new Font("Segoe UI", 10F);
            AvaiableItemsLabel.ForeColor = Color.White;
            AvaiableItemsLabel.Location = new Point(12, 48);
            AvaiableItemsLabel.Name = "AvaiableItemsLabel";
            AvaiableItemsLabel.Size = new Size(98, 19);
            AvaiableItemsLabel.TabIndex = 12;
            AvaiableItemsLabel.Text = "Avaiable Items";
            AvaiableItemsLabel.Click += AvaiableItemsLabel_Click;
            // 
            // RetrunAnItemLabel
            // 
            RetrunAnItemLabel.AutoSize = true;
            RetrunAnItemLabel.Font = new Font("Segoe UI", 20F);
            RetrunAnItemLabel.ForeColor = Color.White;
            RetrunAnItemLabel.Location = new Point(12, 11);
            RetrunAnItemLabel.Name = "RetrunAnItemLabel";
            RetrunAnItemLabel.Size = new Size(193, 37);
            RetrunAnItemLabel.TabIndex = 11;
            RetrunAnItemLabel.Text = "Retrun An Item";
            RetrunAnItemLabel.Click += RetrunAnItemLabel_Click;
            // 
            // ReturnAnItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1357, 615);
            Controls.Add(ReturnItemsButton);
            Controls.Add(AddItemToUpdateListButton);
            Controls.Add(ItemAddIDTextBox);
            Controls.Add(AddItemToStockInsturctionsLabel);
            Controls.Add(MainMenuButton);
            Controls.Add(ReturnItemsListBox);
            Controls.Add(CartLabels);
            Controls.Add(ItemStockListBox);
            Controls.Add(AvaiableItemsLabel);
            Controls.Add(RetrunAnItemLabel);
            Name = "ReturnAnItemForm";
            Text = "ReturnAnItemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ReturnItemsButton;
        private Button AddItemToUpdateListButton;
        private TextBox ItemAddIDTextBox;
        private Label AddItemToStockInsturctionsLabel;
        private Button MainMenuButton;
        private ListBox ReturnItemsListBox;
        private Label CartLabels;
        private ListBox ItemStockListBox;
        private Label AvaiableItemsLabel;
        private Label RetrunAnItemLabel;
    }
}