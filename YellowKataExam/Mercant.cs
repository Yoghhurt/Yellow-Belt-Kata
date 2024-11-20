namespace DefaultNamespace;

public class Mercant : Trading
{
    public string Name { get; set; }
    private List<string> Inventory { get; set; }

    public Merchant(string name)
    {
        Name = name;
        Inventory = new List<string> { "Sword", "Shield", "Potion" };
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: Take a look at my wares.");
    }

    public void ShowInventory()
    {
        Console.WriteLine("Available items:");
        foreach (var item in Inventory)
        {
            Console.WriteLine($"- {item}");
        }
    }

    public void TradeItem(string item, int cost)
    {
        Console.WriteLine($"You purchased {item} for {cost} gold.");
    }
}