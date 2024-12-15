public class CheckListGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus): base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}