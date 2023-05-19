namespace a_zadania.g_dziedziczenie;

public class Shape
{
    public int x;
    public int y;
    public string color;

    public Shape(int x, int y, string color)
    {
        this.x = x;
        this.y = y;
        this.color = color;
    }

    public string GetDescription()
    {
        string description = "This is shape with the middle x: " + this.x + ", y: " + this.y + " and color " + this.color;
        Console.WriteLine(description);
        return description;
    }

    public double getDistance(Shape shape)
    {
        double resultX = this.x - shape.x;
        double resultY = this.y - shape.y;
        Console.WriteLine("X: " + resultX + " Y: " + resultY);
        return resultX;
    }
}