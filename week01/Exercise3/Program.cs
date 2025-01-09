using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        //Console.WriteLine($"You selected {magicNumber} as magic number.");

        int guessNumber = -1;

        //Console.WriteLine($"Guess number is {guessNumber}");
        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
        

            if (magicNumber > guessNumber)
            {
               Console.WriteLine("Higher");
            }
            else if (magicNumber < guessNumber)
            {
               Console.WriteLine("Lower");
            }
            else 
            {
               Console.WriteLine("You Guessed it!");
            }

        }
    }
}