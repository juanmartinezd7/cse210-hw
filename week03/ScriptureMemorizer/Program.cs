using System;
class Program
{
    static void Main(string[] args)
    {

        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Matthew", 5, 9), "Blessed are the peacemakers: for they shall be called the children of God."),
        };

        Random random = new Random();
        bool continueProgram = true;

        while (continueProgram)
        {
            Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];
            selectedScripture.ResetHiddenWords();
            

            while (true)
            {

                Console.Clear();
                Console.WriteLine(selectedScripture.GetDisplayText());

                if (selectedScripture.IsCompletelyHidden())
                {
                    Console.WriteLine("The scripture is fully hidden!");
                    Console.Write("\nDo you want to try again? y or n: ");
                    string responce = Console.ReadLine().ToLower(); 
                
                
                    if (responce == "n")
                    {
                        continueProgram = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                    else if (responce == "y")
                    {
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
                    string input = Console.ReadLine()?.ToLower();
                    if (input == "quit")
                    {
                        Console.WriteLine("Goodbye!");
                        continueProgram = false;
                        break;
                    }

                    selectedScripture.HideRandomWords(3);
                }   
                    
            }  

        }


    }
}