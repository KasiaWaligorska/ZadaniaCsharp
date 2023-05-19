using zadanieWK;

class Program
{
    static void Main(String[] args)
    {
        Pizzeria pizzeria = new Pizzeria(1000,"Italiano","Mario", "Luigi");
        FastFood fastFood = new FastFood(500, "Piri piri", "Robert", "Adaś");
        Customer customer1 = new Customer("Bartek", 75);
        customer1.BuyMeal("Pizza", pizzeria);
        customer1.BuyMeal("Hot-dog", fastFood);
        Console.WriteLine(customer1.Cash);
        customer1.DisplayOrderedMeals();
        fastFood.DisplayOrderedMeals();
        Console.WriteLine(pizzeria.CashAmount);
        Console.WriteLine(fastFood.CashAmount);
      //  fastFood.PlaceOrderForSupplies();
        pizzeria.PlaceOrderForSupplies();
    }
}