using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber = -1;


        while (newNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            
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


            }
            

        }
    }
}