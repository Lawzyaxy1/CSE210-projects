using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        // Prompt the user to enter numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number;
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            
            // Add the number to the list if it's not 0
            if (number != 0)
            {
                numbers.Add(number);
            }
            
        } while (number != 0);
        
        // Calculate the sum
        int sum = numbers.Sum();
        
        // Calculate the average
        double average = numbers.Count > 0 ? (double)sum / numbers.Count : 0;
        
        // Find the largest number
        int largest = numbers.Count > 0 ? numbers.Max() : 0;
        
        // Find the smallest positive number
        int smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty(0).Min();
        
        // Sort the list
        List<int> sortedNumbers = new List<int>(numbers);
        sortedNumbers.Sort();
        
        // Display the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        
        // Display the sorted list
        Console.Write("The sorted list is: ");
        Console.WriteLine(string.Join(" ", sortedNumbers));
    }
}
