public class Dragon : Monsters{

    
    
    public override void nameMonster(string monsterName, Character character)
    {
        MonsterHP = 240;
        MonsterAttack = 10;
        monsterName = "Dragon";
        Mpoint = 5;
        base.nameMonster(monsterName, character);
        
    }

        public override void monsterPrompt(){
        Console.Clear();
        Console.WriteLine("The Dragon is flying a sky and brathing fire!!");
        Console.WriteLine($"The Monster: Dragon\nHP: ??\nAttack: ??");
        Console.WriteLine("");
        Random random = new Random();
        while (attempt != 3){
            Console.WriteLine("What do you want to do?\n1. Fight\n2. Run Away\n3. Hind in the cave");
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
                Console.WriteLine("The monster lost you. The monster dissapeared!!");
                attempt+=3; 
                
                }

                else{
                    Console.WriteLine("The dragon is still fling on the cave!!");
                    attempt+=0;
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