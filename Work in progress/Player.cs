public class Player
{
    // eigenschappen
    public int CurrentHitPoints { get; set; }
    public int MaximumHitPoints { get; set; }
    public int Gold { get; set; }
    public int ExperiencePoints { get; set; }
    public int Level { get; set; }
    public Location CurrentLocation { get; set; }
    public Weapon CurrentWeapon { get; set; }
    public List<Quest> CompletedQuests { get; set; }
    public List<Quest> AcceptedQuests { get; set; }
    public List<Quest> Inventory { get; set; }

    // Constructor
    public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level)
    {
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maximumHitPoints;
        Gold = gold;
        ExperiencePoints = experiencePoints;
        Level = level;
        CurrentLocation = null;
        CurrentWeapon = null;
        CompletedQuests = new List<Quest>();
        AcceptedQuests = new List<Quest>();
        Inventory = new List<Quest>();

    }

    // Methods
    public void Move(Location newLocation)
    {
        CurrentLocation = newLocation;
    }

    public void EquipWeapon(Weapon weapon)
    {
        CurrentWeapon = weapon;
    }

    // Hier straks toevogen wat de speler kan doen 
}

