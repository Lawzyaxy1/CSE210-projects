using System;

class Program
{
    static void Main(string[] args)
    {   
        // user input request                     
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}.");
    }
}   

