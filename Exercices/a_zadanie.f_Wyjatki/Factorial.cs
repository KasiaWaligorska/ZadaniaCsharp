namespace a_zadanie.f_Wyjatki;

public class Factorial
{
    public Factorial()
    {
        
    }
    public int CalculateFactorial(int number)
    {
        int result = 1;
        if (number < 0)
        {
            throw new ArgumentException();
        }
        else
        {
            for (int i = 1; i < number; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
            return result;
        }
    }
}