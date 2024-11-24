public class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }

    public Player(string name, int level, int health)
    {
        Name = name;
        Level = level;
        Health = health;
    }

    public void Attack(Enemy enemy)
    {
        Console.WriteLine($"{Name} attacked {enemy.Type} and deals {Level * 10} damage.");
        enemy.TakeDamage(Level * 10);
    }
}

public class Enemy
{
    public string Type { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    public Enemy(string type, int health, int damage)
    {
        Type = type;
        Health = health;
        Damage = damage;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health > 0)
        {
            Console.WriteLine($"{Type} takes {damage} damage. Remaining health: {Health}.");
        }
        else
        {
            Console.WriteLine($"{Type} was defeated.");
        }
    }
}

public class NPC
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
        Console.WriteLine($"{Name} says: {Dialogue}");
    }
}

public class Merchant
{
    public string Name { get; set; }
    public List<string> Inventory { get; set; }

    public Merchant(string name, List<string> inventory)
    {
        Name = name;
        Inventory = inventory;
    }

    public void Trade()
    {
        Console.WriteLine($"{Name}'s inventory: {string.Join(", ", Inventory)}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Jack",2, 100 );
        
        Enemy goblin = new Enemy("Goblin",50, 20);
        
        player.Attack(goblin);
        
        NPC villager = new NPC("Villager", "Welcome, Traveler!");
        villager.Speak();

        Merchant merchant = new Merchant("Merchant", new List<string> { "Sword", "Shield", "Potion" });
        merchant.Trade();
    }
}