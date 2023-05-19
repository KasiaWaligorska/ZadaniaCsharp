namespace a_zadania.d_Konstruktor;

public class Person
{
    private String name;
    private String surname;
    private int age;
    private char sex;

    public Person(String name, String surname)
    {
        this.name = name;
        this.surname = surname;
    }
    
    public Person(String name, int age)
    {
        this.name = name;
        this.age = age;
    }
    
    public Person(String name, String surname, int age, char sex)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.sex = sex;
    }
}