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
                throw new ArgumentException("Invalid arguments count.");
            }

            if (args.Length > 3)
            {
                throw new ArgumentException("Too many arguments.");
            }

            if (args[0] < 0 || args[1] < 0 || args[2] < 0)
            {
                throw new ArgumentException("Triangle's side length cannot be negative");
            }

            double aPow = Math.Pow(args[0], 2);
            double bPow = Math.Pow(args[1], 2);
            double cPow = Math.Pow(args[2], 2);

            if (aPow + bPow == cPow)
            {
                return GetRightTriangleArea(args[0], args[1]);
            }

            if (aPow + cPow == bPow)
            {
                return GetRightTriangleArea(args[0], args[2]);
            }

            if (bPow + cPow == aPow)
            {
                return GetRightTriangleArea(args[1], args[2]);
            }

            double p = (args[0] + args[1] + args[2]) / 2;

            return (double)Math.Sqrt(p * (p - args[0]) * (p - args[1]) * (p - args[2]));
        }

        private double GetRightTriangleArea(double a, double b)
        {
            return (a * b) / 2;
        }
    }

    public class CircleArea : IAreaCalculation
    {
        double IAreaCalculation.GetArea(params double[] args)
        {
            if (args.Length < 1)
            {
                throw new ArgumentException("Invalid arguments count.");
            }

            if (args.Length > 1)
            {
                throw new ArgumentException("Too many arguments.");
            }


            if (args[0] < 0)
            {
                throw new ArgumentException("Radius cannot be negative.");
            }

            return (double)(Math.PI * (Math.Pow(args[0], 2)));
        }
    }
}