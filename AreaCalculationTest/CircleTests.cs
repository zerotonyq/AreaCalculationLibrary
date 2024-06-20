using AreaCalculationLibrary.Shapes.Circles;

namespace AreaCalculationTest;

public class CircleTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AreaTest1()
    {
        var circle = new Circle(10);

        var area = circle.CalculateArea();
        var expectedArea = 100 * Single.Pi;

        Assert.That(area, Is.EqualTo(expectedArea));
    }

    [Test]
    public void AreaTest2()
    {
        var circle = new Circle(0);

        var area = circle.CalculateArea();
        var expectedArea = 0f;

        Assert.That(area, Is.EqualTo(expectedArea));
    }

    [Test]
    public void WrongRadius()
    {
        Assert.Throws<ArgumentException>
        (
            () =>
            {
                var circle = new Circle(-1);
            }
        );
    }
}