public class Weapon
{
    public int ID { get; private set; }
    public string Name { get; private set; }
    public int HitPoints { get; private set; }

    public Weapon(int id, string name, int hitPoints)
    {
        ID = id;
        Name = name;
        HitPoints = hitPoints;
    }

    // Additional methods can be added here if needed
}