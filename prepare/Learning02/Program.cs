using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");

        // creating first job instance
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2001;
        job1._endYear = 2003;

        //Console.WriteLine(job1._company);//testing the first job by printing the company name
        //job1.DisplayJobDetails(); //using the built method to display job1 details

        //creating second jpb instance
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Designer";
        job2._startYear = 2003;
        job2._endYear = 2006;

        //Console.WriteLine(job2._company);//testing the second job
        //job2.DisplayJobDetails();

        //creating a Resume instance
        Resume resume1 = new Resume();
        resume1._name = "Thandokuhle Simelane";// adding a simpple variable
        resume1._jobs.Add(job1); //adding a custom-made variable of trype list. the item beign added to the list is job1 which comes with all the details already entered above 
        resume1._jobs.Add(job2);

        //accessing a specific variable withing _jobs object which is withing resume object
        //the _jobs object is a list of jobs so we use [0] index to specify
        //Console.WriteLine(resume1._jobs[0]._jobTitle);

        resume1.DisplayResume();//displaying resume informaion using function in the resume class


    }
}