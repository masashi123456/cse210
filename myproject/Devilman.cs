public class Devilman : Monsters{
    
    public override void nameMonster(string monsterName)
    {
        MonsterHP = 30;
        MonsterAttack = 5;
        monsterName = "Devilman";
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