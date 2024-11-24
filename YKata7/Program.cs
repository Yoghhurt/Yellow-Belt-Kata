public class Player
{
    private int health;
    private int level;
    private int experience;

    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public int Level
    {
        get { return level; }
        set
        {
            if (value >= 0)
            {
                level = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Level cannot be negative.");
            }
        }
    }

    public int Experience
    {
        get { return experience; }
        set
        {
            if (value >= 0)
            {
                experience = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Experience cannot be negative.");
            }
        }
    }

    private void LevelUp()
    {
        Level++;
        Experience = 0;
        Console.WriteLine($"Congratulations! You are now level {Level}.");
    }

    public void GainExperience(int exp)
    {
        if (exp <= 0)
        {
            Console.WriteLine("Experience must be positive.");
            return;
        }
        
        Experience += exp;
        Console.WriteLine($"You gained {exp} experience.");

        if (Experience >= 100)
        {
            LevelUp();
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Player player = new Player();
        player.Level = 1;
        player.Experience = 0;
        player.Health = 100;
        
        player.GainExperience(50);
        player.GainExperience(60);
    }
}