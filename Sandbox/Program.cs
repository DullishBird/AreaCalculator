// See https://aka.ms/new-console-template for more information
using AreaCalculation;

public class RectangleArea : IAreaCalculation
{
    double IAreaCalculation.GetArea(params double[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Invalid arguments count for rectangle area calculation.");
            return 0.0;
        }
        if (args[0] < 0 || args[1] < 0)
        {
            Console.WriteLine("Rectangl's side length cannot be negative"); //TODO : Must be replaced to Exceptions
            return 0;
        }
        return args[0] * args[1];
    }
}

// 1. Вычисление площади фигуры без знания типа фигуры в compile-time
// 2. Юнит-тесты
// 3. Проверку на то, является ли треугольник прямоугольным





