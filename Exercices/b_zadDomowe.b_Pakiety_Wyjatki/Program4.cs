/*namespace b_zadDomowe.b_Pakiety_Wyjatki;

public class Program4
{
    static void Main(string[] args)
    {
        try
        {
            ToInt("12 34 ");
        }
        catch (FormatException e)
        {
            Console.WriteLine("Can't be converted to number");
        }
    }
    
    static int ToInt(String str)
    {
        int IntFromString;
        if (int.TryParse(str.Trim(), out IntFromString))
        {
            Console.WriteLine(IntFromString);
            return IntFromString;
        }
        else
        {
            throw new FormatException();
        }
        return 0;
    }
}*/