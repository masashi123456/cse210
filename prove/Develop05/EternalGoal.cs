public class EternalGoal : Goal
{
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations, you have earned {_addPoints} points!");
        // We never mark the eternal goal as complete, because an eternal goal is
        // eternal, and can never be marked as complete.
        return _addPoints;
    }
}