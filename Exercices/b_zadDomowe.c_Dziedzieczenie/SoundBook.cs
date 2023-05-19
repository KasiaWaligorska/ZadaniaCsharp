using b_zadDomowe.a_Obiekty_Klasy;

namespace b_zadDomowe.c_Dziedzieczenie;

public class SoundBook : Book 
{
    private int duration;
    private int numberOfCarriers;

    public SoundBook(int id, string title, int duration, int numberOfCarriers) : base(id, title)
    {
        this.duration = duration;
        this.numberOfCarriers = numberOfCarriers;
    }
}