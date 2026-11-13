using System;
using System.Collections.Generic;
using System.Linq;
namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the reference and scripture text.
            Reference reference = new Reference("John", 3, 16);
            string scriptureText = "For God so loved the world that he gave his only begotten son, that whosoever believeth in him should not perish but have everlasting life.";
            var words = scriptureText
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(word => new Word(word.Trim()))
                .ToList();
            Scripture scripture = new Scripture(reference, words);
            var hiddenWords = new HashSet<Word>();
            var random = new Random();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Scripture Memorizer!");
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();

                if (hiddenWords.Count == words.Count)
                {
                    Console.WriteLine("All words are hidden! You have successfully memorised the scripture.");
                    break;
                }

                Console.WriteLine("Press Enter to hide more words or type \"quit\" to exit.");
                string input = Console.ReadLine()?.Trim().ToLower();
                if (input == "quit")
                {
                    break;
                }
                //Hide 3 random words from the scripture each time the user presses enter, until all words are hidden.
                foreach (Word word in words
                    .Where(word => !hiddenWords.Contains(word))
                    .OrderBy(_ => random.Next())
                    .Take(3))
                {
                    word.Hide();
                    hiddenWords.Add(word);
                }
            }
        }
    }
}