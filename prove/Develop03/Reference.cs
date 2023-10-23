public class Reference{
    public string _book;
    public string _chapter;
    public string _verse;

    public Reference(string book, string chapter, string verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public void display(){
        Console.Write($"{_book}:{_chapter}-{_verse} ");
    }

}