public interface ISpeakable
{
    void Speak();
}

public interface IDamageable
{
    void TakeDamage();
}

public class Player : IDamageable
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }

    public Player(string name, int health, int level)
    {
        Name = name;
        Health = health;
        Level = level;
    }

    public void Attack(IDamageable enemy)
    {
        int damage = Level * 10;
        Console.WriteLine($"{Name} attacks {enemy.GetType().Name} for {damage} damage.");
        enemy.TakeDamage(damage);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health > 0)
        {
            Console.WriteLine($"Player takes {damage} damage. Remaining health: {Health}");
        }
        else
        {
            Console.WriteLine($"Player has died.");
        }
    }
}

public class Enemy : IDamageable, ISpeakable
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
            Console.WriteLine($"{Type} takes {damage} damage. Remaining health: {Health}");
        }
        else
        {
            Console.WriteLine($"{Type} has been defeated.");
        }
    }

    public void Speak()
    {
        Console.WriteLine($"{Type} growls.");
    }
}

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

public class Merchant : ISpeakable
{
    public string Name { get; set; }
    public List<string> Inventory { get; set; }

    public Merchant(string name, List<string> inventory)
    {
        Name = name;
        Inventory = inventory;
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: Ready to trade!");
    }

    public void Trade()
    {
        Console.WriteLine($"{Name}'s inventory: {string.Join(", ", Inventory)}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Player player = new Player("Bob", 100, 2);
        
        Enemy goblin = new Enemy("Goblin", 50, 10);
        
        player.Attack(goblin);
        
        NPC villager = new NPC("Villager", "Welcome to our village!");
        villager.Speak();

        Merchant merchant = new Merchant("Merchant", new List<string> { "Sword", "Shield", "Potion" });
        merchant.Speak();
        merchant.Trade();
    }
}