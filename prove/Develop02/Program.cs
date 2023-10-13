using System;
using Microsoft.VisualBasic;
using Microsoft.Win32.SafeHandles;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        bool trying = true;
        Random rnd = new Random();
        Prompt usersWrite = new Prompt();
        Journal journal = new Journal();
        
        
        // Sentinel controlled loop
        while(trying == true)
        {
        Console.WriteLine("Please select one of these choices\n1. Write\n2. Display\n3. Load\n4. Save\n5. View points\n6. Quit");
        Console.WriteLine("What would you like to do?");
        String choice = Console.ReadLine();

          if(choice == "1")
          {
            Entry entry = new Entry();

            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();

            
            
            int randIndex = rnd.Next(usersWrite._promptList.Count);

            Console.WriteLine(usersWrite._promptList[randIndex]);
            string usersAnswer = Console.ReadLine();

            entry._date = dateText;
            entry._text = usersWrite._promptList[randIndex] + usersAnswer;


            journal.AddEntry(entry);
            if (journal._points >= 1000) {
              journal.AddPoints(200);  
              Console.WriteLine($"+200 points for writing in your journal. You now have {journal._points} points!");
            }
            else {
              journal.AddPoints(100);   // Give user 100 points for writing in their journal.
              Console.WriteLine($"+100 points for writing in your journal. You now have {journal._points} points!");
            }
            Console.WriteLine();
          }

          else if(choice == "2")
          {
            journal.DisplayJournal();
            Console.WriteLine();
            
          }
          else if(choice == "3")
          {
            journal = ReadFromFile();
            Console.WriteLine();
          }

          else if(choice == "4")
          {
            SaveToFile(journal);
          }

          else if(choice == "5"){
            Console.WriteLine($"You have {journal._points} points.");
          }

          else if (choice == "6") trying = false;
        } 
    }


    public static void SaveToFile(Journal journal){
    string filename = "journal.txt";

    Console.WriteLine("Save to a file...");
    Console.WriteLine();
    using(StreamWriter outputFile = new StreamWriter(filename))
    {
      // Print number of points before everything else
      outputFile.WriteLine(journal._points.ToString()); 

      foreach(Entry entry in journal._entries)
      {
        outputFile.WriteLine($"{entry._date}, {entry._text}");
      }
    }

    }

    public static Journal ReadFromFile()
    {
      Console.WriteLine("Reading a list from a file...");
      Console.WriteLine();

      // List<Entry>entries = new List<Entry>();
      Journal journal = new Journal();
      
      string filename = "journal.txt";

      string[] lines = System.IO.File.ReadAllLines(filename);


      foreach(string line in lines)
      {
        if (line == lines[0]){
          journal._points = Int32.Parse(line);
        }
        else {
          string[] parts = line.Split(",");
          Entry entry = new Entry();
          entry._date = parts[0];
          entry._text = parts[1];
          journal._entries.Add(entry);
        }
      }
      return journal;
    }



}