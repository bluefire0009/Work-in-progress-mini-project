// Player.HP is atribute
// ID represents healing item type (1 = small, 2 = medium, 3 = large, ect)
public static class Healing
{
    public static void heal(Player player, int healId)
    {
        if (player.CurrentHitPoints <= 0)
        {
            Console.WriteLine("You cant heal when your death");
        }
        else if (healId == 1)
        {
            player.CurrentHitPoints += 20;
            Console.WriteLine($"Healed 20HP");
        }
        else if (healId == 2)
        {
            player.CurrentHitPoints += 50;
            Console.WriteLine($"Healed 50HP");
        }
        else if (healId == 3)
        {
            player.CurrentHitPoints += 80;
            Console.WriteLine($"Healed 80HP");
        }
        else if (healId == 4)
        {
            player.CurrentHitPoints += 150;
            Console.WriteLine($"Healed 150HP");
        }
        else if (healId == 5)
        {
            player.CurrentHitPoints += 300;
            Console.WriteLine($"Healed 300HP");
        }
        else  // fail save
        {
            player.CurrentHitPoints += 0;
            Console.WriteLine($"Healed <NULL>HP");
        }
    }
}