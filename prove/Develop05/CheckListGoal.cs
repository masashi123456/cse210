public class CheckListGoal : Goal
{
    protected int _repsRequired;
    public int RepsRequired{
        get{return _repsRequired;}
        set{_repsRequired = value;}
    }
    protected int _repsCompleted = 0;
    public int RepsCompleted{
        get{return _repsCompleted;}
        set{_repsCompleted = value;}
    }
    protected int _bonusPoints;
    public int BonusPoints{
        get{return _bonusPoints;}
        set{_addPoints = value;}
    }
    public override void PromptUser()
    {
        base.PromptUser(); // call the base to get the name, description, and points
        Console.Write("How many times would you like to complete this goal? ");
        _repsRequired = int.Parse(Console.ReadLine());
        Console.Write("How many bonus do you want from the goal? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override int RecordEvent()
    {
        // This goal only gets marked as complete if repsRequired == repsComplete. 
        // if it doesn't, then just increment 
        _repsCompleted++;
        if (_repsCompleted != RepsRequired){
            Console.WriteLine($"Congratulations! You have earned {_addPoints} points!");
            return _addPoints;
        }

        else {
            Console.WriteLine($"Congratulations! You have earned {_addPoints + _bonusPoints} points!");
            IsCompleted = true;
            return _addPoints + _bonusPoints;
        }

        
    }

    public override string ToString()
    {
        return $" {_repsCompleted}/{_repsRequired} Bonus Points: {_bonusPoints}";
    }

    public override string GetStringRepresentation()
    {
        string r = base.GetStringRepresentation();
        r += $",{RepsCompleted},{RepsRequired},{BonusPoints}";
        return r;
    }
}