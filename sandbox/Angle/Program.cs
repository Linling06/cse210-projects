using System.Globalization;

class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello world");

        Angle myAngle = new Angle();
        myAngle.SetRadians(10);
        Console.WriteLine(myAngle.GetRadians());

        Angle myAngle2 = new Angle(100.234);
        Console.WriteLine(myAngle2.GetRadians());
    }

    
}
