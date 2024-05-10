public class Reference
{
    //attributes/variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // //Constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }   
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    } 

    //methods/ functions
    public string GetDisplayText()
    {
        string refe;
        if (_verse == _endVerse)
        {
            string chapterString = _chapter.ToString();
            string verseString = _verse.ToString();
            string endVerseString = _endVerse.ToString();
            refe= string.Concat(_book, " " , chapterString, ":",verseString , " ");
        }
        else
        {
            string chapterString = _chapter.ToString();
            string verseString = _verse.ToString();
            string endVerseString = _endVerse.ToString();
            refe= string.Concat(_book, " " , chapterString, ":",verseString, "-" , endVerseString , " ");
        }

        return refe;
    }
}