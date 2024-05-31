using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("3 Auburn Ave", "Cleveland", "Ohio", "USA");
        Address address2 = new Address("7 Hepburn St", "Freemans Bay", "Auckland", "NZ");
        Address address3 = new Address("2 Main Rd", "Arorangi", "Rarotonga", "CI");

        LectureEvent event1 = new LectureEvent("Singing With Oomph!","Lecture on how to put oomph in music.","06/07/24","08:00hrs",address1,"Bro Big Man",100);
        ReceptionEvent event2 = new ReceptionEvent("Mr & Mrs Pik's 2nd Annivesary","2 year annivessary for the Piks","01/05/24","17:00hrs",address2,"thepiks@mail.com");
        OutdoorEvent event3 =new OutdoorEvent("Warthog Run","Fun Run for All ages at wild game park","11/09/24","10:00hrs",address3,"Sunny, gentle breeze");

        event1.DisplayBaseDetails();
        Console.WriteLine();
        event1.DisplayFullDetails();
        Console.WriteLine();
        event1.DisplayShortDetails();
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine();

        event2.DisplayBaseDetails();
        Console.WriteLine();
        event2.DisplayFullDetails();
        Console.WriteLine();
        event2.DisplayShortDetails();
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine();

        event3.DisplayBaseDetails();
        Console.WriteLine();
        event3.DisplayFullDetails();
        Console.WriteLine();
        event3.DisplayShortDetails();
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine();
    }
}