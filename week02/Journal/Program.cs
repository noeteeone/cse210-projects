using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string Content { get; set; }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Content: {Content}");
    }
}

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (var entry in entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        for (int i = 0; i + 2 < lines.Length; i += 3)
        {
            entries.Add(new Entry
            {
                Date = lines[i],
                PromptText = lines[i + 1],
                Content = lines[i + 2]
            });
        }
    }

    public void SaveToFile(string filename)
    {
        List<string> lines = new List<string>();
        foreach (var entry in entries)
        {
            lines.Add(entry.Date);
            lines.Add(entry.PromptText);
            lines.Add(entry.Content);
        }

        File.WriteAllLines(filename, lines);
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        List<string> prompts = new List<string>
        {
            "What was the best part of my day?",
            "What was the strongest emotion I felt today?",
            "How did I see the hand of the Lord in my life today?",
            "If I had one thing I could do over today, what would it be?",
            "What challenge did I face today and how did I overcome it?",
            "What is the one thing or person that you really misssed today?",
            "What do I regret doing today and how do I intend to undo it?",
            "What Bible verse uplifted your spirit today?"
        };
        Random random = new Random();

        bool running = true;
        while (running)
        {
            Console.WriteLine("=============== MENU ===============");
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1.   Write a new entry");
            Console.WriteLine("2.   Display the Journal");
            Console.WriteLine("3.   Load Journal from file");
            Console.WriteLine("4.   Save Journal to file");
            Console.WriteLine("5.   Quit");
            Console.Write("What would you like to do?");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    string prompt = prompts[random.Next(prompts.Count)];
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write(">");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();

                    theJournal.AddEntry(new Entry
                    {
                        PromptText = prompt,
                        Content = response,
                        Date = date
                    });
                    break;

                case "2":
                    theJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter the filename to load (e.g journal.txt): ");
                    string loadFile = Console.ReadLine();
                    theJournal.LoadFromFile(loadFile);
                    break;

                case "4":
                    Console.Write("Enter the filename to save to (e.g, journal.txt) : ");
                    string saveFile = Console.ReadLine();
                    theJournal.SaveToFile(saveFile);
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose between 1 and 5.");
                    break;
            }
        }
    }
}