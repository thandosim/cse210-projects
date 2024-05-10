public class Scripture
{
    //attributes/variables
    // private Reference _reference = new Reference();
    private List<Word> _words = new List<Word>();

    //Constructors
    public Scripture(Reference reference, string text)
    {
        // _reference = reference;
        // _words = text;
    }

    //methods/ functions
    public void HideRandomWords(int numberToHide)
    {
        
    }

    public string GetDisplayText()
    {  
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }

}
