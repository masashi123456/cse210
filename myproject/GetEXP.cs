public class GetEXP : Event{
    public GetEXP(string name) : base(name){
        EventName = "Get EXP!!";
    }

    public void addEXP(){
        Console.WriteLine("You got 10 EXP!!");
        getEXP(10);
    } 


}