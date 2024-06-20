using AreaCalculationLibrary.Services;
using AreaCalculationLibrary.Shapes.Circles;
using AreaCalculationLibrary.Shapes.Triangles;

namespace AreaCalculationTest;

public class CalculatorTests
{
    [SetUp]
    public void Setup(){}

    [Test]
    public void CalculatorAreaTestTriangle()
    {
        dynamic triangle = new Triangle([3, 4, 5]);

        float area = Calculator.CalculateArea(triangle);
        float expectedArea = 6;
        
        Assert.That(area, Is.EqualTo(expectedArea));
    }
    
    [Test]
    public void CalculatorAreaTestCircle()
    {
        dynamic triangle = new Circle(10);

        float area = Calculator.CalculateArea(triangle);
        float expectedArea = 100 * Single.Pi;
        
        Assert.That(area, Is.EqualTo(expectedArea));
    }
}