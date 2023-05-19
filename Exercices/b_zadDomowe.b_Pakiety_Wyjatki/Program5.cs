namespace b_zadDomowe.b_Pakiety_Wyjatki;

public class Program5
{
    static void Main(string[] args)
    {
        int[] elements = {1, 4, 77, 90, 2};
        try
        {
            IndexOf(elements, 727);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("The given element doesn't exist in the table.");
        }
    }

    static int IndexOf (int[] elements, int value)
    {
        for (int i = 0; i < elements.Length-1; i++)
        {
            if (elements[i] == value)
            {
                Console.WriteLine(i);
                return i;
            }
        }
        throw new IndexOutOfRangeException();
    }
}