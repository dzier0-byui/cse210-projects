//I have exceeded the requirements by never duplicating questions in the listing activity, and always finishing the breathing activity with 'breathe out'

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an activity from the menu: ");

            string input = Console.ReadLine();
            System.Console.Clear();

            if (input == "4")
            {
                Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
                break;
            }

            switch (input)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case "3":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please select a valid option.");
                    continue;
            }
        }
    }
}