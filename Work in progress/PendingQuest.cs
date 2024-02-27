public class PendingQuest
{
    // parameter: Questid 1 = rat, Questid 2 = snake, Questid 3 = giantSpider
    // parameter: Player data for HP calculation
    public void Fight(int Questid, Player player)
    {   
        // Monster data
        Monster rat = new Monster(1, "rat", 1, 3, 3);
        Monster snake = new Monster(2, "snake", 10, 7, 7);
        Monster giantSpider = new Monster(3, "giant spider", 3, 10, 10);
        // Weapon data
        Weapon rusty_sword = new Weapon(1, "Rusty sword", 5);
        Weapon club = new Weapon(2, "Club", 10);
        // input
        string choice;

        if (Questid == 1)
        {
            while(rat.Health >= 0)
            {
                Console.WriteLine($"Your HP: {player.CurrentHitPoints}");
                Console.WriteLine($"{rat.Name} HP: {rat.Health}");
                Console.WriteLine(" ");
                Console.WriteLine("1) ATTACK WITH CLUB");
                Console.WriteLine("2) ATTACK WITH RUSTY SWORD");
                Console.WriteLine("3) HEAL");
                Console.WriteLine("4) ACCEPT FATE");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    rat.Health -= club.HitPoints;
                    Console.WriteLine($"\nyou smacked the {rat.Name}] with the club");
                    Console.WriteLine("nothing was left of his carcase");
                    Console.WriteLine("but you showed him who is the boss");
                }
                if (choice == "2")
                {
                    rat.Health -= rusty_sword.HitPoints;
                    player.CurrentHitPoints += 10;
                    if (player.CurrentHitPoints > player.MaximumHitPoints)
                    {
                        player.CurrentHitPoints = player.MaximumHitPoints;
                    }
                    Console.WriteLine($"\nyou staped the {rat.Name} with the rusty sword");
                    Console.WriteLine("you cooked the rat as meal to restore 10 hp");
                }
                if (choice == "3")
                {
                    Healing.heal(player, 2);
                    if (player.CurrentHitPoints > player.MaximumHitPoints)
                    {
                        player.CurrentHitPoints = player.MaximumHitPoints;
                    }
                }
                if (choice == "4")
                {
                    player.CurrentHitPoints = 0;
                    Console.WriteLine($"\nyou closed your eyes and let {rat.Name} keep bitting you,");
                    Console.WriteLine($"evantualy the {rat.Name} gave you enough poision to let breath out a foume of green bubles and fall deffeated on the ground");
                    Console.WriteLine($"you lost to a {rat.Name}");
                }
                else
                {
                    player.CurrentHitPoints = 0;
                    Console.WriteLine($"\nyou closed your eyes and let {rat.Name} keep bitting you,");
                    Console.WriteLine($"evantualy the {rat.Name} gave you enough poision to let breath out a foume of green bubles and fall deffeated on the ground");
                    Console.WriteLine($"you lost to a {rat.Name}");
                }
                if (rat.Health > 0)
                {
                    player.CurrentHitPoints -= rat.DmgGiven;
                    Console.WriteLine($"\nyou received {rat.DmgGiven} damage from {rat.Name}");
                }
                if (rat.Health <= 0)
                {
                    Reward.PlayerReward(1, player);
                }
            }
        }


        else if (Questid == 2)
        {
            while(snake.Health >= 0)
            {
                Console.WriteLine($"\nYour HP: {player.CurrentHitPoints}");
                Console.WriteLine($"{snake.Name} HP: {snake.Health}");
                Console.WriteLine(" ");
                Console.WriteLine("1) ATTACK WITH CLUB");
                Console.WriteLine("2) ATTACK WITH RUSTY SWORD");
                Console.WriteLine("3) HEAL");
                Console.WriteLine("4) ACCEPT FATE");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    snake.Health -= club.HitPoints;
                    Console.WriteLine("\nyou smacked the {} with the club");
                    Console.WriteLine("nothing was left of his carcase");
                    Console.WriteLine("but you showed him who is the boss");
                }
                if (choice == "2")
                {
                    snake.Health -= rusty_sword.HitPoints;
                    if (snake.Health <= 0)
                    {
                    player.CurrentHitPoints += 10;
                    if (player.CurrentHitPoints > player.MaximumHitPoints)
                    {
                        player.CurrentHitPoints = player.MaximumHitPoints;
                    }
                    Console.WriteLine($"\nyou staped the {snake.Name} with the rusty sword");
                    Console.WriteLine($"you cooked the {snake.Name} as meal to restore 10 hp");
                    }
                    else
                    {
                        Console.WriteLine($"you dealth {rusty_sword.HitPoints} on {snake.Name}");
                    }
                }
                if (choice == "3")
                {
                    Healing.heal(player, 2);
                    if (player.CurrentHitPoints > player.MaximumHitPoints)
                    {
                        player.CurrentHitPoints = player.MaximumHitPoints;
                    }
                }
                if (choice == "4")
                {
                    player.CurrentHitPoints = 0;
                    Console.WriteLine($"\nyou closed your eyes and let {snake.Name} keep bitting you,");
                    Console.WriteLine($"evantualy the {snake.Name}gave you enough poision to let breath out a foume of green bubles and fall deffeated on the ground");
                    Console.WriteLine($"you lost to a {snake.Name}");;
                }
                else
                {
                    player.CurrentHitPoints = 0;
                    Console.WriteLine($"\nyou closed your eyes and let {snake.Name} keep bitting you,");
                    Console.WriteLine($"evantualy the {snake.Name} gave you enough poision to let breath out a foume of green bubles and fall deffeated on the ground");
                    Console.WriteLine($"you lost to a {snake.Name}");
                }
                if (snake.Health > 0)
                {
                    player.CurrentHitPoints -= snake.DmgGiven;
                    Console.WriteLine($"\nyou received {snake.DmgGiven} damage from {snake.Name}");
                }
                if (snake.Health <= 0)
                {
                    Reward.PlayerReward(2, player);
                }
            }
        }


        else if (Questid == 3)
        {
            while(giantSpider.Health >= 0)
            {
                Console.WriteLine($"\nYour HP: {player.CurrentHitPoints}");
                Console.WriteLine($"{giantSpider.Name} HP: {giantSpider.Health}");
                Console.WriteLine(" ");
                Console.WriteLine("\n1) ATTACK WITH CLUB");
                Console.WriteLine("2) ATTACK WITH RUSTY SWORD");
                Console.WriteLine("3) HEAL");
                Console.WriteLine("4) ACCEPT FATE"); 
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    giantSpider.Health -= club.HitPoints;
                    Console.WriteLine($"\nyou smacked the {giantSpider.Name} with the club");
                    Console.WriteLine("nothing was left of his carcase");
                    Console.WriteLine("but you showed him who is the boss");
                }
                if (choice == "2")
                {
                    giantSpider.Health -= rusty_sword.HitPoints;
                    if (snake.Health <= 0)
                    {
                    player.CurrentHitPoints += 20;
                    if (player.CurrentHitPoints > player.MaximumHitPoints)
                    {
                        player.CurrentHitPoints = player.MaximumHitPoints;
                    }
                    Console.WriteLine($"\nyou staped the {giantSpider.Name} with the rusty sword");
                    Console.WriteLine($"you cooked the {giantSpider.Name} as meal to restore 20 hp");
                    }
                    else
                    {
                        Console.WriteLine($"you dealth {rusty_sword.HitPoints} on {giantSpider.Name}");
                    }
                }
                if (choice == "3")
                {
                    Healing.heal(player, 2);
                    if (player.CurrentHitPoints > player.MaximumHitPoints)
                    {
                        player.CurrentHitPoints = player.MaximumHitPoints;
                    }
                }
                if (choice == "4")
                {
                    player.CurrentHitPoints = 0;
                    Console.WriteLine($"\nyou closed your eyes and let {giantSpider.Name} keep bitting you,");
                    Console.WriteLine($"evantualy the {giantSpider.Name}gave you enough poision to let breath out a foume of purple bubles and fall deffeated on the ground");
                    Console.WriteLine($"you lost to a {giantSpider.Name}");
                }
                else
                {
                    player.CurrentHitPoints = 0;
                    Console.WriteLine($"\nyou closed your eyes and let {giantSpider.Name} keep bitting you,");
                    Console.WriteLine($"evantualy the {giantSpider.Name}gave you enough poision to let breath out a foume of purple bubles and fall deffeated on the ground");
                    Console.WriteLine($"you lost to a {giantSpider.Name}");
                }
                if (giantSpider.Health > 0)
                {
                    player.CurrentHitPoints -= giantSpider.DmgGiven;
                    Console.WriteLine($"\nyou received {giantSpider.DmgGiven} damage from {giantSpider.Name}");
                }
                if (giantSpider.Health <= 0)
                {
                    Reward.PlayerReward(3, player);
                }
            }
        }
    }
}