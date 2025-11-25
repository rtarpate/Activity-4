namespace LibrayManagemntSystem
{
    partial class RentAnItemForm
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
            RentAnItemLabel = new Label();
            AvaiableItemsLabel = new Label();
            ItemStockListBox = new ListBox();
            CartLabels = new Label();
            ShoppingCartListBox = new ListBox();
            MainMenuButton = new Button();
            ShopCartInstructionsLabel = new Label();
            ShopCartIDTextBox = new TextBox();
            AddItemToShopCartButton = new Button();
            CheckOutButton = new Button();
            SuspendLayout();
            // 
            // RentAnItemLabel
            // 
            RentAnItemLabel.AutoSize = true;
            RentAnItemLabel.Font = new Font("Segoe UI", 20F);
            RentAnItemLabel.ForeColor = Color.White;
            RentAnItemLabel.Location = new Point(12, 9);
            RentAnItemLabel.Name = "RentAnItemLabel";
            RentAnItemLabel.Size = new Size(169, 37);
            RentAnItemLabel.TabIndex = 1;
            RentAnItemLabel.Text = "Rent An Item";
            RentAnItemLabel.Click += RentAnItemLabel_Click;
            // 
            // AvaiableItemsLabel
            // 
            AvaiableItemsLabel.AutoSize = true;
            AvaiableItemsLabel.Font = new Font("Segoe UI", 10F);
            AvaiableItemsLabel.ForeColor = Color.White;
            AvaiableItemsLabel.Location = new Point(12, 46);
            AvaiableItemsLabel.Name = "AvaiableItemsLabel";
            AvaiableItemsLabel.Size = new Size(98, 19);
            AvaiableItemsLabel.TabIndex = 2;
            AvaiableItemsLabel.Text = "Avaiable Items";
            AvaiableItemsLabel.Click += AvaiableItemsLabel_Click;
            // 
            // ItemStockListBox
            // 
            ItemStockListBox.FormattingEnabled = true;
            ItemStockListBox.ItemHeight = 15;
            ItemStockListBox.Location = new Point(12, 68);
            ItemStockListBox.Name = "ItemStockListBox";
            ItemStockListBox.Size = new Size(729, 214);
            ItemStockListBox.TabIndex = 3;
            ItemStockListBox.SelectedIndexChanged += ItemStockListBox_SelectedIndexChanged;
            // 
            // CartLabels
            // 
            CartLabels.AutoSize = true;
            CartLabels.Font = new Font("Segoe UI", 10F);
            CartLabels.ForeColor = Color.White;
            CartLabels.Location = new Point(13, 288);
            CartLabels.Name = "CartLabels";
            CartLabels.Size = new Size(35, 19);
            CartLabels.TabIndex = 4;
            CartLabels.Text = "Cart";
            CartLabels.Click += CartLabels_Click;
            // 
            // ShoppingCartListBox
            // 
            ShoppingCartListBox.FormattingEnabled = true;
            ShoppingCartListBox.ItemHeight = 15;
            ShoppingCartListBox.Location = new Point(13, 310);
            ShoppingCartListBox.Name = "ShoppingCartListBox";
            ShoppingCartListBox.Size = new Size(728, 214);
            ShoppingCartListBox.TabIndex = 5;
            ShoppingCartListBox.SelectedIndexChanged += ShoppingCartListBox_SelectedIndexChanged;
            // 
            // MainMenuButton
            // 
            MainMenuButton.BackColor = Color.Red;
            MainMenuButton.Font = new Font("Segoe UI", 20F);
            MainMenuButton.ForeColor = Color.White;
            MainMenuButton.Location = new Point(12, 530);
            MainMenuButton.Name = "MainMenuButton";
            MainMenuButton.Size = new Size(169, 68);
            MainMenuButton.TabIndex = 6;
            MainMenuButton.Text = "Main Menu";
            MainMenuButton.UseVisualStyleBackColor = false;
            MainMenuButton.Click += MainMenuButton_Click;
            // 
            // ShopCartInstructionsLabel
            // 
            ShopCartInstructionsLabel.AutoSize = true;
            ShopCartInstructionsLabel.Font = new Font("Segoe UI", 10F);
            ShopCartInstructionsLabel.ForeColor = Color.White;
            ShopCartInstructionsLabel.Location = new Point(747, 46);
            ShopCartInstructionsLabel.Name = "ShopCartInstructionsLabel";
            ShopCartInstructionsLabel.Size = new Size(210, 19);
            ShopCartInstructionsLabel.TabIndex = 7;
            ShopCartInstructionsLabel.Text = "Enter ID to Add to shopping cart";
            ShopCartInstructionsLabel.Click += ShopCartInstructionsLabel_Click;
            // 
            // ShopCartIDTextBox
            // 
            ShopCartIDTextBox.Location = new Point(747, 68);
            ShopCartIDTextBox.Name = "ShopCartIDTextBox";
            ShopCartIDTextBox.Size = new Size(100, 23);
            ShopCartIDTextBox.TabIndex = 8;
            ShopCartIDTextBox.TextChanged += ShopCartIDTextBox_TextChanged;
            // 
            // AddItemToShopCartButton
            // 
            AddItemToShopCartButton.BackColor = Color.Red;
            AddItemToShopCartButton.Font = new Font("Segoe UI", 10F);
            AddItemToShopCartButton.ForeColor = Color.White;
            AddItemToShopCartButton.Location = new Point(747, 97);
            AddItemToShopCartButton.Name = "AddItemToShopCartButton";
            AddItemToShopCartButton.Size = new Size(100, 49);
            AddItemToShopCartButton.TabIndex = 9;
            AddItemToShopCartButton.Text = "Add Item to Cart";
            AddItemToShopCartButton.UseVisualStyleBackColor = false;
            AddItemToShopCartButton.Click += AddItemToShopCartButton_Click;
            // 
            // CheckOutButton
            // 
            CheckOutButton.BackColor = Color.Red;
            CheckOutButton.Font = new Font("Segoe UI", 10F);
            CheckOutButton.ForeColor = Color.White;
            CheckOutButton.Location = new Point(747, 310);
            CheckOutButton.Name = "CheckOutButton";
            CheckOutButton.Size = new Size(100, 49);
            CheckOutButton.TabIndex = 10;
            CheckOutButton.Text = "Check Out";
            CheckOutButton.UseVisualStyleBackColor = false;
            CheckOutButton.Click += CheckOutButton_Click;
            // 
            // RentAnItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1347, 634);
            Controls.Add(CheckOutButton);
            Controls.Add(AddItemToShopCartButton);
            Controls.Add(ShopCartIDTextBox);
            Controls.Add(ShopCartInstructionsLabel);
            Controls.Add(MainMenuButton);
            Controls.Add(ShoppingCartListBox);
            Controls.Add(CartLabels);
            Controls.Add(ItemStockListBox);
            Controls.Add(AvaiableItemsLabel);
            Controls.Add(RentAnItemLabel);
            Name = "RentAnItemForm";
            Text = "RentAnItemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RentAnItemLabel;
        private Label AvaiableItemsLabel;
        private ListBox ItemStockListBox;
        private Label CartLabels;
        private ListBox ShoppingCartListBox;
        private Button MainMenuButton;
        private Label ShopCartInstructionsLabel;
        private TextBox ShopCartIDTextBox;
        private Button AddItemToShopCartButton;
        private Button CheckOutButton;
    }
}