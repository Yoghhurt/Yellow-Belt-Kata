namespace DefaultNamespace;

public class Player : Combating, Interacting
{
    public string PlayerName { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }

    public Player(string playerName)
    {
        PlayerName = playerName;
        Health = 100;
        Level = 1;
        Experience = 0;
    }

    public void Attack(Combating target)
    {
        int damage = 20;
        Console.Writeline($"{PlayerName} attacks the target for {damage} damage.")
            target.TakeDamage(damage);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.Writeline($"{PlayerName} takes {damage} damage. Health left: {Health}.")
    }

    public void Heal()
    {
        int healingAmount = 20;
        Health += healingAmount;
        Console.Writeline($"{PlayerName} heals {healingAmount}. Health: {Health}.")
    }

    public void GainExperience()
    {
        Experience += points;
        Console.Writeline($"{PlayerName} gains {points} experience points! Total experience: {Experience}.")
    }

    public void Speak()
    {
        Console.Writeline($"{PlayerName} says: Ready for battle!")
    }
}