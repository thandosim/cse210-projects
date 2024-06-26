public class Scripture
{
    //attributes/variables
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private int _numWords;
    private List<bool> _boolList = new List<bool>();
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

    public int getNumberOfWords()
    {
        _numWords = _words.Count;
        return _numWords;
    }

    //methods/ functions
    public void HideRandomWords()//i have changed this method so that it randomly chooses a number of words to hide from 1 to 3 words. 
    {
        _numWords = _words.Count;//get number of words in verse/s
        Random randomGenerator = new Random();
        int _numberToHide;
        _numberToHide = randomGenerator.Next(1,3);//randomly chosoe to hide between 1 to 3 words

        int _wordsToHide;
        for (int i = 0; i <= _numberToHide; i++ )
        {
            int check =0;
            while (check < _numberToHide )
            {
                _wordsToHide = randomGenerator.Next(0,_numWords);
                if ( _words[_wordsToHide].IsHidden()== false)// if the word is not hidden, 
                {
                    _words[_wordsToHide].Hide();//hide random word if not already hidden
                    check += 0;
                }
   
                else
                {
                    check += 1;
                }
            }
        }
    }

    public string GetDisplayText()
    {
        string textToDisplay =_reference.GetDisplayText() + " ";
        foreach (var word in _words)
        {
            textToDisplay += word.GetDisplayText();
            textToDisplay += " ";
        } 
        return textToDisplay;
    }

    public bool IsCompletelyHidden()
    {
        
        _numWords = _words.Count;//get number of words in verse/s
        _boolList =[];
        for (int i = 0; i <= _numWords-1; i++)
        {
            _boolList.Add(_words[i].IsHidden());
        }
        bool allTrue =_boolList.All(item => item == true);

        return allTrue;
    }

}
