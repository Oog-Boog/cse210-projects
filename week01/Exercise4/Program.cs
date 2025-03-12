using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        List<int> numbers = new List<int>();

        int userNum = -1;
        while (userNum !=0 )
        {
            Console.Write("Enter number: ");

            string userList = Console.ReadLine();
            userNum = int.Parse(userList);

            if (userNum !=0)
            {
                numbers.Add(userNum);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.Write($"The max is: {max}");

    }

}