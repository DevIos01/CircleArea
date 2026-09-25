namespace CircleArea;

class Program
{
    static void Main(string[] args)
    {
        // Create two circles with different radius
        Circle smallCircle = new Circle(5);
        Circle bigCircle = new Circle(6);

        // Print the area of each circle with two decimals
        Console.WriteLine($"Arean på en cirkel med radie 5 är {smallCircle.GetArea():F2}");
        Console.WriteLine($"Arean på en cirkel med radie 6 är {bigCircle.GetArea():F2}");

        // Print the circumference of each circle
        Console.WriteLine($"Omkretsen på en cirkel med radie 5 är {smallCircle.GetCircumference():F2}");
        Console.WriteLine($"Omkretsen på en cirkel med radie 6 är {bigCircle.GetCircumference():F2}");
    }
}
