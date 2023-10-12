public class Book
{
    private string _author;
    private string _name;
    private int _timesRead;
    private bool _available;

    public Book(string name, string author){
        _name = name;
        _author = author;
    }

    public int TimesRead()
    {
        return _timesRead;
    }

    public void CheckOut()
    {
        _timesRead += 1;
        _available = false;
    }

    public void CheckIn
    {
        
    }

   

}