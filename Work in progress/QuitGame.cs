public class QuitGame
{
    public static bool PromptToQuit()
    {
        Console.WriteLine("Press 'Q' to quit or any other key to continue.");

        // Read the user's input
        char userInput = Console.ReadKey().KeyChar;

        // Check if the user wants to quit
        return (userInput == 'q' || userInput == 'Q');
    }
}