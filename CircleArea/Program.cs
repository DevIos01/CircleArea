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

        // Print the volume if the circles were spheres
        Console.WriteLine($"Volymen på en sfär med radie 5 är {smallCircle.GetSphereVolume():F2}");
        Console.WriteLine($"Volymen på en sfär med radie 6 är {bigCircle.GetSphereVolume():F2}");

        // Create a triangle and print its area and perimeter
        Triangle triangle = new Triangle(6, 4, 5, 5);
        Console.WriteLine($"Arean på en triangel med basen 6 och höjden 4 är {triangle.GetArea():F2}");
        Console.WriteLine($"Omkretsen på en triangel med sidorna 6, 5 och 5 är {triangle.GetPerimeter():F2}");
    }
}
