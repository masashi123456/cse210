using System;
using System.IO;
using System.Timers;
public class Walk : Event{
    
    public Walk (string name) : base(name){
        EventName = "You are walking.....";
    }

    public void walkEvent(){
    Random random = new Random();
    int rnd = random.Next(1,10);
    Console.WriteLine("You are waliking...");
    Animation(5);
    if (rnd == 0 || rnd==1 || rnd == 2||rnd == 3 || rnd==4 || rnd == 5){
        Random mrandom = new Random();
        int mrnd = mrandom.Next(1,10);

        if (mrnd == 0 || mrnd==1 || mrnd == 2){
        Gobrin gobrin = new Gobrin();
        gobrin.nameMonster("Gobrin");
        gobrin.monsterPrompt();
        gobrin.MonsterFight();
        
        }

        else if (mrnd == 3 || mrnd==4 || mrnd == 5){
            Devilman devilman = new Devilman();
            devilman.nameMonster("Devilman");
            devilman.monsterPrompt();
            devilman.MonsterFight();
            }

        else if (mrnd == 6 || mrnd==7 || mrnd == 8){
            Dragon dragon = new Dragon();
            dragon.nameMonster("Devilman");
            dragon.monsterPrompt();
            dragon.MonsterFight();
            }

        else{
            Gobrin gobrin = new Gobrin();
            gobrin.nameMonster("Gobrin");
            }
        
        
    }


    else if (rnd == 6 || rnd==7 || rnd == 8){
        Console.WriteLine("A Monster Appeared");
        }


    else{
        Console.WriteLine("A Monster Appeared");
        }
    
    }

    

    
}    