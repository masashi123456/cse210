public abstract class Monsters {
    protected string _nameMonster;
    public string NameMonster {
        get {return _nameMonster;}
        set {_nameMonster = value;}
    }

    protected int _mpath;
    public int Mpath {
        get {return _mpath;}
        set {_mpath = value;}
    }

    protected int _mpoint;
    public int Mpoint {
        get {return _mpoint;}
        set {_mpoint = value;}
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
    private int _attempt = 0;
    public int attempt{
        get {return _attempt;}
        set {_attempt = value;}
    }

    private Random random = new Random();
    
    private Character character;





    public virtual void nameMonster(string monsterName, Character character){
        NameMonster = monsterName;
        this.character = character;
        Console.WriteLine("A monster appeared!!");
        Console.WriteLine($"The monster is {NameMonster}!!");
    }   

    public abstract void monsterPrompt();

    
    
    
    public virtual void MonsterFight(){
        
        while(MonsterHP > 0 && character.Life > 0){
            MonsterHP -= character.Attack;
            character.Life -= MonsterAttack;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write($"Your HP: {character.Life}   >><<   Monster's HP: {MonsterHP}");
            Thread.Sleep(1000);
            


        }
        if(character.Life > 0){
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("You won!! You beated the monster!!");
            Console.WriteLine($"Your life is {character.Life}");
            Console.WriteLine($"You proceeded {Mpoint} Km!!");
            Thread.Sleep(5000);
            Console.Clear();
            attempt+=3;

            Mpoint = Mpath;
            
        
        }
            
        else {
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("You lose.");
            Console.WriteLine("You have to go to the JUJU hospital!!");
            Thread.Sleep(5000);
            attempt+=3;
            Console.Clear();
            
        }
        
        
        

    }

    

    
}