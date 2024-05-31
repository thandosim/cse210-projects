using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity runningActivity = new RunningActivity("03 Nov 2024",30, 4);
        BicycleActivity bicycleActivity = new BicycleActivity("05 May 2024",45,60);
        SwimmingActivity swimmingActivity = new SwimmingActivity("06 Apr 2024",60,40);
        List<Activity> activities = new List<Activity>();
        activities.Add(runningActivity);
        activities.Add(bicycleActivity);
        activities.Add(swimmingActivity);
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        
    }
}