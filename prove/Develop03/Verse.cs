public class Verse
{
    // List to hold multiple words
    private List<Word> Words;

    // Constructor to initialize the verse with text
    public Verse(string text)
    {
        Words = new List<Word>();
        foreach (var wordText in text.Split())
        {
            Words.Add(new Word(wordText));
        }
    }

    // Method to hide a random visible word in the verse
    public void HideWord()
    {
        var visibleWords = Words.Where(word => !word.IsHidden()).ToList();
        if (visibleWords.Any())
        {
            var wordToHide = visibleWords[new Random().Next(visibleWords.Count)];
            wordToHide.HideWord();
        }
    }

    // Method to check if all words in the verse are hidden
    public bool IsFinished()
    {
        return Words.All(word => word.IsHidden());
    }

    // Method to display the current state of the verse
    public string Display()
    {
        return string.Join(" ", Words.Select(word => word.Display()));
    }
}
