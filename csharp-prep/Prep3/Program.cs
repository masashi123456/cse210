using System;

class Program
{
    static void Main(string[] args)
    {   
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess = -1;
        
        while (guess != number)
        {  
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        if(number < guess)
        {
            Console.WriteLine("lower");
        }

        if(number > guess)
        {
            Console.WriteLine("higher");
        }

        else
        {
            Console.Write("You named it!!");
        }

        }
        
        
        
    

   
    
    
}

}



 