public class Character{
    public string _name;    
    public int _life = 30;
    public int _lifeMax = 35;
    public int _attack = 5;
    public int _path = 0;

   

    public Character(){
        Console.WriteLine("What is the name of the Character?");
        string Name = Console.ReadLine();
        _name = Name;
    }


    



    public void CharacterStrength(int path){
        _path = path;
        

        if (_path > 10){
            _lifeMax = 32;
            _attack += 6;
        }

        else if (_path > 5 & path < 10){
            _lifeMax = 50;
            _attack += 20;
        }
        
        else if (_path > 10 & path < 15){ 
            _lifeMax = 60;
            _attack += 20;
        }

        else if (_path > 15 & path < 20){ 
            _lifeMax = 70;
            _attack += 30;
        }
        
    }


}