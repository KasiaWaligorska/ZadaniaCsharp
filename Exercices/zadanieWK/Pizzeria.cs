namespace zadanieWK;

public class Pizzeria : Restaurant, OrderSupplies
{
    public Dictionary<string, int> pizzeriaMenu;
    private string pizzeriaEmployee;
    public Pizzeria(int cashAmount, string name, string owner, string pizzeriaEmployee) : base(cashAmount, name, owner)
    {
        this.pizzeriaEmployee = pizzeriaEmployee;
        this.pizzeriaMenu = new Dictionary<string, int>();
        pizzeriaMenu.Add("Pizza", 45);
    }
    
    public void PlaceOrder(string meal)
    {
        if (this.pizzeriaMenu.TryGetValue(meal, out int mealPrice))
        {
            this.cashAmount = this.cashAmount + mealPrice;
            String orderedMeal = "Ordered element with name " + meal + " and price " + mealPrice + ".";
            Console.WriteLine(orderedMeal);
        }
        else
        {
            Console.WriteLine("There is no such meal in our menu.");
        }
    }
    
    public void PlaceOrderForSupplies()
    {
        Console.WriteLine("Placing order for supplies for the pizzeria.");
        Console.WriteLine("Ordering 50 kg of flour.");
        Console.WriteLine("Ordering 20 kg of cheese.");
        Console.WriteLine("Ordering 10 kg of tomatoes.");
        Console.WriteLine("Order for supplies placed successfully.");
    }
}