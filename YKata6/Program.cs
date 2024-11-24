class Program
{
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Damage { get; set; }

        public void Attack(Enemy enemy, int damage)
        {
            Console.WriteLine($"Player {Name} attacked {enemy.Type} for {damage} damage.");
            enemy.TakeDamage(damage);
        }

        public void GainExperience(int exp)
        {
            Experience += exp;
            Console.WriteLine($"Player {Name} gained {exp} experience.");
        } 
    }

    public class Enemy
    {
        public string Type { get; set; }
        public int enemyHealth { get; set; }

        public void TakeDamage(int damage)
        {
            enemyHealth -= damage;
            Console.WriteLine($"{Type} took {damage} damage.");
            
            if (enemyHealth < 0)
            {
                Console.WriteLine($"{Type} was defeated.");
            }
        }
    }

    public static void Main(string[] args)
    {
        Player player = new Player()
        {
            Name = "James",
            Health = 100,
            Level = 1,
            Experience = 0,
            Damage = 20,
        };

        Enemy enemy = new Enemy()
        {
            Type = "Orc",
            enemyHealth = 50
        };
        
        player.Attack(enemy, player.Damage);
        
        player.GainExperience(50);
    }
}