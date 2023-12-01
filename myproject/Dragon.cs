public class Dragon : Monsters{
    
    public override void nameMonster(string monsterName)
    {
        MonsterHP = 30;
        MonsterAttack = 5;
        monsterName = "Dragon";
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