using System;

//Here we are creating the class Job
//This class will be used to store information about a job
public class Job
{
    // These are the information that we will store about a job
    public string _companyName;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    //This function will show the details of the job 
    public void ShowJobDetails()
    {
        Console.WriteLine($"Company: {_companyName}");
        Console.WriteLine($"Job Title: {_jobTitle}");
        Console.WriteLine($"Start Year: {_startYear}");
        Console.WriteLine($"End Year: {_endYear}");
    }
}