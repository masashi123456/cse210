using System;
using System.IO;
using System.Timers;
public class Event{
    private string _eventName;
    public string EventName {
        get {return _eventName;}
        set {_eventName = value;}
    }
    public int _exp = 0;
    public int EXP {
        get {return _exp;}
        set {_exp = value;}
    }
    public int _way = 0;


    public Event(string eventname){
        EventName = eventname; 
    }

    public void getEXP(int points){
        EXP += points;
        
    }
    public void DisplayBegin(){
        Console.WriteLine($"Welcome to the {EventName}");
        Console.WriteLine("-----------------------------");
    }

    
    public void Animation(int times){
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
}