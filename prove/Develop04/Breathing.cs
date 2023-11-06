

public class Breathing : Activity{


    public Breathing(string name) : base(name){
        ActivityName = "Breathing Activity";
    }
    public void BreathAct(){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Time);
        DateTime currentTime = DateTime.Now;
        while(currentTime < endTime){
            Console.Write("Breath in...");
            DisplayCountdown(4);
            Console.WriteLine();
            Console.Write("Breath out..."); 
            DisplayCountdown(6);
            Console.WriteLine("\n");
            currentTime = DateTime.Now;
        }
    }
}