using System;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    //public Scripture(Reference reference, List<Word> words)
    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _words = scriptureText
            .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(word => new Word(word.Trim()))
            .ToList();
    }
    public void HideRandomWords(int count)
    {
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        int wordsToHide = Math.Min(count, visibleWords.Count);
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
    public string GetDisplayText()
    {
        string displayText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} - {displayText}";
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}


