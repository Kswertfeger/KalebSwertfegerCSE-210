public class Word
{
    private string _word;
    private bool _hidden;

    // Constructor to initialize the word with text
    public Word(string text)
    {
        _word = text;
        _hidden = false;
    }

    // Method to hide the word
    public void HideWord()
    {
        _hidden = true;
    }

    // Method to check if the word is hidden
    public bool IsHidden()
    {
        return _hidden;
    }

    // Method to display the current state of the word
    public string Display()
    {
        return _hidden ? "_____" : _word;
    }
}
