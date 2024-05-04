public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry( Entry newEntry)//revisit
    {
        //put new entries into the _entries
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        //display all entris in the _entris list useing display function
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void SaveToFile( string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date} , {e._promptText}, {e._entryText}");
            }
        } 
    }

    public Journal LoadFromFile(string file)
    {
        Entry anEntry = new Entry();
        string[] lines = System.IO.File.ReadAllLines(file);
        Journal theJournal = new Journal();

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string dateIn = parts[0];
            string promptTextIn = parts[1];
            string entryTextIn = parts[2];

            anEntry._date = dateIn;
            anEntry._promptText = promptTextIn;
            anEntry._entryText = entryTextIn;

            theJournal.AddEntry(anEntry);


        }
        return theJournal;

    }
}