namespace LibrayManagemntSystem
{
    internal class Book : IInventoryItem
    {
        public string BookName { get; set; } = string.Empty;
        public string BookAuthor { get; set; } = string.Empty;
        public int BookPrice { get; set; }
        public int BookStock { get; set; }
        public int BookYearPublished { get; set; }

        // For IInventoryItem
        public int Stock
        {
            get => BookStock;
            set => BookStock = value;
        }

        public Book(string bookname, string bookauthor, int bookprice, int bookstock, int bookyearpublished)
        {
            BookName = bookname;
            BookAuthor = bookauthor;
            BookPrice = bookprice;
            BookStock = bookstock;
            BookYearPublished = bookyearpublished;
        }

        public virtual string GetDisplayInfo()
        {
            return $"Book: {BookName} | Author: {BookAuthor} | Price: ${BookPrice} | Stock: {BookStock} | Year: {BookYearPublished}";
        }
    }

    internal class Novel : Book
    {
        public string Genre { get; set; }

        public Novel(string bookname, string bookauthor, int bookprice, int bookstock, int bookyearpublished, string genre)
            : base(bookname, bookauthor, bookprice, bookstock, bookyearpublished)
        {
            Genre = genre;
        }

        public override string GetDisplayInfo()
        {
            return base.GetDisplayInfo() + $" | Genre: {Genre}";
        }
    }

    internal class ComicBook : Book
    {
        public string Illustrator { get; set; }

        public ComicBook(string bookname, string bookauthor, int bookprice, int bookstock, int bookyearpublished, string illustrator)
            : base(bookname, bookauthor, bookprice, bookstock, bookyearpublished)
        {
            Illustrator = illustrator;
        }

        public override string GetDisplayInfo()
        {
            return base.GetDisplayInfo() + $" | Illustrator: {Illustrator}";
        }
    }

    internal class Manga : Book
    {
        public string Language { get; set; }

        public Manga(string bookname, string bookauthor, int bookprice, int bookstock, int bookyearpublished, string language)
            : base(bookname, bookauthor, bookprice, bookstock, bookyearpublished)
        {
            Language = language;
        }

        public override string GetDisplayInfo()
        {
            return base.GetDisplayInfo() + $" | Language: {Language}";
        }
    }
}
