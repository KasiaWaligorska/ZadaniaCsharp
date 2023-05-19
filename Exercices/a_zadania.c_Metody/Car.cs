namespace a_zadania.c_Metody;

public class Car
{
    public String brand;
    public String model;
    public int price;

    public void setBrand(String brand)
    {
        this.brand = brand;
    }
    
    public void setModel(String model)
    {
        this.model = model;
    }
    
    public void setPrice(int price)
    {
        this.price = price;
    }

    public String getBrand()
    {
        Console.WriteLine(this.brand);
        return this.brand;
    }
    
    public String getModel()
    {
        Console.WriteLine(this.model);
        return this.model;
    }
    
    public int getPrice()
    {
        Console.WriteLine(this.price);
        return this.price;
    }

    public String toString()
    {
        String toString = this.brand + " " + this.price;
        Console.WriteLine(toString);
        return toString;
    }
}