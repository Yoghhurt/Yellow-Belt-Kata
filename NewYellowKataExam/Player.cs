namespace NewYellowKataExam;

public class Player : ICombatable, ISpeakable
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    public int Damage { get; set; }

    public Player(string name)
    {
        Name = name;
        Health = 100;
        Level = 1;
        Experience = 0;
    }

    public void Attack(ICombatable target)
    {
        int Damage = 20;
        Console.WriteLine($"{Name} attacks the taget for {Damage} damage.");
        target.TakeDamage(Damage);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage. Health left: {Health}");
    }

    public bool isAlive() => Health > 0;

    public void Speak()
    {
        Console.WriteLine($"{Name} says: Ready for battle!");
    }

    public void GainExperience(int exp)
    {
        Experience += exp;
        Console.WriteLine($"{Name} gains {exp} experience.");
        if (Experience >= 100)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        Level += 1;
        Experience = 0;
        Console.WriteLine($"Congratulations! You reached level {Level}!");
    }
}