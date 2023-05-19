namespace zadanieWK;

public class Customer
{
    private string name;
    private int cash;
    private List<string> orderedMeals;

    public Customer(string name, int cash)
    {
        this.name = name;
        this.cash = cash;
        this.orderedMeals = new List<string>();
    }

    public void BuyMeal(string meal, Restaurant restaurant)
    {
        if (restaurant is Pizzeria pizzeria && pizzeria.pizzeriaMenu.TryGetValue(meal, out int restaurantMealPrice))
        {
            if (restaurantMealPrice > this.cash)
            {
                Console.WriteLine("Not enough money to buy this meal!");
            }
            else
            {
                this.cash -= restaurantMealPrice;
                string eatenMeal = meal + " from " + pizzeria.name + ".";
                orderedMeals.Add(eatenMeal);
                pizzeria.PlaceOrder(meal);
            }
        } else if (restaurant is FastFood fastFood && fastFood.menu.TryGetValue(meal, out int fastfoodMealPrice))
        {
            if (fastfoodMealPrice > this.cash)
            {
                Console.WriteLine("Not enough money to buy this meal!");
            }
            else
            {
                this.cash -= fastfoodMealPrice;
                string eatenMeal = meal + " from " + fastFood.name + ".";
                orderedMeals.Add(eatenMeal);
                fastFood.PlaceOrder(meal);
            }
        } else
        {
            Console.WriteLine("This restaurant doesn't have such meal in the menu.");
        }
    }

    /*public void buyMealFromPizzeria(string meal, Pizzeria pizzeria)
    {
        if (pizzeria.pizzeriaMenu.TryGetValue(meal, out int mealPrice))
        {
            if (mealPrice > this.cash)
            {
                Console.WriteLine("Not enough money to buy this meal!");
            }
            else
            {
                this.cash -= mealPrice;
                String eatenMeal = "I have eaten meal " + meal + " from " + pizzeria.name + ".";
                orderedMeals.Add(eatenMeal);
                pizzeria.PlaceOrder(meal);
            }
        }
        else
        {
            Console.WriteLine("This restaurant doesn't have such meal in the menu.");
        }
    }
    
    public void buyMealFromFastFood(string meal, FastFood fastFood)
    {
        if (fastFood.menu.TryGetValue(meal, out int mealPrice))
        {
            if (mealPrice > this.cash)
            {
                Console.WriteLine("Not enough money to buy this meal!");
            }
            else
            {
                this.cash -= mealPrice;
                String eatenMeal = "I have eaten meal " + meal + " from " + fastFood.name + ".";
                orderedMeals.Add(eatenMeal);
                fastFood.PlaceOrder(meal);
            }
        }
        else
        {
            Console.WriteLine("This restaurant doesn't have such meal in the menu.");
        }
    }*/

    public string Name => name;

    public int Cash => cash;

    public void DisplayOrderedMeals()
    {
        Console.WriteLine("Ordered Meals:");
        foreach (string meal in orderedMeals)
        {
            Console.WriteLine(meal);
        }
    }
}

//jak dodać zabezpieczenie przeed podaniem złej nazwy restauracji?