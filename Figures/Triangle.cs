namespace Figures;

public class Triangle : IFigure
{
    private readonly double _aSide;
    private readonly double _bSide;
    private readonly double _cSide;

    public Triangle(double aSide, double bSide, double cSide)
    {
        _aSide = aSide;
        _bSide = bSide;
        _cSide = cSide;
    }

    public double GetArea()
    {
        return GetArea(_aSide, _bSide, _cSide);
    }

    public static double GetArea(double aSide, double bSide, double cSide)
    {
        var halfPerimeter = (aSide + bSide + cSide) / 2;
        return Math.Sqrt((halfPerimeter - aSide) * (halfPerimeter - bSide) * (halfPerimeter - cSide) * halfPerimeter);
    }

    private static void AssertCanBeTriangle(double aSide, double bSide, double cSide)
    {
        if (
            aSide + bSide <= cSide ||
            aSide + cSide <= bSide ||
            bSide + cSide <= aSide
        ) throw new ArgumentException("Can't be a triangle");
    }
    
    private static void AssertNoNegativeOrZeroSides(double aSide, double bSide, double cSide)
    {
        if (aSide <= 0 || bSide <= 0 || cSide <= 0) 
            throw new ArgumentException("Sides can't be negative or zero");
    }

    private static void AssertNoNaNSides(double aSide, double bSide, double cSide)
    {
        if (double.IsNaN(aSide) || double.IsNaN(bSide) || double.IsNaN(cSide)) 
            throw new ArgumentException("Sides can't be NaN");
    }

    private static void AssertNoInfiniteSides(double aSide, double bSide, double cSide)
    {
        if (double.IsInfinity(aSide) || double.IsInfinity(bSide) || double.IsInfinity(cSide)) 
            throw new ArgumentException("Sides can't be infinite");
    }

    private static void ValidateSides(double aSide, double bSide, double cSide)
    {
        AssertNoNegativeOrZeroSides(aSide, bSide, cSide);
        AssertNoNaNSides(aSide, bSide, cSide);
        AssertNoInfiniteSides(aSide, bSide, cSide);
        AssertCanBeTriangle(aSide, bSide, cSide);
    }
}