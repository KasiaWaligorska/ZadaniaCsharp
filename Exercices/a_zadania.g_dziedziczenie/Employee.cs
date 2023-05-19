namespace a_zadania.g_dziedziczenie;

public class Employee
{
    public int id;
    public string firstName;
    public string lastName;
    public int wage;

    public Employee(int id, string firstName, string lastName, int wage)
    {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.wage = wage;
    }

    public int RaiseWage(int percent)
    {
        if (percent > 0)
        {
            this.wage = wage + (wage * percent) / 100;
            return wage;
        }
        else
        {
            Console.WriteLine("Amount of the raise must be bigger than 0");
        }

        return wage;
    }

    public void GetWage()
    {
        Console.WriteLine("The wage of the employee equals: " + this.wage);
    }
}