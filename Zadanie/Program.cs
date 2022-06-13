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


        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Podaj Wartosc dla a = ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Podaj Wartosc dla b = ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Podaj Wartosc dla c = ");
                double c = double.Parse(Console.ReadLine());

                double x1, x2;
                rownaniekwadratowe(a, b, c, out x1, out x2);
                Console.WriteLine("Wartosc X1 = " + x1 + ", X2 = " + x2);
            }
            catch (Exception exc)
            {
                Console.Error.WriteLine(exc.Message);
            }
        }
    }
}