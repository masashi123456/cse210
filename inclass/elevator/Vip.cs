public class Vip : Elevator
{
    public string _code;
public Vip(string code) 
{
    _code = code;
} 

public void TypeCode(string code)
{
    if(code == _code)
    {
        doorOpen();
        Console.WriteLine("VIP access granted. Please choose a floor.");

    }

    else{
        Console.WriteLine("Invalid access code.");
    }
}


}