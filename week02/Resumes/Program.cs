using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2015;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Entry Level Software Engineer";
        job2._startYear = 2025;
        job2._endYear = 2027;

        Resume resume1 = new Resume();
        resume1._name = "John Doe";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();


    }
}