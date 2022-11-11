namespace Figures;

public class Circle : IFigure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        ValidateRadius(radius);
        _radius = radius;
    }

    public double GetArea()
        => GetArea(_radius);

    public static double GetArea(double radius)
    {
        ValidateRadius(radius);
        return Math.PI * radius * radius;
    }
    
    private static void AssertRadiusGreaterThenZero(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException($"Radius must be greater then zero (passed radius: {radius})");
    }
    
    private static void AssertRadiusNotInfinite(double radius)
    {
        if (double.IsInfinity(radius))
            throw new ArgumentException("Radius cannot be infinite.");
    }
    
    private static void AssertRadiusNotNaN(double radius)
    {
        if (double.IsNaN(radius))
            throw new ArgumentException("Radius cannot be NaN.");
    }
    
    private static void ValidateRadius(double radius)
    {
        AssertRadiusGreaterThenZero(radius);
        AssertRadiusNotInfinite(radius);
        AssertRadiusNotNaN(radius);
    }
}