/*namespace b_zadDomowe.b_Pakiety_Wyjatki;

public class Program2
{
    static void Main(String[] args) {

        string[] strTab = {"Ala", "ma ", "kota."};

        try
        {
            SafeGet(strTab, 4);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Index is out of range.");
        }
        
        static string SafeGet(string[] strTab, int index)
        {
            if (index > strTab.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                for (int i = 0; i < strTab.Length; i++)
                {
                    if (i == index)
                    {
                        Console.WriteLine(strTab[i]);
                        return strTab[i];
                    }
                }
            }
            return null;
        }
    }
}*/