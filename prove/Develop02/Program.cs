using System;
using Microsoft.VisualBasic;
using Microsoft.Win32.SafeHandles;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        bool trying = true;
        Entry entry = new Entry();
        Random rnd = new Random();
        Prompt usersWrite = new Prompt();
        Journal journal = new Journal();
        
        
        
        while(trying)
        {
        Console.WriteLine("Please select one of these choices\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.WriteLine("What would you like to do?");
        String choice = Console.ReadLine();

        if(choice == "1")
        {
          

          DateTime theCurrentTime = DateTime.Now;
          string dateText = theCurrentTime.ToShortDateString();

          
          
          int randIndex = rnd.Next(usersWrite._promptList.Count);

          Console.WriteLine(usersWrite._promptList[randIndex]);
          string usersAnswer = Console.ReadLine();

          journal.AddEntry(entry);
          Console.WriteLine();

          break;

  
         
          
         
        }

        else if(choice == "2")
        {
          journal.DisplayJournal();
          Console.WriteLine();
          break;
        }

        else if(choice == "3")
        {
          SaveToFile(journal._entries);
        }

        else if(choice == "4")
        {
          List<Entry>newEntries = ReadFromFile();
          Console.WriteLine();
        }

        else if(choice == "5")
        {
          break;
        }
        } 
    }


    public static void SaveToFile(List<Entry> _entries){
    string filename = "journal.text";

    Console.WriteLine("Save to a file...");
    Console.WriteLine();
    using(StreamWriter outputFile = new StreamWriter(filename))
    {
      foreach(Entry entry in _entries)
      {
        outputFile.WriteLine($"{entry._date}, {entry._text}");
      }

    }

    }

    public static List<Entry> ReadFromFile()
    {
      Console.WriteLine("Reading a list from a file...");
      Console.WriteLine();

      List<Entry>entries = new List<Entry>();
      string filename = "journal.txt";

      string[]lines = System.IO.File.ReadAllLines(filename);

      foreach(string line in lines)
      {
        Console.WriteLine(line);
      }
      return entries;
    }



}