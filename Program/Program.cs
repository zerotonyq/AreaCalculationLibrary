using AreaCalculationLibrary.Services;
using AreaCalculationLibrary.Shapes.Triangles;
using AreaCalculationTest;

dynamic triangle = new Triangle([3, 4, 5]);

Console.WriteLine("triangle area is " + Calculator.CalculateArea(triangle));

Console.WriteLine("is triangle right angled? " + (triangle as Triangle)!.CheckRightAngled());
