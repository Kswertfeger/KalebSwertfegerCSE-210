using System;

// Main program class
class Program
{
    // A list to store all goals
    static List<Goal> goals = new List<Goal>();
    // Variables to keep track of points and levels
    static int totalPoints = 0;
    static int currentLevel = 1;

    static void Main(string[] args)
    {
        // Display menu and handle user input
        DisplayMenu();
        Console.WriteLine("Exiting...");
        
    }

    // Displays the menu options and handles user choices
    static void DisplayMenu()
    {
        bool keepRunning = true;

        while (keepRunning != false)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. List Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            // Switch statement to handle different menu choices
            switch (choice)
            {
                case "1":
                    AddGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ListGoals();
                    break;
                case "4":
                    DisplayScore();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    keepRunning = false; // Exit the menu loop
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }


    // Prompts the user to add a new goal
    static void AddGoal()
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string type = Console.ReadLine();

        // Collect goal details from the user
        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal;

        // Create the appropriate type of goal based on user input
        switch (type)
        {
            case "1":
                goal = new SimpleGoal { Name = name, Description = description, Points = points };
                break;
            case "2":
                goal = new EternalGoal { Name = name, Description = description, Points = points };
                break;
            case "3":
                Console.Write("Enter the target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal
                {
                    Name = name,
                    Description = description,
                    Points = points,
                    TargetCount = targetCount,
                    BonusPoints = bonusPoints
                };
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        goals.Add(goal); // Add the new goal to the list
        Console.WriteLine("Goal added successfully!");
    }

    // Records progress for a specific goal
    static void RecordEvent()
    {
        Console.WriteLine("Choose a goal to record:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }
        int choice = int.Parse(Console.ReadLine()) - 1;

        // Validate the user's choice and update progress
        if (choice >= 0 && choice < goals.Count)
        {
            var goal = goals[choice];
            goal.RecordEvent(ref totalPoints); // Update points for the goal

            // Check if the user has leveled up
            while (totalPoints >= 100)
            {
                totalPoints -= 100; // Deduct points for the level
                currentLevel++; // Increment the level
                Console.WriteLine($"Congratulations! You've leveled up to Level {currentLevel}!");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    // Lists all the goals and their status
    static void ListGoals()
    {
        Console.WriteLine("\nGoals:");
        foreach (var goal in goals)
        {
            goal.DisplayStatus();
        }
    }

    // Displays the current score and level
    static void DisplayScore()
    {
        Console.WriteLine($"\nCurrent Level: {currentLevel}");
        Console.WriteLine($"\nTotal Score: {totalPoints}");
    }

    // Saves the list of goals and progress to a file
    static void SaveGoals()
    {
        try
        {
            string filePath = "goals.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(totalPoints); // Save total points
                writer.WriteLine(currentLevel); // Save current level

                // Save each goal's details
                foreach (var goal in goals)
                {
                    string goalType = goal.GetType().Name;
                    writer.Write($"{goalType}|{goal.Name}|{goal.Description}|{goal.Points}|{goal.Finished}");

                    if (goal is ChecklistGoal checklistGoal)
                    {
                        writer.WriteLine($"|{checklistGoal.CurrentCount}|{checklistGoal.TargetCount}|{checklistGoal.BonusPoints}");
                    }
                    else
                    {
                        writer.WriteLine();
                    }
                }
            }

            Console.WriteLine("Goals and progress saved successfully to a text file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving: {ex.Message}");
        }
    }

    // Loads the list of goals and progress from a file
    static void LoadGoals()
    {
        try
        {
            string filePath = "goals.txt";

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    totalPoints = int.Parse(reader.ReadLine()); // Load total points
                    currentLevel = int.Parse(reader.ReadLine()); // Load current level

                    goals.Clear(); // Clear the existing goals list

                    // Read each goal from the file
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        string goalType = parts[0];
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        bool finished = bool.Parse(parts[4]);

                        Goal goal;

                        // Create the appropriate goal type based on file data
                        if (goalType == nameof(SimpleGoal))
                        {
                            goal = new SimpleGoal { Name = name, Description = description, Points = points, Finished = finished };
                        }
                        else if (goalType == nameof(EternalGoal))
                        {
                            goal = new EternalGoal { Name = name, Description = description, Points = points, Finished = finished };
                        }
                        else if (goalType == nameof(ChecklistGoal))
                        {
                            int currentCount = int.Parse(parts[5]);
                            int targetCount = int.Parse(parts[6]);
                            int bonusPoints = int.Parse(parts[7]);

                            goal = new ChecklistGoal
                            {
                                Name = name,
                                Description = description,
                                Points = points,
                                Finished = finished,
                                CurrentCount = currentCount,
                                TargetCount = targetCount,
                                BonusPoints = bonusPoints
                            };
                        }
                        else
                        {
                            throw new InvalidOperationException("Unknown goal type found in file.");
                        }

                        goals.Add(goal);
                    }
                }

                Console.WriteLine("Goals and progress loaded successfully from the text file.");
            }
            else
            {
                Console.WriteLine("No save file found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading: {ex.Message}");
        }
    }
}
