public class Word
{
    //attributes/variables
    private string _text;
    private bool _isHidden;

    //Constructors
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //methods/ functions
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_isHidden == false)
        {
            return false;
        }
        else
        {
            return true;
        }
        // return false;
    }

    public string GetDisplayText()
    {   
        // gets Word object, checks _isHidden attribute, returns _ for every letter if _ishidden ==true
        string wordHolder ="";
        if (_isHidden == false)
        {
            wordHolder = _text;
        }
        else
        {
            foreach (char c in _text)
            {
                if (c == ',' || c== '.' || c==';' || c=='\''|| c=='"' || c=='?' || c=='!')//to exclude special charracters from hiding
                {
                    wordHolder+=c;
                }
                else
                {
                    wordHolder += "_";
                }                
            }
            
        }
        return wordHolder;
    }



}

