using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {   
        //Classes using for this program
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string filePath = "myJournalFile.txt";
        


        //Load from file if it exists
        if (File.Exists(filePath))
        {
            journal.LoadFromFile(filePath);
        }

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("===Welcome to the Journal Program!===");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string option = Console.ReadLine();


            switch (option)
            {
                case "1":
                    //Write
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Write your entry: ");
                    string entryText = Console.ReadLine();
                    Entry newEntry = new Entry(prompt, entryText);
                    journal.AddEntry(newEntry);
                    break;

                case "2":
                    //Display
                    journal.DisplayAll();
                    break;

                case "3":
                    //Load 
                    journal.LoadFromFile(filePath);
                    Console.WriteLine(".........Journal Loaded!");
                    break;

                case "4":
                    //Save 
                    journal.SaveToFile(filePath);
                    Console.WriteLine(".........Journal saved!");
                    break;

                case "5":
                    //Quit
                    Console.Write("\n****Remember to save your new entries! ");
                    Console.Write("\nAre you sure you want to quit? y or n: ");
                    string finish = Console.ReadLine().ToLower();  // Convert input to lowercase

                    if (finish == "y")
                    {
                        Console.WriteLine("***Good Bye***");
                        running = false;
                    }
                    else if (finish == "n")
                    {
                        running = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                    }

                    break;

                default:
                    Console.WriteLine("Invalid selection, Please choce a valid option.");
                    break;

            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
                
        }
    }
}