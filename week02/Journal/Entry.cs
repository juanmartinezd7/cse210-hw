
public class Entry
{
    
    public string Date {get;}
    public string PromptText {get;}
    public string EntryText {get;}


    public Entry(string _promptText, string _entryText)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        PromptText = _promptText;
        EntryText = _entryText;
    }
    public Entry(string date, string _promptText, string _entryText)
    {
        Date = date;
        PromptText = _promptText;
        EntryText = _entryText;
    }


    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Entry: {EntryText}");
        Console.WriteLine();
    }

    public override string ToString()
    {
        return $"{Date}|{PromptText}|{EntryText}";
    }
}