using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();

        // Display reference, then scripture
        scripture._reference.display();
        scripture.DisplayScripture();

        Console.WriteLine();
        Console.WriteLine();





    //     bool boolean = true;
    //     while (boolean){

    //     // Console.WriteLine("What would you like to do?\n1. Memorize a new scripture \n2. quit");
    //     string userInput = Console.ReadLine();

    //     if (userInput == "1"){
    //         Console.WriteLine("Which scripture do you want to study today?(Type the name of the book)");
    //         string book = Console.ReadLine();
    //         Console.WriteLine("Which chapter do you want to learn? ");
    //         string chapter = Console.ReadLine();
    //         Console.WriteLine("Which verse do you want to learn? ");
    //         string verce = Console.ReadLine();
    //         Reference raireference = new Reference(book, chapter, verce);
    //         Console.WriteLine("Now, Please type the scripture");
    //         string scripture = Console.ReadLine();
    //         Scripture Memorizescripture = new Scripture(raireference,scripture);

    //         Console.WriteLine(Memorizescripture);
    //     }

    //     if (userInput=="2"){
    //         break;
    //     }
    //   } 
    }
}