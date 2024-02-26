// Player.HP is atribute
// ID represents healing item type (1 = small, 2 = medium, 3 = large, ect)
public static class Healing
{
    public static void heal(Player player, int healId)
    {
        if (Player.CurrentHitPoints >= 0)
        {
            Console.Wrtiteline("You cant heal when your death")
        }
        else if (healId == 1)
        {
            Player.CurrentHitPoints += 20;
            Console.Writeline($"Healed 20HP");
        }
        else if (healId == 2)
        {
            Player.CurrentHitPoints += 50;
            Console.Writeline($"Healed 50HP");
        }
        else if (healId == 3)
        {
            Player.CurrentHitPoints += 80;
            Console.Writeline($"Healed 80HP");
        }
        else if (healId == 4)
        {
            Player.CurrentHitPoints += 150;
            Console.Writeline($"Healed 150HP");
        }
        else if (healId == 5)
        {
            Player.CurrentHitPoints += 300;
            Console.Writeline($"Healed 300HP");
        }
        else  // fail save
        {
            Player.CurrentHitPoints += 0;
            Console.Writeline($"Healed <NULL>HP");
        }
    }
}