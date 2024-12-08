
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
        Console.WriteLine($"Starting {_name} Activity...");
        Console.WriteLine(_description);
        Console.WriteLine($"This activity will last for {_duration} seconds.\n");
        ShowCountDown(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nYou have completed the {_name} Activity. Well done!");
        Console.WriteLine("Take a moment to reflect on how you feel now.\n");
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

    public virtual void Run()
    {
        throw new NotImplementedException("Run method must be implemented in derived classes.");
    }
}