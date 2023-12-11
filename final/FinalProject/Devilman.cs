public class Devilman : Monsters{

    
    
    public override void nameMonster(string monsterName, Character character)
    {
        MonsterHP = 150;
        MonsterAttack = 7;
        monsterName = "Devilman";
        Mpoint = 2;
        base.nameMonster(monsterName, character);
       
    }

        public override void  monsterPrompt(){
        Console.Clear();
        Console.WriteLine("The Devilman says, \"Wha ha ha ha ha!!\"");
        Console.WriteLine($"The Monster: Goobrin\nHP: {MonsterHP}\nAttack: {MonsterAttack}");
        Console.WriteLine("");
        Random random = new Random();
        while (attempt < 3){
            Console.WriteLine("What do you want to do?\n1. Fight\n2. Run Away\n3. Sleep");
            string? userPrompt = Console.ReadLine();

            if(userPrompt =="1"){
                MonsterFight();
                
                
            }

            else if (userPrompt == "2") {
                Console.WriteLine("The monster is still chasing you");
                attempt++;
                Thread.Sleep(1000);
                Console.Clear();
                }
            
            
                
            
                
            else if (userPrompt == "3"){
                
                int rnd = random.Next(1,6);

                if (rnd == 1 || rnd==2){
                Console.WriteLine("The monster thought you are dead. The monster dissapeared!!");
                attempt+=3; 
                
                }

                else{
                    Console.WriteLine("The monster is still stearing at you!!");
                    attempt+=1;
                }

            

            }

        

        }

        if(attempt ==3){
            Console.WriteLine("--------The monster dissapeared");
            Thread.Sleep(3000);
            Console.Clear();
        }
    
    }

    

}