using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "WISE Home Solutions";
        job1._jobTitle = "Director of Call Center Operations";
        job1._startYear = "2018";
        job1._endYear = "Present";

        Job job2 = new Job();
        job2._company = "Landmark Home Warranty";
        job2._jobTitle = "Director Inside Sales";
        job2._startYear = "2012";
        job2._endYear = "2017";

        Resume myResume = new Resume();
        myResume._name = "David Mendenhall";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();       
    }
}