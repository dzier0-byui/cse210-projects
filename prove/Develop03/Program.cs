using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world, that he gave his only begotten Son, " +
                               "that whosoever believeth in him should not perish, but have everlasting life.";

        Scripture scripture = new Scripture(reference, scriptureText);

        Console.WriteLine("Welcome to the Scripture Memorization Program!");
        Console.WriteLine($"Scripture: {reference.GetDisplayText()}");
        Console.WriteLine("Choose a difficulty level (1 = Easy, 5 = Hard): ");

        int difficulty = GetDifficultyLevel();
        Console.Clear();

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Scripture: {reference.GetDisplayText()}");
            Console.WriteLine("\n" + scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are now hidden! Well done.");
                break;
            }

            Console.Write("\nPress ENTER to hide more words, or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            scripture.HideRandomWords(difficulty);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("Scripture: " + scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden! Well done!");
                break;
            }
        }
    }

    private static int GetDifficultyLevel()
    {
        while (true)
        {
            Console.Write("Enter a difficulty level (1-5): ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int difficulty) && difficulty >= 1 && difficulty <= 5)
            {
                return difficulty;
            }
            Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
        }
    }
}