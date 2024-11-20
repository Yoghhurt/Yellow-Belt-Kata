namespace DefaultNamespace;

public class Enemy : Combating
{
    public string Type { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    public Enemy(string type)
    {
        Type = type;
        Health = 30; 
        Damage = 5;  
    }

    public void Attack(ICombatable target)
    {
        Console.WriteLine($"{Type} attacks the player for {Damage} damage.");
        target.TakeDamage(Damage);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Type} takes {damage} damage. Remaining health: {Health}");
    }
}