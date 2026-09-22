using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        try
        {
            Book book = new Book("Clean Code", 464); // construct an object
            book.Pages = 500;   // accepted
            book.Pages = -50;   // rejected 
            Console.WriteLine($"{book.Title}: {book.Pages} pages");  // reads two properties               
        }
        catch(ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}


class Book
{
    public string Title { get; }    // read-only

    // public int Pages { get; set; }  // read and write

    private int _pages; // Backing Field
    public int Pages    // Validated Property
    {
        //get => _pages;
        get
        {
            return _pages;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value),"Pages must be greater than zero.");
            }
            _pages = value;
        }
    }

    public Book(string title, int pages)
    {
        Title = title;
        Pages = pages;  // use the property, not _pages
    }
}