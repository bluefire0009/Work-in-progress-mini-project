public class Reward
{
    public static void PlayerReward(int RewardId, Player player)
    {
        if (RewardId == 1)
        {
            player.Gold += 10;
            player.ExperiencePoints +=  50;
            Console.WriteLine("\nYou won!");
            Console.WriteLine("Reward: 10 Gold and 50 EXP");
        }
        if (RewardId == 2)
        {
            player.Gold += 20;
            player.ExperiencePoints +=  100;
            Console.WriteLine("\nYou won!");
            Console.WriteLine("Reward: 20 Gold and 100 EXP");
        }
        if (RewardId == 3)
        {
            player.Gold += 50; 
            player.ExperiencePoints +=  200;
            Console.WriteLine("\nYou won!");
            Console.WriteLine("Reward: 50 Gold and 200 EXP");
        }
    }
}