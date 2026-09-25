namespace CircleArea;

class Triangle
{
    // The base and the height of the triangle
    double _baseLength;
    double _height;

    // Constructor, runs when a new Triangle is created
    public Triangle(double baseLength, double height)
    {
        _baseLength = baseLength;
        _height = height;
    }

    // Returns the area of the triangle (base * height / 2)
    public double GetArea()
    {
        return _baseLength * _height / 2;
    }
}
