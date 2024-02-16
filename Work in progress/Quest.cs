public class Quest
{
    public int ID { get; }
    public string Name { get; }
    public string Description { get; }
    public int GoalAmount { get; }
    public int CurrentAmount { get; private set; }
    public bool IsCompleted => CurrentAmount >= GoalAmount;

    public Quest(int id, string name, string description, int goalAmount)
    {
        ID = id;
        Name = name;
        Description = description;
        GoalAmount = goalAmount;
        CurrentAmount = 0;
    }

}