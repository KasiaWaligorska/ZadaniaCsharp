using a_zadania.d_Konstruktor;

class Program
{
    static void Main(String[] args)
    {
        Calculator calculator = new Calculator();
        calculator.Add(3, 3);
        calculator.Divide(3, 3);
        calculator.PrintOperations();
        calculator.ClearOperations();
    }
}