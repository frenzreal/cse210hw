using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you grade percentage? ");
        string gradePercent = Console.ReadLine();
        int gradeNum = int.Parse(gradePercent);
        string gradeLetter, remarks;
        if (gradeNum >= 90)
        {
            gradeLetter = "A";
        }
        else if (80 <= gradeNum && gradeNum <= 90)
        {
            gradeLetter = "B";
        }
        else if (70 <= gradeNum && gradeNum <= 80)
        {
            gradeLetter = "C";
        }
        else if (60 <= gradeNum && gradeNum <= 70)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }
        Console.WriteLine($"Your Letter Grade is: {gradeLetter}");
        if (gradeNum >= 70)
        {
            remarks = "You passed!";
        }
        else
        {
            remarks = "You failed.";
        }
        Console.WriteLine(remarks);
    }
}