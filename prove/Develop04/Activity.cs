public class Activity
{
    // Properties for the activities.
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    // Method for starting an activity.
    public virtual void StartActivity()
    {
        Console.WriteLine($"Starting the {Name} activity.");
        Console.WriteLine(Description);
        Console.Write("Enter the duration of the activity in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        PauseWithAnimation(3); 
    }

    // Method for ending the activity.
    public virtual void EndActivity()
    {
        Console.WriteLine("Good job! You have completed the activity.");
        PauseWithAnimation(3); 
        Console.WriteLine($"You completed the {Name} activity for {Duration} seconds.");
    }

    // Method for the animation that plays during the activity.
    public void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
