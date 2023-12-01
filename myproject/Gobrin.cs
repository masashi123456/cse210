public class Gobrin : Monsters{


    public override void nameMonster(string monsterName)
    {   MonsterHP = 30;
        MonsterAttack = 5;
        monsterName = "Gobrin";
        base.nameMonster(monsterName);
        
    }

    public override void monsterPrompt()
    {
        base.monsterPrompt();
    }

    public override void MonsterFight()
    {
        base.MonsterFight();
    }

}

    
