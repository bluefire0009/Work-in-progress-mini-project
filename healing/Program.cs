public static class Healing
{
    public static int heal(int Heal.id)
    {
        if (heal.id == 1)
            Player.HP += 20
            Console.Write($"Healed 20HP")

        else if (heal.id == 2)
            Player.HP += 50
            Console.Write($"Healed 50HP")

        else if (heal.id == 3)
            Player.HP += 80
            Console.Write($"Healed 80HP")

        else if (heal.id == 4)
            Player.HP += 150
            Console.Write($"Healed 150HP")

        else if (heal.id == 5)
            Player.HP += 300
            Console.Write($"Healed 300HP")

        else  // fail save
            Player.HP += 0
            Console.Write($"Healed <NULL>HP")

    }
}
