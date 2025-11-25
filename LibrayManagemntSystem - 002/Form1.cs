using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibrayManagemntSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LibraryManagemntSystemLable_Click(object sender, EventArgs e)
        {
            // Title label; no logic needed here.
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Exit the whole application
            Application.Exit();
        }

        private void RentAnItemButton_Click(object sender, EventArgs e)
        {
            // Go to RentAnItemForm
            var form = new RentAnItemForm
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            form.Show();
            this.Hide();
        }

        private void ReturnAnItemButton_Click(object sender, EventArgs e)
        {
            // Go to ReturnAnItemForm
            var form = new ReturnAnItemForm
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            form.Show();
            this.Hide();
        }

        private void AddNewBookButton_Click(object sender, EventArgs e)
        {
            // Go to AddNewItemFormBook
            var form = new AddNewItemFormBook
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            form.Show();
            this.Hide();
        }

        private void AddNewDVDButton_Click(object sender, EventArgs e)
        {
            // Go to AddNewItemFormDVD
            var form = new AddNewItemFormDVD
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            form.Show();
            this.Hide();
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(
                @"Server=(localdb)\MSSQLLocalDB;Database=LibraryManagementSystem;Integrated Security=True;"))
            {
                conn.Open();
                MessageBox.Show("SQL Connected!");
            }
        }
        */
    }
}
