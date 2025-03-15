// Class representing a simple goal that can be completed once
public class SimpleGoal : Goal
{
    // Marks the goal as finished and updates total points
    public override void RecordEvent(ref int totalPoints)
    {
        Finished = true; // Set goal as finished
        totalPoints += Points; // Add goal's points to the total score
        Console.WriteLine($"You have completed the goal: {Name}! You earned {Points} points.");
    }

    // Displays the goal's name, description, and completion status
    public override void DisplayStatus()
    {
        string status = Finished ? "[X]" : "[ ]"; // Display "[X]" if completed, otherwise "[ ]"
        Console.WriteLine($"{status} {Name} - {Description}");
    }
}
