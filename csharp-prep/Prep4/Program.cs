using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        List<int> numbers = new List<int>();
        do{
            bool validInput = false;
            while (!validInput) {
                Console.Write("Enter a number: ");
                
                if (int.TryParse(Console.ReadLine(), out number)) {
                    validInput = true;
                    if (number != 0) {
                        numbers.Add(number);
                    }
                }
                else {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        } while (number != 0);

        if (numbers.Count > 0) {
            int total = numbers.Sum();
            float average = (float)total / numbers.Count;
            int largestNumber = numbers.Max();

            Console.WriteLine($"The sum is: {total}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largestNumber}");
        }
        else {
            Console.WriteLine("No numbers were entered.");
        }
    }
}