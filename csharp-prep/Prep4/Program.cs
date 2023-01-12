using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();

        int userInput = -1;

        while (userInput != 0)
        {
            Console.Write("Enter a number to add to the list or enter 0 to quit: ");

            string number = Console.ReadLine();
            userInput = int.Parse(number);

            if (userInput != 0)
            {
                numberList.Add(userInput);
            }
        }

        int sum = 0;
        foreach (int input in numberList)
        {
            sum += input;
        }

        Console.WriteLine($"The sum is {sum}.");

        float average = ((float)sum) / numberList.Count;
        Console.WriteLine($"The average is {average}.");

        int max = numberList[0];

        foreach (int input in numberList)
        {
            if (input > max)
            {
                max = input;
            }
        }

        Console.WriteLine($"The largest number is {max}.");
    }
}