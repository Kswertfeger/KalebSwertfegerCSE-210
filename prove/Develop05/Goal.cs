// Abstract class representing a generic goal
public abstract class Goal
{
    // Name of the goal
    public string Name { get; set; }

    // Description of the goal
    public string Description { get; set; }

    // Points associated with the goal
    public int Points { get; set; }

    // Status indicating whether the goal is completed
    public bool Finished { get; set; }

    // Abstract method to record progress for the goal
    // Accepts a reference to the totalPoints variable for updating
    public abstract void RecordEvent(ref int totalPoints);

    // Abstract method to display the goal's status
    public abstract void DisplayStatus();
}
