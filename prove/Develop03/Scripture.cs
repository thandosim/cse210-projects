public class Scripture
{
    //attributes/variables
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    //Constructors
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word wordObject = new Word(word);
            _words.Add(wordObject);
        }
    }

    //methods/ functions
    public void HideRandomWords()//i have changed this method so that it randomly chooses a number of words to hide from 1 to 3 words. 
    {
        int numWords = _words.Count;//get number of words in verse/s
        Random randomGenerator = new Random();
        int _numberToHide;
        _numberToHide = randomGenerator.Next(1,3);//randomly chosse to hide between 1 to 3 words

        int _wordsToHide;
        for (int i = 0; i <= _numberToHide; i++ )
        {
            _wordsToHide = randomGenerator.Next(1,numWords); 
            _words[_wordsToHide].Hide();//hide random word
        }
    }

    public string GetDisplayText()
    {
        string textToDisplay ="";
        foreach (var word in _words)
        {
            textToDisplay += word.GetDisplayText();
        } 
        return textToDisplay;
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }

}
