namespace AreaCalculation
{
    public interface IAreaCalculation
    {
        public double GetArea(params double[] list);
    }

    public class TriangleArea : IAreaCalculation
    {
        double IAreaCalculation.GetArea(params double[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Invalid arguments count.");
                return 0.0;
            }

            if (args[0] < 0 || args[1] < 0 || args[2] < 0)
            {
                Console.WriteLine("Triangle's side length cannot be negative"); //TODO : Must be replaced to Exceptions
                return 0;
            }

            double p = (args[0] + args[1] + args[2]) / 2;

            return (double)Math.Sqrt(p * (p - args[0]) * (p - args[1]) * (p - args[2]));
        }
    }

    public class CircleArea : IAreaCalculation
    {
        double IAreaCalculation.GetArea(params double[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Invalid arguments count.");
                return 0.0;
            }

            if (args[0] < 0)
            {
                Console.WriteLine("Radius cannot be negative."); //TODO : Must be replaced to Exceptions
                return 0;
            }

            return (double)(Math.PI * (Math.Pow(args[0], 2)));
        }
    }
}