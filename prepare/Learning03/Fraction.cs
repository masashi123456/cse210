public class Fraction
{
    private int _topNumbers;
    private int _bottomNumbers;

    public Fraction()
    {
        _topNumbers = 1;
        _bottomNumbers = 1;
        
    }

    public Fraction(int tNumber)
    {
        _topNumbers = tNumber;
        _bottomNumbers = 1;
    }

    public Fraction(int top, int bottom)
    {
       _topNumbers = top;
       _bottomNumbers = bottom;
    }

    public string GetFractionString()
    {

     string text =$"{_topNumbers}/{_bottomNumbers}";
     return text;
    }

    public double GetDecimalValue()
    {
        return (double)_topNumbers / (double) _bottomNumbers
    }
}