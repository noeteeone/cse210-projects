namespace Week02.Journal
{
    public class Journal
    {
        public List<Entry> _entries;
        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }
        public void DisplayAll()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("No entries to display.");
                return;
            }
            foreach (Entry entry in _entries)
            {
                string cleanPrompt = entry._promptText.Replace("\n", " ");
                string cleanResponse = entry._entryText.Replace("\n", " ");
                Console.WriteLine($"{entry.Date} - Prompt: {cleanPrompt} - Entry: {cleanResponse}");
            }
        }
        public void SaveToFile(string file)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    foreach (Entry entry in _entries)
                    {
                        writer.WriteLine(entry._date);
                        writer.WriteLine(entry._promptText);
                        writer.WriteLine(entry._entryText);
                    }
                }
                Console.WriteLine($"Journal saved to file: {file} successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving to the file: {ex.Message}"); 
            }
        }
        public void LoadFromFile(string file)
        {
            if (!File.Exists(file))
            {
                Console.WriteLine($"Error: File not found: {file}");
                return;
            }
            try
            {
                _entries.Clear();
                string[] lines = file.ReadAllLines(file);
                foreach (string line in lines)
                {
                    string[] parts = line.Split("\", " ");
                    if (parts.Length == 3)
                    {
                        string date = parts[0];
                        string prompt = parts[1];
                        string entryText = parts[2];
                        Entry entry = new Entry(prompt, entryText, date);
                    }
                }
                Console.WriteLine($"Journal loaded from file: {file} successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading from the file: {ex.Message}");
            }
        }
    }
}