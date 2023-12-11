public class Character{
    protected string _name;
    public string Name{
        get{return _name;}
        set{_name = value;}  
    }
    protected int _life = 32;
    public int Life{
        get{return _life;}
        set{_life = value;}  
    }
    protected int _lifeMax ;
    public int LifeMax{
        get{return _lifeMax;}
        set{_lifeMax = value;}  
    }
    protected int _attack ;
    public int Attack{
        get{return _attack;}
        set{_attack = value;}  
    }
    protected int _path = 0;
    public int Path{
        get{return _path;}
        set{_path = value;}  
    }

    

    public Character(string name){
        
        Name = name;
        
    }


    public void Heal(){
        Life = LifeMax;
    }



    public void CharacterStrength(int path){
        Path = path;
        

        if (Path < 5){
            Life = 32;
            Attack = 5;
        }

        else if (Path > 5 && Path < 10){
            Life = 50;
            Attack = 25;
        }
        
        else if (Path > 10 && Path < 15){ 
            Life = 60;
            Attack = 30;
        }

        else if (Path > 20 && Path < 25){ 
            Life = 70;
            Attack = 40;
        }

        else if (Path > 30){ 
            Life = 80;
            Attack = 50;
        }
        
    }

    public virtual string GetStringRepresentation(){
        return $"{GetType()},Name: {Name},Life: {Life},Attack Power: {Attack}";
    }


}