using System.Threading.Channels;
using b_zadDomowe.a_Obiekty_Klasy;

class Program
{
    static void Main(String[] args)
    {
        User user = new User(1, "Kasia", "Wu");
        Book book1 = new Book(1, "Historia Pa Salta");
        Book book2 = new Book(2, "1000 krzyżówek panoramicznych");
        Book book3 = new Book(3, "Czerwony kapturek");
        user.AddBook(book3);
        user.GetBooks();
        //user.ReturnBook(book3);
    }
}