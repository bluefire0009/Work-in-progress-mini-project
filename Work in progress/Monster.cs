public class Monster
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int XpGiven { get; private set; }
    public int DmgGiven { get; private set; }

    public Monster(int id, string name, int health, int xpGiven, int dmgGiven)
    {
        Id = id;
        Name = name;
        Health = health;
        XpGiven = xpGiven;
        DmgGiven = dmgGiven;
    }

    // Additional methods can be added here
    // For example: Attack, TakeDamage, etc.
}