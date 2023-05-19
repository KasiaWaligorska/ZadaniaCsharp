/*class Program
{
    static void Main(String[] args)
    {
        try
        {
            Average("3", "0");
        }
        catch (FormatException e)
        {
            Console.WriteLine("Only numbers can be provided.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Can't divide by 0!");
        }
        
        static void Average(String a, String b)
        {
            double numA = Convert.ToDouble(a);
            double numB = Convert.ToDouble(b);
            if (numB == 0)
            {
                throw new DivideByZeroException();
            }
            if (!double.TryParse(a, out numA) || !double.TryParse(b, out numB))
            {
                throw new FormatException();
            }
            else
            {
                double result = numA/numB;
                Console.WriteLine("The result: " + result);
            }
        }
    }
}*/