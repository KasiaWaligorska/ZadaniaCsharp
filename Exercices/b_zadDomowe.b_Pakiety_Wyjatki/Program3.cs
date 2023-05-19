/*namespace b_zadDomowe.b_Pakiety_Wyjatki;

public class Program3
{
    static void Main(string[] args)
    {
        try
        {
            GetLength(null);
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine("Null is not allowed.");
        }

        static int GetLength(String str)
        {
            if (str == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                int length = str.Length;
                Console.WriteLine(length);
                return length;
            }
        }
    }
}*/