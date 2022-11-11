namespace Figures.Tests;

public class CircleTests
{
    [Test]
    [TestCase(1, 1 * 1 * Math.PI)]
    [TestCase(2, 2 * 2 * Math.PI)]
    [TestCase(331, 331 * 331 * Math.PI)]
    [TestCase(2567, 2567 * 2567 * Math.PI)]
    [TestCase(25677, 25677 * 25677 * Math.PI)]
    public void GetArea_CountsProperly(double radius, double expected)
    {
        var circle = new Circle(radius);
        var actual = circle.GetArea();
        Assert.That(actual, Is.EqualTo(expected).Within(double.Epsilon));
    }
    
    [Test]
    [TestCase(1, 1 * 1 * Math.PI)]
    [TestCase(2, 2 * 2 * Math.PI)]
    [TestCase(331, 331 * 331 * Math.PI)]
    [TestCase(2567, 2567 * 2567 * Math.PI)]
    [TestCase(25677, 25677 * 25677 * Math.PI)]
    public void Static_GetArea_CountsProperly(double radius, double expected)
    {
        var actual = Circle.GetArea(radius);
        Assert.That(actual, Is.EqualTo(expected).Within(double.Epsilon));
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
        Assert.Throws<ArgumentException>(() => Circle.GetArea(radius));
    }
}
