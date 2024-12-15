using System.Runtime.InteropServices;

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
            Console.WriteLine($"Congrats!! You {GetDescription()} {_target} times and earned {_bonus} bonus points.");
            points += _bonus;
            _isComplete = true;
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
        return $"CheckListGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_isComplete}";
    }
}