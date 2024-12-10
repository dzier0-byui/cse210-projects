public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "List as many things as you are grateful for.",
        "List your recent accomplishments.",
        "List the people who have positively impacted your life."
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
        Console.WriteLine("Start listing your responses! Press Enter after each item. Type 'done' to finish:");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done") break;
            userInput.Add(input);
        }
        return userInput;
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}\n");

        List<string> responses = GetListFromUser();

        _count = responses.Count;
        Console.WriteLine($"\nYou listed {_count} items. Great job!");

        DisplayEndingMessage();
    }
}