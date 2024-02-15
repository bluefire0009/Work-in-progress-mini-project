class Location
{
    public int ID;
    public string Name;
    public string Description;
    public Quest? QuestAvailableHere;
    public Monster? MonsterLivingHere;
    public Location? LocationToNorth;
    public Location? LocationToEast;
    public Location? LocationToSouth;
    public Location? LocationToWest;

    public Location(int id, string name, string description, Quest? questHere = null, Monster? monsterHere = null, 
                    Location? locationN = null, Location? locationE = null, Location? locationS = null, Location? locationW = null)
    {
        ID = id;
        Name = name;
        Description = description;
        QuestAvailableHere = questHere;
        MonsterLivingHere = monsterHere;
        LocationToNorth = locationN;
        LocationToEast = locationE;
        LocationToSouth = locationS;
        LocationToWest = locationW;
    }
    public void SetNorthTo(Location location) => LocationToNorth = location;
    public void SetEastTo(Location location) => LocationToEast = location;
    public void SetSouthTo(Location location) => LocationToSouth = location;
    public void SetWestTo(Location location) => LocationToWest = location;

    public string Compass()
    {
        return"";
    }
}