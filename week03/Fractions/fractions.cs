public class Fractions
{
    private int _top;
    private int _bottom;
    public Fractions(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fractions(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

    public string GetFractionString()
    {
        string answer = $"{_top}/{_bottom}";
        return answer;
    }

    public double GetDecimalValue()
    {
        double answer = (double)_top / (double)_bottom;
        return answer;
    }
}