namespace b_zadDomowe.a_Obiekty_Klasy;

public class BankAccount
{
    private int number;
    private double cash;

    public BankAccount(int number)
    {
        this.number = number;
        this.cash = 0;
    }

    public int GetNumber()
    {
        Console.WriteLine("Number: " + this.number);
        return number;
    }
    
    public double GetCash()
    {
        Console.WriteLine("Cash: " + this.cash);
        return cash;
    }

    public void DepositCash(int amount)
    {
        if (amount > 0)
        {
            this.cash = this.cash + amount;
            Console.WriteLine("Cash deposited: " + amount);
        }
        else
        {
            Console.WriteLine("The amount must be bigger than 0");
        }
    }

    public double withdrawCash(double amount)
    {
        if (amount > 0)
        {
            if (amount <= this.cash)
            {
                this.cash = this.cash - amount;
                Console.WriteLine("Cash withdrawed: " + amount);
                return amount;
            }
            else
            {
                amount = this.cash;
                this.cash = 0;
                Console.WriteLine("Cash withdrawed: " + amount);
                return amount;
            }
        }
        else
        {
            Console.WriteLine("The amount must be bigger than 0");
        }

        return amount;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Account number: " + this.number + ". Cash: " + this.cash);
    }
}