using AreaCalculationLibrary.Shapes.Base;

namespace AreaCalculationLibrary.Services;

public static class Calculator
{
    public static float CalculateArea(IShape shape) => shape.CalculateArea();
}