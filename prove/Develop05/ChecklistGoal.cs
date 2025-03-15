// Class representing a goal that requires multiple steps to complete
public class ChecklistGoal : Goal
{
    // Total number of steps required to complete the goal
    public int TargetCount { get; set; }

    // Current progress (number of steps completed)
    public int CurrentCount { get; set; }

    // Bonus points awarded upon completion
    public int BonusPoints { get; set; }

    // Records progress for the goal and updates total points
    public override void RecordEvent(ref int totalPoints)
    {
        CurrentCount++; // Increment the count of completed steps
        totalPoints += Points; // Add goal's points to the total score

        // Check if the goal is completed
        if (CurrentCount < TargetCount)
        {
            // Goal is not yet completed; display current progress
            Console.WriteLine($"Progress made on {Name}. You've earned {Points} points. ({CurrentCount}/{TargetCount})");
        }
        else if (CurrentCount == TargetCount)
        {
            // Goal is completed; award bonus points
            Finished = true; // Mark goal as completed
            int totalReward = Points + BonusPoints; // Calculate total reward including bonus
            totalPoints += BonusPoints; // Add bonus points to the total score
            Console.WriteLine($"Congratulations! You completed {Name} and earned {totalReward} points, including a bonus of {BonusPoints} points.");
        }
    }

    // Displays the goal's name, description, and progress
    public override void DisplayStatus()
    {
        string status = Finished ? "[X]" : "[ ]"; // Display "[X]" if completed, otherwise "[ ]"
        Console.WriteLine($"{status} {Name} - {Description} (Checklist Goal: {CurrentCount}/{TargetCount})");
    }
}
