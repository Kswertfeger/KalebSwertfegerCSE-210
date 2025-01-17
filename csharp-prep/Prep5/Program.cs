using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favorite_number = PromptUserNumber();
        float number_squared = SquareNumber(favorite_number);
        DisplayResult(name, number_squared);

    }

    // Displays welcome message.
    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the Program!");
    }

    // Get the user's name.
    static string PromptUserName() {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        return name;
    }

    // Get the user's favorite number.
    static int PromptUserNumber() {
        Console.Write("What is your favorite number? ");
        string user_answer = Console.ReadLine();
        int favorite_number = int.Parse(user_answer);

        return favorite_number;
    }

    // Square the user's favorite number.
    static float SquareNumber(int number) {
        return number * number;
    }

    // Display the user's name and their favorite number squared.
    static void DisplayResult(string name, float number_squared) {
        Console.WriteLine($"{name}, the square of your number is {number_squared}");
    }
}