using System.Runtime.CompilerServices;

class Angle
{
    private double _radians;

    public Angle()
    {
        _radians = 0;
    }

    public Angle(double radians)
    {
        SetRadians(radians);
    }

    public Angle(int degrees)
    {
        _radians = ToRadians(degrees);
    }

    public double GetRadians()
    {
        return _radians;
    }

    public void SetGegrees(double degrees)
    {
        _radians = ToRadians(degrees);
    }
    public void SetRadians(double radians)
    {
        if (radians < 0)
        {
            Console.WriteLine("Invalid data");
            _radians = 0;
        } 
        else
        {
            _radians = radians;
        }
    }

    private double ToRadians(double degrees)
    {
        return degrees / 180.0 * Math.PI;
    }
}