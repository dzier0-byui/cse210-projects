using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        while (true)
        {
            Console.WriteLine("\nChoose an activity to begin:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Your choice: ");

            string input = Console.ReadLine();

            if (input == "4")
            {
                Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
                break;
            }

            Activity selectedActivity;

            switch (input)
            {
                case "1":
                    selectedActivity = new BreathingActivity();
                    break;
                case "2":
                    selectedActivity = new ListingActivity();
                    break;
                case "3":
                    selectedActivity = new ReflectingActivity();
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please select a valid option.");
                    continue;
            }

            selectedActivity.Run();
        }

    }
}