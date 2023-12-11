using System;
using System.IO;
using System.Timers;
public class Walk {
    
    
    public Walk (){
        Console.WriteLine("You have to walk up to 50 km to go back to your throne!!");
        
       
    }

    private int _path = 0;
    public int Path{
        get{return _path;}
        set{_path = value;}
    }

    private Character character;

    public void walkEvent(Character character){
    this.character = character;
    Console.WriteLine("You are waliking....");
    // Animation(5);
    Random random = new Random();
    int rnd = random.Next(1,10);
    Console.Clear();
    if (rnd >= 1 && rnd <= 5){
        Random mrandom = new Random();
        int mrnd = mrandom.Next(1,10);

        if (mrnd == 0 || mrnd==1 || mrnd == 2|| mrnd == 9){
            Gobrin gobrin = new Gobrin();
            gobrin.nameMonster("Gobrin", character);
            gobrin.monsterPrompt();
            Path = gobrin.Mpath;
            }

        else if (mrnd == 3 || mrnd==4 || mrnd == 5||mrnd == 6){
            Devilman devilman = new Devilman();
            devilman.nameMonster("Devilman", character);
            devilman.monsterPrompt();
            Path = devilman.Mpath;
            }

        else if (mrnd==7 || mrnd == 8){
            Dragon dragon = new Dragon();
            dragon.nameMonster("Devilman", character);
            dragon.monsterPrompt();
            Path = dragon.Mpath;
            }

        
        
        
    }


    else if (rnd == 6 || rnd==7 || rnd == 8){
        Console.WriteLine("Nothing happened!!");
        Console.WriteLine("You walked 1 km!!");
        Path = 1;
        Thread.Sleep(3000);
        Console.Clear();
        }


    else{
        Console.WriteLine("You got a special chance!!");
        Path = 0;
        }
    
    }

    public void Animation(int times){
        int Atimes = 0;
        Console.Write("_");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        while(Atimes < times){
            

            Console.Write("_");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write(" _");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("  _");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
            Console.Write("   _");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("     _");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Atimes +=5;
            }
            
        Console.WriteLine();
    } 

        public void Animation2(int times){
        int Atimes = 0;
        Console.Write("z");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        while(Atimes < times){
            

            Console.Write("zz");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("zzz");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("zzzz");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
            Console.Write("zzzzz");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Atimes +=5;
            }
            
        Console.WriteLine();
    } 

    public Character Character = new Character("You");

    
}    