namespace a_zadania.g_dziedziczenie;

public class HourlyEmployee : Employee
{
    public HourlyEmployee (int id, String firstName, string lastName, int wage) : base(id, firstName, lastName, wage)
    {
        
    }

    public int CalculatePayment(int hours)
    {
        int result = this.wage * hours;
        Console.WriteLine("Wage for additional hours: " + result);
        return result;
    }
}