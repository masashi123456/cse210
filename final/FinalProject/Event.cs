using System;
using System.IO;
using System.Timers;
public class Event{
    private string _eventName;
    public string EventName {
        get {return _eventName;}
        set {_eventName = value;}
    }
    
    public void DisplayBegin(){
        Console.WriteLine($"Welcome to the {EventName}");
        Console.WriteLine("-----------------------------");
    }

    
    public void Animation(int times){
        int Atimes = 0;
        Console.Write("_");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        while(Atimes < times){
            

            Console.Write("__");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("___");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("____");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
            Console.Write("_____");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("______");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Atimes +=5;
            }
            
        Console.WriteLine();
    } 

        public void Animation2(int times){
        int Atimes = 0;
        Console.Write("-");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        while(Atimes < times){
            

            Console.Write("/");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("\\");
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