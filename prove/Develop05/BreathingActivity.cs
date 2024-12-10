public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.", 60) { }

    public void Run()
    {
        DisplayStartingMessage();

        for (int i = 0; i < _duration / 6; i++)
        {
            CountDown("in", 3);
            CountDown("out", 3);
        }

        DisplayEndingMessage();
    }

    public void CountDown(string inOrOut, int seconds)
    {
        if (inOrOut.ToLower() == "in")
        {
            ShowCountDown("Breathe in  ...", seconds);
        }
        else 
        {
            ShowCountDown("Breathe out ...", seconds);
        }
    }
}