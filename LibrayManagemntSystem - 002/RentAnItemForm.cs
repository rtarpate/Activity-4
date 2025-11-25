using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibrayManagemntSystem
{
    public partial class RentAnItemForm : Form
    {
        private List<IInventoryItem> _availableItems = new();

        public RentAnItemForm()
        {
            InitializeComponent();
            this.Load += RentAnItemForm_Load;
        }

        private void RentAnItemForm_Load(object sender, EventArgs e)
        {
            RefreshAvailableItems();
            RefreshCartList();
        }

        private void RefreshAvailableItems()
        {
            _availableItems = GlobalStates.Library.GetAvailableItems();
            ItemStockListBox.Items.Clear();

            int id = 1;
            foreach (var item in _availableItems)
            {
                ItemStockListBox.Items.Add($"{id}. {item.GetDisplayInfo()}");
                id++;
            }
        }

        private void RefreshCartList()
        {
            ShoppingCartListBox.Items.Clear();

            foreach (var item in GlobalStates.ShoppingCart.Items)
            {
                ShoppingCartListBox.Items.Add(item.GetDisplayInfo());
            }
        }

        private void RentAnItemLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void AvaiableItemsLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void ItemStockListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: highlight selected item
        }

        private void ShopCartInstructionsLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void ShopCartIDTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: validation
        }

        private void AddItemToShopCartButton_Click(object sender, EventArgs e)
        {
            // Add item to shopping cart using the entered "ID" (row number)
            if (!int.TryParse(ShopCartIDTextBox.Text.Trim(), out int id))
            {
                MessageBox.Show("Please enter a valid number for the item ID.", "Invalid ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (id < 1 || id > _availableItems.Count)
            {
                MessageBox.Show("That ID is not in the available items list.", "Invalid ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = _availableItems[id - 1];
            GlobalStates.ShoppingCart.AddItem(item);
            RefreshCartList();

            ShopCartIDTextBox.Clear();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            var main = new Form1
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            main.Show();
            this.Close();
        }

        private void CartLabels_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void ShoppingCartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: show detail
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            if (GlobalStates.ShoppingCart.Items.Count == 0)
            {
                MessageBox.Show("Your cart is empty.", "Nothing to Checkout",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 1. UPDATE SQL STOCK FOR EACH ITEM
            foreach (var item in GlobalStates.ShoppingCart.Items)
            {
                // Memory already holds the correct stock BEFORE checkout
                int newStock = item.Stock - 1;
                if (newStock < 0) newStock = 0;

                item.Stock = newStock;  // Update memory

                if (item is Book b)
                {
                    DataBaseMangement.UpdateBookStock(b.BookName, newStock);
                }
                else if (item is DVD d)
                {
                    DataBaseMangement.UpdateDVDStock(d.DVDName, newStock);
                }
            }

            // 2. CLEAR CART
            GlobalStates.ShoppingCart.Clear();

            // 3. REFRESH UI
            RefreshAvailableItems();
            RefreshCartList();

            MessageBox.Show("Checkout complete. Items have been rented and database updated.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
