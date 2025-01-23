using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        /*
        //Create fraction using all 3 constructors
        Fraction fraction1 = new Fraction(); // 1/1
        Fraction fraction2 = new Fraction(6); // 8/1
        Fraction fraction3 = new Fraction(6, 7); // 6/7

        //Display initial values
        Console.WriteLine("Initial Fractions: ");
        Console.WriteLine($"Fraction1: {fraction1.GetTop()}/{fraction1.GetBottom()}");
        Console.WriteLine($"Fraction2: {fraction2.GetTop()}/{fraction2.GetBottom()}");
        Console.WriteLine($"Fraction3: {fraction3.GetTop()}/{fraction3.GetBottom()}");

        //Setters to change values
        fraction1.SetTop(3);
        fraction1.SetBottom(4);

        fraction2.SetTop(7);
        fraction2.SetBottom(2);

        fraction3.SetTop(9);
        fraction3.SetBottom(5);

        //Display results
        Console.WriteLine("\nUpdated Fractions:");
        Console.WriteLine($"Fraction1: {fraction1.GetTop()}/{fraction1.GetBottom()}");
        Console.WriteLine($"Fraction2: {fraction1.GetTop()}/{fraction2.GetBottom()}");
        Console.WriteLine($"Fraction3: {fraction1.GetTop()}/{fraction3.GetBottom()}");*/

        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());


    }
}


