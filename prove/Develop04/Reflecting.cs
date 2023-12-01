public class Reflecting : Activity{
    private List<string>_prompt = new List<string>() {
        "Think of a time when you did something really difficult",
        "Think of a time when you feel the spirit",
        "Think of a time when you achieve something you had never achieve",
        "Think of a time when you helped someone in need.",
    };

    private List<string>_question = new List<string>(){
        "How did you feel when you acomplished it? ",
        "What is your favorite thing about this experience",
        "What did you learn from the experience?",
        "Why was this experience meaningful to you?",
        "What made this time different than other times when you were not as successful?",
        "How can you keep this experience in mind in the future?",
        "What did you learn about yourself through this experience?",
        "What could you learn from this experience that applies to other situations?",
    };
    
    public List<string>Prompt{
        get{return _prompt;}
        set{_prompt= value;}
    }

    public Reflecting (string name) : base(name){
        ActivityName = "Reflecting Activity";
    }

    public void ReflectAct(){
        Random random = new Random();
        int rnd = random.Next(_question.Count);
        int prnd = random.Next(_question.Count);
        Animation(9);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {_prompt[rnd]} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string userEnter = Console.ReadLine();
        Console.Clear();
        Console.WriteLine();
        if(userEnter==""){
            Console.WriteLine("Now ponder on each of the fllowing question as they related to this experience");
            Console.Write("You may begin in: ");
            DisplayCountdown(8);
            Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(Time);
            DateTime currentTime = DateTime.Now;

            while(currentTime < endTime){
                prnd = random.Next(_question.Count);
                Console.WriteLine(_question[prnd]);
                Console.ReadLine();
                currentTime = DateTime.Now;
                
                
            }
        
                
            

        }
    }

  


}