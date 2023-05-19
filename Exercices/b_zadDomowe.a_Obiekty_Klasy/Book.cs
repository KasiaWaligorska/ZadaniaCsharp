namespace b_zadDomowe.a_Obiekty_Klasy;

public class Book
{
    private int id;
    private string title;
    private bool available = true;
    private Author author;
    private Author[] additionalAuthors = new Author[]{};
    private int popularity;

    public Book(int id, string title)
    {
        this.id = id;
        this.title = title;
    }
    
    public Book(int id, string title, Author author)
    {
        this.id = id;
        this.title = title;
        this.author = author;
    }
    
    public Book(int id, string title, Author author, Author[] additionalAuthors)
    {
        this.id = id;
        this.title = title;
        this.author = author;
        this.additionalAuthors = this.additionalAuthors;
    }

    public void Equals(Book book)
    {
        if (this.id == book.id)
        {
            Console.WriteLine("These are the same books.");
        }
        else
        {
            Console.WriteLine("Books are not the same.");
        }
    }

    public void BorrowBook(User user)
    {
        if (this.available == true)
        {
            Console.WriteLine("Book borrowed: " + this.title);
            user.AddBook(this);
            this.available = false;
            this.popularity++;
        }
        else
        {
            Console.WriteLine("Book is not available for borrowing.");
        }
    }

    public void ReturnBook()
    {
        if (this.available == false)
        {
            Console.WriteLine("Book " + this.title + " returned.");
            this.available = true;
        }
        else
        {
            Console.WriteLine("Book is already available.");
        }
    }
    
    public int GetId()
    {
       // Console.WriteLine(this.id);
        return this.id;
    }
    
    public String GetTitle()
    {
        // Console.WriteLine(this.title);
        return this.title;
    }
    public void GetAuthor()
    {
        Console.WriteLine(this.author);
    }
    public bool GetAvailable()
    {
        Console.WriteLine(this.available);
        return this.available;
    }
    public void GetAdditionalAuthors()
    {
        Console.WriteLine(this.additionalAuthors);
    }

    public void getPopularit()
    {
        Console.WriteLine(this.popularity);
    }

    public void SetAvailable(bool a)
    {
        this.available = a;
    }
    
    
}