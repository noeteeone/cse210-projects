using System;
namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the reference and scripture text.
            Reference reference = new Reference("John", 3, 16);
            string scriptureText = "For God so loved the world that he gave his only begotten son, that whosoever believeth in him should not perish but have everlasting life.";
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
                    break;
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