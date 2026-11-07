using System;
using System.Collections.Generic;

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
}

internal class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry
        {
            Date = DateTime.Now.ToShortDateString(),
            PromptText = "What was the best part of your day?",
            Content = "I visited my childhood friend who I hadn't seen in years."
        };

        theJournal.AddEntry(anEntry);
        theJournal.DisplayAll();
    }
}