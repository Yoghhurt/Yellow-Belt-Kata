namespace NewYellowKataExam;

public class Merchant : ISpeakable, ITradeable
{
    public string Name { get; set; }
    public List<Item> Inventory { get; set; }

    public Merchant(string name)
    {
        Name = name;
        Inventory = new List<Item>
        {
            new Item("Sword", 20),
            new Item("Shield", 15),
            new Item("Potion", 10)
        };
    }
    public void Speak()
    {
        Console.WriteLine($"{Name} says: Take a look at my wares.");
    }
    public void Trade(Player player)
    {
        Console.WriteLine("Available items:");
        foreach (var item in Inventory)
        {
            Console.WriteLine($"{item.Name} - {item.Price} gold");
        }

        Console.Write("Choose an item to purchase (enter item name): ");
        string choice = Console.ReadLine();
        Item selectedItem = Inventory.Find(i => i.Name.Equals(choice, StringComparison.OrdinalIgnoreCase));

        if (selectedItem != null)
        {
            player.BuyItem(selectedItem.Name, selectedItem.Price);
        }
        else
        {
            Console.WriteLine("Item not found.");
        }
    }
}