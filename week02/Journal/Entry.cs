namespace Week02.Journal
{
    public class Entry
    {
        public string _date { get; set; }
        public string _promptText { get; set; }
        public string _entryText { get; set; }
        public Entry(string Prompt, string entryText, string date)
        {
            _promptText = Prompt;
            _entryText = entryText;
            _date = date;
        }
        public void Display()
        {
            // Display the entry details
            Console.WriteLine($"Date: {_date}");
            Console.WriteLine($"Prompt: {_promptText}");
            Console.WriteLine($"Entry: {_entryText}");
        }
    }
}