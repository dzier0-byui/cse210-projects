public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you overcame a challenge.",
        "Reflect on a moment of joy in your life.",
        "Consider a time you helped someone in need."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you grow as a person from it?",
        "What lessons did you learn?",
        "How did you feel when it was complete?",
        "What is your favorite thing about this experience?",
        "What would you do differently if faced with this again?",
        "Who else was involved, and how did they impact the experience?",
        "What emotions did you feel during this moment?",
        "What strengths did you use to navigate this experience?",
        "How has this experience shaped your future choices?"
    };

    private List<string> _unusedQuestions;

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilence.\nThis will help you recognize the power you have and how you can use it in other aspects of life.", 60) 
    {
        _unusedQuestions = new List<string>(_questions);
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        if (_unusedQuestions.Count == 0)
        {
            _unusedQuestions = new List<string>(_questions);
        }

        Random random = new Random();
        int index = random.Next(_unusedQuestions.Count);
        string question = _unusedQuestions[index];
        _unusedQuestions.RemoveAt(index);
        return question;
    }

    private void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"Take a moment to reflect on this prompt:\n{prompt}");
    }

    private void DisplayQuestions()
    {
        List<string> randomQuestions = new List<string>();
        randomQuestions.Add(GetRandomQuestion());
        randomQuestions.Add(GetRandomQuestion());
        randomQuestions.Add(GetRandomQuestion());

        foreach (string question in randomQuestions)
        {
            Console.WriteLine($"> {question}");
            ShowSpinner(_duration/randomQuestions.Count);
        }
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        DisplayPrompt($"-- {prompt} --");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.\n");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");

        ShowCountDown("You may begin in: ", 5);
        Console.Clear();

        DisplayQuestions();

        DisplayEndingMessage();
    }
}