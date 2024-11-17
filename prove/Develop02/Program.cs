using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option (1-5): ");
            
            string input = Console.ReadLine();
            
            switch (input)
            {
                case "1": // Write
                    WriteEntry(journal, promptGenerator);
                    break;

                case "2": // Display
                    journal.DisplayAll();
                    Console.WriteLine("Press Enter to return to menu.");
                    Console.ReadLine();
                    break;

                case "3": // Load
                    Console.Write("Enter the filename to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    Console.WriteLine("Journal loaded. Press Enter to return to menu.");
                    Console.ReadLine();
                    break;

                case "4": // Save
                    Console.Write("Enter the filename to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    Console.WriteLine("Journal saved. Press Enter to return to menu.");
                    Console.ReadLine();
                    break;

                case "5": // Quit
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    static void WriteEntry(Journal journal, PromptGenerator promptGenerator)
    {
        Console.WriteLine("New Entry:");

        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine("Prompt: " + prompt);

        Console.Write("Your response: ");
        string entryText = Console.ReadLine();

        Entry newEntry = new Entry
        {
            _date = DateTime.Now.ToString("yyyy-MM-dd"),
            _promptText = prompt,
            _entryText = entryText
        };
        journal.AddEntry(newEntry);

        Console.WriteLine("Entry added! Press Enter to return to menu.");
        Console.ReadLine();
    }
}