using a_zadania.d_Konstruktor;

namespace a_zadania.g_dziedziczenie;

public class AdvancedCalculator : Calculator
{
    public AdvancedCalculator()
    {
        
    }

    public double pow(int num1, int num2)
    {
        double result = Math.Pow(num1, num2) ;
        String operation = num1 + "^" + num2 + " equals " + result;
        AddToOperationList(operation);
        return result;
    }

    public double root(int num1, int num2)
    {
        double result = Math.Pow(num1, 1.0/num2);
        String operation = num2 + " root of " + num1 + " equals " + result;
        AddToOperationList(operation);
        return result;
    }
}