using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            

            switch (choice)
            {
                
                default:
                Console.WriteLine("Invalid Choice Please Try Again.");
                continue;

            }

            
        }
    }
}