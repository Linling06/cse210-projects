class Circle
{
    public double _radius;

     public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

    public double GetCircumference()
    {
        return 2 * Math.PI * _radius;
    }

    public double GetDiameter()
    {
        return _radius * 2;
    }
}