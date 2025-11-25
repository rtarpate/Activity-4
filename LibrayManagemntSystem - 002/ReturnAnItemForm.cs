using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibrayManagemntSystem
{
    public partial class ReturnAnItemForm : Form
    {
        private List<IInventoryItem> _allItems = new();

        public ReturnAnItemForm()
        {
            InitializeComponent();
            this.Load += ReturnAnItemForm_Load;
        }

        private void ReturnAnItemForm_Load(object sender, EventArgs e)
        {
            RefreshAllItems();
            RefreshReturnList();
        }

        private void RefreshAllItems()
        {
            _allItems = GlobalStates.Library.GetAllItems();
            ItemStockListBox.Items.Clear();

            int id = 1;
            foreach (var item in _allItems)
            {
                ItemStockListBox.Items.Add($"{id}. {item.GetDisplayInfo()}");
                id++;
            }
        }

        private void RefreshReturnList()
        {
            ReturnItemsListBox.Items.Clear();

            foreach (var item in GlobalStates.ReturnItemsCart.Items)
            {
                ReturnItemsListBox.Items.Add(item.GetDisplayInfo());
            }
        }

        private void RetrunAnItemLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void AvaiableItemsLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void ItemStockListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: show detail
        }

        private void AddItemToStockInsturctionsLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void ItemAddIDTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: validation
        }

        private void AddItemToUpdateListButton_Click(object sender, EventArgs e)
        {
            // Add item to the "update list" (return list) using entered ID
            if (!int.TryParse(ItemAddIDTextBox.Text.Trim(), out int id))
            {
                MessageBox.Show("Please enter a valid number for the item ID.", "Invalid ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (id < 1 || id > _allItems.Count)
            {
                MessageBox.Show("That ID is not in the inventory list.", "Invalid ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = _allItems[id - 1];
            GlobalStates.ReturnItemsCart.AddItem(item);
            RefreshReturnList();

            ItemAddIDTextBox.Clear();
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

        private void ReturnItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: show detail
        }

        private void ReturnItemsButton_Click(object sender, EventArgs e)
        {
            if (GlobalStates.ReturnItemsCart.Items.Count == 0)
            {
                MessageBox.Show("No items in the return list.", "Nothing to Return",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 1. UPDATE SQL + MEMORY
            foreach (var item in GlobalStates.ReturnItemsCart.Items)
            {
                int newStock = item.Stock + 1;
                item.Stock = newStock;

                if (item is Book b)
                {
                    DataBaseMangement.UpdateBookStock(b.BookName, newStock);
                }
                else if (item is DVD d)
                {
                    DataBaseMangement.UpdateDVDStock(d.DVDName, newStock);
                }
            }

            // 2. CLEAR RETURN LIST
            GlobalStates.ReturnItemsCart.Clear();

            // 3. REFRESH UI
            RefreshAllItems();
            RefreshReturnList();

            MessageBox.Show("Items successfully returned and database updated.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
