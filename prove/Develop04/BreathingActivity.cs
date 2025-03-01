public class BreathingActivity
{
    // Properties for this activity
    public string Name { get; set; } = "Breathing";
    public string Description { get; set; } = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    public int Duration { get; set; }

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
        while (totalSeconds < Duration)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(5);
            totalSeconds += 5;
            if (totalSeconds >= Duration) break;

            Console.WriteLine("Breathe out...");
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

    // Method for the animation that plays during activities.
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
