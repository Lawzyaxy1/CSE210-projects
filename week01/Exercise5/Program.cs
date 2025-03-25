using System;

class Program
{
    static void Main(string[] args)
    {
        // Welcome message
        Console.WriteLine("Welcome to the program!");
        
        // Ask for the user's name
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        
        // Ask for the user's favorite number
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        
        // Calculate the square of the number
        int square = favoriteNumber * favoriteNumber;
        
        // Display the result with the user's name
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
