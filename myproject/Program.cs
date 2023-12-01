// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Timers;

class Program
{
    static void Main(string[] args){
        int totalPath = 0;
        Console.WriteLine("Welcone to the New World!!");
        Character character = new Character();

        while(totalPath != 20)
            Console.WriteLine("What do you like to do?\n1. Walk\n2. Buy Items\n3. Sleep\n4. Save Date\n5. Chech your Stetas\n6. Reset");
            string userAttemp = Console.ReadLine();
            totalPath++;
                if (userAttemp == "1"){
                    Walk walk = new Walk("You are walking.....");
                    walk.walkEvent();
                    
                }

    }
}
