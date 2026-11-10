using System;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //Constructor for a single verse reference i.e John 3:16
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }
    //Constructor for a range of verses i.e John 3:16-18
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
       //ensures that the end verse is greater than the starting verse and that it is not zero. 
        if (_endVerse > 0 && _endVerse > _verse) 
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }

        return $"{_book} {_chapter}:{_verse}";
    }
}