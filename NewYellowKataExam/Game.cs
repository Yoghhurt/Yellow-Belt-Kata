using System.Xml.Xsl;

namespace NewYellowKataExam;

public class Game
{
    private static Random _random = new Random();

    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();
        Player player = new Player(playerName);

        Encounter(player);
    }

    public static void Encounter(Player player)
    {
        int encounterType = _random.Next(0, 3);

        switch (encounterType)
        {
            case 0:
                EncounterEnemy(player);
                break;
            case 1:
                EncounterNPC(player);
                break;
            case 2:
                EncounterMerchant(player);
                break;
        }
    }

    public static void EncounterEnemy(Player player)
    {
        Enemy enemy = new Enemy("Goblin");
        Console.WriteLine($"A wild {enemy.Type} appears with {enemy.Health} health, and does {enemy.Damage} damage!");
        
        player.Speak();
        while (enemy.isAlive() && player.isAlive())
        {
            Console.WriteLine("Choose an action: ");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                player.Attack(enemy);
                if (enemy.isAlive())
                {
                    enemy.TakeDamage(player.Damage);
                }
            }

            else if (choice == "2")
            {
                Console.WriteLine($"{player.Name} heals for 10 health.");
                player.Health += 10;
            }

            if (!enemy.isAlive())
            {
                player.GainExperience(30);
                Console.WriteLine($"{enemy.Type} is defeated!");
            }

            if (!player.isAlive())
            {
                Console.WriteLine($"{player.Name} has been defeated! Game over.");
                return;
            }
        }
    }

    public static void EncounterNPC(Player player)
    {
        NPC npc = new NPC("Villager", "Welcome to our village!");
        npc.Speak();
    }

    public static void EncounterMerchant(Player player)
    {
        Merchant merchant = new Merchant("Merchant");
        merchant.Speak();
        merchant.Trade();
    }
}