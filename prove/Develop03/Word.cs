using System.ComponentModel.DataAnnotations;

public class Word {
    public string _wstring;
    public bool _isHidden;

    public Word(string scripture){
        this._wstring = scripture;
        this._isHidden = false;
    }

    public void display()
    {
        Console.WriteLine(_wstring);
    }
}