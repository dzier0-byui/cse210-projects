
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity...\n");
        Console.WriteLine($"{_description}\n");


        bool validInput = false;
        while (validInput == false)
        {
            Console.Write("How long would you like this activity to last in seconds? ");
            string stringDuration = Console.ReadLine();
            int newDuration;
            if (int.TryParse(stringDuration, out newDuration))
            {
                _duration = newDuration;
                validInput = true;
            }
            else {
                System.Console.WriteLine("Please enter a valid number");
            }
        }

        Console.Clear();
        Console.WriteLine($"This activity will last for {_duration} seconds.\n");
        
        Console.WriteLine("Get ready...");
        ShowSpinner(4);
        System.Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"\nYou have completed the {_name} Activity. Well done!");
        Console.WriteLine("Take a moment to reflect on how you feel now.\n");
        Console.Write("Press any enter to return to the menu");
        Console.ReadLine();
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rStarting in {i}...");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}