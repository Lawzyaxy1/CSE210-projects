using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        console.WriteLine($"Your grade is: {percent}%");


        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
            Console.WriteLine(letter);
        }
        else if (percent >= 80)
        {
            letter = "B";
            Console.WriteLine(letter);
        }
        else if (percent >= 70)
        {
            letter = "C";
            Console.WriteLine(letter);
        }
        else if (percent >= 60)
        {
            letter = "D";
            Console.WriteLine(letter);
        }
        else
        {
            letter = "F";
            Console.WriteLine(letter);
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
            Console.WriteLine("You can do it!");
        }
    }
}