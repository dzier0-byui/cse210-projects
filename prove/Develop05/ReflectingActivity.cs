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
        "What lessons did you learn?"
    };

    public ReflectingActivity() : base("Reflecting", "Reflect on meaningful moments to gain insights and perspective.", 60) { }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    private void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"Take a moment to reflect on this prompt:\n{prompt}");
    }

    private void DisplayQuestions()
    {
        Console.WriteLine("Now consider the following questions:");
        foreach (string question in _questions)
        {
            Console.WriteLine($"- {question}");
            ShowSpinner(5);
        }
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);

        ShowSpinner(5);
        DisplayQuestions();

        DisplayEndingMessage();
    }
}