// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[]args)
    {
        // Console.WriteLine("Choose your option\n1. Add device\n2. Turn on/off all lights\n3. Turn on/off device\n4. Turn on/off all devices in Room\n5.Report All items in the room and their status\n6. Report All items that are on\n7. Report Item that have been on the longest");
        SmartHeater smartheater = new SmartHeater("Apple TV");
        smartheater.TogglePower();
        Console.WriteLine(smartheater.GetPower());
    
    
    
    
    }

}
