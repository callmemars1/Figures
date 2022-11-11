namespace Figures.Tests;

public class TriangleTests
{
    [Test]
    [TestCase(3, 4, 5, 6)]
    [TestCase(5, 12, 13, 30)]
    [TestCase(8, 15, 17, 60)]
    public void GetArea_CountsProperly(double a, double b, double c, double expected)
    {
        var triangle = new Triangle(a, b, c);
        var actual = triangle.GetArea();
        Assert.AreEqual(expected, actual);
    }

    [Test]
    [TestCase(3, 4, 5, 6)]
    [TestCase(5, 12, 13, 30)]
    [TestCase(8, 15, 17, 60)]
    public void Static_GetArea_CountsProperly(double a, double b, double c, double expected)
    {
        var actual = Triangle.GetArea(a, b, c);
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    [TestCase(3, 4, 5, true)]
    [TestCase(300, 400, 500, true)]
    [TestCase(300, 400, 501, false)]
    [TestCase(1, 1, 1, false)]
    [TestCase(5, 3, 4, true)]
    [TestCase(10, 8, 6, true)]
    public void IsRight_CountsProperly(double a, double b, double c, bool expected)
    {
        var triangle = new Triangle(a, b, c);
        var actual = triangle.IsRight();
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    [TestCase(3, 4, 5, true)]
    [TestCase(300, 400, 500, true)]
    [TestCase(300, 400, 501, false)]
    [TestCase(1, 1, 1, false)]
    [TestCase(5, 3, 4, true)]
    [TestCase(10, 8, 6, true)]
    public void Static_IsRight_CountsProperly(double a, double b, double c, bool expected)
    {
        var actual = Triangle.IsRight(a, b, c);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    [TestCase(1, 4, 5)]
    [TestCase(0, 4, 5)]
    [TestCase(1, 1, 10)]
    [TestCase(1, 1, double.NaN)]
    [TestCase(1, 1,  -350)]
    [TestCase(1, 1,  double.NegativeZero)]
    [TestCase(1, 1,  double.PositiveInfinity)]
    public void Static_GetArea_IsValidTriangle(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => Triangle.GetArea(a, b, c));
    }
    
    [Test]
    [TestCase(1, 4, 5)]
    [TestCase(0, 4, 5)]
    [TestCase(1, 1, 10)]
    [TestCase(1, 1, double.NaN)]
    [TestCase(1, 1,  -350)]
    [TestCase(1, 1,  double.NegativeZero)]
    [TestCase(1, 1,  double.PositiveInfinity)]
    public void Static_IsRight_IsValidTriangle(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => Triangle.IsRight(a, b, c));
    }
    
    [Test]
    [TestCase(1, 4, 5)]
    [TestCase(0, 4, 5)]
    [TestCase(1, 1, 10)]
    [TestCase(1, 1, double.NaN)]
    [TestCase(1, 1,  -350)]
    [TestCase(1, 1,  double.NegativeZero)]
    [TestCase(1, 1,  double.PositiveInfinity)]
    public void Constructor_IsValidTriangle(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
}