namespace b_zadDomowe.a_Obiekty_Klasy;

public class User : Person
{
    private Book[] books;

    public User(int id, string firstName, string lastName) : base(id, firstName,lastName)
    {
       this.books = new Book[0];
    }

    public void AddBook(Book book)
    {
        if (Array.IndexOf(this.books, book) >= 0)
        {
            Console.WriteLine("Książka jest już wypożyczona.");
            return;
        }

        int lengthPlus = this.books.Length + 1;
        Book[] tempArray = new Book[lengthPlus];
        for (int i = 0; i < this.books.Length; i++)
        {
            tempArray[i] = this.books[i];
        }

        tempArray[lengthPlus - 1] = book;
        this.books = tempArray;
        Console.WriteLine("Książka zostałą wypożyczona.");
    }

    public void ReturnBook(Book book)
    {
        int returnedBookId = book.GetId();
        for (int i = 0; i < this.books.Length; i++)
        {
            int id = this.books[i].GetId();
            if (id == returnedBookId)
            {
                for (int j = i; j < this.books.Length - 1; j++)
                {
                    this.books[j] = this.books[j + 1];
                }
                Array.Resize(ref this.books, this.books.Length - 1);
                book.SetAvailable(true);
                Console.WriteLine("Book returned: " + book.GetTitle());
                return;
            }
        }
        Console.WriteLine("User does not have the book: " + book.GetTitle());
    }

    public void ReturnAllBooks()
    {
        this.books = new Book[0];
        Console.WriteLine("All books returned.");
    }
    public void GetBooks()
    {
        Console.WriteLine("Wypożyczone książki:");
        if (this.books.Length == 0)
        {
            Console.WriteLine("Nie masz wypożyczonych książek.");
            return;
        }
        for (int i = 0; i < this.books.Length; i++)
        {
            string title = this.books[i].GetTitle();
            Console.WriteLine(title);
        }
    }
}