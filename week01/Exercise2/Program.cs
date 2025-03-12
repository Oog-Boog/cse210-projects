using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Grade Percentage: ");
        string gradePercentage = Console.ReadLine();

        int x = int.Parse(gradePercentage);

        string letter = "";
        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (x >= 70)
        {
            Console.WriteLine($"Congrats! You have passed the class with a {letter}!");
        }
        else
        {
            Console.WriteLine($"You recieved a {letter}, Better luck next time!");
        }
    }
}