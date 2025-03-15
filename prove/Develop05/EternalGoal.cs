// Class representing a goal with no completion (eternal)
public class EternalGoal : Goal
{
    // Records progress for the goal and updates total points
    public override void RecordEvent(ref int totalPoints)
    {
        totalPoints += Points; // Add goal's points to the total score
        Console.WriteLine($"You recorded progress for: {Name}. You earned {Points} points.");
    }

    // Displays the goal's name and description
    public override void DisplayStatus()
    {
        Console.WriteLine($"[ ] {Name} - {Description} (Eternal Goal)");
    }
}
