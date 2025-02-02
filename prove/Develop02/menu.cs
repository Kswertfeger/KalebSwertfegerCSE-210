public class Menu
{
    private Journal journal;
    private PromptManager promptManager;
    
    public Menu(Journal journal, PromptManager promptManager)
    {
        this.journal = journal;
        this.promptManager = promptManager;
    }

    public void DisplayMenu()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptManager.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                Entry entry = new Entry(prompt, response);
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename: ");
                string saveFilename = Console.ReadLine();
                journal.SaveToFile(saveFilename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                string loadFilename = Console.ReadLine();
                journal.LoadFromFile(loadFilename);
            }
            else if (choice == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }
}
