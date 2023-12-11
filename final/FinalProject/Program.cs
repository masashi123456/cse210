using System;
class Program
{
    static int totalPath = 0;
    static string Name;
    static void Main(string[] args){
        Console.WriteLine("Welcone to the New World!!");
        Console.WriteLine("What is your name?");
        string? name = Console.ReadLine();
        Name = name;
        Character character = new Character(Name);
        Console.Clear();
        Console.WriteLine($"{character.Name}, Let's enjoy the adventure!!");
        character.CharacterStrength(totalPath);
        Thread.Sleep(2000);
        Walk walk = new Walk();
        Thread.Sleep(3000);
        Console.Clear();
        while(totalPath < 50){
            Console.WriteLine(Name);
            Console.WriteLine($"You walked {totalPath}/50 km!!");
            Console.WriteLine($"HP: {character.Life}\nAttack: {character.Attack}");
            Console.WriteLine("");
            Console.WriteLine("What do you like to do?\n1. Walk\n2. Go to Juju Hospital(Heal/Level UP(sometimes))\n3. Chaeck your status\n4. Save Date\n5. Reset");
            string? userAttempt = Console.ReadLine();
            
        
            if (userAttempt == "1"){
                totalPath ++ ;
                walk.walkEvent(character);
                totalPath += walk.Path;
               
                
            }

            else if (userAttempt == "2"){
                Console.WriteLine("You are going to the Juju Hospital!!");
                walk.Animation(5);
                Console.WriteLine("You are taking a rest");
                walk.Animation2(5);
                Console.WriteLine("You are fully recovered!!");
                character.CharacterStrength(totalPath);
               
                
            }

            else if (userAttempt == "3"){
                Console.WriteLine(name);
                Console.WriteLine($"HP: {character.Life}\nAttack: {character.Attack}");
                if (totalPath < 5){
                    int rest = 5 - totalPath;
                    Console.WriteLine($"You have {rest}km to have next level up!!");
                    Console.WriteLine($"Your life max will be 50, and your attack power will be 25!!");
                }
                
                else if (totalPath > 5 && totalPath > 10){
                    int rest = 10 - totalPath;
                    Console.WriteLine($"You have {rest}km to have next level up!!");
                    Console.WriteLine($"Your life max will be 60, and your attack power will be 30!!");
                }

                else if (totalPath > 10 &&totalPath > 20){
                    int rest = 20 - totalPath;
                    Console.WriteLine($"You have {rest}km to have next level up!!");
                    Console.WriteLine($"Your life max will be 50, and your attack power will be 40!!");
                }

                else if (totalPath > 20 &&totalPath > 30){
                    int rest = 30 - totalPath;
                    Console.WriteLine($"You have {rest}km to have next level up!!");
                    Console.WriteLine($"Your life max will be 80, and your attack power will be 50!!");
                }

                Console.WriteLine("You will return to the main menue in 6 secomds!!");
                Thread.Sleep(10000);
                Console.Clear();
               
                
            }

            else if (userAttempt == "4"){
                SaveFile();
            }
            
        }

    }

    

    static void SaveFile(){
        Character character = new Character(Name);
        Console.Write("Which file do you want to save? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.Write(character.GetStringRepresentation()+",");
            outputFile.Write($"totalpoints,{totalPath}");
            
        }

    }

    // static void LoadFile(){
       
    //     Character character = new Character("");
    //     Console.WriteLine("From which file do you want to load a data?" );
    //     string filename = Console.ReadLine();
    //     string[] lines = System.IO.File.ReadAllLines(filename);

    //     foreach (string line in lines)
    //     {
    //         string[] parts = line.Split(",");
    //         // make a new goal.
    //             // Create a new simple goal
                
    //         character.Name = parts[1];    // get all the information from the user. do this each time
    //         character. = parts[2];
    //         simpleGoal.Points = int.Parse(parts[3]);   
    //         goals.Add(simpleGoal);  // add object to the list of goals to save it for later
                

    // }
}

