using a_zadania.g_dziedziczenie;

class Program
{
    static void Main(String[] args)
    {
        /*AdvancedCalculator advancedCalculator = new AdvancedCalculator();
        advancedCalculator.root(8, 3);
        advancedCalculator.pow(8, 3);
        advancedCalculator.PrintOperations();*/

        /*Shape shape1 = new Shape(3, 3, "blue");
        Shape shape2 = new Shape(1, 5, "red");
        shape1.GetDescription();
        shape2.GetDescription();
        shape1.getDistance(shape2);
        shape2.getDistance(shape1);*/

        /*Circle circle = new Circle(5, 4, "green", 2);
        circle.GetDescription();
        circle.GetArea();
        circle.GetCircuit();*/

        /*Employee employee = new Employee(123, "Marek", "Marecki", 4500);
        employee.GetWage();
        employee.RaiseWage(0);
        employee.GetWage();*/

        /*HourlyEmployee hourlyEmployee = new HourlyEmployee(45, "A", "B", 20);
        hourlyEmployee.CalculatePayment(168);*/

        SalariedEmployee salariedEmployee = new SalariedEmployee(3, "d", "s", 150);
        salariedEmployee.CalculatePayment();
    }
}