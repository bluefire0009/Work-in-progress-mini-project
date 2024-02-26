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
    public void Move ()
    {
        List<string> allowedNames = new();
        List<Location> allowed = allowedLocations(CurrentLocation);
        // Add names of allowed locations names to allowedNames list
        foreach (Location loc in allowed) 
        {
            allowedNames.Add(loc.Name);
        } 
        // print text
        Console.WriteLine($"You are currently here: {CurrentLocation.Name}");
        Console.WriteLine("To which of the following locations would you like to go :\n(Case sensitive)");
        foreach(Location loc in allowed)
        {
            Console.WriteLine($" - {loc.Name}");
        }
        // end print
        
        string locationInput;
        do
        {
            locationInput = Console.ReadLine();
        } 
        while(!allowedNames.Contains(locationInput));
        Location chosenLocation = new(0,"","",false,false);
        
        // Go through allowed list and assign the input location to a Location which has the same name field
        foreach(Location loc in allowed)
        {
            if (locationInput == loc.Name)
                chosenLocation = loc;
        }
        // Move the player
        tryMove(chosenLocation);
    }

    public void EquipWeapon(Weapon weapon)
    {
        CurrentWeapon = weapon;
    }
    // given a location if the player can move there returns true and changes the field CurrentLocation 
    // to the location else returns false
    private bool tryMove(Location newLocation)
    {
        List<Location> allowed = allowedLocations(CurrentLocation);
        if (allowed.Contains(newLocation)){
            CurrentLocation = newLocation;
            return true;}
        else
            return false;
    }
    // takes a location and returns a list of locations where you can go to from the given location
    private List<Location> allowedLocations(Location toCheck)
    {
        List<Location> Locations = new();

        if (toCheck.LocationToSouth != null)
            Locations.Add(toCheck.LocationToSouth);
        if (toCheck.LocationToNorth != null)
            Locations.Add(toCheck.LocationToNorth);
        if (toCheck.LocationToEast != null)
            Locations.Add(toCheck.LocationToEast);
        if (toCheck.LocationToWest != null)
            Locations.Add(toCheck.LocationToWest);
        
        return Locations;
    }
    // Hier straks toevogen wat de speler kan doen 
}

