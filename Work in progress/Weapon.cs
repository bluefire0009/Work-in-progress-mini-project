public class Weapon
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public int HitPoints { get; private set; }

    public Weapon(int id, string name, int hitPoints)
    {
        Id = id;
        Name = name;
        HitPoints = hitPoints;
    }

    // Additional methods can be added here if needed
}