public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>(); //creating a variable of type List associated with the class Job which is already create in a different file
                                              //also initialising the variable with new for ease of future actions

    public void DisplayResume() //creating a method or function that will use the variables
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");
        foreach (Job j in _jobs)
        {
            j.DisplayJobDetails();          
        } 

        
    }
}