// Book book1 = new Book();
// book1.Title = "The Hobbit";
// book1.Author = "J.R.R Tolkien";
Book book1 = new Book("The Hobbit","J.R.R Tolkien");
// Console.WriteLine($"{book1.Title} by {book1.Author}");
//book1.PrintSummary();
Book book2 = new Book("Dune","Frank Herbert");
book1.Title = "The Hobitt - Updated";
book2.Pages = 888;
book1.PrintSummary();
book2.PrintSummary();
class Book 
{
    // public int Pages;   // field
    public int Pages { get; set;} // auto-implemented property
    public string Title {get; set;}
    public string Author {get; set;}

    public Book(string title, string author, int pages = 0 )
    {
        this.Title = title;
        this.Author = author;
        this.Pages = pages;
    }

    public void PrintSummary()
    {
        Console.WriteLine($"{Title} by {Author} ({Pages} pages)");
    }
}

