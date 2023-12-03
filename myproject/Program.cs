// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Timers;

class Program
{
    static int totalPath = 0;
    static void Main(string[] args){
        Console.WriteLine("Welcone to the New World!!");
        Character character = new Character();
    
        while(totalPath < 20){
            Console.WriteLine("What do you like to do?\n1. Walk\n2. Buy Items\n3. Sleep\n4. Save Date\n5. Chech your Stetas\n6. Reset");
            string? userAttempt = Console.ReadLine();
        
            if (userAttempt == "1"){
                totalPath ++ ;
                Walk walk = new Walk("You are walking.....");
                walk.walkEvent();
                
                
            }
        }

    }
}
