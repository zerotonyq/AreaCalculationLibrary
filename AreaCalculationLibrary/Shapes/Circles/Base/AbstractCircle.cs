using AreaCalculationLibrary.Shapes.Base;

namespace AreaCalculationLibrary.Shapes.Circles.Base;

public abstract class AbstractCircle : IShape
{
    public float Radius { get; }

    protected AbstractCircle(float radius)
    {
        if (radius < 0)
            throw new ArgumentException("circle radius cannot be less than zero");

        Radius = radius;
    }
    
    public float CalculateArea()
    {
        return Single.Pi * Radius * Radius;
    }
}