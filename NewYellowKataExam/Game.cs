using System.Xml.Xsl;

namespace NewYellowKataExam;

public class Game
{
    private static Random random = new Random();

    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();
        Player player = new Player(playerName);
        
        bool gameRunning = true;
        while (gameRunning && player.isAlive())
        {
            Encounter(player);
            if (!player.isAlive())
            {
                Console.WriteLine($"{player.Name} has been defeated! Game over.");
                gameRunning = false;
                break;
            }
            Console.WriteLine("Do you want to continue playing?");
            Console.WriteLine("1. Continue");
            Console.WriteLine("2. Exit");
            string choice = Console.ReadLine();
            if (choice == "2")
            {
                gameRunning = false;
                Console.WriteLine("You have exited the game.");
            }
        }
    }

    public static void Encounter(Player player)
    {
        int encounterType = random.Next(0, 3);

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
        Console.WriteLine($"A wild {enemy.Type} appears with {enemy.Health} health and {enemy.Damage} damage!");

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
                    Console.WriteLine($"{enemy.Type} attacks back!");
                    player.TakeDamage(enemy.Damage);
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
                break;
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
        merchant.Trade(player);
    }
}