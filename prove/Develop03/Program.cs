using System;

class Program
{
    static void Main(string[] args)
    {

      

       

    
        Console.WriteLine("Which scripture do you want to study today?(Type the name of the book)");
        string book = Console.ReadLine();
        Console.WriteLine("Which chapter do you want to learn? ");
        string chapter = Console.ReadLine();
        Console.WriteLine("Which verse do you want to learn? ");
        string verce = Console.ReadLine();
        Reference reference = new Reference(book, chapter, verce);
        Console.WriteLine("Now, Please type the scripture");
        string raiscripture = Console.ReadLine();
    
        Scripture scripture = new Scripture(reference, raiscripture);

        // Display reference, then scripture
        scripture._reference.display();
        scripture.DisplayScripture();

        Console.WriteLine();
        Console.WriteLine();
        

        bool scriptstudy = true;
        while (scriptstudy == true){
        Console.WriteLine("Please enter to continue or press 'quit' to finish: ");
        string trial = Console.ReadLine();
          if(trial == ""){

            scripture._reference.display();
            scripture.ScriptureRandom();
            scripture.DisplayScripture();
            Console.WriteLine();
            Console.WriteLine();
          }

          else if(trial == "quit"){
                break;
            }
        

        }
        
        

        
         




    }
}