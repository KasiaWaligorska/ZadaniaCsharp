namespace a_zadania.g_dziedziczenie;

public class SalariedEmployee : Employee
{
    public SalariedEmployee(int id, string firstName, string lastName, int wage) : base(id, firstName, lastName, wage)
    {
        
    }

    public int CalculatePayment()
    {
        int hoursInMonth = 160;
        int payment = hoursInMonth * this.wage;
        Console.WriteLine(payment);
        return payment;
    }
}