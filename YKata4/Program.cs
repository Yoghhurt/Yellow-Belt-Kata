using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] enemies = { "Goblin", "Orc", "Troll", "Skeleton", "Dragon" };
        
        Console.WriteLine("Enemies:");
        foreach (var enemy in enemies)
        {
            Console.WriteLine(enemy);
        }
        
        List<string> inventory = new List<string> { "Sword", "Shield", "Potion" };
        
        Console.WriteLine("\nPlayer Inventory:");
        foreach (var item in inventory)
        {
            Console.WriteLine(item);
        }
        
        inventory.Add("Helmet");
        inventory.Add("Armor");
        
        inventory.Remove("Potion");
        
        Console.WriteLine("\nUpdated Inventory:");
        foreach (var item in inventory)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine($"\nTotal Items in Inventory: {inventory.Count}");
    }
}