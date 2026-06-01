class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] wordList = scriptureText.Split(" ");

        foreach (string word in wordList)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetScriptureString()
    {
        string displayText = _reference.GetReferenceString() + " ";

        foreach (Word word in _words)
        {
            displayText += word.GetWordString() + " ";
        }

        return displayText;
    }

    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;

        while (hiddenCount < numberToHide && !IsCompletelyHidden())
        {
            int index = _random.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}