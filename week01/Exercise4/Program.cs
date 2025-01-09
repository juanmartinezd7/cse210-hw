using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        while (newNumber != 0)
        {
            Console.Write("Enter a number: ");
            
            string inputNumber = Console.ReadLine();
            newNumber = int.Parse(inputNumber);
            //add the numbers to the list.
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
            
            //show the results
            if (newNumber == 0)
            {
                //sum the numbers
               int sumNumbers = 0;
               foreach (int number in numbers)
               {
                   sumNumbers += number;
               } 

               Console.WriteLine($"The sum of the list is: {sumNumbers}");

                //get the average 
               float listAverage = ((float)sumNumbers) / numbers.Count;
               Console.WriteLine($"The Average is: {listAverage}");

               //get the largest number
               int largestNumber = numbers[0];
               foreach (int number in numbers)
               {
                  if (number > largestNumber)
                  {
                     largestNumber = number;
                  }
               }
               Console.WriteLine($"The largest number is: {largestNumber}");


               //get the smallest positive number closest to zero
               int? closestPositive = null;

               foreach (var number in numbers)
               {
                if (number > 0)
                {
                    if (closestPositive == null || number < closestPositive)
                    {
                        closestPositive = number;
                    }
                }
               }
                //show the result
               if (closestPositive.HasValue)
               {
                   Console.WriteLine($"The Smallest positive number closest to zero is: {closestPositive}");
               }
               else
               {
                   Console.WriteLine("There are no positive numbers in the list");
               }
                //show the list of numbers sorted
                Console.WriteLine($"The sorted list is:");
                numbers.Sort();
                foreach (var number in numbers)
                {
                    
                    Console.WriteLine(number);
                }



            }
            

        }
    }
}