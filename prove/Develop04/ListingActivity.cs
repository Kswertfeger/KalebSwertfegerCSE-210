public class ListingActivity
{
    // Properties for the activity.
    public string Name { get; set; } = "Listing";
    public string Description { get; set; } = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    public int Duration { get; set; }

    // Static list for the questions.
    private static List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
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

        var random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
        Console.WriteLine("You have a few seconds to prepare...");
        PauseWithAnimation(5); 

        int totalSeconds = 0;
        int itemCount = 0;
        while (totalSeconds < Duration)
        {
            Console.WriteLine("Enter an item: ");
            Console.ReadLine();
            itemCount++;
            totalSeconds += 5;
        }

        Console.WriteLine($"You listed {itemCount} items.");
        EndActivity();
    }

    // Method to end the activity.
    public void EndActivity()
    {
        Console.WriteLine("Good job! You have completed the activity.");
        PauseWithAnimation(3);
        Console.WriteLine($"You completed the {Name} activity for {Duration} seconds.");
    }

    // Method to display an animation during the program.
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
