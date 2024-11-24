class Program
{
    public static void AttackEnemy(string EnemyName, int damage)
    {
        Console.Write($"Attacked {EnemyName} for {damage} damage.");
    }
    public static void HealPlayer(string PlayerName, int healAmount)
    {
        Console.Write($"Player healed {PlayerName} for {healAmount} health.");
    }

    static void Main(string[] args)
    {
        AttackEnemy("Goblin", 25);
        
        HealPlayer("Jack", 25);
    }
}