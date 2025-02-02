using System;

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptManager promptManager = new PromptManager();
        Menu menu = new Menu(journal, promptManager);

        menu.DisplayMenu();
    }
}
