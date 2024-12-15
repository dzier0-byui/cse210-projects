public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager() 
    { 
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        LoadGoals();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Goal Tracking Program!");
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();
            System.Console.Clear();

            if (input == "5")
            {
                Console.WriteLine("\nThank you for using the Goal Tracking program. Goodbye!");
                break;
            }

            switch (input)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetials();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    RecordEvent();
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please select a valid option.");
                    continue;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nCurrent Score: {_score}");
    }

    public void ListGoalNames()
    {
        Console.Clear();
        Console.WriteLine("Your goals are:\n");
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetials()
    {
        Console.Clear();
        Console.WriteLine("Your goals are:\n");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        
        DisplayPlayerInfo();
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nThe Types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        bool validChoice = false;
        while (validChoice == false)
        {
            Console.Write("Which type of goal would you like to create? ");

            string input = Console.ReadLine();
            string name = "";
            string description = "";
            int points = 0;

            if (input == "1" || input == "2" || input == "3") 
            {
                Console.Write("\nWhat is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();
                bool valid = false;
                while (valid == false)
                {
                    Console.Write("How many points is this goal worth? ");
                    string stringPoints = Console.ReadLine();

                    if (int.TryParse(stringPoints, out int intPoints))
                    {
                        points = intPoints;
                        valid = true;
                    }
                    else {
                        Console.WriteLine("\nInvalid input. Enter a number.");
                    }
                }
            } 

            switch (input)
            {
                case "1":
                    validChoice = true;
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    _goals.Add(simpleGoal);
                    break;
                case "2":
                    validChoice = true;
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                    break;
                case "3":
                    validChoice = true;
                    int target = 0;
                    int bonusPoints = 0;
                    bool valid1 = false;
                    while (valid1 == false)
                    {
                        Console.Write("How many times do you want to complete this goal? ");
                        string stringTarget = Console.ReadLine();

                        if (int.TryParse(stringTarget, out int intTarget))
                        {
                            target = intTarget;
                            valid1 = true;
                        }
                        else {
                            Console.Write("\nInvalid input. Enter a number.");
                        }
                    }
                    
                    bool valid = false;
                    while (valid == false)
                    {
                        Console.Write("How many bonus point will you receive when completing this goal? ");
                        string stringBonus = Console.ReadLine();

                        if (int.TryParse(stringBonus, out int intBonus))
                        {
                            bonusPoints = intBonus;
                            valid = true;
                        }
                        else {
                            Console.WriteLine("\nInvalid input. Enter a number.");
                        }
                    }

                    CheckListGoal checkListGoal = new CheckListGoal(name, description, points, target, bonusPoints);
                    _goals.Add(checkListGoal);
                    break;
                default:
                    Console.WriteLine("\nInvalid choice.");
                    break;
            }
            
        }

        Console.WriteLine("Goal added. Press enter to continue...");
        Console.ReadLine();
    }

    public void RecordEvent()
    {
        Console.Clear();
        ListGoalNames();
        int goalNumber = 0;
        bool valid = false;
        while (valid == false)
        {
            Console.Write("Which goal did you accomplish? ");
            string stringGoal = Console.ReadLine();

            if (int.TryParse(stringGoal, out int intGoal))
            {
                if (intGoal > _goals.Count())
                {
                    Console.WriteLine("\nInput too high. Enter a number for one of your goals.");
                }
                else
                {
                    goalNumber = intGoal;
                    valid = true;
                }
            }
            else {
                Console.WriteLine("\nInvalid input. Enter a number.");
            }
        }

        Goal completedGoal = _goals[goalNumber - 1];

        Console.WriteLine($"Congratulations! You have earned {completedGoal.GetPoints()} points");
        int pointsAdded = completedGoal.RecordEvent();
        _score += pointsAdded;

        DisplayPlayerInfo();
    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {
        
    }


}