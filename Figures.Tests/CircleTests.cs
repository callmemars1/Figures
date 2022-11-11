namespace Figures.Tests;

public class CircleTests
{
    // MSDN - double has a precision of 15-16 digits
    private const double Epsilon = 1e-15;
    
    [Test]
    [TestCase(1, 1 * 1 * Math.PI)]
    [TestCase(2, 2 * 2 * Math.PI)]
    [TestCase(331, 331 * 331 * Math.PI)]
    [TestCase(2567, 2567 * 2567 * Math.PI)]
    public void GetArea_CountsProperly(double radius, double expected)
    {
        var circle = new Circle(radius);
        var actual = circle.GetArea();
        Assert.That(actual, Is.EqualTo(expected).Within(Epsilon));
    }
    
    [Test]
    [TestCase(1, 1 * 1 * Math.PI)]
    [TestCase(2, 2 * 2 * Math.PI)]
    [TestCase(331, 331 * 331 * Math.PI)]
    [TestCase(2567, 2567 * 2567 * Math.PI)]
    public void Static_GetArea_CountsProperly(double radius, double expected)
    {
        var actual = Circle.GetArea(radius);
        Assert.That(actual, Is.EqualTo(expected).Within(Epsilon));
    }
    
    [Test]
    [TestCase(-1)]
    [TestCase(-100)]
    [TestCase(double.NegativeInfinity)]
    [TestCase(double.NegativeZero)]
    [TestCase(double.NaN)]
    [TestCase(0)]
    public void Constructor_RadiusCantBeNegativeOrZeroOrNaN(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
    
    [Test]
    [TestCase(-1)]
    [TestCase(-100)]
    [TestCase(double.NegativeInfinity)]
    [TestCase(double.NegativeZero)]
    [TestCase(double.NaN)]
    [TestCase(0)]
    public void Static_GetArea_RadiusCantBeNegativeOrZeroOrNaN(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
}
