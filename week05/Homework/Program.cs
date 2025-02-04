using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine("Base class assignment");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();


        MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine("Derived class assignment");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());


        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "Europen History", "The Causes of World War II");
        Console.WriteLine();
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
        Console.WriteLine();

    }
}