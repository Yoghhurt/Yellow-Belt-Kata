namespace NewYellowKataExam;

public class Enemy : ICombatable
{
    public string Type { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    public Enemy(string type)
    {
        Type = type;
        Random rnd = new Random();
        Health = rnd.Next(30, 100);
        Damage = rnd.Next(5, 20);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Type} takes {damage} damage. Remaining health: {Health}");
    }
    
    public bool isAlive() => Health > 0;
}