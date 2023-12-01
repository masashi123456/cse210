public class SimpleGoal : Goal
{
    public override int RecordEvent()
    {
        Console.WriteLine("Congratulations, you have earned {_addPoints} points!");
        // mark the goal as complete
        _isCompleted = true;
        return _addPoints;
    }
}