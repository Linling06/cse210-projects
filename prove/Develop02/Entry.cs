class Entry
{
    public DateTime DateTime { get; set; } = DateTime.Now;
    public string Prompt { get; set; }
    public string Answer { get; set; }
    public Entry() {}
    public Entry(string prompt, string answer)
    {
        Prompt = prompt;
        Answer = answer;
    }
    public string DisplayEntry()
    {
        return $"Date: {DateTime.ToShortDateString()} - Prompt: {Prompt}\n{Answer}";
    }
}