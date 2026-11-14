//using System;
//namespace ScriptureMemorizer
//{
   // class Program
    //{
        //static void Main(string[] args)
        //{
            // Define the reference and scripture text.
            //Reference reference = new Reference("John", 3, 16);
            //string scriptureText = "For God so loved the world that he gave his only begotten son, that whosoever believeth in him should not perish but have everlasting life.";
            //Scripture scripture = new Scripture(reference, scriptureText);
using System;
using System.Collections.Generic;
using System.IO;

namespace ScriptureMemorizer
{
    class Program
    {
        // Define a local file path to store scriptures offline
        private static readonly string FilePath = "scriptures.txt";

        static void Main(string[] args)
        {
            EnsureStorageFileExists();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Offline Scripture Memorizer ===");
                Console.WriteLine("1. Memorize a stored scripture");
                Console.WriteLine("2. Add a new scripture to offline storage");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine()?.Trim();

                if (choice == "1")
                {
                    RunMemorizerFlow();
                }
                else if (choice == "2")
                {
                    RunAddScriptureFlow();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Press Enter to try again.");
                    Console.ReadLine();
                }
            }
        }

        private static void EnsureStorageFileExists()
        {
            if (!File.Exists(FilePath))
            {
                // Create a default file with a sample verse if it doesn't exist yet
                using (StreamWriter sw = File.CreateText(FilePath))
                {
                    sw.WriteLine("John|3|16|For God so loved the world that he gave his only begotten son, that whosoever believeth in him should not perish but have everlasting life.");
                }
            }
        }

        private static void RunAddScriptureFlow()
        {
            Console.Clear();
            Console.WriteLine("=== Add New Scripture ===");
            
            Console.Write("Enter Book (e.g., Proverbs): ");
            string book = Console.ReadLine()?.Trim();

            Console.Write("Enter Chapter: ");
            string chapter = Console.ReadLine()?.Trim();

            Console.Write("Enter Verse: ");
            string verse = Console.ReadLine()?.Trim();

            Console.Write("Enter Text: ");
            string text = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(book) || string.IsNullOrEmpty(chapter) || string.IsNullOrEmpty(verse) || string.IsNullOrEmpty(text))
            {
                Console.WriteLine("\nAll fields are required! Press Enter to return.");
                Console.ReadLine();
                return;
            }

            // Append to the local text file using a pipe | delimiter
            string line = $"{book}|{chapter}|{verse}|{text}";
            File.AppendAllLines(FilePath, new[] { line });

            Console.WriteLine("\nScripture saved successfully offline! Press Enter to return.");
            Console.ReadLine();
        }

        private static void RunMemorizerFlow()
        {
            Console.Clear();
            Console.WriteLine("=== Select a Scripture ===");

            string[] lines = File.ReadAllLines(FilePath);
            if (lines.Length == 0)
            {
                Console.WriteLine("No scriptures found. Please add one first! Press Enter to return.");
                Console.ReadLine();
                return;
            }

            // Display all saved verses
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                if (parts.Length >= 4)
                {
                    Console.WriteLine($"{i + 1}. {parts[0]} {parts[1]}:{parts[2]}");
                }
            }

            Console.Write("Enter the number of the scripture to memorize: ");
            if (!int.TryParse(Console.ReadLine(), out int selection) || selection < 1 || selection > lines.Length)
            {
                Console.WriteLine("Invalid selection. Press Enter to return.");
                Console.ReadLine();
                return;
            }

            // Parse the selected verse
            string[] selectedParts = lines[selection - 1].Split('|');
            string book = selectedParts[0];
            int chapter = int.Parse(selectedParts[1]);
            int verse = int.Parse(selectedParts[2]);
            string scriptureText = selectedParts[3];

            // Initialize objects
            Reference reference = new Reference(book, chapter, verse);
            Scripture scripture = new Scripture(reference, scriptureText);



            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Scripture Memorizer!");
                Console.WriteLine();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();

                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("All words are hidden! You have successfully memorised the scripture.");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Press Enter to hide more words or type quit to exit.");
                }
                Console.WriteLine("Press Enter to hide more words or type \"quit\" to exit.");
                string input = Console.ReadLine()?.Trim().ToLower();
                if (input == "quit")
                {
                    break;
                }
                // Hide 3 random words each time the user presses Enter.
                scripture.HideRandomWords(3);
            }
        }
    }
}