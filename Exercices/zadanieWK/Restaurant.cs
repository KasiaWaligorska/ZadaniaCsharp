namespace zadanieWK;

public abstract class Restaurant
{
    public int cashAmount;
    public string name;
    private string owner;

    public Restaurant(int cashAmount, string name, string owner)
    {
        this.cashAmount = cashAmount;
        this.name = name;
        this.owner = owner;
    }

    public void PlaceOrder(string meal)
    {
        Console.WriteLine("Ta metoda nic nie robi, jest z klasy Restaurant.");
    }

    public int CashAmount => cashAmount;

    public string Name => name;
}