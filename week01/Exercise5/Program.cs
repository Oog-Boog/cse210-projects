using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squared = SquareNumber(userNumber);
        
        DisplayResult(userName, squared);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    static int SquareNumber(int num)
    {
        int sq = num * num;
        return sq;
    }
    static void DisplayResult(string name, int sq)
    {
        Console.WriteLine($"{name}, the square of your number is {sq}");
    }
}

//DisplayWelcome
//PromptUserName
//PromptUserNumber
//SquareNumber
//DisplayResult

