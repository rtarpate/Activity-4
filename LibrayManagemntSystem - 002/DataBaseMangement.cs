using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace LibrayManagemntSystem
{
    internal class DataBaseMangement
    {
        // ★ IMPORTANT ★
        // Your correct SQL Server Express instance
        private static readonly string _connectionString =
            @"Server=ASHTONPC002\SQLEXPRESS;Database=LibraryManagementSystem;Integrated Security=True;";

        // ============================================================
        //  LOAD ALL BOOKS FROM DATABASE
        // ============================================================
        public static List<Book> LoadAllBooks()
        {
            List<Book> books = new();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Books", conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Base Book object
                    var book = new Book(
                        reader["BookName"].ToString(),
                        reader["BookAuthor"].ToString(),
                        Convert.ToInt32(reader["BookPrice"]),
                        Convert.ToInt32(reader["BookStock"]),
                        Convert.ToInt32(reader["BookYearPublished"])
                    );

                    // Derive correct child object (Novel / ComicBook / Manga)
                    string type = reader["BookType"].ToString();

                    if (type == "Novel")
                        book = new Novel(book.BookName, book.BookAuthor, book.BookPrice, book.BookStock, book.BookYearPublished, "Novel");
                    else if (type == "ComicBook")
                        book = new ComicBook(book.BookName, book.BookAuthor, book.BookPrice, book.BookStock, book.BookYearPublished, "Unknown");
                    else if (type == "Manga")
                        book = new Manga(book.BookName, book.BookAuthor, book.BookPrice, book.BookStock, book.BookYearPublished, "Japanese");

                    books.Add(book);
                }
            }

            return books;
        }

        // ============================================================
        //  LOAD ALL DVDS FROM DATABASE
        // ============================================================
        public static List<DVD> LoadAllDVDs()
        {
            List<DVD> dvds = new();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM DVDs", conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Base DVD object
                    var dvd = new DVD(
                        reader["DVDName"].ToString(),
                        reader["DVDDirector"].ToString(),
                        Convert.ToInt32(reader["DVDPrice"]),
                        Convert.ToInt32(reader["DVDStock"]),
                        Convert.ToInt32(reader["DVDYearPublished"])
                    );

                    string type = reader["DVDType"].ToString();

                    if (type == "HDDVD")
                        dvd = new HDDVD(dvd.DVDName, dvd.DVDDirector, dvd.DVDPrice, dvd.DVDStock, dvd.DVDYearPublished, "1080p");
                    else if (type == "BluRay")
                        dvd = new BluRay(dvd.DVDName, dvd.DVDDirector, dvd.DVDPrice, dvd.DVDStock, dvd.DVDYearPublished, true);
                    else if (type == "VHS")
                        dvd = new VHS(dvd.DVDName, dvd.DVDDirector, dvd.DVDPrice, dvd.DVDStock, dvd.DVDYearPublished, "Good");

                    dvds.Add(dvd);
                }
            }

            return dvds;
        }

        // ============================================================
        //  INSERT NEW BOOK INTO DATABASE
        // ============================================================
        public static void InsertBook(string name, string author, int price, int stock, int year, string type)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO Books (BookName, BookAuthor, BookPrice, BookStock, BookYearPublished, BookType) " +
                "VALUES (@n, @a, @p, @s, @y, @t)", conn))
            {
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@a", author);
                cmd.Parameters.AddWithValue("@p", price);
                cmd.Parameters.AddWithValue("@s", stock);
                cmd.Parameters.AddWithValue("@y", year);
                cmd.Parameters.AddWithValue("@t", type);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ============================================================
        //  INSERT NEW DVD INTO DATABASE
        // ============================================================
        public static void InsertDVD(string name, string director, int price, int stock, int year, string type)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO DVDs (DVDName, DVDDirector, DVDPrice, DVDStock, DVDYearPublished, DVDType) " +
                "VALUES (@n, @d, @p, @s, @y, @t)", conn))
            {
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@d", director);
                cmd.Parameters.AddWithValue("@p", price);
                cmd.Parameters.AddWithValue("@s", stock);
                cmd.Parameters.AddWithValue("@y", year);
                cmd.Parameters.AddWithValue("@t", type);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ============================================================
        //  UPDATE BOOK STOCK (FOR RENT / RETURN)
        // ============================================================
        public static void UpdateBookStock(string name, int newStock)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE Books SET BookStock=@s WHERE BookName=@n", conn))
            {
                cmd.Parameters.AddWithValue("@s", newStock);
                cmd.Parameters.AddWithValue("@n", name);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ============================================================
        //  UPDATE DVD STOCK (FOR RENT / RETURN)
        // ============================================================
        public static void UpdateDVDStock(string name, int newStock)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE DVDs SET DVDStock=@s WHERE DVDName=@n", conn))
            {
                cmd.Parameters.AddWithValue("@s", newStock);
                cmd.Parameters.AddWithValue("@n", name);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
