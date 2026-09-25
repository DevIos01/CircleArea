namespace CircleArea;

class Triangle
{
    // The base and the height of the triangle
    double _baseLength;
    double _height;

    // The two other sides, needed for the perimeter
    double _leftSide;
    double _rightSide;

    // Constructor, runs when a new Triangle is created
    public Triangle(double baseLength, double height, double leftSide, double rightSide)
    {
        _baseLength = baseLength;
        _height = height;
        _leftSide = leftSide;
        _rightSide = rightSide;
    }

    // Returns the area of the triangle (base * height / 2)
    public double GetArea()
    {
        return _baseLength * _height / 2;
    }

    // Returns the perimeter of the triangle (all three sides added together)
    public double GetPerimeter()
    {
        return _baseLength + _leftSide + _rightSide;
    }
}
