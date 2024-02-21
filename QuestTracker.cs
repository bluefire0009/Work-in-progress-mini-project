public class QuestTracker
{
    public List<int> Completed_Quests;
    
    public QuestTracker()
    {
        this.Completed_Quests = new List<int>();
    }

    public void AddToCompleted(int Quest_ID)
    {
        Completed_Quests.Add(Quest_ID);
        // <__DEBUG__> massage for testing turn in comment if you not planning to use it.
        // hint: public void AddToCompleted(int Quest_ID, string Quest_Name)
        // Console.WriteLine($"\nQuest {Quest_Name} compleet")
        Console.WriteLine($"\nQuest {Quest_ID} compleet")
    }

    public bool RetrieveQuestStatus(int Quest_ID)
    {
        return Completed_Quests.Contains(Quest_ID);
    }
}
// Example usage
// Quest_ID = 1;

// if RetrieveQuestStatus(Quest_ID); (true)
// Quest status compleet, (can be used to avoid dublicated quest)

// if !RetrieveQuestStatus(Quest_ID); (false)
// Quest status set stage 1, (optional if you want to use it to start new quest, however carefull ussage to avoid reseting pending quests)


// Example usage
// Quest_ID = 1;

// Completed_Quests.Add(Quest_ID)
// In the background it will now be flaged as compleet when ussing. (make sure to use it at evry final stage of a quest)
