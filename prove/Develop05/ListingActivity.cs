public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "List as many things as you are grateful for.",
        "List your recent accomplishments.",
        "List the people who have positively impacted your life.",
        "When have you felt the Holy Ghost this month?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 60) { }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser()
    {
        List<string> userInput = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                userInput.Add(input);
            }
        }
        return userInput;
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"List as many responses you can to the following prompt: {prompt}\n");
        Console.WriteLine($"-- {prompt} --\n");
        ShowCountDown("You may begin in:", 3);

        System.Console.WriteLine();
        List<string> responses = GetListFromUser();

        _count = responses.Count;
        Console.WriteLine($"\nYou listed {_count} items. Great job!");

        DisplayEndingMessage();
    }
}