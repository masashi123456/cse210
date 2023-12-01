using System;
using System.IO;
using System.Timers;
public class Activity{
    private string _activityName;
    public string ActivityName {
        get {return _activityName;}
        set {_activityName = value;}
    }
    private int _time;
    public int Time {
        get {return _time;}
        set {_time = value;}
    }


    private string _instruction;
    public string Instruction {
        get {return _instruction;}
        set {_instruction = value;}
    }

    public Activity(string activityName){
        ActivityName = activityName;

      
    }
    public void DisplayBegin(){
        Console.WriteLine($"Welcome to the {ActivityName}");
        Console.WriteLine("-----------------------------");
    }

    public void userTime(){
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int usertime = int.Parse(Console.ReadLine());
        Time = usertime;
        
        }

    
    public void Animation(int times){
        Console.Write("Get ready...");
        int Atimes = 0;
        Console.Write("-");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        while(Atimes < times){
            

            Console.Write("\\");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
            Console.Write("-");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Atimes +=5;
            }
            
        Console.WriteLine();
    } 
    public void DisplayCountdown(int seconds) {
        while (seconds > 0) {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds --;
        }
        Console.WriteLine();
    }
        
     


    public void DisplayDone(){
        Console.WriteLine();
        Console.WriteLine("Well Done");
        Console.WriteLine();
    }

    public void DisplayEnd(){
        Console.WriteLine($"You have completated {Time} seconds of the {ActivityName}. ");
        Animation(4);
        Console.Clear();
    }

    public void yRnd(){
        Random random = new Random();
        int rnd = random.Next(1,10);
    }
    
}