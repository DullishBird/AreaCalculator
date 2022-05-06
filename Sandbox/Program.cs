// See https://aka.ms/new-console-template for more information
using AreaCalculation;

{
    IAreaCalculation area = new TriangleArea();
    double[] sides = { 4.0 , 5.0 , 6.4031242374328486864882176746218 };
    Console.WriteLine(area.GetArea(sides));
}

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
            Console.WriteLine("Rectangle's side length cannot be negative"); //TODO : Must be replaced to Exceptions
            return 0;
        }
        return args[0] * args[1];
    }
}





// 1. Вычисление площади фигуры без знания типа фигуры в compile-time // черная магия 
// 2. Юнит-тесты // расширить, привести в порядок, заменить ошибки на Exceptions 
// 3. Проверку на то, является ли треугольник прямоугольным  // Done





