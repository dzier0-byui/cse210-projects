using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string fileName)
    {
        if (Path.GetExtension(fileName).ToLower() != ".csv")
        {
            fileName = Path.ChangeExtension(fileName, ".csv");
        }

        if (File.Exists(fileName))
        {
            Console.WriteLine($"The file '{fileName}' already exists. Do you want to overwrite it? (y/n)");

            string userInput = Console.ReadLine().ToLower();

            if (userInput != "y")
            {
                Console.WriteLine("Save operation canceled.");
                return;
            }
        }

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                string date = "\"" + entry._date.Replace("\"", "\"\"") + "\"";
                string prompt = "\"" + entry._promptText.Replace("\"", "\"\"") + "\"";
                string entryText = "\"" + entry._entryText.Replace("\"", "\"\"") + "\"";

                writer.WriteLine($"{date},{prompt},{entryText}");
            }
        }

        Console.WriteLine($"File '{fileName}' has been saved.");
    }
    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            _entries.Clear();

            try
            {
                foreach (var line in File.ReadLines(fileName))
                {
                    string[] parts = ParseCsvLine(line);

                    if (parts.Length == 3)
                    {
                        _entries.Add(new Entry
                        {
                            _date = parts[0],
                            _promptText = parts[1],
                            _entryText = parts[2]
                        });
                    }
                    else
                    {
                        Console.WriteLine("Warning: Malformed line in file, skipping.");
                    }
                }

                Console.WriteLine("Journal entries loaded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading the file: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine($"File '{fileName}' not found.");
        }
    }

    private string[] ParseCsvLine(string line)
    {
        var result = new List<string>();
        bool insideQuotes = false;
        string currentField = string.Empty;

        for (int i = 0; i < line.Length; i++)
        {
            char currentChar = line[i];

            if (currentChar == '"' && (i + 1 < line.Length && line[i + 1] == '"'))
            {
                currentField += '"';
                i++;
            }
            else if (currentChar == '"')
            {
                insideQuotes = !insideQuotes; 
            }
            else if (currentChar == ',' && !insideQuotes)
            {
                result.Add(currentField);
                currentField = string.Empty; 
            }
            else
            {
                currentField += currentChar;
            }
        }

        result.Add(currentField);
        return result.ToArray();
    }
}