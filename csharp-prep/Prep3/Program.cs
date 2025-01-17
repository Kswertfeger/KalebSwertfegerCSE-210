using System;

class Program
{
    static void Main()
    {
        // Generates a random number and assigns it to an int.
        Random randomGenerator = new Random();
        int random_number = randomGenerator.Next(1, 101);
        // Calls the guessing_game() function with the random number as a parameter.
        guessing_game(random_number);

        // Ask the user if they want to play again.
        Console.Write("Do you want to play again? (y/n) ");
        string play_again = Console.ReadLine();

        // If the user wants to play again, call main to restart the game with a new random number.
        if (play_again == "y") {
            Main();
        }
    }

    static void guessing_game(int random_number) {
        // Initializes the word_found variable as false.
        bool word_found = false;
        // Do the games main function while the word has not been found.
        do 
        {
            // Prompt the user for a guess between 1-100.
            Console.Write("Guess the magic number between 1 and 100: ");
            // Convert the input to an int from a string
            string str_guess = Console.ReadLine();
            int int_guess = int.Parse(str_guess);

            // If the user guesses the number, congrtulate them, and set the word_found variable to true.
            if (int_guess == random_number) {
                Console.WriteLine("You guessed the magic number!");
                word_found = true;
            }
            // If the user guesses higher then the number, prompt them to guess lower.
            else if (int_guess > random_number) {
                Console.WriteLine("Lower!");
            }
            // If the user guesses lower then the number, prompt them to guess higher.
            else if (int_guess < random_number) {
                Console.WriteLine("Higher!");
            }
            // Else, the user made an invalid input, basic error handling.
            else {
                Console.WriteLine("Please enter a valid guess.");
            }
        }
        // While the word has not been found keep playing the game.
        while (word_found == false); 
    }
}