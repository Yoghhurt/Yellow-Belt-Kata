namespace NewYellowKataExam;

public class Merchant : ISpeakable, ITradeable
{
    public string Name { get; set; }
    public List<string> Inventory { get; set; }

    public Merchant(string name)
    {
        Name = name;
        Inventory = new List<string>{"Sword", "Shield", "Potion"};
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: Have a look at my wears!");
    }

    public void Trade()
    {
        Console.WriteLine("Available items: " + string.Join(",", Inventory));
    }
}