using System.Runtime.CompilerServices;

namespace zadanieWK;

public class FastFood : Restaurant, OrderSupplies
{
    public Dictionary<string, int> menu;
    private List<string> orderedMealsList;
    private String fastFoodEmployee;
    public FastFood(int cashAmount, string name, string owner, string fastFoodEmployee) : base(cashAmount, name, owner)
    {
        this.fastFoodEmployee = fastFoodEmployee;
        this.menu = new Dictionary<string, int>();
        this.orderedMealsList = new List<string>();
        menu.Add("Burger", 30);
        menu.Add("French fries", 10);
        menu.Add("Hot-dog",15);
    }

    public void PlaceOrder(string meal)
    {
        if (this.menu.TryGetValue(meal, out int mealPrice))
        {
            this.cashAmount = this.cashAmount + mealPrice;
            String orderedMeal = "Ordered element with name " + meal + " and price " + mealPrice + ".";
            this.orderedMealsList.Add(orderedMeal);
        }
        else
        {
            Console.WriteLine("There is no such meal in our menu.");
        }
    }

    public void DisplayOrderedMeals()
    {
        Console.WriteLine("Ordered Meals from fastfood menu:");
        foreach (string meal in orderedMealsList)
        {
            Console.WriteLine(meal);
        }
    }
    
    public void PlaceOrderForSupplies()
    {
        Console.WriteLine("Placing order for supplies for the fastfood.");
        Console.WriteLine("Ordering 50 kg of potatoes.");
        Console.WriteLine("Ordering 20 kg of beef meat.");
        Console.WriteLine("Ordering 100 hot dog buns.");

        Console.WriteLine("Order for supplies placed successfully.");
    }
}