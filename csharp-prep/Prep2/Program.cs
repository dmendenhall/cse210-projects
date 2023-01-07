using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        int grade = int.Parse(userInput);
        string letter = "";
        
        if (grade >= 90)
        {
            letter = ("A");
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = ("B");
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = ("C");
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = ("D");
        }
        else if (grade < 60)
        {
            letter = ("F");
        }

        Console.WriteLine($"Your letter grade is {letter}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations. You passed!");
        }
        else
        {
            Console.WriteLine("Good effort. Keep trying!");
        }
    }
}