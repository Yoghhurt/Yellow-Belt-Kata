class Program
{
    public static void Main(string[] args)
    {
        string[] enemies = { "Goblin, Orc, Troll" };
        
        Console.WriteLine("Enemies: ");
        foreach (var enemy in enemies)
        {
            Console.WriteLine(enemy);
        }
        
        List<string> inventory = new List<string> {"Sword, Potion, Sheild"};
        
        Console.WriteLine("\nPlayer Inventory: ");
        foreach (var item in inventory)
        {
            Console.WriteLine(item);
        }
        
        inventory.Add("Helmet");
        
        Console.WriteLine("\nUpdated inventory: ");
        foreach (var item in inventory)
        {
            Console.WriteLine(item);
        }
    }
}