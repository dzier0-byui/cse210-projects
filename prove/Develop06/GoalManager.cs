public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager() { }

    public void Start()
    {
        Console.WriteLine("Welcome to the Goal Tracking Program!");
        List<Goal> goals = new List<Goal>();

        while (true)
        {
            Console.Clear();
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
                    CreateGoal(goals);
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please select a valid option.");
                    continue;
            }
        }
    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetials()
    {

    }

    public void CreateGoal(List<Goal> goals)
    {
        Console.WriteLine("\nThe Types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string input = Console.ReadLine();
        string name = "";
        string description = "";
        int points = 0;

        if (input == "1" || input == "2" || input == "3") 
        {
            Console.WriteLine("\nWhat is the name of your goal? ");
            name = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            description = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("How many points is this goal worth? ");
                string stringPoints = Console.ReadLine();

                if (int.TryParse(stringPoints, out int intPoints))
                {
                    points = intPoints;
                    break;
                }
                else {
                    Console.WriteLine("\nInvalid input. Enter a number.");
                }
            }
        } 

        switch (input)
        {
            case "1":
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                goals.Add(simpleGoal);
                break;
            case "2":
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                goals.Add(eternalGoal);
                break;
            case "3":
                int target = 0;
                int bonusPoints = 0;
                while (true)
                {
                    Console.WriteLine("How many times do you want to complete this goal? ");
                    string stringTarget = Console.ReadLine();

                    if (int.TryParse(stringTarget, out int intTarget))
                    {
                        target = intTarget;
                        break;
                    }
                    else {
                        Console.WriteLine("\nInvalid input. Enter a number.");
                    }
                }

                while (true)
                {
                    Console.WriteLine("How many bonus point will you receive when completing this goal? ");
                    string stringBonus = Console.ReadLine();

                    if (int.TryParse(stringBonus, out int intBonus))
                    {
                        bonusPoints = intBonus;
                        break;
                    }
                    else {
                        Console.WriteLine("\nInvalid input. Enter a number.");
                    }
                }

                CheckListGoal checkListGoal = new CheckListGoal(name, description, points, target, bonusPoints);
                goals.Add(checkListGoal);
                break;
            default:
                Console.WriteLine("\nInvalid choice.");
                break;
        }
    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {
        
    }


}