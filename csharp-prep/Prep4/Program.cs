using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int>numbers = new List<int>();
        int Mnumber = -1;
        while (Mnumber != 0)
        {
            Console.Write("Enter a number(0 when you finish)");

            string response = Console.ReadLine();
            Mnumber = int.Parse(response);

            if (Mnumber != 0)
            {
                numbers.Add(Mnumber);
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            foreach (int number in numbers);
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");

             int max = numbers[0];

            foreach (int number in numbers)
            {
             if (number > max)
              {
                // if this number is greater than the max, we have found the new max!
                max = number;
              }
            }

            Console.WriteLine($"The max is: {max}");



        } 
     





    }
}