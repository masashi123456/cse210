public class Match
{
    private Team _team1;
    private Team _team2;

    public Match(Team team1. team2)
    {
    _team1 = team1
    _team2 = team2
    }

    public void Decidewin()

    {
        Console.writeLine("Which Team won?")
        Console.writeLine($"1{_team1. GetTeamName()}")
        Console.writeLine($"2{_team1. GetTeamName()}")
        string wineer = Console.ReadLine();
        if(winner == "1")
        {
            _team1.Addwin();
            _team2.Addlosses();
        }
        else
        {
           _team1.Addlosses();
           _team2.Addwin();  
        }
    }

}

