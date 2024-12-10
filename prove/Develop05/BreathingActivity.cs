public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "Focus on your breathing to relax and center yourself.", 60) { }

    public void Run()
    {
        DisplayStartingMessage();

        for (int i = 0; i < _duration / 10; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("Now breathe out...");
            ShowCountDown(4);
        }

        DisplayEndingMessage();
    }
}