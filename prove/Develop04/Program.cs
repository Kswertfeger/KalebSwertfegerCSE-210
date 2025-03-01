using System;

class Program
{
    static void Main()
    {
        bool continuing = true;
        while (continuing == true)
        {   
            // Displays the menu to the user.
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Words of Affirmation Activity");
            Console.WriteLine("5. Exit");

            // Depending on the choice the user makes, start the activity the user wants to do, or quit the program.
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                var activity = new BreathingActivity();
                activity.StartActivity();
            }
            else if (choice == "2")
            {
                var activity = new ReflectionActivity();
                activity.StartActivity();
            }
            else if (choice == "3")
            {
                var activity = new ListingActivity();
                activity.StartActivity();
            }
            else if (choice == "4")
            {
                var activity = new WordsOfAffirmationActivity();
                activity.StartActivity();
            }
            else if (choice == "5") 
            {
                continuing = false;
            }
            // Handles when the user makes an invalid input, it will continue prompting until the user's input is valid.
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }
}