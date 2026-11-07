namespace BYU.CSE210.Week02.Journal
{
    public class Entry
    {
        public string _date;
        public string _promptText;
        public string _entryText;
        public void Display()
        {
            // Display the entry details
            Console.WriteLine("Date: " + _date);
            Console.WriteLine("Prompt: " + _promptText);
            Console.WriteLine("Entry: " + _entryText);
        }
    }
}