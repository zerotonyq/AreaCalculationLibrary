using AreaCalculationLibrary.Shapes.Base;

namespace AreaCalculationLibrary.Shapes.Triangles.Base;

public abstract class AbstractTriangle : IShape
{
    public IReadOnlyList<float> SideLengths { get; }

    private const float FloatTolerance = 0.0001f;

    protected AbstractTriangle(List<float> sideLengths)
    {
        if (sideLengths.Count != 3)
            throw new ArgumentException("Wrong count of side lengths");

        SideLengths = sideLengths;
    }

    public virtual float CalculateArea()
    {
        var halfPerimeter = SideLengths.Sum() / 2;

        return float.Sqrt(SideLengths.Aggregate(halfPerimeter, (current, len) => current * (halfPerimeter - len)));
    }

    public bool CheckRightAngled()
    {
        var maxSideLength = SideLengths.Max();

        var squaredSidesSum = SideLengths.Select(l => l * l)
            .Where(l => Math.Abs(l - maxSideLength * maxSideLength) > FloatTolerance).Sum();

        return Math.Abs(maxSideLength * maxSideLength - squaredSidesSum) < FloatTolerance;
    }
}