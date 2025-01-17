 
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
        Console.WriteLine("\n=== All Entries ===");
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet.");
        }
        else
        {
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }
    }


    public void SaveToFile(string file)
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                sw.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            using (StreamReader sr = new StreamReader(file))
            {
                //Clear existing entries
                _entries.Clear();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] entryParts = line.Split('|');
                    if (entryParts.Length == 3)
                    {
                        _entries.Add(new Entry(entryParts[0], entryParts[1], entryParts[2]));
                    }
                }
            }
        }
    }

    
}