namespace CircleArea;

class Circle
{
    // The radius of the circle
    int _radius;

    // Constructor, runs when a new Circle is created
    public Circle(int radius)
    {
        _radius = radius;
    }

    // Returns the area of the circle (radius * radius * pi)
    public double GetArea()
    {
        return _radius * _radius * Math.PI;
    }

    // Returns the circumference of the circle (2 * pi * radius)
    public double GetCircumference()
    {
        return 2 * Math.PI * _radius;
    }

    // Returns the volume if the circle was a sphere (4/3 * pi * radius^3)
    // 4.0 / 3.0 is used so it is not integer division (4 / 3 would be 1)
    public double GetSphereVolume()
    {
        return 4.0 / 3.0 * Math.PI * _radius * _radius * _radius;
    }
}
