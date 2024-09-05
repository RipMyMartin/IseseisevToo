using System;

class Triangle
{
    public double A { get; }
    public double B { get; }
    public double C { get; }

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double GetPerimeter()
    {
        return A + B + C;
    }

    public double GetArea()
    {
        double s = GetPerimeter() / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }
}

class TriangleAnalyzer
{
    public static Triangle FindMaxPerimeterTriangle(Triangle[] triangles)
    {
        Triangle maxPerimeterTriangle = triangles[0];
        foreach (var triangle in triangles)
        {
            if (triangle.GetPerimeter() > maxPerimeterTriangle.GetPerimeter())
            {
                maxPerimeterTriangle = triangle;
            }
        }
        return maxPerimeterTriangle;
    }

    public static Triangle FindMaxAreaTriangle(Triangle[] triangles)
    {
        Triangle maxAreaTriangle = triangles[0];
        foreach (var triangle in triangles)
        {
            if (triangle.GetArea() > maxAreaTriangle.GetArea())
            {
                maxAreaTriangle = triangle;
            }
        }
        return maxAreaTriangle;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Три треугольника
        Triangle[] triangles = {
            new Triangle(3, 4, 5),
            new Triangle(6, 8, 10),
            new Triangle(7, 24, 25)
        };

        Triangle maxPerimeterTriangle = TriangleAnalyzer.FindMaxPerimeterTriangle(triangles);
        Triangle maxAreaTriangle = TriangleAnalyzer.FindMaxAreaTriangle(triangles);

        Console.WriteLine($"Треугольник с наибольшим периметром: {maxPerimeterTriangle.GetPerimeter()}");
        Console.WriteLine($"Треугольник с наибольшей площадью: {maxAreaTriangle.GetArea()}");

        if (maxPerimeterTriangle == maxAreaTriangle)
        {
            Console.WriteLine("Треугольник с наибольшим периметром и площадью — это один и тот же треугольник.");
        }
        else
        {
            Console.WriteLine("Треугольники с наибольшим периметром и площадью разные.");
        }
    }
}
