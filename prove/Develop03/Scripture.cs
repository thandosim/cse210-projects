public class Scripture
{
    //attributes/variables
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private int numWords;
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
        numWords = _words.Count;//get number of words in verse/s
        Random randomGenerator = new Random();
        int _numberToHide;
        _numberToHide = randomGenerator.Next(1,3);//randomly chosoe to hide between 1 to 3 words

        int _wordsToHide;
        for (int i = 0; i <= _numberToHide; i++ )
        {
            _wordsToHide = randomGenerator.Next(0,numWords); 
            _words[_wordsToHide].Hide();//hide random word
        }
    }

    public string GetDisplayText()
    {
        string textToDisplay ="";
        foreach (var word in _words)
        {
            textToDisplay += word.GetDisplayText();
            textToDisplay += " ";
        } 
        return textToDisplay;
    }

    public bool IsCompletelyHidden()
    {
        List<bool> boolList = new List<bool>();
        numWords = _words.Count;//get number of words in verse/s
        for (int i = 0; i <= numWords-1; i++)
        {
            boolList.Add(_words[i].IsHidden());
        }
        bool allTrue = boolList.All(item => item == true);

        return allTrue;
    }

}
