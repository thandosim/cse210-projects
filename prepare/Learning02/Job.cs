public class Job // creating a class named Job
{
    public string _company; //creating the variables that each job  object will have
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void DisplayJobDetails() //creating a method or function that will use the variables
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}