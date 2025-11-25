using System;
using System.Windows.Forms;

namespace LibrayManagemntSystem
{
    public partial class AddNewItemFormBook : Form
    {
        public AddNewItemFormBook()
        {
            InitializeComponent();
            this.Load += AddNewItemFormBook_Load;
        }

        private void AddNewItemFormBook_Load(object sender, EventArgs e)
        {
            RefreshBookList();
        }

        private void RefreshBookList()
        {
            AllCurentBooksListBox.Items.Clear();

            foreach (var book in GlobalStates.Library.Books)
            {
                AllCurentBooksListBox.Items.Add(book.GetDisplayInfo());
            }
        }

        private void AddNewBookLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void EnterBookNameLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void EnterBookNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: live validation
        }

        private void EnterBookAuthorLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void EnterBookAuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: live validation
        }

        private void EnterBookPriceLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void EnterBookPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: live validation
        }

        private void EnterBookStockLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void EnterBookStockTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: live validation
        }

        private void EnterBookYearPublishedLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void EnterBookYearPublishedTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: live validation
        }

        private void EnterBookTypeLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void NovelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Type choice
        }

        private void ComicBookRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Type choice
        }

        private void MangaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Type choice
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            string name = EnterBookNameTextBox.Text.Trim();
            string author = EnterBookAuthorTextBox.Text.Trim();
            string priceText = EnterBookPriceTextBox.Text.Trim();
            string stockText = EnterBookStockTextBox.Text.Trim();
            string yearText = EnterBookYearPublishedTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(author) ||
                string.IsNullOrWhiteSpace(priceText) ||
                string.IsNullOrWhiteSpace(stockText) ||
                string.IsNullOrWhiteSpace(yearText) ||
                (!NovelRadioButton.Checked && !ComicBookRadioButton.Checked && !MangaRadioButton.Checked))
            {
                MessageBox.Show("Please fill in all fields and select a book type.", "Missing Data",
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
                NovelRadioButton.Checked ? "Novel" :
                ComicBookRadioButton.Checked ? "ComicBook" :
                "Manga";

            // -----------------------
            // 1. INSERT INTO SQL
            // -----------------------
            try
            {
                DataBaseMangement.InsertBook(name, author, price, stock, year, type);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return;
            }

            // -----------------------
            // 2. ADD TO MEMORY
            // -----------------------
            Book newBook;

            if (type == "Novel")
                newBook = new Novel(name, author, price, stock, year, "Novel");
            else if (type == "ComicBook")
                newBook = new ComicBook(name, author, price, stock, year, "Unknown");
            else
                newBook = new Manga(name, author, price, stock, year, "Japanese");

            GlobalStates.Library.Books.Add(newBook);

            RefreshBookList();

            // Clear inputs
            EnterBookNameTextBox.Clear();
            EnterBookAuthorTextBox.Clear();
            EnterBookPriceTextBox.Clear();
            EnterBookStockTextBox.Clear();
            EnterBookYearPublishedTextBox.Clear();
            NovelRadioButton.Checked = false;
            ComicBookRadioButton.Checked = false;
            MangaRadioButton.Checked = false;

            MessageBox.Show("New book added to inventory and database.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void AllCurrentBooksLabel_Click(object sender, EventArgs e)
        {
            // Label only
        }

        private void AllCurentBooksListBox_SelectedIndexChanged(object sender, EventArgs e)
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
