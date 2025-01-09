using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        if (grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid Grade. Please enter a grade between 0 and 100.");
            return;
        }

        string letter = "";
        string sign = "";

        if (grade >=90)
        {
            letter = "A";
            if (grade >= 97) sign = "";
            else if (grade <93) sign = "-";

        }
        else if (grade >=80)
        {
            letter = "B";
            if (grade >= 87) sign = "+";
            else if (grade <83) sign = "-";
        }
        else if (grade >=70)
        {
            letter = "C";
            if (grade >= 77) sign = "+";
            else if (grade <73) sign = "-";
        }
        else if (grade >=60)
        {
            letter = "D";
            if (grade >= 67) sign = "+";
            else if (grade <63) sign = "-";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");

        if (grade >= 70 )
        {
            Console.WriteLine("Congratulations! you pass this class.");
        }
        else
        {
            Console.WriteLine("Sorry you didn't pass this class, Please keep Trying.");
        }
    }
}