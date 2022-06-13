using System;

namespace zadanie4
{
    public class obliczanie
    {
        public static void rownaniekwadratowe(double a, double b, double c, out double x1, out double x2)
        {

            double delta = b * b - 4 * a * c;

            if (delta >= 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            }
            else
            {
                x1 = double.NaN;
                x2 = double.NaN;
            }

            static void Main(string[] args)
            {

            }



        }
    }
}