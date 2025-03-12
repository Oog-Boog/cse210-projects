using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        string valueFromUser = Console.ReadLine();

        int x = int.Parse(valueFromUser);
        int y = 2;
        int z = 5;

        if (!(x < y || x < z) && y < z)
        {
            Console.WriteLine("Greater");
        }        
        else if (x < y)
        {
            Console.WriteLine("Less");
        }
        else
        {
            Console.WriteLine("Equal");
        }
}

// general structure of a function definition  ***camel case all but functions Title Case***
// returnType FunctionName(dataType parameter1, dataType parameter2)
//{
//  //function_body
//}
// types: int string void
//use static only for now "static void Display Message()

