public abstract class Goal{
    protected int       _addPoints;
    public int Points{
        get {return _addPoints;}
        set {_addPoints = value;}
    }
    protected bool      _isCompleted;
    public bool IsCompleted
    {
        get {return _isCompleted;}
        set {_isCompleted = value;}
    }
    protected string    _name;
    public string Name{
        get{return _name;}
        set{_name = value;}
    }
    protected string    _description;
    public string Description{
        get{return _description;}
        set{_description = value;}
    }

    // virtual = optional
    public virtual void PromptUser()
    {
        // Get the name of the goal
        Console.Write("What is the name of the goal? ");
        _name = Console.ReadLine();
        // Get the description of the goal
        Console.Write("What is a short description of the goal? ");
        _description = Console.ReadLine();
        // Get the points for the goal
        Console.Write("How many points will this goal be worth? ");
        _addPoints = int.Parse(Console.ReadLine());
    }

    // abstract = required
    public abstract int RecordEvent();

    public virtual string GetStringRepresentation(){
        return $"{GetType()},{Name},{Description},{Points}";
    }
    
}