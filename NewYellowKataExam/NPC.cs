namespace NewYellowKataExam;

public class NPC : ISpeakable
{
    public string Name { get; set; }
    public string Dialogue { get; set; }

    public NPC(string name, string dialogue)
    {
        Name = name;
        Dialogue = dialogue;
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says {Dialogue}");
    }
}