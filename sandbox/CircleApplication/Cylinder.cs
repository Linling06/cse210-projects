class Cylinder
{
    public Circle _circle;

    public double _height;

    public double GetCylinderVolume()
    {
        return _circle.GetArea() * _height;
    }
}