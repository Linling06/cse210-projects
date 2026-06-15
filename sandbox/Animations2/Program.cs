class Program
{
    public static void Main(string[] args)
    {
        int sleepTime = 500;

        Console.Clear();
        Console.CursorVisible = false;
        // for (int i = 0; i < 20; i++)
        // {
        //     Console.Write("+");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        //     Console.Write("-");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        // }

        // string animationString = "-\\-|/";
        // DateTime now = DateTime.Now;
        // DateTime endTime = now.AddSeconds(10);
        // // int index = 0;
        // // for (int i = 0; i < 20; i++)
        // int index = 0;
        // while(DateTime.Now < endTime)
        // {
        //     Console.Write(animationString[index++ % animationString.Length]);
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        // }

        int count = 15;
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(count);
        // int index = 0;
        // for (int i = 0; i < 20; i++)
        // Console.WriteLine("" + now.ToString(""));
        while (DateTime.Now < endTime)
        // while(count >= 0)
        {
            Console.Write($"{count--,2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        // Console.WriteLine("" + now.ToString(""));


        Console.CursorVisible = true;
    }
}
