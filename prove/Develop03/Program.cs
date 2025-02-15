using System;

public class Program
{
    // List to hold multiple scriptures
    private static List<Scripture> Scriptures;

    static void Main(string[] args)
    {
        // Initialize the scriptures list with multiple scriptures
        Scriptures = new List<Scripture>
        {
            new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding.|In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture("Psalm 23:1-2", "The Lord is my shepherd; I shall not want.|He maketh me to lie down in green pastures: he leadeth me beside the still waters.")
        };

        // Randomly select a scripture from the list
        Random random = new Random();
        Scripture selectedScripture = Scriptures[random.Next(Scriptures.Count)];

        // Loop through the selected scripture
        while (selectedScripture.IsFinished() == false)
        {
            // Display the current state of the scripture
            selectedScripture.Display();

            // Prompt the user for input
            Console.WriteLine("Press Enter to hide words or type 'quit' to end.");
            string input = Console.ReadLine();

            // Exit the program if the user types 'quit'
            if (input.ToLower() == "quit")
                return;

            // Hide random words in the scripture
            selectedScripture.HideWords();
        }

        // Display the scripture with all words hidden before ending the program
        selectedScripture.Display();
        Console.WriteLine("All words are hidden. Program will end.");
    }
}
