public class Quest
{
    public int ID { get; private set; }
    public string Description { get; private set; }
    public string Goal { get; private set; }
    public bool IsCompleted { get; private set; }

    public Quest(int questId, string description, string goal)
    {
        ID = questId;
        Description = description;
        Goal = goal;
        IsCompleted = false;
    }

    public void CompleteQuest()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            // Additional logic for when the quest is completed
            // For example, grant experience points to the player
        }
    }

}
