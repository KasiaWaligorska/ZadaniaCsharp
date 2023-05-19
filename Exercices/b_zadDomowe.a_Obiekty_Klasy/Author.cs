namespace b_zadDomowe.a_Obiekty_Klasy
{
    public class Author : Person
    {
        private string pseudonym;

        public Author(int id, string firstName, string lastName, string pseudonym) : base(id, firstName, lastName)
        {
            this.pseudonym = pseudonym;
        }
    }
}