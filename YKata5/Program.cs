class Program
{
    public class Player
    {
        public string Name{get;set;}
        public int Health{get;set;}
        public int Level{get;set;}
    }

    public class Enemy
    {
        public string Type{get;set;}
        public int Health{get;set;}
        public int Damage{get;set;}
    }

    public static void Main(string[] args)
    {
        Player player = new Player
        {
            Name = "Jack",
            Health = 100,
            Level = 1
        };

        Enemy enemy = new Enemy
        {
            Type = "Goblin",
            Health = 50,
            Damage = 10
        };
        
        Console.WriteLine("Player info: ");
        Console.WriteLine($"Name: {player.Name}");
        Console.WriteLine($"Health: {player.Health}");
        Console.WriteLine($"Level: {player.Level}");
        
        Console.WriteLine("\nEnemy info: ");
        Console.WriteLine($"Type: {enemy.Type}");
        Console.WriteLine($"Health: {player.Health}");
        Console.WriteLine($"Damage: {enemy.Damage}");
        
        
    }
}