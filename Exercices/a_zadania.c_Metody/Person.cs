namespace a_zadania.c_Metody;

public class Person
{
    private String name = "Kasia";
    private String surname = "Waligórska";
    private int age = 33;
    private char sex = 'K';

    public void setName(String name)
    {
        this.name = name;
    }

    public void setSurname(String surname)
    {
        this.surname = surname;
    }

    public void setAge(int age)
    {
        this.age = age;
    }

    public void setSex(char sex)
    {
        this.sex = sex;
    }

    public String getFullName()
    {
        String fullName = this.name + " " + this.surname;
        Console.WriteLine(fullName);
        return fullName;
    }

    public int increaseAge()
    {
        this.age = ++age;
        return age;
    }
}