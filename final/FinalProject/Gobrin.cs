public class Gobrin : Monsters{

    


    public override void nameMonster(string monsterName, Character character)
    {   
        MonsterHP = 30;
        MonsterAttack = 5;
        monsterName = "Gobrin";
        Mpoint = 1;
        base.nameMonster(monsterName,character);
        
    }

        public override void monsterPrompt(){
        Console.Clear();
        Console.WriteLine("The Gobrin says, \"Yipee!\"");
        Console.WriteLine($"The Monster: Goobrin\nHP: {MonsterHP}\nAttack: {MonsterAttack}");
        Console.WriteLine("");

        while (attempt < 3){
            Console.WriteLine("What do you want to do?\n1. Fight\n2. Run Away\n3. Sleep");
            string? userPrompt = Console.ReadLine();

            if(userPrompt =="1"){
                MonsterFight();
                
                
            }

            else if (userPrompt == "2") {
                Console.WriteLine("The monster is still chasing you");
                attempt+= 2;
                Thread.Sleep(2000);
                Console.Clear();
                }
            
            
                
            
                
            else if (userPrompt == "3"){
                Console.WriteLine("The monster thought you are dead. The monster dissapeared!!");
                attempt+=3; 
            }

            

            

        

        }

        if(attempt ==3){
            Console.WriteLine("--------The monster dissapeared");
            Thread.Sleep(3000);
            Console.Clear();
        }
    
    }

    

    
}

    
