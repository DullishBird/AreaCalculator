// See https://aka.ms/new-console-template for more information
using AreaCalculation;

{
    IAreaCalculation circle = new CircleArea();
    double[] r = { 0 };
    Console.WriteLine(circle.GetArea(r));

    IAreaCalculation area = new TriangleArea();
    double[] sides = { 5, 7, 21 };
    Console.WriteLine(area.GetArea(sides));
}

public class RectangleArea : IAreaCalculation
{
    double IAreaCalculation.GetArea(params double[] args)
    {
        if (args.Length < 2)
        {
            throw new ArgumentException("Invalid arguments count for rectangle area calculation.");
        }
        if (args[0] < 0 || args[1] < 0)
        {
            throw new ArgumentException("Rectangle's side length cannot be negative");
        }
        return args[0] * args[1];
    }
}





// 1. Вычисление площади фигуры без знания типа фигуры в compile-time // черная магия 
// 2. Юнит-тесты // расширить, привести в порядок, заменить ошибки на Exceptions //Done 
// 3. Проверку на то, является ли треугольник прямоугольным  // Done





