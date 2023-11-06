using System;
// Director
class Program
{
    static void Main(string[] args)
    {
        bool done = false;
        Random rnd = new Random();
        while(!done){
            Console.WriteLine("Menu Option\n1. Start Breathing Activity\n2. Reflecting Activity\n3. Listening Activity\n4. Improving Activity\n5. quit");
            Console.WriteLine("Select a choice from menu: ");
            string response = Console.ReadLine();
            
            if( response == "1"){
                Breathing breathing = new Breathing("Breathing Activity");
                Console.Clear();
                breathing.DisplayBegin();
                Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
                breathing.userTime();
                Console.Clear();
                breathing.Animation(9);
                breathing.BreathAct();
                breathing.DisplayDone();
                breathing.DisplayEnd();
            }

            else if( response == "2"){
                Reflecting reflecting = new Reflecting("Reflecting Activity");
                Console.Clear();
                reflecting.DisplayBegin();
                Console.WriteLine("This acticity will help you frflect on times in your life when you have shown strength and resilience. This will help you recognize thepower you have and how you can use it in other aspects of your life");
                Console.WriteLine();
                reflecting.userTime();
                Console.Clear();
                reflecting.ReflectAct();
                reflecting.DisplayDone();
                reflecting.DisplayEnd();
            }

            else if( response == "3"){
                Console.Clear();
                Listing listing = new Listing("Listing Activity");
                Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a vertains area.");
                Console.WriteLine();
                listing.userTime();
                Console.Clear();
                listing.Animation(4);
                Console.WriteLine();
                listing.DisplayBegin();
                listing.ListingAct();
                listing.DisplayDone();
                listing.DisplayEnd();
            }

            else if( response == "4"){
                Console.Clear();
                Improve improve = new Improve("Improving Activity");
                Console.WriteLine("This activity will help you reflect on the things you can improve in your life");
                Console.WriteLine();
                improve.userTime();
                Console.Clear();
                improve.Animation(9);
                Console.WriteLine();
                improve.DisplayBegin();
                improve.ImproveAct();
                improve.DisplayDone();
                improve.DisplayEnd();
            }

            else done = true;
        }
  }
}