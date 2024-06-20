using AreaCalculationLibrary.Shapes.Triangles;

namespace AreaCalculationTest;

public class TriangleTests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void AreaTest1()
    {
        var triangle = new Triangle([3, 4, 5]);
        
        const float expectedArea = 6f; 
        
        Assert.That(triangle.CalculateArea(), Is.EqualTo(expectedArea));
    }

    [Test]
    public void AreaTest2()
    {
        var triangle = new Triangle([0, 0, 0]);
        
        const float expectedArea = 0f;
        
        Assert.That(triangle.CalculateArea(), Is.EqualTo(expectedArea));
    }

    
    [Test]
    public void WrongSideLengthCount()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var triangle = new Triangle([10, 5]);
        });
    }

    [Test]
    public void RightAngledCheckTest1()
    {
        var triangle = new Triangle([3, 4, 5]);

        var isRightAngled = triangle.CheckRightAngled();
        var isRightAngledExpected = true;
        
        Assert.That(isRightAngled, Is.EqualTo(isRightAngledExpected));
    }

    [Test]
    public void RightAngledCheckTest2()
    {
        var triangle = new Triangle([1, 2, 3]);
        
        var isRightAngled = triangle.CheckRightAngled();
        var isRightAngledExpected = false;
        
        Assert.That(isRightAngled, Is.EqualTo(isRightAngledExpected));
    }
}