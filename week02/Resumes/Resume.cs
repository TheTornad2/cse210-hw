using System;

public class Resume
{
    public string _name;
    public List<Job> _Jobs = new List<Job>();

    public void ShowResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job Job in _Jobs)
        {
            Job.ShowJobDetails();
            Console.WriteLine("--------------------");
        }
    }
}