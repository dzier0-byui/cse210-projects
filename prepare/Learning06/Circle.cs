using System;

public class Cirlce: Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.Pi * _radius * _radius;
    }
}