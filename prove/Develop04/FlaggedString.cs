class FlaggedString
{
    private string _prompt;
    private bool _hasBeenUsed;

    public FlaggedString(string prompt, bool hasBeenUsed)
    {
        _prompt = prompt;
        _hasBeenUsed = hasBeenUsed;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public void SetHasBeenUsed()
    {
        _hasBeenUsed = true;
    }

    public void ResetHasBeenUsed()
    {
        _hasBeenUsed = false;
    }

    public bool GetHasBeenUsed()
    {
        return _hasBeenUsed;
    }
}