class Program
{
    public static void Main(string[] args)
    {
        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine(myCircle.GetArea());

        myCircle._radius = 20;
        Console.WriteLine(myCircle._radius);
        Console.WriteLine(myCircle.GetArea());

        Circle myCircle2 = new Circle();
        myCircle2._radius = 30;
        Console.WriteLine(myCircle2.GetArea());


        Cylinder myCylinder = new Cylinder();
        myCylinder._circle = new Circle();
        myCylinder._circle._radius = 10;
        myCylinder._height = 30;
        Console.WriteLine(myCylinder.GetCylinderVolume());
    }
}
