class Program
{
    public static void PassByReference(ref int z)
    {
        z += 102;
        Console.WriteLine($"In PassByReference {z}");
    }

    public static void PassByOut(out int a)
    {
        a = 1101;
        // Console.Write("he");
    }
    public static void PassByValue(int z)
    {
        z += 102;
        Console.WriteLine($"In PassByValue {z}");
    }
    public static void Main(string[] args)
    {


        int x = 10;
        int y = x;
        // x++;
        // Console.WriteLine(x);
        // Console.WriteLine(y);


        // int[] data = [1, 2, 3, 4];
        // int[] data2 = data;

        // data[0] += 100;
        // Console.WriteLine(data2[0]);

        PassByValue(x);
        Console.WriteLine($"In main {x}");

        PassByReference(ref x);
        Console.WriteLine($"In main {x}");

        int d;
        PassByOut(out d);
        Console.WriteLine(d);

        int[] data = [1, 2, 3, 4];
        PassReferenceTypeByValue(data);
        Console.WriteLine(data[0]);

    }
}