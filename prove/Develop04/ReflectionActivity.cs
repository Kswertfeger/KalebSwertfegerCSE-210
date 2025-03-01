public class ReflectionActivity
{
    // Properties for the activity.
    public string Name { get; set; } = "Reflection";
    public string Description { get; set; } = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    public int Duration { get; set; }

    // Static list of the prompts.
    private static List<string> Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    // Static list of the questions.
    private static List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // Method to start the activity
    public void StartActivity()
    {
        Console.WriteLine($"Starting the {Name} activity.");
        Console.WriteLine(Description);
        Console.Write("Enter the duration of the activity in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        PauseWithAnimation(3);

        var random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
        int totalSeconds = 0;
        while (totalSeconds < Duration)
        {
            Console.WriteLine(Questions[random.Next(Questions.Count)]);
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

    // Method for the animation that plays during the activity.
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
