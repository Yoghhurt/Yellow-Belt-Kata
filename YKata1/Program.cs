class Program
{
    public static void Attack(int damage)
    {
        Console.WriteLine($"Player dealt {damage} damage}");
    }

    public static void Heal(int healAmount)
    {
        Console.Writeline($"Player heals {healAmount} health}")
    }

    static void Main(string[] args)
    {
        Attack(15);
        
        Heal(10);
    }
}