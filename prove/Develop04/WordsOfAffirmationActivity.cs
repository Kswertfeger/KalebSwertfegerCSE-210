public class WordsOfAffirmationActivity
{
    // Properties for this activity.
    public string Name { get; set; } = "Words of Affirmation";
    public string Description { get; set; } = "This activity will help you feel positive and confident by encouraging you to say words of affirmation out loud.";
    public int Duration { get; set; }

    // Static list of words of affirmation.
    private static List<string> Affirmations = new List<string>
    {
        "I am strong.",
        "I am capable.",
        "I am confident.",
        "I am worthy.",
        "I am loved.",
        "I am resilient.",
        "I am enough.",
        "I am grateful.",
        "I am unstoppable.",
        "I am at peace."
    };

    // Method to start the activity.
    public void StartActivity()
    {
        Console.WriteLine($"Starting the {Name} activity.");
        Console.WriteLine(Description);
        Console.Write("Enter the duration of the activity in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        PauseWithAnimation(3);

        int totalSeconds = 0;
        var random = new Random();
        Console.WriteLine("Say these words of affirmation out loud:");

        while (totalSeconds < Duration)
        {
            Console.WriteLine(Affirmations[random.Next(Affirmations.Count)]);
            PauseWithAnimation(5); 
            totalSeconds += 5;
        }

        EndActivity();
    }

    // Method to end the activity.
    public void EndActivity()
    {
        Console.WriteLine("Good job! You have completed the activity.");
        PauseWithAnimation(3); 
        Console.WriteLine($"You completed the {Name} activity for {Duration} seconds.");
    }

    // Method to display the animation for the activity.
    private void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
