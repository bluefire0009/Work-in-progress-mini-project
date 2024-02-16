public class Location
{
    public int ID { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public bool IsCompleted { get; private set; }
    public bool IsAccessible { get; private set; }
    public Quest QuestAvailableHere { get; set; }
    public Monster MonsterLivingHere { get; set; }
    public Location LocationToNorth { get; set; }
    public Location LocationToSouth { get; set; }
    public Location LocationToEast { get; set; }
    public Location LocationToWest { get; set; }

    public Location(int id, string name, string description, bool isCompleted, bool isAccessible)
    {
        ID = id;
        Name = name;
        Description = description;
        IsCompleted = isCompleted;
        IsAccessible = isAccessible;
    }
  // Additional methods and logic can be added here
    // For example, methods to update IsCompleted and IsAccessible statuses
}
