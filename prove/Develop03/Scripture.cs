public class Scripture
{
    // List to hold multiple verses
    private List<Verse> Verses;

    // Constructor to initialize the scripture with a reference and text
    public Scripture(string reference, string text)
    {
        Verses = new List<Verse>();
        var verseTexts = text.Split('|');
        foreach (var verseText in verseTexts)
        {
            Verses.Add(new Verse(verseText));
        }
    }

    // Method to hide random words in each verse
    public void HideWords()
    {
        foreach (var verse in Verses)
        {
            verse.HideWord();
        }
    }

    // Method to check if all words in all verses are hidden
    public bool IsFinished()
    {
        return Verses.All(verse => verse.IsFinished());
    }

    // Method to display the current state of the scripture
    public void Display()
    {
        Console.Clear();
        foreach (var verse in Verses)
        {
            Console.WriteLine(verse.Display());
        }
    }
}
