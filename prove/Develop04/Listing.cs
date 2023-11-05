public class Listing : Activity{

    private List<string>_questions = new List<string>(){
      "When have you felt the Holy Ghost this month?",
      "When did you feel joy this month?",
      "What can you be grateful for from this past month? ",
      "What are personal strengths of yours?"
    };
    
    public List<string>Questions{
        get{return _questions;}
        set{_questions = value;}
    }

    public int _nItems;

    public Listing(string name) : base(name){
        ActivityName = "Listing Activity";
    }

    public void ListingAct(){
        _nItems = 0; 
        Random rnd = new Random();
        int Qrnd = rnd.Next(Questions.Count);
        Console.WriteLine("List as many response you ca to the following prompt");
        Console.WriteLine($"---{Questions[Qrnd]}---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        DisplayCountdown(8);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Time);
        DateTime currentTime = DateTime.Now;
        while(currentTime < endTime){
            Console.Write(">");
            Console.ReadLine();
            _nItems += 1;
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {_nItems} items");
    }

}
