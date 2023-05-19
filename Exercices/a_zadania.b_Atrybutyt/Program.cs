using System.Runtime.CompilerServices;
using a_zadania.b_Atrybuty;

public class Program
{
    static void Main(string[] args)
    {
        AccessModifier testAttribute = new AccessModifier();
        string publicAttribute = testAttribute.publicAttribute;
        publicAttribute = "To jest atrybut publiczny";
        Console.WriteLine(publicAttribute);

        Person person = new Person();
        Console.WriteLine(person.name);
        Console.WriteLine(person.surname);
        Console.WriteLine(person.age);
        Console.WriteLine(person.sex);
    }
}