public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
{
    Console.WriteLine("Attempting to save journal to file: " + filename);
    using (StreamWriter sw = new StreamWriter(filename))
    {
        foreach (var entry in entries)
        {
            sw.WriteLine($"{entry.Date}~|~{entry.Prompt}~|~{entry.Response}");
        }
    }
    Console.WriteLine("Journal saved successfully.");
}


    public void LoadFromFile(string filename)
    {
        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[1], parts[2])
                {
                    Date = parts[0]
                };
                entries.Add(entry);
            }
        }
    }
}
