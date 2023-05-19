namespace a_zadania.g_dziedziczenie;

public class Circle : Shape
{
    private int radius;
    
    public Circle(int x, int y, string color, int radius) : base(x, y, color)
    {
        this.radius = radius;
    }

    public string GetDescription()
    {
        string description = "This is shape with the middle x: " + this.x + ", y: " + this.y + ", radius: " + this.radius + " and color " + this.color;
        Console.WriteLine(description);
        return description;
    }

    public double GetArea()
    {
        double area = Math.Floor(Math.Sqrt(Math.PI * this.radius));
        Console.WriteLine("Area of the circle equals: " + area);
        return area;
    }
    
    public double GetCircuit()
    {
        double circuit = 2 * Math.PI * this.radius;
        Console.WriteLine("Circuit of the circle equals: " + circuit);
        return circuit;
    }
}