namespace DefaultNamespace;

public class NPC : Interacting
{
    public string Name { get; set; }

    public NPC(string name)
    {
        Name = name;
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: Welcome to our village!");
    }
}