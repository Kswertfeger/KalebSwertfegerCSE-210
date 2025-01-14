using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade as a percentage? ");
        string user_grade = Console.ReadLine();
        int grade_percent = int.Parse(user_grade);
        
        string letter = "";

        // A >= 90
        if (grade_percent >= 90) {
            letter = "A";
        }
        // B >= 80
        else if (grade_percent >= 80) {
            letter = "B";
        }
        // C >= 70
        else if (grade_percent >= 70) {
            letter = "C";
        }
        // D >= 60
        else if (grade_percent >= 60) {
            letter = "D";
        }
        // F < 60
        else {
            letter = "F";      
        }
        
        Console.WriteLine($"Your grade is {letter}");

        if (grade_percent >= 70) {
            Console.WriteLine("Congratulations you've passed!");
        }
        else {
            Console.WriteLine("You didn't pass, but you can do better next time!");
        }
    }
}