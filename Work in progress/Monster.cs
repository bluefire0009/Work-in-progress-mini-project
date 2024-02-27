public class Monster
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Health { get; set; }
    public int XpGiven { get; set; }
    public int DmgGiven { get; set; }

    public Monster(int id, string name, int health, int xpGiven, int dmgGiven)
    {
        ID = id;
        Name = name;
        Health = health;
        XpGiven = xpGiven;
        DmgGiven = dmgGiven;
    }

    // Additional methods can be added here
    // For example: Attack, TakeDamage, etc.
}