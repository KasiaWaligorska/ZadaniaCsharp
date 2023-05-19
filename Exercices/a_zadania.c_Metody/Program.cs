using a_zadania.c_Metody;

class Program
{
    static void Main(String[] args)
    {
        Person person = new Person();
        person.setName("Mateusz");
        person.setSurname("Kowalski");
        person.setSex('M');
        person.setAge(33);
        person.getFullName();
    }
}