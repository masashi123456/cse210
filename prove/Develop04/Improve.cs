using System.Diagnostics;

public class Improve : Activity{

    private List<string> _genre = new List<string>(){
        "chores",
        "Assignment",
        "Relationships with friends",
        "Relationship with family",
        "Job",
        "Future Plan",
        "Hobby",
        "Eating",
        "Gosple",
        "Time Management",
    };

   public List<string>Genre{
    get{return _genre;}
    set{_genre = value;}
   }

   public Improve (string name) : base(name){
        ActivityName = "Reflecting Activity";
    }

    public void ImproveAct(){
    Random random = new Random();
    int rnd = random.Next(Genre.Count);
    Console.WriteLine("Ponder on each genre and think how you can improve on it or what you can do to it. ");
    Console.WriteLine();
    Console.Write("You may begin in: ");
    DisplayCountdown(8);
    Console.Clear();
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(Time);
    DateTime currentTime = DateTime.Now;
        while(currentTime < endTime){
            rnd = random.Next(Genre.Count);
            Console.Write($"{Genre[rnd]}...");
            DisplayCountdown(4);
            Console.Write(">");
            Console.ReadLine();
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
   }


}