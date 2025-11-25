using System.Collections.Generic;
using System.Linq;

namespace LibrayManagemntSystem
{
    internal class LibraryManager
    {
        public List<Book> Books { get; } = new();
        public List<DVD> DVDs { get; } = new();

        public LibraryManager()
        {
            /*
            LoadSampleData();
            */

            LoadFromDatabase();
        }

        /*
        private void LoadSampleData()
        {
            // Books from the original console program
            Books.AddRange(new List<Book>
            {
                new Novel("The Lost World", "Arthur Conan Doyle", 15, 100, 1912, "Adventure"),
                new Novel("Pride and Prejudice", "Jane Austen", 10, 100, 1813, "Romance"),
                new Novel("1984", "George Orwell", 18, 100, 1949, "Dystopian"),
                new ComicBook("Spider-Man", "Stan Lee", 8, 100, 1962, "Steve Ditko"),
                new Manga("Naruto", "Masashi Kishimoto", 11, 100, 1999, "Japanese")
            });

            // DVDs from the original console program
            DVDs.AddRange(new List<DVD>
            {
                new HDDVD("Matrix Reloaded", "Lana Wachowski", 20, 100, 2003, "1080p"),
                new HDDVD("Troy", "Wolfgang Petersen", 17, 100, 2004, "1080i"),
                new BluRay("Inception", "Christopher Nolan", 25, 100, 2010, true),
                new BluRay("Avatar", "James Cameron", 28, 100, 2009, true),
                new VHS("Star Wars", "George Lucas", 5, 100, 1977, "Good")
            });
        }
        */

        public List<IInventoryItem> GetAllItems()
        {
            var list = new List<IInventoryItem>();
            list.AddRange(Books);
            list.AddRange(DVDs);
            return list;
        }

        public List<IInventoryItem> GetAvailableItems()
        {
            return GetAllItems()
                .Where(i => i.Stock > 0)
                .ToList();
        }

        public void LoadFromDatabase()
        {
            Books.Clear();
            DVDs.Clear();

            Books.AddRange(DataBaseMangement.LoadAllBooks());
            DVDs.AddRange(DataBaseMangement.LoadAllDVDs());
        }

    }
}
