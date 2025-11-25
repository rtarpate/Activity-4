using System;
using System.Windows.Forms;

namespace LibrayManagemntSystem
{
    public partial class AddNewItemFormDVD : Form
    {
        public AddNewItemFormDVD()
        {
            InitializeComponent();
            this.Load += AddNewItemFormDVD_Load;
        }

        private void AddNewItemFormDVD_Load(object sender, EventArgs e)
        {
            RefreshDVDList();
        }

        private void RefreshDVDList()
        {
            AllCurentDVDsListBox.Items.Clear();

            foreach (var dvd in GlobalStates.Library.DVDs)
            {
                AllCurentDVDsListBox.Items.Add(dvd.GetDisplayInfo());
            }
        }

        private void AddNewDVDLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void EnterBookNameLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void EnterDVDNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: validation
        }

        private void EnterDVDDirectorLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void EnterDVDDirectorTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: validation
        }

        private void EnterDVDPriceLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void EnterDVDPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: validation
        }

        private void EnterDVDStockLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void EnterDVDStockTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: validation
        }

        private void EnterDVDYearPublishedLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void EnterDVDYearPublishedTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: validation
        }

        private void EnterDVDTypeLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void HDDVDRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Type choice
        }

        private void BlueRayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Type choice
        }

        private void VHSRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Type choice
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            string name = EnterDVDNameTextBox.Text.Trim();
            string director = EnterDVDDirectorTextBox.Text.Trim();
            string priceText = EnterDVDPriceTextBox.Text.Trim();
            string stockText = EnterDVDStockTextBox.Text.Trim();
            string yearText = EnterDVDYearPublishedTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(director) ||
                string.IsNullOrWhiteSpace(priceText) ||
                string.IsNullOrWhiteSpace(stockText) ||
                string.IsNullOrWhiteSpace(yearText) ||
                (!HDDVDRadioButton.Checked && !BlueRayRadioButton.Checked && !VHSRadioButton.Checked))
            {
                MessageBox.Show("Please fill in all fields and select a DVD type.", "Missing Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(priceText, out int price) ||
                !int.TryParse(stockText, out int stock) ||
                !int.TryParse(yearText, out int year))
            {
                MessageBox.Show("Price, Stock, and Year Published must be whole numbers.", "Invalid Numbers",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string type =
                HDDVDRadioButton.Checked ? "HDDVD" :
                BlueRayRadioButton.Checked ? "BluRay" :
                "VHS";

            // -----------------------
            // 1. INSERT INTO SQL
            // -----------------------
            try
            {
                DataBaseMangement.InsertDVD(name, director, price, stock, year, type);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return;
            }

            // -----------------------
            // 2. ADD TO MEMORY
            // -----------------------
            DVD newDvd;

            if (type == "HDDVD")
                newDvd = new HDDVD(name, director, price, stock, year, "1080p");
            else if (type == "BluRay")
                newDvd = new BluRay(name, director, price, stock, year, true);
            else
                newDvd = new VHS(name, director, price, stock, year, "Good");

            GlobalStates.Library.DVDs.Add(newDvd);

            RefreshDVDList();

            // Clear inputs
            EnterDVDNameTextBox.Clear();
            EnterDVDDirectorTextBox.Clear();
            EnterDVDPriceTextBox.Clear();
            EnterDVDStockTextBox.Clear();
            EnterDVDYearPublishedTextBox.Clear();
            HDDVDRadioButton.Checked = false;
            BlueRayRadioButton.Checked = false;
            VHSRadioButton.Checked = false;

            MessageBox.Show("New DVD added to inventory and database.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void AllCurrentDVDLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void AllCurentDVDsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: show details when selected
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
    }
}
