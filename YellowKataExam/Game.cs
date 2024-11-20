public class Game
{
    private Player _player;
    private Random _random = new Random();

    public void Start()
    {
        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();
        _player = new Player(playerName);

        Console.WriteLine($"{_player.Name} says: Ready for battle!");

        GameLoop();
    }

    private void GameLoop()
    {
        while (_player.Health > 0)
        {
            int encounterType = _random.Next(1, 4);
            Interacting interactable = null;
            Combating combatant = null;

            if (encounterType == 1)
            {
                
                combatant = new Enemy("Goblin");
                Console.WriteLine($"A wild Goblin appears with {((Enemy)combatant).Health} health and {((Enemy)combatant).Damage} damage!");
            }
            else if (encounterType == 2)
            {
                
                interactable = new NPC("Villager");
                interactable.Speak();
            }
            else if (encounterType == 3)
            {
                
                interactable = new Merchant("Bob the Merchant");
                ((Trading)interactable).Speak();
                ((Trading)interactable).ShowInventory();
            }

            if (combatant != null)
            {
                CombatLoop((Combating)combatant);
            }

            
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            string action = Console.ReadLine();

            if (action == "1" && combatant != null)
            {
                _player.Attack(combatant);
            }
            else if (action == "2")
            {
                _player.Heal();
            }

            
            if (_player.Health <= 0)
            {
                Console.WriteLine($"{_player.Name} has died. Game Over!");
                break;
            }
            
            Console.ReadKey();
        }
    }

    private void CombatLoop(Combating enemy)
    {
        while (enemy is Combating && _player.Health > 0)
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                _player.Attack(enemy);
                if (enemy is Combating)
                {
                    ((Combating)enemy).Attack(_player);
                }
            }
            else if (choice == "2")
            {
                _player.Heal();
            }
        }
    }
}
