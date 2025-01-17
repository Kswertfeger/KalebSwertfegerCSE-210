using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // Guide the user on how to use this program
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        // Call get_list_of_numbers() to get a list of numbers from the user.
        List<int> numbers = get_list_of_numbers();
        // Call calc_sum() to calculate the sum of the list of numbers.
        int sum = calc_sum(numbers);
        // Call calc_average() to calculate the average of the list of numbers.
        float average = calc_average(sum, numbers);
        // Call display() to display the average and the sum.
        display(average, sum);
    }

    // Prompts the user to enter a list of number and adds them to a list.
    static List<int> get_list_of_numbers() {
        // Initialize the list.
        List<int> numbers = new List<int>();
        // Initialize number.
        int number = -1;

        // While the user has not entered a 0 continue adding the entered numbers to the list.
        while (number != 0) {
            // Tell the user to enter a number and convert it to an integer.
            Console.Write("Enter number: ");
            string user_input = Console.ReadLine();

            number = int.Parse(user_input);

            // Add the inputed number to the list as long as the user did not enter a 0.
            if (number != 0) {
                numbers.Add(number);
            }
        }

        return numbers;

    }

    // Calculates the sum from the list of numbers the user entered.
    static int calc_sum(List<int> numbers) {
        // Initialize sum.
        int sum = 0;
        // For each number in the list add that to the sum.
        foreach(int number in numbers) {
            sum += number;
        }

        return sum;
    }

    // Calculate the average of all the numbers the user entered.
    static float calc_average(int sum, List<int> numbers) {
        // Count the length of the list and assign that to a variable.
        int numbers_length = numbers.Count;
        // Divides sum and numbers_length as a float.
        float average = (float)sum / numbers_length;

        return average;
    }

    // Displays the sum and average.
    static void display(float average, int sum) {
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
    }
}
