public class Player
{
    // Properties
    public int CurrentHitPoints { get; set; }
    public int MaximumHitPoints { get; set; }
    public int Gold { get; set; }
    public int ExperiencePoints { get; set; }
    public int Level { get; set; }
    public Location CurrentLocation { get; set; }
    public Weapon CurrentWeapon { get; set; }
    public List<Quest> CompletedQuests { get; set; }
    public List<Quest> AcceptedQuests { get; set; }
    public List<Weapon> Inventory { get; set; } // Assuming Item is a class representing inventory items

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
        Inventory = new List<Weapon>();
    }

    // Methods
    public void Move()
    {
        var allowed = AllowedLocations(CurrentLocation);
        var allowedNames = new List<string>();
        // print text
        Console.WriteLine("To which of the following locations would you like to go :\n(Case sensitive)");
        foreach (var loc in allowed)
        {
            allowedNames.Add(loc.Name);
            Console.WriteLine($" - {loc.Name}");
        }
        // end print
        string locationInput;
        do
        {
            locationInput = Console.ReadLine();
        } while (!allowedNames.Contains(locationInput));

        var chosenLocation = allowed.Find(loc => loc.Name == locationInput);
        // Move the player
        TryMove(chosenLocation);
    }

    public void EquipWeapon(Weapon weapon)
    {
        CurrentWeapon = weapon;
    }

    private bool TryMove(Location newLocation)
    {
        if (AllowedLocations(CurrentLocation).Contains(newLocation))
        {
            CurrentLocation = newLocation;
            return true;
        }
        return false;
    }

    private List<Location> AllowedLocations(Location toCheck)
    {
        var locations = new List<Location>();
        if (toCheck.LocationToSouth != null) locations.Add(toCheck.LocationToSouth);
        if (toCheck.LocationToNorth != null) locations.Add(toCheck.LocationToNorth);
        if (toCheck.LocationToEast != null) locations.Add(toCheck.LocationToEast);
        if (toCheck.LocationToWest != null) locations.Add(toCheck.LocationToWest);

        return locations;
    }

    public void AcceptQuest(Quest quest)
    {
        if (!AcceptedQuests.Contains(quest))
        {
            AcceptedQuests.Add(quest);
            Console.WriteLine($"{quest.Description} has been added to your quests.");
        }
    }

    public void CompleteQuest(Quest quest)
    {
        if (AcceptedQuests.Contains(quest))
        {
            AcceptedQuests.Remove(quest);
            CompletedQuests.Add(quest);
            Console.WriteLine($"{quest.Description} has been completed.");
        }
    }
}
