

using System.Runtime.CompilerServices;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    
    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine($"\nYou have {_score} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select an option from the menu: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": Console.WriteLine("\n****Remember to save your goals!");
                Console.WriteLine("\nAre you sure you want to quit? y or n: ");
                string finish = Console.ReadLine().ToLower(); //Convert input to lowercase.

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
                    running = true;
                }
                break;
                default: Console.WriteLine("Invalid option. Try again."); break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        
        string type;
        while (true) // Keep asking until a valid option is entered
        {
            Console.Write("Which type of goal would you like to create? ");
            type = Console.ReadLine();

            if (type == "1" || type == "2" || type == "3")
                break; // Exit the loop if input is valid

                Console.WriteLine("Please select a valid option (1, 2, or 3).");
        }


        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine();

        int points;
        while (true)
        {
            Console.Write("What is the amount of points associated with this goal? ");
            if (int.TryParse(Console.ReadLine(), out points))
               break; // Exit loop if input is valid

               Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        
        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }

        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }

        else if (type == "3")
        {
            int target;
            while (true)
            {
                Console.Write("How many times does this goal need to be accomplishhed for a bonus? ");
                if (int.TryParse(Console.ReadLine(), out target))
                    break;

                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            int bonus;
            while (true)
            {
                Console.Write("What is the bonus for accomplishing it that many times? ");
                if (int.TryParse(Console.ReadLine(), out bonus))
                   break;

                   Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
        Console.WriteLine("Goal created successfully!");
    }

    private void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }
        Console.WriteLine("The goals are:");
        int index = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
    }

    private void SaveGoals()
    {
        Console.Write("Enter the file name to save goals (default: goals.txt): ");
        string fileName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(fileName)) fileName = "goals.txt"; // Default file

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName, false))
            {
                writer.WriteLine(_score);
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine($"Goals saved successfully to {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    private void LoadGoals()
    {
        Console.Write("Enter the file name to load goals (default: goals.txt): ");
        string fileName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(fileName)) fileName = "goals.txt"; // Default file

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found. No goals loaded.");
            return;
        }
        try
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                _score = int.Parse(reader.ReadLine());

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');

                    if (parts[0] == "SimpleGoal")
                    {
                        bool isCompleted = parts.Length > 4 && bool.TryParse(parts[4], out bool completed) ? completed : false;
                        SimpleGoal goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                        goal.SetCompletion(isCompleted);
                        _goals.Add(goal);
                    }
                    else if (parts[0] == "EternalGoal")
                    {
                        _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    }
                    else if (parts[0] == "ChecklistGoal")
                    {
                        int targetCount = parts.Length > 4 && int.TryParse(parts[4], out int target) ? target : 0;
                        int currentCount = parts.Length > 5 && int.TryParse(parts[5], out int completed) ? completed : 0;
                        int bonusPoints = parts.Length > 6 && int.TryParse(parts[6], out int bonus) ? bonus : 0;

                        ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), targetCount, bonusPoints);
                        goal.SetProgress(currentCount);
                        _goals.Add(goal);
                    }
                }

            }
            Console.WriteLine($"Goals loaded successfully from {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }

    private void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record.");
            return;
        }
        Console.Write("Which goal did you accomplish? ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > _goals.Count)
        {
            Console.WriteLine("Invalid input. Please enter a valid goal number.");
            return;
        }
        
        index -= 1; // Convert to zero-based index
        int previousScore = _score; // Store previous score
        _goals[index].RecordEvent(ref _score); // Record event


        int pointsEarned = _score - previousScore; // Calculate points gained
        if (pointsEarned > 0)
        {
            Console.WriteLine($"Congratulations! You earned {pointsEarned} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
        
    }
}