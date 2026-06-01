// Word class will contain the word. If the word is hidden, GetWordString
// will return _ characters - one for each character in the word
using System.Reflection.Metadata.Ecma335;

class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    // GetWordString - Return either the word, if not hidden, or the _s
    public string GetWordString()
    {
        string tempWord = "";
        if (_hidden)
        {
            foreach (char c in _word)
            {
                tempWord += '_';
            }
        }
        else
        {
            tempWord = _word;
        }
        return tempWord;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void DisplayWord()
    {
        Console.WriteLine(GetWordString());
    }



}