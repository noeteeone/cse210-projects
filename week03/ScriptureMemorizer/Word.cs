public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            char[] masked = _text.Select(c => char.IsLetter(c) ? '_' : c).ToArray();
            return new string(masked);
        }

        return _text;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}
