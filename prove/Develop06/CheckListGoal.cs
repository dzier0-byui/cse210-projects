public class CheckListGoal: Goal
{
    private int _amountCompleted;
    private bool _isComplete;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus): base(name, description, points)
    {
        _isComplete = false;
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        int points = GetPoints();
        _amountCompleted += 1;
        if (_amountCompleted == _target)
        {
            Celebrate();

            points += _bonus;
            _isComplete = true;

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        return points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" -- {_amountCompleted}/{_target} complete";
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_target}|{_bonus}|{_amountCompleted}";
    }

    public void Celebrate()
    {
        Console.Clear();
         for (int i = 0; i < 5; i++) 
        {
            Console.Clear();
            Console.ForegroundColor = i % 2 == 0 ? ConsoleColor.Yellow : ConsoleColor.Cyan;
            Console.WriteLine(new string('*', 50));
            Console.WriteLine(new string('*', 50));
            Console.WriteLine();
            Console.WriteLine("                   YOU DID IT!!!            ");
            Console.WriteLine();
            Console.WriteLine(new string('*', 50));
            Console.WriteLine(new string('*', 50));
            System.Threading.Thread.Sleep(300);
        }

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        for (int j = 0; j < 10; j++)
        {
            Console.SetCursorPosition(j * 5, j % 3 + 1);
            Console.WriteLine("+++");
            System.Threading.Thread.Sleep(150);
        }

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("**************************************************");
        Console.WriteLine("*                                                *");
        Console.WriteLine("*                CONGRATULATIONS!                *");
        Console.WriteLine("*                                                *");
        Console.WriteLine("**************************************************");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine();
        Console.WriteLine($"   !! You completed \"{GetName()}\" {_target} times!!");
        Console.WriteLine($"     You earned {_bonus} BONUS POINTS!  ");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("**************************************************");
        Console.WriteLine("*       YOU ARE AMAZING! KEEP UP THE GREAT WORK!       *");
        Console.WriteLine("**************************************************");
        System.Threading.Thread.Sleep(900);

        Console.ForegroundColor = ConsoleColor.Green;
        for (int k = 0; k < 3; k++) 
        {
            Console.Clear();
            Console.WriteLine("###########################################################################");
            System.Threading.Thread.Sleep(150);
            Console.Clear();
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            System.Threading.Thread.Sleep(150);
        }

        Console.ResetColor();
    }
}