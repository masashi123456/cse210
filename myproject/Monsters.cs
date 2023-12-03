public abstract class Monsters {
    protected string _nameMonster;
    public string NameMonster {
        get {return _nameMonster;}
        set {_nameMonster = value;}
    }

    protected int _monsterHP;

    public int MonsterHP{
        get {return _monsterHP;}
        set {_monsterHP = value;}
    }

    protected int _monsterAttack;

    public int MonsterAttack{
        get {return _monsterAttack;}
        set {_monsterAttack = value;}
    }

    int attempt = 0;
    


    public virtual void nameMonster(string monsterName){
        NameMonster = monsterName;
        Console.WriteLine($"The monster is {NameMonster}!!");
    }   

    public virtual void monsterPrompt(){

        while (attempt != 3){
        Console.WriteLine("What do you want to do?\n1. Fight\n2.Run Away\n3. Sleep");
        string? userPrompt = Console.ReadLine();

        if(userPrompt =="1"){
            MonsterFight();
        }

        else if (userPrompt == "2") {
            Console.WriteLine("The monster is still chasing you");
            attempt++;
            }
        
        
            
        
            
        else if (userPrompt == "3"){
            Random random = new Random();
            int rnd = random.Next(1,5);

            if (rnd == 0 || rnd==1){
            Console.WriteLine("The monster thought you are dead. The monster dissapeared!!");
            attempt+=3; 
            
            }

            else if (rnd == 2||rnd == 3 || rnd==4 || rnd == 5){
                Console.WriteLine("You are attacked by the monster!!");
                attempt+=3;
            }

        }

        

        }
    }

    public virtual void MonsterFight(){
        Character character = new Character();
        while(MonsterHP == 0||character._life == 0){
            MonsterHP -= character._attack;
            character._life -= MonsterAttack;

        }
        if(MonsterHP == 0){
            Console.WriteLine("You won!! You beated the monster!!");
            Console.WriteLine($"Your life is {character._life}");
            attempt+=3;
        }
            
        else{
            Console.WriteLine("You lose.");
            Console.WriteLine("You have to go to the JUJU hospital!!");
            attempt+=3;
        }
        

    }

    

    

    
    
    

    
    




}